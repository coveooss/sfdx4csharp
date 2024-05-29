import { Result, Flag } from "./rootObject";
import {
  IClassDefinition,
  IFunctionDefinition,
  IParameterDefinition,
  IClassDefinitions
} from "./classDefinition";
import * as fs from "fs-extra";
import * as _ from "underscore";
import * as path from "path";
import { exec } from "child_process";

export interface IGeneratorOptions {
  SFDXPath: string;
  outputDirectory: string;
  templateDirectory: string;
  fileExtension: string;
  formatFileName?: (defaultFileName: string) => string;
}

export class Generator {
  private cliVersion: string = "";
  private templateHelpers: any = {};

  constructor(private options: IGeneratorOptions) {
    this.initializeTemplateHelpers();
  }

  public async generate(json?: string) {
    await this.initializeCliVersion();

    // If no JSON is passed, use SFDX to gather it.
    if (json === undefined) {
      json = await this.runCommand("commands --json");
    }

    let formatFileName = (defaultFileName: string): string => {
      return this.options.formatFileName
        ? this.options.formatFileName(defaultFileName)
        : defaultFileName;
    };

    const rootObject = this.parse<Result[]>(json);
    const classDefinitions: { [id: string]: IClassDefinition } = {};
    rootObject.forEach(result => {
      const topic = this.extractTopicFromId(result.id);
      if (topic === result.id) {
        return;
      }

      // Check if existing, else creates it.
      let className = this.extractClassNameFromTopic(topic);
      className = this.beautifyName(className);
      if (!classDefinitions[className]) {
        classDefinitions[className] = {
          apiCommandClass: topic,
          className: this.capitalizeFirstLetter(className),
          fileName: formatFileName(className),
          functionDefinitions: []
        };
      }

      let command = result.id.substring(topic.length + 1);
      let examples = result.examples?.join("\n") ?? "";
      if (result.usage){
        if (examples !== ""){
          examples += "\n";
        }

        examples += result.usage;
      }

      let funcName = this.extractFunctionNameFromCommand(command)
      let functionDefinition: IFunctionDefinition = {
        apiCommand: command.split(":").join(" "),
        name: this.beautifyName(funcName),
        parameters: this.extractParameters(result),
        returnType: this.extractReturnType(result),
        shortDescription: result.description,
        description: result.description,
        example: examples,
        help: result.help
      };

      let classNameDefinition = classDefinitions[className];
      classNameDefinition.functionDefinitions.push(functionDefinition);
    });

    const templateFile = fs
      .readFileSync(path.resolve(this.options.templateDirectory, "class.ejs"))
      .toString();
    const classTemplate = _.template(templateFile);

    // Cleaning generated modules.

    try {
      fs.removeSync(this.options.outputDirectory);
    } catch (e) {
      // Ignore
    }

    fs.mkdirSync(this.options.outputDirectory);

    _.forEach(classDefinitions, classDefinition => {
      let classImplementation = classTemplate(
        this.addTemplateHelper(classDefinition)
      );
      fs.writeFileSync(
        path.format({
          dir: this.options.outputDirectory,
          name: classDefinition.fileName,
          ext: this.options.fileExtension
        }),
        classImplementation
      );
    });

    let classDefinitionsTemplateElement: IClassDefinitions = {
      classDefinitions: _.map(classDefinitions, element => element)
    };

    const templateSFDXFile = fs
      .readFileSync(
        path.resolve(this.options.templateDirectory, "sfdxClass.ejs")
      )
      .toString();
    const sfdxClassTemplate = _.template(templateSFDXFile);

    fs.writeFileSync(
      path.format({
        dir: this.options.outputDirectory,
        name: formatFileName("generatedClient"),
        ext: this.options.fileExtension
      }),
      sfdxClassTemplate(this.addTemplateHelper(classDefinitionsTemplateElement))
    );
  }

  private beautifyName(name: String): string {
    let niceName = "";
    for (var part of name.split("-")){
      for (var part2 of part.split(" ")){
        niceName = niceName.concat(this.capitalizeFirstLetter(part2));
      }
    }

    return niceName;
  }

  private extractParameters(result: Result): IParameterDefinition[] {
    let parameters = [];
    let flags = result.flags;
    const configs = result.flagsConfig;
    for (const key in configs){
      if ("longDescription" in configs[key]) {
        flags[key]["longDescription"] = configs[key]["longDescription"];
      }

      if ("kind" in configs[key]) {
        flags[key]["kind"] = configs[key]["kind"];
      }
    }

    for (const key in flags) {
      const flag = flags[key];
      const desription = this.capitalizeFirstLetter(
        flag.longDescription ?? flag.description ?? ("No description for " + key)
      );

      let paramName = key === "protected" ? "isprotected" : key;
      if (paramName.toLowerCase() === "internal") {
        // Keyword "internal" is a reserved Keyword in C#.
        paramName = "_" + paramName;
      }

      let parameter: IParameterDefinition = {
        name: this.beautifyName(paramName),
        flagKey: "--" + key,
        type: this.extractType(flag),
        description: desription,
        optional: !flag.required
      };

      parameters.push(parameter);
    }

    parameters.push({
      name: "Expression",
      description: "Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.",
      flagKey: "",
      optional: false,
      type: "IStringKeyPair[] | string[] | string"
    });

    return parameters.sort((a, b) => {
      if (a.optional && b.optional) {
        // Empty flag key should always be on top of other optional parameters.
        if (a.flagKey === "") {
          return -1;
        }
      }
      return a.optional ? 1 : -1;
    });
  }

  private extractReturnType(result: Result) {
    return "Object";
  }

  private extractType(flag: Flag): string {
    if (flag.type) {
      if (flag.type === "boolean" || flag.kind === "boolean") {
        // Workaround for the flag noprompt in force:package:version:promote (was 'flag;' instead of 'flag')
        return "Boolean";
      }

      if (flag.type === "number" || flag.type === "minutes" || flag.kind === "number" || flag.kind === "minutes" || flag.kind === "integer") {
        return "number";
      }
    }

    if (flag.name === "loglevel") {
      return "loglevel";
    }

    return "string";
  }

  private extractTopicFromId(id: string): string {
    var curId = id;
    if (curId.includes(" "))
      curId = id.split(" ").join(":")

    var idParts = curId.split(":");
    if (!idParts[1] || idParts[0] !== "force"){
      return idParts[0];
    }

    return idParts[0] + " " + idParts[1];
  }

  private extractClassNameFromTopic(topic: string): string {
    const topicParts = topic.split(":");
    if (!topicParts[1] || topicParts[0] !== "force"){
      return topicParts[0];
    }

    return topicParts[1];
  }

  private extractFunctionNameFromCommand(command: string): string {
    const commandParts = command.split(":");
    return _.union(
      [commandParts[0]],
      _.map(commandParts.splice(1), element => {
        return this.capitalizeFirstLetter(element);
      })
    ).join("");
  }

  private capitalizeFirstLetter(element: string): string {
    return element.charAt(0).toUpperCase() + element.slice(1);
  }

  private addTemplateHelper(element: Object): any {
    return _.extend(
      { cliVersion: this.cliVersion },
      element,
      this.templateHelpers
    );
  }

  private async initializeCliVersion() {
    const unformattedCliVersion = await this.runCommand("--version");
    // Format by removing carriage returns
    this.cliVersion = unformattedCliVersion.replace(/\n/g, "");
  }

  private initializeTemplateHelpers() {
    this.templateHelpers.escapeForComments = this.escapeForComments;
    this.templateHelpers.getCurrentFormatedDate = this.getCurrentFormatedDate;
    this.templateHelpers.capitalizeFirstLetter = this.capitalizeFirstLetter;
    this.templateHelpers.isAllOptionalParameters = this.isAllOptionalParameters;
  }

  private isAllOptionalParameters(parameters: IParameterDefinition[]): Boolean {
    let allOptional: Boolean = true;
    _.each(parameters, param => {
      allOptional = allOptional && param.optional;
    });

    return allOptional;
  }

  private escapeForComments(element: string, numberOfSpaces: number = 3) {
    if (element === undefined) {
      return element;
    }
    const spaces: string = new Array(numberOfSpaces + 1).join(" ");
    return element.replace(/\*\//g, "* /").replace(/\n/g, "\n" + spaces + "* ");
  }

  private getCurrentFormatedDate(): string {
    return new Date().toDateString();
  }

  private parse<T>(response: string): T {
    // For now it's realllly easy, but maybe someday we'll have to remove some stuff or handle more complex stuff.
    let returnValue: T = JSON.parse(response);

    return returnValue;
  }

  private cleanOutputFromUpdateMessage(errorMessage: string): string {
    let errors = errorMessage.trim().split("\n");
    if (errors && errors[0].includes("sfdx-cli: update available")) {
      errors.shift();
      return errors.join("\n").trim();
    }
    return errorMessage;
  }

  private runCommand(command: string): Promise<string> {
    return new Promise<string>((resolve, reject) => {
      const fullCommand = this.options.SFDXPath + " " + command;
      exec(fullCommand, { maxBuffer: 512 * 1024 }, (error, stdout) => {
        error
          ? reject(error)
          : resolve(this.cleanOutputFromUpdateMessage(stdout));
      });
    });
  }
}

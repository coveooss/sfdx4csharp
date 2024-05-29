import { Generator } from "./lib/sfdxGenerator";
import { resolve } from "path";
import { readFileSync } from "fs";

const root = resolve(__dirname, "../../");
const commandListJsonFilePath = resolve(root, "./dist/commands.json");
const templatesFolderPath = resolve(root, "./templates");
const outputDirectoryPath = resolve(root, "../src/Client/Commands/Generated");

const generator = new Generator({
  SFDXPath: "sf",
  templateDirectory: templatesFolderPath,
  outputDirectory: outputDirectoryPath,
  fileExtension: ".cs",
  formatFileName: (defaultFileName: string) => {
    return defaultFileName.charAt(0).toUpperCase() + defaultFileName.slice(1);
  }
});

const stringCommandsFile = readFileSync(commandListJsonFilePath, "utf8");
generator.generate(stringCommandsFile).then(() => {
  console.log("Generating done");
});

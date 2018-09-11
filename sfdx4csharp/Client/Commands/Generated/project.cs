// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method create of class Project.
 *
 * IProjectCreate
 */
public class ProjectCreateOptions : SFDXOptions {

  /**
   * [Required] The name for the new project. Any valid folder name is accepted.
   * @type {string}
   * @memberof ProjectCreateOptions
   */
  [SwitchName("--projectname")]
  public string projectname  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ProjectCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] Formats output as JSON.
   * @type {string}
   * @memberof ProjectCreateOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] The default package directory name. Metadata items such as classes and Lightning bundles are placed inside this folder.
   * @type {string}
   * @memberof ProjectCreateOptions
   */
  [SwitchName("--defaultpackagedir")]
  public string defaultpackagedir  {get; set;}

  /**
   * [Required] The namespace associated with this project and any connected scratch orgs.
   * @type {string}
   * @memberof ProjectCreateOptions
   */
  [SwitchName("--namespace")]
  public string @namespace  {get; set;}

  /**
   * [Required] The source API version for the project. The version defaults to the current release and will normally be defaulted.This is used to properly import or export metadata.
   * @type {string}
   * @memberof ProjectCreateOptions
   */
  [SwitchName("--sourceapiversion")]
  public string sourceapiversion  {get; set;}

  /**
   * [Required] The login URL for the Salesforce instance being used.Normally defaults to https://login.salesforce.com.
   * @type {string}
   * @memberof ProjectCreateOptions
   */
  [SwitchName("--loginurl")]
  public string loginurl  {get; set;}

  /**
   * [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
   * @type {string}
   * @memberof ProjectCreateOptions
   */
  [SwitchName("--reflect")]
  public string reflect  {get; set;}

  /**
   * [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
   * @type {string}
   * @memberof ProjectCreateOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
   * @type {string}
   * @memberof ProjectCreateOptions
   */
  [SwitchName("--template")]
  public string template  {get; set;}
}

/**
 * Options for the method upgrade of class Project.
 *
 * IProjectUpgrade
 */
public class ProjectUpgradeOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ProjectUpgradeOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof ProjectUpgradeOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Optional] Run all upgrades, even if the project definition files have already been upgraded.
   * @type {bool}
   * @memberof ProjectUpgradeOptions
   */
  [SwitchName("--forceupgrade")]
  public bool? forceupgrade  {get; set;}
}


/**
 * Project
 *
 * @class Project
 */
[CommandClass("force:project")]
public class Project : SFDXCommand {
        /// <inheritDoc />
    public Project(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * create a new SFDX project
   * @returns {(Promise<Object | void>)}
   * @memberof Project
   * @description Creates a Salesforce DX project  in the specified directory or the current working directory. The command creates the necessary configuration files and folders.
   * @example Default values are used if the template, namespace, defaultpackagedir, and outputdir aren’t supplied.
   * The outputdir can be an absolute path or relative to the current working directory.
   * 
   * Examples:
   *    $ sfdx force:project:create --projectname mywork
   *    $ sfdx force:project:create --projectname mywork --defaultpackagedir myapp
   * 
   * force:project:create -n <string> [-t <string>] [-d <string>] [-s <string>] [-p <string>] [--json] [--loglevel <string>]
   */
   [Command("create")]
    public JToken create(ProjectCreateOptions p_Options) {
      return ExecuteCommand<ProjectCreateOptions, JToken>(nameof(create), p_Options);      
    }
  
  /**
   * update project config files to the latest format
   * @returns {(Promise<Object | void>)}
   * @memberof Project
   * @description Updates project configuration and definition files to the latest format.
   * @example Examples:
   *  $   sfdx force:project:upgrade
   *  $   sfdx force:project:upgrade -f
   * force:project:upgrade [-f] [--json] [--loglevel <string>]
   */
   [Command("upgrade")]
    public JToken upgrade(ProjectUpgradeOptions p_Options = null) {
      return ExecuteCommand<ProjectUpgradeOptions, JToken>(nameof(upgrade), p_Options);      
    }
  
}

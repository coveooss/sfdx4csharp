// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method componentCreate of class Visualforce.
 *
 * IVisualforceComponentCreate
 */
public class VisualforceComponentCreateOptions : SFDXOptions {

  /**
   * [Required] The Visualforce component name. The name can be up to 40 characters and must start with a letter.
   * @type {string}
   * @memberof VisualforceComponentCreateOptions
   */
  [SwitchName("--componentname")]
  public string componentname  {get; set;}

  /**
   * [Required] The label saved in the metadata for the Visualforce component.
   * @type {string}
   * @memberof VisualforceComponentCreateOptions
   */
  [SwitchName("--label")]
  public string label  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof VisualforceComponentCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] Formats output as JSON.
   * @type {string}
   * @memberof VisualforceComponentCreateOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] The API version of the created source.
   * @type {string}
   * @memberof VisualforceComponentCreateOptions
   */
  [SwitchName("--apiversion")]
  public string apiversion  {get; set;}

  /**
   * [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
   * @type {string}
   * @memberof VisualforceComponentCreateOptions
   */
  [SwitchName("--reflect")]
  public string reflect  {get; set;}

  /**
   * [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
   * @type {string}
   * @memberof VisualforceComponentCreateOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
   * @type {string}
   * @memberof VisualforceComponentCreateOptions
   */
  [SwitchName("--template")]
  public string template  {get; set;}
}

/**
 * Options for the method pageCreate of class Visualforce.
 *
 * IVisualforcePageCreate
 */
public class VisualforcePageCreateOptions : SFDXOptions {

  /**
   * [Required] The Visualforce page name. The name can be up to 40 characters and must start with a letter.
   * @type {string}
   * @memberof VisualforcePageCreateOptions
   */
  [SwitchName("--pagename")]
  public string pagename  {get; set;}

  /**
   * [Required] The label saved in the metadata for the Visualforce page.
   * @type {string}
   * @memberof VisualforcePageCreateOptions
   */
  [SwitchName("--label")]
  public string label  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof VisualforcePageCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] Formats output as JSON.
   * @type {string}
   * @memberof VisualforcePageCreateOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] The API version of the created source.
   * @type {string}
   * @memberof VisualforcePageCreateOptions
   */
  [SwitchName("--apiversion")]
  public string apiversion  {get; set;}

  /**
   * [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
   * @type {string}
   * @memberof VisualforcePageCreateOptions
   */
  [SwitchName("--reflect")]
  public string reflect  {get; set;}

  /**
   * [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
   * @type {string}
   * @memberof VisualforcePageCreateOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
   * @type {string}
   * @memberof VisualforcePageCreateOptions
   */
  [SwitchName("--template")]
  public string template  {get; set;}
}


/**
 * Visualforce
 *
 * @class Visualforce
 */
[CommandClass("force:visualforce")]
public class Visualforce : SFDXCommand {
        /// <inheritDoc />
    public Visualforce(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * create a Visualforce component
   * @returns {(Promise<Object | void>)}
   * @memberof Visualforce
   * @description Creates a Visualforce component in the specified directory or the current working directory. The command creates the .component file and associated metadata file.
   * @example If not supplied, the apiversion, template, and outputdir use default values.
   * The outputdir can be an absolute path or relative to the current working directory.
   * Name and label are required.
   * 
   * Examples:
   *    $ sfdx force:visualforce:component:create -n mycomponent -l mylabel
   *    $ sfdx force:visualforce:component:create -n mycomponent -l mylabel -d components
   * 
   * force:visualforce:component:create -n <string> -l <string> [-t <string>] [-d <string>] [-a <string>] [--json] [--loglevel <string>]
   */
   [Command("component:create")]
    public JToken componentCreate(VisualforceComponentCreateOptions p_Options) {
      return ExecuteCommand<VisualforceComponentCreateOptions, JToken>(nameof(componentCreate), p_Options);      
    }
  
  /**
   * create a Visualforce page
   * @returns {(Promise<Object | void>)}
   * @memberof Visualforce
   * @description Creates a Visualforce page in the specified directory or the current working directory. The command creates the .page file and associated metadata file.
   * @example If not supplied, the apiversion, template, and outputdir use default values.
   * The outputdir can be an absolute path or relative to the current working directory.
   * Name and label are required.
   * 
   * Examples:
   *    $ sfdx force:visualforce:page:create -n mypage -l mylabel
   *    $ sfdx force:visualforce:page:create -n mypage -l mylabel -d pages
   * 
   * force:visualforce:page:create -n <string> -l <string> [-t <string>] [-d <string>] [-a <string>] [--json] [--loglevel <string>]
   */
   [Command("page:create")]
    public JToken pageCreate(VisualforcePageCreateOptions p_Options) {
      return ExecuteCommand<VisualforcePageCreateOptions, JToken>(nameof(pageCreate), p_Options);      
    }
  
}

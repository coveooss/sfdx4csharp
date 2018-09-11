// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method convert of class Source.
 *
 * ISourceConvert
 */
public class SourceConvertOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof SourceConvertOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof SourceConvertOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] The name of the package to associate with the Metadata API–formatted metadata.
   * @type {string}
   * @memberof SourceConvertOptions
   */
  [SwitchName("--packagename")]
  public string packagename  {get; set;}

  /**
   * [Required] The output directory to export the Metadata API–formatted metadata to.
   * @type {string}
   * @memberof SourceConvertOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] A directory other than the default package directory that contains the Salesforce DX–formatted source to convert.
   * @type {string}
   * @memberof SourceConvertOptions
   */
  [SwitchName("--rootdir")]
  public string rootdir  {get; set;}
}

/**
 * Options for the method open of class Source.
 *
 * ISourceOpen
 */
public class SourceOpenOptions : SFDXOptions {

  /**
   * [Required] File to edit.
   * @type {string}
   * @memberof SourceOpenOptions
   */
  [SwitchName("--sourcefile")]
  public string sourcefile  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof SourceOpenOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof SourceOpenOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof SourceOpenOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Generate a navigation URL path, but don’t launch a browser-based editor.
   * @type {bool}
   * @memberof SourceOpenOptions
   */
  [SwitchName("--urlonly")]
  public bool? urlonly  {get; set;}
}

/**
 * Options for the method pull of class Source.
 *
 * ISourcePull
 */
public class SourcePullOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof SourcePullOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof SourcePullOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof SourcePullOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Runs the pull command even if conflicts exist. Changes in the scratch org overwrite changes in the project.
   * @type {bool}
   * @memberof SourcePullOptions
   */
  [SwitchName("--forceoverwrite")]
  public bool? forceoverwrite  {get; set;}

  /**
   * [Required] The number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
   * @type {string}
   * @memberof SourcePullOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}
}

/**
 * Options for the method push of class Source.
 *
 * ISourcePush
 */
public class SourcePushOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof SourcePushOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof SourcePushOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof SourcePushOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
   * @type {string}
   * @memberof SourcePushOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Optional] Replaces tokens in source files prior to deployment.
   * @type {bool}
   * @memberof SourcePushOptions
   */
  [SwitchName("--replacetokens")]
  public bool? replacetokens  {get; set;}

  /**
   * [Optional] Completes the deployment even if warnings are generated.
   * @type {bool}
   * @memberof SourcePushOptions
   */
  [SwitchName("--ignorewarnings")]
  public bool? ignorewarnings  {get; set;}

  /**
   * [Optional] Runs the push command even if conflicts exist. Changes in the project overwrite changes in the scratch org.
   * @type {bool}
   * @memberof SourcePushOptions
   */
  [SwitchName("--forceoverwrite")]
  public bool? forceoverwrite  {get; set;}
}

/**
 * Options for the method status of class Source.
 *
 * ISourceStatus
 */
public class SourceStatusOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof SourceStatusOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof SourceStatusOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof SourceStatusOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Lists the changes that have been made in the scratch org.
   * @type {bool}
   * @memberof SourceStatusOptions
   */
  [SwitchName("--remote")]
  public bool? remote  {get; set;}

  /**
   * [Optional] Lists the changes that have been made locally.
   * @type {bool}
   * @memberof SourceStatusOptions
   */
  [SwitchName("--local")]
  public bool? local  {get; set;}

  /**
   * [Optional] Lists all the changes that have been made.
   * @type {bool}
   * @memberof SourceStatusOptions
   */
  [SwitchName("--all")]
  public bool? all  {get; set;}
}


/**
 * Source
 *
 * @class Source
 */
[CommandClass("force:source")]
public class Source : SFDXCommand {
        /// <inheritDoc />
    public Source(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * convert Salesforce DX source into Metadata API format
   * @returns {(Promise<Object | void>)}
   * @memberof Source
   * @description Converts source in a Salesforce DX project into metadata that you can deploy using Metadata API.
   * @example NOTE: This command must be run from within a project.
   * 
   * To convert Salesforce DX–formatted source into a format that you can deploy using Metadata API, run "sfdx force:source:convert". Then deploy the metadata using "sfdx force:mdapi:deploy".
   * 
   * To convert Metadata API–formatted source into the Salesforce DX format, run "sfdx force:mdapi:convert".
   * 
   * To specify a package name that includes spaces, enclose the name in single quotes.
   * 
   * Examples:
   *    $ sfdx force:source:convert -r <path to source>
   *    $ sfdx force:source:convert -r <path to source> -d <path to output dir> -n 'My Package'
   * force:source:convert [-r <directory>] [-d <directory>] [-n <string>] [--json] [--loglevel <string>]
   */
   [Command("convert")]
    public JToken convert(SourceConvertOptions p_Options) {
      return ExecuteCommand<SourceConvertOptions, JToken>(nameof(convert), p_Options);      
    }
  
  /**
   * edit a Lightning Page with Lightning App Builder
   * @returns {(Promise<Object | void>)}
   * @memberof Source
   * @description Opens the specified Lightning Page in Lightning App Builder. Lightning Page files have the suffix .flexipage-meta.xml, and are stored in the flexipages directory. If you specify a different type of file, this command opens your org’s home page.
   * @example NOTE: This command must be run from within a project.
   * 
   * The file opens in your default browser.
   * If no browser-based editor is available for the selected file, this command opens your org’s home page.
   * To generate a URL for the browser-based editor but not open the editor, use --urlonly.
   * 
   * Examples:
   *    $ sfdx force:source:open -f Property_Record_Page.flexipage-meta.xml
   *    $ sfdx force:source:open -f Property_Record_Page.flexipage-meta.xml -r
   * force:source:open -f <filepath> [-r] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("open")]
    public JToken open(SourceOpenOptions p_Options) {
      return ExecuteCommand<SourceOpenOptions, JToken>(nameof(open), p_Options);      
    }
  
  /**
   * pull source from the scratch org to the project
   * @returns {(Promise<Object | void>)}
   * @memberof Source
   * @description Pulls changed source from the scratch org to your project to keep them in sync.
   * @example NOTE: This command must be run from within a project.
   * 
   * If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
   * force:source:pull [-w <minutes>] [-f] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("pull")]
    public JToken pull(SourcePullOptions p_Options) {
      return ExecuteCommand<SourcePullOptions, JToken>(nameof(pull), p_Options);      
    }
  
  /**
   * push source to an org from the project
   * @returns {(Promise<Object | void>)}
   * @memberof Source
   * @description Pushes changed source from your project to the scratch org to keep them in sync.
   * @example NOTE: This command must be run from within a project.
   * 
   * If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
   * force:source:push [-f] [-g] [-w <minutes>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("push")]
    public JToken push(SourcePushOptions p_Options) {
      return ExecuteCommand<SourcePushOptions, JToken>(nameof(push), p_Options);      
    }
  
  /**
   * list local changes and/or changes in a scratch org
   * @returns {(Promise<Object | void>)}
   * @memberof Source
   * @description Lists changes that have been made locally, in a scratch org, or both.
   * @example NOTE: This command must be run from within a project.
   * 
   * Examples:
   *    $ sfdx force:source:status -l
   *    $ sfdx force:source:status -r
   *    $ sfdx force:source:status -a
   *    $ sfdx force:source:status -a -u me@my.org --json
   * force:source:status [-a] [-l] [-r] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("status")]
    public JToken status(SourceStatusOptions p_Options) {
      return ExecuteCommand<SourceStatusOptions, JToken>(nameof(status), p_Options);      
    }
  
}

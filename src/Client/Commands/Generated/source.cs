// Generated on September 11th 2018, 5:23:30 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  
  /// <summary>
  /// Options for the method convert of class Source.
  /// </summary>
  public class SourceConvertOptions : SFDXOptions {
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] The name of the package to associate with the Metadata API–formatted metadata.
    /// </summary>  
    [SwitchName("--packagename")]
    public string packagename  {get; set;}
  
    /// <summary>
    /// [Required] The output directory to export the Metadata API–formatted metadata to.
    /// </summary>  
    [SwitchName("--outputdir")]
    public string outputdir  {get; set;}
  
    /// <summary>
    /// [Required] A directory other than the default package directory that contains the Salesforce DX–formatted source to convert.
    /// </summary>  
    [SwitchName("--rootdir")]
    public string rootdir  {get; set;}
  }
  
  /// <summary>
  /// Options for the method open of class Source.
  /// </summary>
  public class SourceOpenOptions : SFDXOptions {
  
    /// <summary>
    /// [Required] File to edit.
    /// </summary>  
    [SwitchName("--sourcefile")]
    public string sourcefile  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Optional] Generate a navigation URL path, but don’t launch a browser-based editor.
    /// </summary>  
    [SwitchName("--urlonly")]
    public bool? urlonly  {get; set;}
  }
  
  /// <summary>
  /// Options for the method pull of class Source.
  /// </summary>
  public class SourcePullOptions : SFDXOptions {
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Optional] Runs the pull command even if conflicts exist. Changes in the scratch org overwrite changes in the project.
    /// </summary>  
    [SwitchName("--forceoverwrite")]
    public bool? forceoverwrite  {get; set;}
  
    /// <summary>
    /// [Required] The number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
    /// </summary>  
    [SwitchName("--wait")]
    public string wait  {get; set;}
  }
  
  /// <summary>
  /// Options for the method push of class Source.
  /// </summary>
  public class SourcePushOptions : SFDXOptions {
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Required] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
    /// </summary>  
    [SwitchName("--wait")]
    public string wait  {get; set;}
  
    /// <summary>
    /// [Optional] Replaces tokens in source files prior to deployment.
    /// </summary>  
    [SwitchName("--replacetokens")]
    public bool? replacetokens  {get; set;}
  
    /// <summary>
    /// [Optional] Completes the deployment even if warnings are generated.
    /// </summary>  
    [SwitchName("--ignorewarnings")]
    public bool? ignorewarnings  {get; set;}
  
    /// <summary>
    /// [Optional] Runs the push command even if conflicts exist. Changes in the project overwrite changes in the scratch org.
    /// </summary>  
    [SwitchName("--forceoverwrite")]
    public bool? forceoverwrite  {get; set;}
  }
  
  /// <summary>
  /// Options for the method status of class Source.
  /// </summary>
  public class SourceStatusOptions : SFDXOptions {
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Optional] Lists the changes that have been made in the scratch org.
    /// </summary>  
    [SwitchName("--remote")]
    public bool? remote  {get; set;}
  
    /// <summary>
    /// [Optional] Lists the changes that have been made locally.
    /// </summary>  
    [SwitchName("--local")]
    public bool? local  {get; set;}
  
    /// <summary>
    /// [Optional] Lists all the changes that have been made.
    /// </summary>  
    [SwitchName("--all")]
    public bool? all  {get; set;}
  }
  

  /// <summary>
  /// Source
  /// </summary>
  [CommandClass("force:source")]
  public class Source : SFDXCommand {

    /// Constructor.
    public Source(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// convert Salesforce DX source into Metadata API format
    /// </summary>
    /// <remarks>
    /// Converts source in a Salesforce DX project into metadata that you can deploy using Metadata API.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// To convert Salesforce DX–formatted source into a format that you can deploy using Metadata API, run "sfdx force:source:convert". Then deploy the metadata using "sfdx force:mdapi:deploy".
    /// 
    /// To convert Metadata API–formatted source into the Salesforce DX format, run "sfdx force:mdapi:convert".
    /// 
    /// To specify a package name that includes spaces, enclose the name in single quotes.
    /// 
    /// Examples:
    ///    $ sfdx force:source:convert -r <path to source>
    ///    $ sfdx force:source:convert -r <path to source> -d <path to output dir> -n 'My Package'
    /// force:source:convert [-r <directory>] [-d <directory>] [-n <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("convert")]
      public JToken convert(SourceConvertOptions p_Options) {
        return ExecuteCommand<SourceConvertOptions, JToken>(nameof(convert), p_Options);      
      }
    
    /// <summary>
    /// edit a Lightning Page with Lightning App Builder
    /// </summary>
    /// <remarks>
    /// Opens the specified Lightning Page in Lightning App Builder. Lightning Page files have the suffix .flexipage-meta.xml, and are stored in the flexipages directory. If you specify a different type of file, this command opens your org’s home page.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// The file opens in your default browser.
    /// If no browser-based editor is available for the selected file, this command opens your org’s home page.
    /// To generate a URL for the browser-based editor but not open the editor, use --urlonly.
    /// 
    /// Examples:
    ///    $ sfdx force:source:open -f Property_Record_Page.flexipage-meta.xml
    ///    $ sfdx force:source:open -f Property_Record_Page.flexipage-meta.xml -r
    /// force:source:open -f <filepath> [-r] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("open")]
      public JToken open(SourceOpenOptions p_Options) {
        return ExecuteCommand<SourceOpenOptions, JToken>(nameof(open), p_Options);      
      }
    
    /// <summary>
    /// pull source from the scratch org to the project
    /// </summary>
    /// <remarks>
    /// Pulls changed source from the scratch org to your project to keep them in sync.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
    /// force:source:pull [-w <minutes>] [-f] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("pull")]
      public JToken pull(SourcePullOptions p_Options) {
        return ExecuteCommand<SourcePullOptions, JToken>(nameof(pull), p_Options);      
      }
    
    /// <summary>
    /// push source to an org from the project
    /// </summary>
    /// <remarks>
    /// Pushes changed source from your project to the scratch org to keep them in sync.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
    /// force:source:push [-f] [-g] [-w <minutes>] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("push")]
      public JToken push(SourcePushOptions p_Options) {
        return ExecuteCommand<SourcePushOptions, JToken>(nameof(push), p_Options);      
      }
    
    /// <summary>
    /// list local changes and/or changes in a scratch org
    /// </summary>
    /// <remarks>
    /// Lists changes that have been made locally, in a scratch org, or both.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// Examples:
    ///    $ sfdx force:source:status -l
    ///    $ sfdx force:source:status -r
    ///    $ sfdx force:source:status -a
    ///    $ sfdx force:source:status -a -u me@my.org --json
    /// force:source:status [-a] [-l] [-r] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("status")]
      public JToken status(SourceStatusOptions p_Options) {
        return ExecuteCommand<SourceStatusOptions, JToken>(nameof(status), p_Options);      
      }
    
  }
}

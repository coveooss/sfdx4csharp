// Generated on September 19th 2018, 4:53:42 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method create of class Project.
  /// </summary>
  public class ProjectCreateOptions : SFDXOptions {
    /// <summary>
    /// [Required] The name for the new project. Any valid folder name is accepted.
    /// </summary>  
    [SwitchName("--projectname")]
    public string projectname  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Required] Formats output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public string json  {get; set;}
  
    /// <summary>
    /// [Required] The default package directory name. Metadata items such as classes and Lightning bundles are placed inside this folder.
    /// </summary>  
    [SwitchName("--defaultpackagedir")]
    public string defaultpackagedir  {get; set;}
  
    /// <summary>
    /// [Required] The namespace associated with this project and any connected scratch orgs.
    /// </summary>  
    [SwitchName("--namespace")]
    public string @namespace  {get; set;}
  
    /// <summary>
    /// [Required] The source API version for the project. The version defaults to the current release and will normally be defaulted.This is used to properly import or export metadata.
    /// </summary>  
    [SwitchName("--sourceapiversion")]
    public string sourceapiversion  {get; set;}
  
    /// <summary>
    /// [Required] The login URL for the Salesforce instance being used.Normally defaults to https://login.salesforce.com.
    /// </summary>  
    [SwitchName("--loginurl")]
    public string loginurl  {get; set;}
  
    /// <summary>
    /// [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
    /// </summary>  
    [SwitchName("--reflect")]
    public string reflect  {get; set;}
  
    /// <summary>
    /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
    /// </summary>  
    [SwitchName("--outputdir")]
    public string outputdir  {get; set;}
  
    /// <summary>
    /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
    /// </summary>  
    [SwitchName("--template")]
    public string template  {get; set;}
  }
  
  /// <summary>
  /// Options for the method upgrade of class Project.
  /// </summary>
  public class ProjectUpgradeOptions : SFDXOptions {
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
    /// [Optional] Run all upgrades, even if the project definition files have already been upgraded.
    /// </summary>  
    [SwitchName("--forceupgrade")]
    public bool? forceupgrade  {get; set;}
  }
  

  /// <summary>
  /// Project
  /// </summary>
  [CommandClass("force:project")]
  public class Project : SFDXCommand {

    /// Constructor.
    public Project(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// create a new SFDX project
    /// </summary>
    /// <remarks>
    /// Creates a Salesforce DX project  in the specified directory or the current working directory. The command creates the necessary configuration files and folders.
    /// </remarks>
    /// <example>  
    /// Default values are used if the template, namespace, defaultpackagedir, and outputdir aren’t supplied.
    /// The outputdir can be an absolute path or relative to the current working directory.
    /// 
    /// Examples:
    ///    $ sfdx force:project:create --projectname mywork
    ///    $ sfdx force:project:create --projectname mywork --defaultpackagedir myapp
    /// 
    /// force:project:create -n <string> [-t <string>] [-d <string>] [-s <string>] [-p <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("create")]
      public JToken Create(ProjectCreateOptions p_Options) {
        return ExecuteCommand<ProjectCreateOptions, JToken>(nameof(Create), p_Options);      
      }
    
    /// <summary>
    /// update project config files to the latest format
    /// </summary>
    /// <remarks>
    /// Updates project configuration and definition files to the latest format.
    /// </remarks>
    /// <example>  
    /// Examples:
    ///  $   sfdx force:project:upgrade
    ///  $   sfdx force:project:upgrade -f
    /// force:project:upgrade [-f] [--json] [--loglevel <string>]
    /// </example>
    [Command("upgrade")]
      public JToken Upgrade(ProjectUpgradeOptions p_Options = null) {
        return ExecuteCommand<ProjectUpgradeOptions, JToken>(nameof(Upgrade), p_Options);      
      }
    
  }
}

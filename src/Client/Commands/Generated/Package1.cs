// Generated on September 19th 2018, 4:53:42 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method versionCreate of class Package1.
  /// </summary>
  public class Package1VersionCreateOptions : SFDXOptions {
    /// <summary>
    /// [Required] ID of the metadata package (starts with 033) of which you’re creating a new version.
    /// </summary>  
    [SwitchName("--packageid")]
    public string packageid  {get; set;}
  
    /// <summary>
    /// [Required] Package version name.
    /// </summary>  
    [SwitchName("--name")]
    public string name  {get; set;}
  
    /// <summary>
    /// [Required] Post install URL.
    /// </summary>  
    [SwitchName("--postinstallurl")]
    public string postinstallurl  {get; set;}
  
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
    /// [Required] Minutes to wait for the package version to be created. The default is 2 minutes.
    /// </summary>  
    [SwitchName("--wait")]
    public string wait  {get; set;}
  
    /// <summary>
    /// [Required] Installation key for creating the key-protected package. The default is null.
    /// </summary>  
    [SwitchName("--installationkey")]
    public string installationkey  {get; set;}
  
    /// <summary>
    /// [Required] Package version description.
    /// </summary>  
    [SwitchName("--description")]
    public string description  {get; set;}
  
    /// <summary>
    /// [Required] Release notes URL.
    /// </summary>  
    [SwitchName("--releasenotesurl")]
    public string releasenotesurl  {get; set;}
  
    /// <summary>
    /// [Optional] Creates a managed package version. To create a beta version, don’t include this parameter.
    /// </summary>  
    [SwitchName("--managedreleased")]
    public bool? managedreleased  {get; set;}
  
    /// <summary>
    /// [Required] Package version in major.minor format, for example, 3.2.
    /// </summary>  
    [SwitchName("--version")]
    public string version  {get; set;}
  }
  
  /// <summary>
  /// Options for the method versionCreateGet of class Package1.
  /// </summary>
  public class Package1VersionCreateGetOptions : SFDXOptions {
    /// <summary>
    /// [Required] The ID of the PackageUploadRequest.
    /// </summary>  
    [SwitchName("--requestid")]
    public string requestid  {get; set;}
  
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
  }
  
  /// <summary>
  /// Options for the method versionDisplay of class Package1.
  /// </summary>
  public class Package1VersionDisplayOptions : SFDXOptions {
    /// <summary>
    /// [Required] ID (starts with 04t) of the metadata package version whose details you want to display.
    /// </summary>  
    [SwitchName("--packageversionid")]
    public string packageversionid  {get; set;}
  
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
  }
  
  /// <summary>
  /// Options for the method versionList of class Package1.
  /// </summary>
  public class Package1VersionListOptions : SFDXOptions {
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
    /// [Required] Metadata package ID (starts with 033) whose package versions you want to list. If not specified, shows all versions for all packages (managed and unmanaged) in the org.
    /// </summary>  
    [SwitchName("--packageid")]
    public string packageid  {get; set;}
  }
  

  /// <summary>
  /// Package1
  /// </summary>
  [CommandClass("force:package1")]
  public class Package1 : SFDXCommand {

    /// Constructor.
    public Package1(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// create a first-generation package version in the release org
    /// </summary>
    /// <remarks>
    /// Creates a first-generation package version in the release org.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// The package version is based on the contents of the specified metadata package. Omit -m if you want to create an unmanaged package version.
    /// force:package1:version:create -i <id> -n <string> [-d <string>] [-v <string>] [-m] [-r <url>] [-p <url>] [-k <string>] [-w <number>] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("version:create")]
      public JToken VersionCreate(Package1VersionCreateOptions p_Options) {
        return ExecuteCommand<Package1VersionCreateOptions, JToken>(nameof(VersionCreate), p_Options);      
      }
    
    /// <summary>
    /// retrieve the status of a package version creation request
    /// </summary>
    /// <remarks>
    /// Retrieves the status of a package version creation request.
    /// </remarks>
    /// <example>  
    /// Examples:
    ///    $ sfdx force:package:version:create:report -i 08c...
    ///    $ sfdx force:package:version:create:report -i 08c... -v devhub@example.com
    /// force:package1:version:create:get -i <id> [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("version:create:get")]
      public JToken VersionCreateGet(Package1VersionCreateGetOptions p_Options) {
        return ExecuteCommand<Package1VersionCreateGetOptions, JToken>(nameof(VersionCreateGet), p_Options);      
      }
    
    /// <summary>
    /// display details about a first-generation package version
    /// </summary>
    /// <remarks>
    /// Displays detailed information about an individual first-generation package version.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// Display detailed information about an individual package version, including metadata package ID, name, the release state, and build number.
    /// force:package1:version:display -i <id> [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("version:display")]
      public JToken VersionDisplay(Package1VersionDisplayOptions p_Options) {
        return ExecuteCommand<Package1VersionDisplayOptions, JToken>(nameof(VersionDisplay), p_Options);      
      }
    
    /// <summary>
    /// list package versions for the specified first-generation package or for the org
    /// </summary>
    /// <remarks>
    /// Lists the versions for the specified package or all first-generation packages in the org.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// If a metadata package ID is specified, lists all versions of the specified package. Otherwise, lists all package versions for the org. For each package version, the list includes the package version ID, metadata package ID, name, version number, and release state.
    /// force:package1:version:list [-i <id>] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("version:list")]
      public JToken VersionList(Package1VersionListOptions p_Options) {
        return ExecuteCommand<Package1VersionListOptions, JToken>(nameof(VersionList), p_Options);      
      }
    
  }
}

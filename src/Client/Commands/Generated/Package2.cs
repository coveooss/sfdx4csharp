// Generated on September 20th 2018, 2:58:04 pm. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method create of class Package2.
  /// </summary>
  public class Package2CreateOptions : SFDXOptions {
    /// <summary>
    /// [Required] Name of the second-generation package to create.
    /// </summary>  
    [SwitchName("--name")]
    public string name  {get; set;}
  
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
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  
    /// <summary>
    /// [Optional] Creates the package with no namespace. Available only for developer-controlled packages. Useful when migrating an existing org to packages, but new metadata should use a namespaced package.
    /// </summary>  
    [SwitchName("--nonamespace")]
    public bool? nonamespace  {get; set;}
  
    /// <summary>
    /// [Required] Description of the second-generation package.
    /// </summary>  
    [SwitchName("--description")]
    public string description  {get; set;}
  
    /// <summary>
    /// [Required] Container options for the package2. 
    /// Managed is default. Other options include Unlocked. (Managed=DeveloperManagedSubscriberManaged, Unlocked=DeveloperControlledSubscriberEditable). 
    /// These options determine the upgrade and editability rules.
    /// </summary>  
    [SwitchName("--containeroptions")]
    public string containeroptions  {get; set;}
  }
  
  /// <summary>
  /// Options for the method list of class Package2.
  /// </summary>
  public class Package2ListOptions : SFDXOptions {
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
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  }
  
  /// <summary>
  /// Options for the method update of class Package2.
  /// </summary>
  public class Package2UpdateOptions : SFDXOptions {
    /// <summary>
    /// [Required] ID of package (starts with 0Ho).
    /// </summary>  
    [SwitchName("--package2id")]
    public string package2id  {get; set;}
  
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
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  
    /// <summary>
    /// [Required] Description of the package.
    /// </summary>  
    [SwitchName("--description")]
    public string description  {get; set;}
  
    /// <summary>
    /// [Required] Name of the package to update.
    /// </summary>  
    [SwitchName("--name")]
    public string name  {get; set;}
  }
  
  /// <summary>
  /// Options for the method versionCreate of class Package2.
  /// </summary>
  public class Package2VersionCreateOptions : SFDXOptions {
    /// <summary>
    /// [Required] Specifies that the sfdx-project.json file should be validated against JSON schema
    /// </summary>  
    [SwitchName("--validateschema")]
    public string validateschema  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Required] The number of minutes to wait for the package version to be created.
    /// </summary>  
    [SwitchName("--wait")]
    public string wait  {get; set;}
  
    /// <summary>
    /// [Required] ID of parent package (starts with 0Ho).
    /// </summary>  
    [SwitchName("--package2id")]
    public string package2id  {get; set;}
  
    /// <summary>
    /// [Required] The package version’s branch.
    /// </summary>  
    [SwitchName("--branch")]
    public string branch  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  
    /// <summary>
    /// [Required] The source org ID used to copy the org shape for the build org.
    /// </summary>  
    [SwitchName("--sourceorg")]
    public string sourceorg  {get; set;}
  
    /// <summary>
    /// [Required] The instance where the package version will be created——for example, NA50.
    /// </summary>  
    [SwitchName("--buildinstance")]
    public string buildinstance  {get; set;}
  
    /// <summary>
    /// [Required] The package version’s tag.
    /// </summary>  
    [SwitchName("--tag")]
    public string tag  {get; set;}
  
    /// <summary>
    /// [Required] The path to the directory that contains the contents of the package version.
    /// </summary>  
    [SwitchName("--directory")]
    public string directory  {get; set;}
  
    /// <summary>
    /// [Required] Specifies that the temp files are preserved that would otherwise be deleted
    /// </summary>  
    [SwitchName("--preserve")]
    public string preserve  {get; set;}
  
    /// <summary>
    /// [Required] Installation key for creating the key-protected package. The default is null.
    /// </summary>  
    [SwitchName("--installationkey")]
    public string installationkey  {get; set;}
  }
  
  /// <summary>
  /// Options for the method versionCreateGet of class Package2.
  /// </summary>
  public class Package2VersionCreateGetOptions : SFDXOptions {
    /// <summary>
    /// [Required] The ID of the package2 version creation request you want to display.
    /// </summary>  
    [SwitchName("--package2createrequestid")]
    public string package2createrequestid  {get; set;}
  
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
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  }
  
  /// <summary>
  /// Options for the method versionCreateList of class Package2.
  /// </summary>
  public class Package2VersionCreateListOptions : SFDXOptions {
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
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  
    /// <summary>
    /// [Required] Filters the list based on the status of version creation requests.
    /// </summary>  
    [SwitchName("--status")]
    public string status  {get; set;}
  
    /// <summary>
    /// [Required] Filters the list based on the specified maximum number of days since the request was created (starting at 00:00:00 of first day to now; 0 for today).
    /// </summary>  
    [SwitchName("--createdlastdays")]
    public string createdlastdays  {get; set;}
  }
  
  /// <summary>
  /// Options for the method versionGet of class Package2.
  /// </summary>
  public class Package2VersionGetOptions : SFDXOptions {
    /// <summary>
    /// [Required] The package version ID (starts with 05i).
    /// </summary>  
    [SwitchName("--package2versionid")]
    public string package2versionid  {get; set;}
  
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
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  }
  
  /// <summary>
  /// Options for the method versionList of class Package2.
  /// </summary>
  public class Package2VersionListOptions : SFDXOptions {
    /// <summary>
    /// [Optional] Display extended package2 versions detail.
    /// </summary>  
    [SwitchName("--verbose")]
    public bool? verbose  {get; set;}
  
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
    /// [Optional] Displays limited package2 version details.
    /// </summary>  
    [SwitchName("--concise")]
    public bool? concise  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  
    /// <summary>
    /// [Required] Orders the list by the specified package2 version fields.
    /// </summary>  
    [SwitchName("--orderby")]
    public string orderby  {get; set;}
  
    /// <summary>
    /// [Optional] Displays released versions only (IsReleased=true).
    /// </summary>  
    [SwitchName("--released")]
    public bool? released  {get; set;}
  
    /// <summary>
    /// [Required] Filters results on the specified comma-delimited package2 IDs (start with 0Ho).
    /// </summary>  
    [SwitchName("--package2ids")]
    public string package2ids  {get; set;}
  
    /// <summary>
    /// [Required] Lists the items modified in the specified last number of days, starting at 00:00:00 of first day to now. Use 0 for today.
    /// </summary>  
    [SwitchName("--modifiedlastdays")]
    public string modifiedlastdays  {get; set;}
  
    /// <summary>
    /// [Required] Filters the list based on the specified maximum number of days since the request was created (starting at 00:00:00 of first day to now; 0 for today).
    /// </summary>  
    [SwitchName("--createdlastdays")]
    public string createdlastdays  {get; set;}
  }
  
  /// <summary>
  /// Options for the method versionUpdate of class Package2.
  /// </summary>
  public class Package2VersionUpdateOptions : SFDXOptions {
    /// <summary>
    /// [Required] The package version ID (starts with 05i).
    /// </summary>  
    [SwitchName("--package2versionid")]
    public string package2versionid  {get; set;}
  
    /// <summary>
    /// [Required] Installation key for creating the key-protected package. The default is null.
    /// </summary>  
    [SwitchName("--installationkey")]
    public string installationkey  {get; set;}
  
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
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  
    /// <summary>
    /// [Optional] No prompt to confirm setting the package version as released.
    /// </summary>  
    [SwitchName("--noprompt")]
    public bool? noprompt  {get; set;}
  
    /// <summary>
    /// [Optional] Sets the second-generation package version as released. Second-generation packages can’t be changed to beta after they’ve been released.
    /// </summary>  
    [SwitchName("--setasreleased")]
    public bool? setasreleased  {get; set;}
  
    /// <summary>
    /// [Required] The package version name.
    /// </summary>  
    [SwitchName("--name")]
    public string name  {get; set;}
  
    /// <summary>
    /// [Required] The second-generation package version tag.
    /// </summary>  
    [SwitchName("--tag")]
    public string tag  {get; set;}
  
    /// <summary>
    /// [Required] The second-generation package version branch.
    /// </summary>  
    [SwitchName("--branch")]
    public string branch  {get; set;}
  
    /// <summary>
    /// [Required] The second-generation package version description.
    /// </summary>  
    [SwitchName("--description")]
    public string description  {get; set;}
  }
  

  /// <summary>
  /// Package2
  /// </summary>
  [CommandClass("force:package2")]
  public class Package2 : SFDXCommand {

    /// Constructor.
    public Package2(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// (deprecated) create a second-generation package
    /// </summary>
    /// <remarks>
    /// Creates a second-generation package.
    /// </remarks>
    /// <example>  
    /// WARNING: The command "create" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:create" instead.
    /// 
    /// NOTE: This command must be run from within a project.
    /// 
    /// First, use this command to create a second-generation package. Then create a package version.
    /// 
    /// Your --name value must be unique within your namespace.
    /// 
    /// Examples:
    ///    $ sfdx force:package2:create -n PackageName -d 'My New Package' -o Unlocked
    /// 
    /// Run 'sfdx force:package2:list' to list all second-generation packages in the Dev Hub org.
    /// force:package2:create -n <string> [-o <string>] [-d <string>] [-e] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("create")]
      public JToken Create(Package2CreateOptions p_Options) {
        return ExecuteCommand<Package2CreateOptions, JToken>(nameof(Create), p_Options);      
      }
    
    /// <summary>
    /// (deprecated) list all second-generation packages in the Dev Hub org
    /// </summary>
    /// <remarks>
    /// Lists all second-generation packages in the Dev Hub org.
    /// </remarks>
    /// <example>  
    /// WARNING: The command "list" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:list" instead.
    /// 
    /// You can view the namespace, IDs, and other details for each package.
    /// force:package2:list [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("list")]
      public JToken List(Package2ListOptions p_Options) {
        return ExecuteCommand<Package2ListOptions, JToken>(nameof(List), p_Options);      
      }
    
    /// <summary>
    /// (deprecated) update a second-generation package
    /// </summary>
    /// <remarks>
    /// Updates a second-generation package.
    /// </remarks>
    /// <example>  
    /// WARNING: The command "update" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:update" instead.
    /// 
    /// NOTE: This command must be run from within a project.
    /// 
    /// Specify a new value for each option you want to update.
    /// 
    /// Examples:
    ///    $ sfdx force:package2:update --package2id 0Ho... --name 'AAnalytics'
    ///    $ sfdx force:package2:update -i 0Ho... -d 'Advanced Analytics'
    /// 
    /// Run 'sfdx force:package2:list' to list all second-generation packages in the Dev Hub org.
    /// force:package2:update -i <id> [-n <string>] [-d <string>] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("update")]
      public JToken Update(Package2UpdateOptions p_Options) {
        return ExecuteCommand<Package2UpdateOptions, JToken>(nameof(Update), p_Options);      
      }
    
    /// <summary>
    /// (deprecated) create a second-generation package version
    /// </summary>
    /// <remarks>
    /// Creates a second-generation package (package2) version in the Dev Hub org.
    /// </remarks>
    /// <example>  
    /// WARNING: The command "version:create" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:create" instead.
    /// 
    /// NOTE: This command must be run from within a project.
    /// 
    /// The package version is based on the package contents in the specified directory.
    /// 
    /// To retrieve details about a package version create request, including status and package2 version ID (05i), run "sfdx force:package2:version:create:get -i 08c...".
    /// 
    /// To list package version creation requests in the org, run "sfdx force:package2:version:create:list".
    /// 
    /// Examples:
    ///    $ sfdx force:package2:version:create -d common
    ///    $ sfdx force:package2:version:create -i 0Ho... -d common
    /// force:package2:version:create [-i <id>] [-d <directory>] [-b <string>] [-t <string>] [-k <string>] [-w <minutes>] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("version:create")]
      public JToken VersionCreate(Package2VersionCreateOptions p_Options) {
        return ExecuteCommand<Package2VersionCreateOptions, JToken>(nameof(VersionCreate), p_Options);      
      }
    
    /// <summary>
    /// (deprecated) retrieve a package version creation request
    /// </summary>
    /// <remarks>
    /// Retrieves a second-generation package version creation request in the Dev Hub org.
    /// </remarks>
    /// <example>  
    /// WARNING: The command "version:create:get" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:create:report" instead.
    /// 
    /// Specify the request ID for which you want to view details. If applicable, the command displays errors related to the request.
    /// 
    /// Examples:
    ///    $ sfdx force:package2:version:create:get --package2createrequestid 08c...
    /// 
    /// To show all requests in the org, run "sfdx force:package2:version:create:list".
    /// force:package2:version:create:get -i <id> [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("version:create:get")]
      public JToken VersionCreateGet(Package2VersionCreateGetOptions p_Options) {
        return ExecuteCommand<Package2VersionCreateGetOptions, JToken>(nameof(VersionCreateGet), p_Options);      
      }
    
    /// <summary>
    /// (deprecated) list package version creation requests
    /// </summary>
    /// <remarks>
    /// Lists all requests to create second-generation package (package2) versions in the Dev Hub org.
    /// </remarks>
    /// <example>  
    /// WARNING: The command "version:create:list" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:create:list" instead.
    /// 
    /// Shows the details of each request to create a package2 version that's run in the Dev Hub org.
    /// 
    /// All filter parameters are applied using the AND logical operator (not OR).
    /// 
    /// To get information about a specific request, run "sfdx force:package2:version:create:get" and supply the request ID.
    /// 
    /// Examples:
    ///    $ sfdx force:package2:version:create:list
    ///    $ sfdx force:package2:version:create:list --createdlastdays 3
    ///    $ sfdx force:package2:version:create:list --status Error
    ///    $ sfdx force:package2:version:create:list -s InProgress
    ///    $ sfdx force:package2:version:create:list -c 3 -s Success
    /// force:package2:version:create:list [-c <number>] [-s <string>] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("version:create:list")]
      public JToken VersionCreateList(Package2VersionCreateListOptions p_Options) {
        return ExecuteCommand<Package2VersionCreateListOptions, JToken>(nameof(VersionCreateList), p_Options);      
      }
    
    /// <summary>
    /// (deprecated) retrieve a package version in the Dev Hub org
    /// </summary>
    /// <remarks>
    /// Retrieves a package version in the Dev Hub org.
    /// </remarks>
    /// <example>  
    /// WARNING: The command "version:get" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:report" instead.
    /// 
    /// NOTE: This command must be run from within a project.
    /// 
    /// Examples:
    ///    $ sfdx force:package2:version:get --package2versionid 05i...
    /// 
    /// To update package version values, run "sfdx force:package2:version:update".
    /// force:package2:version:get -i <id> [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("version:get")]
      public JToken VersionGet(Package2VersionGetOptions p_Options) {
        return ExecuteCommand<Package2VersionGetOptions, JToken>(nameof(VersionGet), p_Options);      
      }
    
    /// <summary>
    /// (deprecated) list all package versions in the Dev Hub org
    /// </summary>
    /// <remarks>
    /// Lists all package2 versions in the Dev Hub org.
    /// </remarks>
    /// <example>  
    /// WARNING: The command "version:list" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:list" instead.
    /// 
    /// Displays details of each package2 version in the org.
    /// 
    /// Use --concise or --verbose to display limited or additional details, respectively.
    /// 
    /// All filter parameters are applied using the AND logical operator (not OR).
    /// 
    /// Examples:
    ///    $ sfdx force:package2:version:list --verbose --createdlastdays 3 --released --orderby PatchVersion
    ///    $ sfdx force:package2:version:list --package2ids 0Ho000000000000,0Ho000000000001 --released --modifiedlastdays 0
    ///    $ sfdx force:package2:version:list --released
    ///    $ sfdx force:package2:version:list --concise --modifiedlastdays 0
    ///    $ sfdx force:package2:version:list --concise -c 3 -r
    /// force:package2:version:list [-c <number>] [-m <number>] [-i <string>...] [-r] [-o <string>...] [-v <string>] [--concise] [--json] [--loglevel <string>] [--verbose]
    /// </example>
    [Command("version:list")]
      public JToken VersionList(Package2VersionListOptions p_Options) {
        return ExecuteCommand<Package2VersionListOptions, JToken>(nameof(VersionList), p_Options);      
      }
    
    /// <summary>
    /// (deprecated) update a second-generation package version
    /// </summary>
    /// <remarks>
    /// Updates a second-generation package version in the Dev Hub org.
    /// </remarks>
    /// <example>  
    /// WARNING: The command "version:update" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:update" instead.
    /// 
    /// NOTE: This command must be run from within a project.
    /// 
    /// Specify a new value for each option you want to update.
    /// 
    /// Examples:
    ///    $ sfdx force:package2:version:update --package2versionid 05i... --setasreleased
    ///    $ sfdx force:package2:version:update -i 05i... -b master -t 'Release 1.0.7'
    /// 
    /// To display details about a package2 version, run "sfdx force:package2:version:get".
    /// force:package2:version:update -i <id> [-n <string>] [-d <string>] [-b <string>] [-t <string>] [-k <string>] [-s] [-p] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("version:update")]
      public JToken VersionUpdate(Package2VersionUpdateOptions p_Options) {
        return ExecuteCommand<Package2VersionUpdateOptions, JToken>(nameof(VersionUpdate), p_Options);      
      }
    
  }
}

// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method create of class Package2.
 *
 * IPackage2Create
 */
public class Package2CreateOptions : SFDXOptions {

  /**
   * [Required] Name of the second-generation package to create.
   * @type {string}
   * @memberof Package2CreateOptions
   */
  [SwitchName("--name")]
  public string name  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package2CreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package2CreateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof Package2CreateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Optional] Creates the package with no namespace. Available only for developer-controlled packages. Useful when migrating an existing org to packages, but new metadata should use a namespaced package.
   * @type {bool}
   * @memberof Package2CreateOptions
   */
  [SwitchName("--nonamespace")]
  public bool? nonamespace  {get; set;}

  /**
   * [Required] Description of the second-generation package.
   * @type {string}
   * @memberof Package2CreateOptions
   */
  [SwitchName("--description")]
  public string description  {get; set;}

  /**
   * [Required] Container options for the package2. 
   * Managed is default. Other options include Unlocked. (Managed=DeveloperManagedSubscriberManaged, Unlocked=DeveloperControlledSubscriberEditable). 
   * These options determine the upgrade and editability rules.
   * @type {string}
   * @memberof Package2CreateOptions
   */
  [SwitchName("--containeroptions")]
  public string containeroptions  {get; set;}
}

/**
 * Options for the method list of class Package2.
 *
 * IPackage2List
 */
public class Package2ListOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package2ListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package2ListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof Package2ListOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}
}

/**
 * Options for the method update of class Package2.
 *
 * IPackage2Update
 */
public class Package2UpdateOptions : SFDXOptions {

  /**
   * [Required] ID of package (starts with 0Ho).
   * @type {string}
   * @memberof Package2UpdateOptions
   */
  [SwitchName("--package2id")]
  public string package2id  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package2UpdateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package2UpdateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof Package2UpdateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] Description of the package.
   * @type {string}
   * @memberof Package2UpdateOptions
   */
  [SwitchName("--description")]
  public string description  {get; set;}

  /**
   * [Required] Name of the package to update.
   * @type {string}
   * @memberof Package2UpdateOptions
   */
  [SwitchName("--name")]
  public string name  {get; set;}
}

/**
 * Options for the method versionCreate of class Package2.
 *
 * IPackage2VersionCreate
 */
public class Package2VersionCreateOptions : SFDXOptions {

  /**
   * [Required] Specifies that the sfdx-project.json file should be validated against JSON schema
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--validateschema")]
  public string validateschema  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] The number of minutes to wait for the package version to be created.
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Required] ID of parent package (starts with 0Ho).
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--package2id")]
  public string package2id  {get; set;}

  /**
   * [Required] The package version’s branch.
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--branch")]
  public string branch  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] The source org ID used to copy the org shape for the build org.
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--sourceorg")]
  public string sourceorg  {get; set;}

  /**
   * [Required] The instance where the package version will be created——for example, NA50.
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--buildinstance")]
  public string buildinstance  {get; set;}

  /**
   * [Required] The package version’s tag.
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--tag")]
  public string tag  {get; set;}

  /**
   * [Required] The path to the directory that contains the contents of the package version.
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--directory")]
  public string directory  {get; set;}

  /**
   * [Required] Specifies that the temp files are preserved that would otherwise be deleted
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--preserve")]
  public string preserve  {get; set;}

  /**
   * [Required] Installation key for creating the key-protected package. The default is null.
   * @type {string}
   * @memberof Package2VersionCreateOptions
   */
  [SwitchName("--installationkey")]
  public string installationkey  {get; set;}
}

/**
 * Options for the method versionCreateGet of class Package2.
 *
 * IPackage2VersionCreateGet
 */
public class Package2VersionCreateGetOptions : SFDXOptions {

  /**
   * [Required] The ID of the package2 version creation request you want to display.
   * @type {string}
   * @memberof Package2VersionCreateGetOptions
   */
  [SwitchName("--package2createrequestid")]
  public string package2createrequestid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package2VersionCreateGetOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package2VersionCreateGetOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof Package2VersionCreateGetOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}
}

/**
 * Options for the method versionCreateList of class Package2.
 *
 * IPackage2VersionCreateList
 */
public class Package2VersionCreateListOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package2VersionCreateListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package2VersionCreateListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof Package2VersionCreateListOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] Filters the list based on the status of version creation requests.
   * @type {string}
   * @memberof Package2VersionCreateListOptions
   */
  [SwitchName("--status")]
  public string status  {get; set;}

  /**
   * [Required] Filters the list based on the specified maximum number of days since the request was created (starting at 00:00:00 of first day to now; 0 for today).
   * @type {string}
   * @memberof Package2VersionCreateListOptions
   */
  [SwitchName("--createdlastdays")]
  public string createdlastdays  {get; set;}
}

/**
 * Options for the method versionGet of class Package2.
 *
 * IPackage2VersionGet
 */
public class Package2VersionGetOptions : SFDXOptions {

  /**
   * [Required] The package version ID (starts with 05i).
   * @type {string}
   * @memberof Package2VersionGetOptions
   */
  [SwitchName("--package2versionid")]
  public string package2versionid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package2VersionGetOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package2VersionGetOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof Package2VersionGetOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}
}

/**
 * Options for the method versionList of class Package2.
 *
 * IPackage2VersionList
 */
public class Package2VersionListOptions : SFDXOptions {

  /**
   * [Optional] Display extended package2 versions detail.
   * @type {bool}
   * @memberof Package2VersionListOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package2VersionListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package2VersionListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Optional] Displays limited package2 version details.
   * @type {bool}
   * @memberof Package2VersionListOptions
   */
  [SwitchName("--concise")]
  public bool? concise  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof Package2VersionListOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] Orders the list by the specified package2 version fields.
   * @type {string}
   * @memberof Package2VersionListOptions
   */
  [SwitchName("--orderby")]
  public string orderby  {get; set;}

  /**
   * [Optional] Displays released versions only (IsReleased=true).
   * @type {bool}
   * @memberof Package2VersionListOptions
   */
  [SwitchName("--released")]
  public bool? released  {get; set;}

  /**
   * [Required] Filters results on the specified comma-delimited package2 IDs (start with 0Ho).
   * @type {string}
   * @memberof Package2VersionListOptions
   */
  [SwitchName("--package2ids")]
  public string package2ids  {get; set;}

  /**
   * [Required] Lists the items modified in the specified last number of days, starting at 00:00:00 of first day to now. Use 0 for today.
   * @type {string}
   * @memberof Package2VersionListOptions
   */
  [SwitchName("--modifiedlastdays")]
  public string modifiedlastdays  {get; set;}

  /**
   * [Required] Filters the list based on the specified maximum number of days since the request was created (starting at 00:00:00 of first day to now; 0 for today).
   * @type {string}
   * @memberof Package2VersionListOptions
   */
  [SwitchName("--createdlastdays")]
  public string createdlastdays  {get; set;}
}

/**
 * Options for the method versionUpdate of class Package2.
 *
 * IPackage2VersionUpdate
 */
public class Package2VersionUpdateOptions : SFDXOptions {

  /**
   * [Required] The package version ID (starts with 05i).
   * @type {string}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--package2versionid")]
  public string package2versionid  {get; set;}

  /**
   * [Required] Installation key for creating the key-protected package. The default is null.
   * @type {string}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--installationkey")]
  public string installationkey  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Optional] No prompt to confirm setting the package version as released.
   * @type {bool}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--noprompt")]
  public bool? noprompt  {get; set;}

  /**
   * [Optional] Sets the second-generation package version as released. Second-generation packages can’t be changed to beta after they’ve been released.
   * @type {bool}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--setasreleased")]
  public bool? setasreleased  {get; set;}

  /**
   * [Required] The package version name.
   * @type {string}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--name")]
  public string name  {get; set;}

  /**
   * [Required] The second-generation package version tag.
   * @type {string}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--tag")]
  public string tag  {get; set;}

  /**
   * [Required] The second-generation package version branch.
   * @type {string}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--branch")]
  public string branch  {get; set;}

  /**
   * [Required] The second-generation package version description.
   * @type {string}
   * @memberof Package2VersionUpdateOptions
   */
  [SwitchName("--description")]
  public string description  {get; set;}
}


/**
 * Package2
 *
 * @class Package2
 */
[CommandClass("force:package2")]
public class Package2 : SFDXCommand {
        /// <inheritDoc />
    public Package2(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * (deprecated) create a second-generation package
   * @returns {(Promise<Object | void>)}
   * @memberof Package2
   * @description Creates a second-generation package.
   * @example WARNING: The command "create" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:create" instead.
   * 
   * NOTE: This command must be run from within a project.
   * 
   * First, use this command to create a second-generation package. Then create a package version.
   * 
   * Your --name value must be unique within your namespace.
   * 
   * Examples:
   *    $ sfdx force:package2:create -n PackageName -d 'My New Package' -o Unlocked
   * 
   * Run 'sfdx force:package2:list' to list all second-generation packages in the Dev Hub org.
   * force:package2:create -n <string> [-o <string>] [-d <string>] [-e] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("create")]
    public JToken create(Package2CreateOptions p_Options) {
      return ExecuteCommand<Package2CreateOptions, JToken>(nameof(create), p_Options);      
    }
  
  /**
   * (deprecated) list all second-generation packages in the Dev Hub org
   * @returns {(Promise<Object | void>)}
   * @memberof Package2
   * @description Lists all second-generation packages in the Dev Hub org.
   * @example WARNING: The command "list" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:list" instead.
   * 
   * You can view the namespace, IDs, and other details for each package.
   * force:package2:list [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("list")]
    public JToken list(Package2ListOptions p_Options) {
      return ExecuteCommand<Package2ListOptions, JToken>(nameof(list), p_Options);      
    }
  
  /**
   * (deprecated) update a second-generation package
   * @returns {(Promise<Object | void>)}
   * @memberof Package2
   * @description Updates a second-generation package.
   * @example WARNING: The command "update" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:update" instead.
   * 
   * NOTE: This command must be run from within a project.
   * 
   * Specify a new value for each option you want to update.
   * 
   * Examples:
   *    $ sfdx force:package2:update --package2id 0Ho... --name 'AAnalytics'
   *    $ sfdx force:package2:update -i 0Ho... -d 'Advanced Analytics'
   * 
   * Run 'sfdx force:package2:list' to list all second-generation packages in the Dev Hub org.
   * force:package2:update -i <id> [-n <string>] [-d <string>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("update")]
    public JToken update(Package2UpdateOptions p_Options) {
      return ExecuteCommand<Package2UpdateOptions, JToken>(nameof(update), p_Options);      
    }
  
  /**
   * (deprecated) create a second-generation package version
   * @returns {(Promise<Object | void>)}
   * @memberof Package2
   * @description Creates a second-generation package (package2) version in the Dev Hub org.
   * @example WARNING: The command "version:create" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:create" instead.
   * 
   * NOTE: This command must be run from within a project.
   * 
   * The package version is based on the package contents in the specified directory.
   * 
   * To retrieve details about a package version create request, including status and package2 version ID (05i), run "sfdx force:package2:version:create:get -i 08c...".
   * 
   * To list package version creation requests in the org, run "sfdx force:package2:version:create:list".
   * 
   * Examples:
   *    $ sfdx force:package2:version:create -d common
   *    $ sfdx force:package2:version:create -i 0Ho... -d common
   * force:package2:version:create [-i <id>] [-d <directory>] [-b <string>] [-t <string>] [-k <string>] [-w <minutes>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("version:create")]
    public JToken versionCreate(Package2VersionCreateOptions p_Options) {
      return ExecuteCommand<Package2VersionCreateOptions, JToken>(nameof(versionCreate), p_Options);      
    }
  
  /**
   * (deprecated) retrieve a package version creation request
   * @returns {(Promise<Object | void>)}
   * @memberof Package2
   * @description Retrieves a second-generation package version creation request in the Dev Hub org.
   * @example WARNING: The command "version:create:get" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:create:report" instead.
   * 
   * Specify the request ID for which you want to view details. If applicable, the command displays errors related to the request.
   * 
   * Examples:
   *    $ sfdx force:package2:version:create:get --package2createrequestid 08c...
   * 
   * To show all requests in the org, run "sfdx force:package2:version:create:list".
   * force:package2:version:create:get -i <id> [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("version:create:get")]
    public JToken versionCreateGet(Package2VersionCreateGetOptions p_Options) {
      return ExecuteCommand<Package2VersionCreateGetOptions, JToken>(nameof(versionCreateGet), p_Options);      
    }
  
  /**
   * (deprecated) list package version creation requests
   * @returns {(Promise<Object | void>)}
   * @memberof Package2
   * @description Lists all requests to create second-generation package (package2) versions in the Dev Hub org.
   * @example WARNING: The command "version:create:list" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:create:list" instead.
   * 
   * Shows the details of each request to create a package2 version that's run in the Dev Hub org.
   * 
   * All filter parameters are applied using the AND logical operator (not OR).
   * 
   * To get information about a specific request, run "sfdx force:package2:version:create:get" and supply the request ID.
   * 
   * Examples:
   *    $ sfdx force:package2:version:create:list
   *    $ sfdx force:package2:version:create:list --createdlastdays 3
   *    $ sfdx force:package2:version:create:list --status Error
   *    $ sfdx force:package2:version:create:list -s InProgress
   *    $ sfdx force:package2:version:create:list -c 3 -s Success
   * force:package2:version:create:list [-c <number>] [-s <string>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("version:create:list")]
    public JToken versionCreateList(Package2VersionCreateListOptions p_Options) {
      return ExecuteCommand<Package2VersionCreateListOptions, JToken>(nameof(versionCreateList), p_Options);      
    }
  
  /**
   * (deprecated) retrieve a package version in the Dev Hub org
   * @returns {(Promise<Object | void>)}
   * @memberof Package2
   * @description Retrieves a package version in the Dev Hub org.
   * @example WARNING: The command "version:get" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:report" instead.
   * 
   * NOTE: This command must be run from within a project.
   * 
   * Examples:
   *    $ sfdx force:package2:version:get --package2versionid 05i...
   * 
   * To update package version values, run "sfdx force:package2:version:update".
   * force:package2:version:get -i <id> [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("version:get")]
    public JToken versionGet(Package2VersionGetOptions p_Options) {
      return ExecuteCommand<Package2VersionGetOptions, JToken>(nameof(versionGet), p_Options);      
    }
  
  /**
   * (deprecated) list all package versions in the Dev Hub org
   * @returns {(Promise<Object | void>)}
   * @memberof Package2
   * @description Lists all package2 versions in the Dev Hub org.
   * @example WARNING: The command "version:list" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:list" instead.
   * 
   * Displays details of each package2 version in the org.
   * 
   * Use --concise or --verbose to display limited or additional details, respectively.
   * 
   * All filter parameters are applied using the AND logical operator (not OR).
   * 
   * Examples:
   *    $ sfdx force:package2:version:list --verbose --createdlastdays 3 --released --orderby PatchVersion
   *    $ sfdx force:package2:version:list --package2ids 0Ho000000000000,0Ho000000000001 --released --modifiedlastdays 0
   *    $ sfdx force:package2:version:list --released
   *    $ sfdx force:package2:version:list --concise --modifiedlastdays 0
   *    $ sfdx force:package2:version:list --concise -c 3 -r
   * force:package2:version:list [-c <number>] [-m <number>] [-i <string>...] [-r] [-o <string>...] [-v <string>] [--concise] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("version:list")]
    public JToken versionList(Package2VersionListOptions p_Options) {
      return ExecuteCommand<Package2VersionListOptions, JToken>(nameof(versionList), p_Options);      
    }
  
  /**
   * (deprecated) update a second-generation package version
   * @returns {(Promise<Object | void>)}
   * @memberof Package2
   * @description Updates a second-generation package version in the Dev Hub org.
   * @example WARNING: The command "version:update" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:version:update" instead.
   * 
   * NOTE: This command must be run from within a project.
   * 
   * Specify a new value for each option you want to update.
   * 
   * Examples:
   *    $ sfdx force:package2:version:update --package2versionid 05i... --setasreleased
   *    $ sfdx force:package2:version:update -i 05i... -b master -t 'Release 1.0.7'
   * 
   * To display details about a package2 version, run "sfdx force:package2:version:get".
   * force:package2:version:update -i <id> [-n <string>] [-d <string>] [-b <string>] [-t <string>] [-k <string>] [-s] [-p] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("version:update")]
    public JToken versionUpdate(Package2VersionUpdateOptions p_Options) {
      return ExecuteCommand<Package2VersionUpdateOptions, JToken>(nameof(versionUpdate), p_Options);      
    }
  
}

// Generated on September 11th 2018, 4:34:13 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method versionCreate of class Package1.
 *
 * IPackage1VersionCreate
 */
public class Package1VersionCreateOptions : SFDXOptions {

  /**
   * [Required] ID of the metadata package (starts with 033) of which you’re creating a new version.
   * @type {string}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--packageid")]
  public string packageid  {get; set;}

  /**
   * [Required] Package version name.
   * @type {string}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--name")]
  public string name  {get; set;}

  /**
   * [Required] Post install URL.
   * @type {string}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--postinstallurl")]
  public string postinstallurl  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Minutes to wait for the package version to be created. The default is 2 minutes.
   * @type {string}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Required] Installation key for creating the key-protected package. The default is null.
   * @type {string}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--installationkey")]
  public string installationkey  {get; set;}

  /**
   * [Required] Package version description.
   * @type {string}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--description")]
  public string description  {get; set;}

  /**
   * [Required] Release notes URL.
   * @type {string}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--releasenotesurl")]
  public string releasenotesurl  {get; set;}

  /**
   * [Optional] Creates a managed package version. To create a beta version, don’t include this parameter.
   * @type {bool}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--managedreleased")]
  public bool? managedreleased  {get; set;}

  /**
   * [Required] Package version in major.minor format, for example, 3.2.
   * @type {string}
   * @memberof Package1VersionCreateOptions
   */
  [SwitchName("--version")]
  public string version  {get; set;}
}

/**
 * Options for the method versionCreateGet of class Package1.
 *
 * IPackage1VersionCreateGet
 */
public class Package1VersionCreateGetOptions : SFDXOptions {

  /**
   * [Required] The ID of the PackageUploadRequest.
   * @type {string}
   * @memberof Package1VersionCreateGetOptions
   */
  [SwitchName("--requestid")]
  public string requestid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package1VersionCreateGetOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package1VersionCreateGetOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof Package1VersionCreateGetOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method versionDisplay of class Package1.
 *
 * IPackage1VersionDisplay
 */
public class Package1VersionDisplayOptions : SFDXOptions {

  /**
   * [Required] ID (starts with 04t) of the metadata package version whose details you want to display.
   * @type {string}
   * @memberof Package1VersionDisplayOptions
   */
  [SwitchName("--packageversionid")]
  public string packageversionid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package1VersionDisplayOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package1VersionDisplayOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof Package1VersionDisplayOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method versionList of class Package1.
 *
 * IPackage1VersionList
 */
public class Package1VersionListOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof Package1VersionListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof Package1VersionListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof Package1VersionListOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Metadata package ID (starts with 033) whose package versions you want to list. If not specified, shows all versions for all packages (managed and unmanaged) in the org.
   * @type {string}
   * @memberof Package1VersionListOptions
   */
  [SwitchName("--packageid")]
  public string packageid  {get; set;}
}


/**
 * Package1
 *
 * @class Package1
 */
[CommandClass("force:package1")]
public class Package1 : SFDXCommand {
        /// <inheritDoc />
    public Package1(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * create a first-generation package version in the release org
   * @returns {(Promise<Object | void>)}
   * @memberof Package1
   * @description Creates a first-generation package version in the release org.
   * @example NOTE: This command must be run from within a project.
   * 
   * The package version is based on the contents of the specified metadata package. Omit -m if you want to create an unmanaged package version.
   * force:package1:version:create -i <id> -n <string> [-d <string>] [-v <string>] [-m] [-r <url>] [-p <url>] [-k <string>] [-w <number>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("version:create")]
    public JToken versionCreate(Package1VersionCreateOptions p_Options) {
      return ExecuteCommand<Package1VersionCreateOptions, JToken>(nameof(versionCreate), p_Options);      
    }
  
  /**
   * retrieve the status of a package version creation request
   * @returns {(Promise<Object | void>)}
   * @memberof Package1
   * @description Retrieves the status of a package version creation request.
   * @example Examples:
   *    $ sfdx force:package:version:create:report -i 08c...
   *    $ sfdx force:package:version:create:report -i 08c... -v devhub@example.com
   * force:package1:version:create:get -i <id> [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("version:create:get")]
    public JToken versionCreateGet(Package1VersionCreateGetOptions p_Options) {
      return ExecuteCommand<Package1VersionCreateGetOptions, JToken>(nameof(versionCreateGet), p_Options);      
    }
  
  /**
   * display details about a first-generation package version
   * @returns {(Promise<Object | void>)}
   * @memberof Package1
   * @description Displays detailed information about an individual first-generation package version.
   * @example NOTE: This command must be run from within a project.
   * 
   * Display detailed information about an individual package version, including metadata package ID, name, the release state, and build number.
   * force:package1:version:display -i <id> [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("version:display")]
    public JToken versionDisplay(Package1VersionDisplayOptions p_Options) {
      return ExecuteCommand<Package1VersionDisplayOptions, JToken>(nameof(versionDisplay), p_Options);      
    }
  
  /**
   * list package versions for the specified first-generation package or for the org
   * @returns {(Promise<Object | void>)}
   * @memberof Package1
   * @description Lists the versions for the specified package or all first-generation packages in the org.
   * @example NOTE: This command must be run from within a project.
   * 
   * If a metadata package ID is specified, lists all versions of the specified package. Otherwise, lists all package versions for the org. For each package version, the list includes the package version ID, metadata package ID, name, version number, and release state.
   * force:package1:version:list [-i <id>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("version:list")]
    public JToken versionList(Package1VersionListOptions p_Options) {
      return ExecuteCommand<Package1VersionListOptions, JToken>(nameof(versionList), p_Options);      
    }
  
}

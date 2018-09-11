// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method create of class Package.
 *
 * IPackageCreate
 */
public class PackageCreateOptions : SFDXOptions {

  /**
   * [Required] Name of the package to create.
   * @type {string}
   * @memberof PackageCreateOptions
   */
  [SwitchName("--name")]
  public string name  {get; set;}

  /**
   * [Required] Package type for the package.
   * The options for package type are Managed and Unlocked (Managed=DeveloperManagedSubscriberManaged, Unlocked=DeveloperControlledSubscriberEditable).
   * These options determine upgrade and editability rules.
   * @type {string}
   * @memberof PackageCreateOptions
   */
  [SwitchName("--packagetype")]
  public string packagetype  {get; set;}

  /**
   * [Required] The path to the directory that contains the contents of the package.
   * @type {string}
   * @memberof PackageCreateOptions
   */
  [SwitchName("--path")]
  public string path  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageCreateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof PackageCreateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Optional] Creates the package with no namespace. Available only for unlocked packages. Useful when you’re migrating an existing org to packages. But, use a namespaced package for new metadata.
   * @type {bool}
   * @memberof PackageCreateOptions
   */
  [SwitchName("--nonamespace")]
  public bool? nonamespace  {get; set;}

  /**
   * [Required] Description of the package.
   * @type {string}
   * @memberof PackageCreateOptions
   */
  [SwitchName("--description")]
  public string description  {get; set;}
}

/**
 * Options for the method install of class Package.
 *
 * IPackageInstall
 */
public class PackageInstallOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageInstallOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageInstallOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof PackageInstallOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] The ID (starts with 04t) or alias of the package version to install.
   * @type {string}
   * @memberof PackageInstallOptions
   */
  [SwitchName("--package")]
  public string package  {get; set;}

  /**
   * [Optional] Allow Remote Site Settings and Content Security Policy websites to send or receive data without confirmation.
   * @type {bool}
   * @memberof PackageInstallOptions
   */
  [SwitchName("--noprompt")]
  public bool? noprompt  {get; set;}

  /**
   * [Required] Maximum number of minutes to wait for the subscriber package version ID to become available in the target org before canceling the installation request. The default is 0.
   * WARNING: The short name "-p" has been deprecated and will be removed in v44.0 or later. Use "--publishwait" instead.
   * @type {string}
   * @memberof PackageInstallOptions
   */
  [SwitchName("--publishwait")]
  public string publishwait  {get; set;}

  /**
   * [Required] Installation key for installing a key-protected package. The default is null.
   * @type {string}
   * @memberof PackageInstallOptions
   */
  [SwitchName("--installationkey")]
  public string installationkey  {get; set;}

  /**
   * [Required] Maximum number of minutes to wait for installation status. The default is 0.
   * @type {string}
   * @memberof PackageInstallOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Required] The ID of the package version to install (starts with 04t).
   * @type {string}
   * @memberof PackageInstallOptions
   */
  [SwitchName("--id")]
  public string id  {get; set;}
}

/**
 * Options for the method installGet of class Package.
 *
 * IPackageInstallGet
 */
public class PackageInstallGetOptions : SFDXOptions {

  /**
   * [Required] The ID of the package install request you want to check.
   * @type {string}
   * @memberof PackageInstallGetOptions
   */
  [SwitchName("--requestid")]
  public string requestid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageInstallGetOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageInstallGetOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof PackageInstallGetOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method installReport of class Package.
 *
 * IPackageInstallReport
 */
public class PackageInstallReportOptions : SFDXOptions {

  /**
   * [Required] The ID of the package install request you want to check.
   * @type {string}
   * @memberof PackageInstallReportOptions
   */
  [SwitchName("--requestid")]
  public string requestid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageInstallReportOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageInstallReportOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof PackageInstallReportOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method installedList of class Package.
 *
 * IPackageInstalledList
 */
public class PackageInstalledListOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageInstalledListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageInstalledListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof PackageInstalledListOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method list of class Package.
 *
 * IPackageList
 */
public class PackageListOptions : SFDXOptions {

  /**
   * [Optional] Displays extended package details.
   * @type {bool}
   * @memberof PackageListOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof PackageListOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}
}

/**
 * Options for the method uninstall of class Package.
 *
 * IPackageUninstall
 */
public class PackageUninstallOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageUninstallOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageUninstallOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof PackageUninstallOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] The ID (starts with 04t) or alias of the package version to uninstall.
   * @type {string}
   * @memberof PackageUninstallOptions
   */
  [SwitchName("--package")]
  public string package  {get; set;}

  /**
   * [Required] Maximum number of minutes to wait for uninstall status. The default is 0.
   * @type {string}
   * @memberof PackageUninstallOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Required] The ID of the second-generation package to uninstall (starts with 04t).
   * @type {string}
   * @memberof PackageUninstallOptions
   */
  [SwitchName("--id")]
  public string id  {get; set;}
}

/**
 * Options for the method uninstallGet of class Package.
 *
 * IPackageUninstallGet
 */
public class PackageUninstallGetOptions : SFDXOptions {

  /**
   * [Required] The ID of the package uninstall request you want to check.
   * @type {string}
   * @memberof PackageUninstallGetOptions
   */
  [SwitchName("--requestid")]
  public string requestid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageUninstallGetOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageUninstallGetOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof PackageUninstallGetOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method uninstallReport of class Package.
 *
 * IPackageUninstallReport
 */
public class PackageUninstallReportOptions : SFDXOptions {

  /**
   * [Required] The ID of the package uninstall request you want to check.
   * @type {string}
   * @memberof PackageUninstallReportOptions
   */
  [SwitchName("--requestid")]
  public string requestid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageUninstallReportOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageUninstallReportOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof PackageUninstallReportOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method update of class Package.
 *
 * IPackageUpdate
 */
public class PackageUpdateOptions : SFDXOptions {

  /**
   * [Required] The D (starts with 0Ho) or alias of the package to update.
   * @type {string}
   * @memberof PackageUpdateOptions
   */
  [SwitchName("--package")]
  public string package  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageUpdateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageUpdateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof PackageUpdateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] New description of the package.
   * @type {string}
   * @memberof PackageUpdateOptions
   */
  [SwitchName("--description")]
  public string description  {get; set;}

  /**
   * [Required] New name of the package.
   * @type {string}
   * @memberof PackageUpdateOptions
   */
  [SwitchName("--name")]
  public string name  {get; set;}
}

/**
 * Options for the method versionCreate of class Package.
 *
 * IPackageVersionCreate
 */
public class PackageVersionCreateOptions : SFDXOptions {

  /**
   * [Required] The number of minutes to wait for the package version to be created.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] The instance where the package version will be created——for example, NA50.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--buildinstance")]
  public string buildinstance  {get; set;}

  /**
   * [Required] The ID (starts with 0Ho) or alias of the package to create a version of.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--package")]
  public string package  {get; set;}

  /**
   * [Required] The source org ID used to copy the org shape for the build org.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--sourceorg")]
  public string sourceorg  {get; set;}

  /**
   * [Required] The path to a definition file (similar to a scratch org definition file) that contains the list of features and org preferences that the metadata in the package version depends on.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--definitionfile")]
  public string definitionfile  {get; set;}

  /**
   * [Required] The name of the package version to be created. Overrides the sfdx-project.json value.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--versionname")]
  public string versionname  {get; set;}

  /**
   * [Required] The package version’s tag.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--tag")]
  public string tag  {get; set;}

  /**
   * [Required] Bypasses the installation key requirement. If you bypass this requirement, anyone can install your package. Either an --installationkey value or the --installationkeybypass flag is required.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--installationkeybypass")]
  public string installationkeybypass  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] The description of the package version to be created. Overrides the sfdx-project.json value.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--versiondescription")]
  public string versiondescription  {get; set;}

  /**
   * [Required] The version number of the package version to be created. Overrides the sfdx-project.json value.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--versionnumber")]
  public string versionnumber  {get; set;}

  /**
   * [Required] Specifies that the temp files are preserved that would otherwise be deleted
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--preserve")]
  public string preserve  {get; set;}

  /**
   * [Required] Installation key for creating the key-protected package. Either an --installationkey value or the --installationkeybypass flag is required.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--installationkey")]
  public string installationkey  {get; set;}

  /**
   * [Required] The package version’s branch.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--branch")]
  public string branch  {get; set;}

  /**
   * [Required] The path to the directory that contains the contents of the package.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--path")]
  public string path  {get; set;}

  /**
   * [Required] Specifies that the sfdx-project.json file should be validated against JSON schema.
   * @type {string}
   * @memberof PackageVersionCreateOptions
   */
  [SwitchName("--validateschema")]
  public string validateschema  {get; set;}
}

/**
 * Options for the method versionCreateList of class Package.
 *
 * IPackageVersionCreateList
 */
public class PackageVersionCreateListOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageVersionCreateListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageVersionCreateListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof PackageVersionCreateListOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] Filters the list based on the status of version creation requests.
   * @type {string}
   * @memberof PackageVersionCreateListOptions
   */
  [SwitchName("--status")]
  public string status  {get; set;}

  /**
   * [Required] Filters the list based on the specified maximum number of days since the request was created (starting at 00:00:00 of first day to now; 0 for today).
   * @type {string}
   * @memberof PackageVersionCreateListOptions
   */
  [SwitchName("--createdlastdays")]
  public string createdlastdays  {get; set;}
}

/**
 * Options for the method versionCreateReport of class Package.
 *
 * IPackageVersionCreateReport
 */
public class PackageVersionCreateReportOptions : SFDXOptions {

  /**
   * [Required] The ID (starts with 08c) of the package version creation request you want to display.
   * @type {string}
   * @memberof PackageVersionCreateReportOptions
   */
  [SwitchName("--packagecreaterequestid")]
  public string packagecreaterequestid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageVersionCreateReportOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageVersionCreateReportOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof PackageVersionCreateReportOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}
}

/**
 * Options for the method versionList of class Package.
 *
 * IPackageVersionList
 */
public class PackageVersionListOptions : SFDXOptions {

  /**
   * [Optional] Displays extended package version details.
   * @type {bool}
   * @memberof PackageVersionListOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageVersionListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageVersionListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Optional] Displays limited package version details.
   * @type {bool}
   * @memberof PackageVersionListOptions
   */
  [SwitchName("--concise")]
  public bool? concise  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof PackageVersionListOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] Orders the list by the specified package version fields.
   * @type {string}
   * @memberof PackageVersionListOptions
   */
  [SwitchName("--orderby")]
  public string orderby  {get; set;}

  /**
   * [Optional] Displays released versions only (IsReleased=true).
   * @type {bool}
   * @memberof PackageVersionListOptions
   */
  [SwitchName("--released")]
  public bool? released  {get; set;}

  /**
   * [Required] Filters results on the specified comma-delimited packages (aliases or 0Ho IDs).
   * @type {string}
   * @memberof PackageVersionListOptions
   */
  [SwitchName("--packages")]
  public string packages  {get; set;}

  /**
   * [Required] Lists the items modified in the specified last number of days, starting at 00:00:00 of first day to now. Use 0 for today.
   * @type {string}
   * @memberof PackageVersionListOptions
   */
  [SwitchName("--modifiedlastdays")]
  public string modifiedlastdays  {get; set;}

  /**
   * [Required] Filters the list based on the specified maximum number of days since the request was created (starting at 00:00:00 of first day to now; 0 for today).
   * @type {string}
   * @memberof PackageVersionListOptions
   */
  [SwitchName("--createdlastdays")]
  public string createdlastdays  {get; set;}
}

/**
 * Options for the method versionPromote of class Package.
 *
 * IPackageVersionPromote
 */
public class PackageVersionPromoteOptions : SFDXOptions {

  /**
   * [Required] The ID (starts with 04t) or alias of the package version to promote.
   * @type {string}
   * @memberof PackageVersionPromoteOptions
   */
  [SwitchName("--package")]
  public string package  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageVersionPromoteOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageVersionPromoteOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof PackageVersionPromoteOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] Do not prompt to confirm setting the package version as released.
   * @type {string}
   * @memberof PackageVersionPromoteOptions
   */
  [SwitchName("--noprompt")]
  public string noprompt  {get; set;}
}

/**
 * Options for the method versionReport of class Package.
 *
 * IPackageVersionReport
 */
public class PackageVersionReportOptions : SFDXOptions {

  /**
   * [Required] The ID (starts with 04t) or alias of the package to retrieve details for.
   * @type {string}
   * @memberof PackageVersionReportOptions
   */
  [SwitchName("--package")]
  public string package  {get; set;}

  /**
   * [Optional] Displays extended package version details.
   * @type {bool}
   * @memberof PackageVersionReportOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageVersionReportOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageVersionReportOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof PackageVersionReportOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}
}

/**
 * Options for the method versionUpdate of class Package.
 *
 * IPackageVersionUpdate
 */
public class PackageVersionUpdateOptions : SFDXOptions {

  /**
   * [Required] The ID (starts with 04t) or alias of the package to update a version of.
   * @type {string}
   * @memberof PackageVersionUpdateOptions
   */
  [SwitchName("--package")]
  public string package  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof PackageVersionUpdateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof PackageVersionUpdateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof PackageVersionUpdateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] The new installation key for the key-protected package. The default is null.
   * @type {string}
   * @memberof PackageVersionUpdateOptions
   */
  [SwitchName("--installationkey")]
  public string installationkey  {get; set;}

  /**
   * [Required] The new package version tag.
   * @type {string}
   * @memberof PackageVersionUpdateOptions
   */
  [SwitchName("--tag")]
  public string tag  {get; set;}

  /**
   * [Required] The new package version branch.
   * @type {string}
   * @memberof PackageVersionUpdateOptions
   */
  [SwitchName("--branch")]
  public string branch  {get; set;}

  /**
   * [Required] The new package version description.
   * @type {string}
   * @memberof PackageVersionUpdateOptions
   */
  [SwitchName("--versiondescription")]
  public string versiondescription  {get; set;}

  /**
   * [Required] The new package version name.
   * @type {string}
   * @memberof PackageVersionUpdateOptions
   */
  [SwitchName("--versionname")]
  public string versionname  {get; set;}
}


/**
 * Package
 *
 * @class Package
 */
[CommandClass("force:package")]
public class Package : SFDXCommand {
        /// <inheritDoc />
    public Package(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * create a package
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Creates a package.
   * @example NOTE: This command must be run from within a project.
   * 
   * First, use this command to create a package. Then create a package version.
   * 
   * If you don't have a namespace defined in your sfdx-project.json file, use --nonamespace.
   * 
   * Your --name value must be unique within your namespace.
   * 
   * Examples:
   *    $ sfdx force:package:create -n YourPackageName -t Unlocked -r force-app
   *    $ sfdx force:package:create -n YourPackageName -d "Your Package Descripton" -t Unlocked -r force-app
   * 
   * Run 'sfdx force:package:list' to list all packages in the Dev Hub org.
   * force:package:create -n <string> -t <string> -r <directory> [-d <string>] [-e] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("create")]
    public JToken create(PackageCreateOptions p_Options) {
      return ExecuteCommand<PackageCreateOptions, JToken>(nameof(create), p_Options);      
    }
  
  /**
   * install a package in the target org
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Installs a package in the target org.
   * @example Supply the ID of the package version you want to install. The package installs in your default target org unless you supply the username for a different target org.
   * 
   * Examples:
   *    $ sfdx force:package:install --package 04t... -u me@example.com
   *    $ sfdx force:package:install --package awesome_package_alias
   *    $ sfdx force:package:install --package "Awesome Package Alias"
   * force:package:install [-i <id>] [-w <minutes>] [-k <string>] [-p <minutes>] [-r] [--package <string>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("install")]
    public JToken install(PackageInstallOptions p_Options) {
      return ExecuteCommand<PackageInstallOptions, JToken>(nameof(install), p_Options);      
    }
  
  /**
   * (deprecated) retrieve the status of a package installation request
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Retrieves the status of a package installation request.
   * @example WARNING: The command "install:get" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:install:report" instead.
   * 
   * Examples:
   *    $ sfdx force:package:install:get -i 0Hf...
   *    $ sfdx force:package:install:get -i 0Hf... -u me@example.com
   * force:package:install:get -i <id> [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("install:get")]
    public JToken installGet(PackageInstallGetOptions p_Options) {
      return ExecuteCommand<PackageInstallGetOptions, JToken>(nameof(installGet), p_Options);      
    }
  
  /**
   * retrieve the status of a package installation request
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Retrieves the status of a package installation request.
   * @example Examples:
   *    $ sfdx force:package:install:report -i 0Hf...
   *    $ sfdx force:package:install:report -i 0Hf... -u me@example.com
   * force:package:install:report -i <id> [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("install:report")]
    public JToken installReport(PackageInstallReportOptions p_Options) {
      return ExecuteCommand<PackageInstallReportOptions, JToken>(nameof(installReport), p_Options);      
    }
  
  /**
   * list the org’s installed packages
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Lists all packages installed in the target org.
   * @example NOTE: This command must be run from within a project.
   * 
   * Examples:
   *    $ sfdx force:package:installed:list
   *    $ sfdx force:package:installed:list -u me@example.com
   * force:package:installed:list [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("installed:list")]
    public JToken installedList(PackageInstalledListOptions p_Options) {
      return ExecuteCommand<PackageInstalledListOptions, JToken>(nameof(installedList), p_Options);      
    }
  
  /**
   * list all packages in the Dev Hub org
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Lists all packages in the Dev Hub org.
   * @example You can view the namespace, IDs, and other details for each package.
   * 
   * Examples:
   *    $ sfdx force:package:list -v devhub@example.com
   *    $ sfdx force:package:list -v devhub@example.com --verbose
   * force:package:list [-v <string>] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("list")]
    public JToken list(PackageListOptions p_Options) {
      return ExecuteCommand<PackageListOptions, JToken>(nameof(list), p_Options);      
    }
  
  /**
   * uninstall a second-generation package from the target org
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Uninstalls a second-generation package from the target org. To uninstall a first-generation package, use the Salesforce user interface.
   * @example Specify the package ID for a second-generation package.
   * 
   * Examples:
   *    $ sfdx force:package:uninstall -p 04t... -u me@example.com
   *    $ sfdx force:package:uninstall -p undesirable_package_alias
   *    $ sfdx force:package:uninstall -p "Undesirable Package Alias"
   * 
   * To list the org’s installed packages, run "sfdx force:package:installed:list".
   * 
   * To uninstall a first-generation package, from Setup, enter Installed Packages in the Quick Find box, then select Installed Packages.
   * force:package:uninstall [-i <id>] [-w <minutes>] [-p <string>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("uninstall")]
    public JToken uninstall(PackageUninstallOptions p_Options) {
      return ExecuteCommand<PackageUninstallOptions, JToken>(nameof(uninstall), p_Options);      
    }
  
  /**
   * (deprecated) retrieve the status of a package uninstall request
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Retrieves the status of a package uninstall request.
   * @example WARNING: The command "uninstall:get" has been deprecated and will be removed in v43.01.0 or later. Use "force:package:uninstall:report" instead.
   * 
   * Examples:
   *    $ sfdx force:package:uninstall:get -i 06y...
   *    $ sfdx force:package:uninstall:get -i 06y... -u me@example.com
   * force:package:uninstall:get -i <id> [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("uninstall:get")]
    public JToken uninstallGet(PackageUninstallGetOptions p_Options) {
      return ExecuteCommand<PackageUninstallGetOptions, JToken>(nameof(uninstallGet), p_Options);      
    }
  
  /**
   * retrieve status of package uninstall request
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Retrieves the status of a package uninstall request.
   * @example Examples:
   *    $ sfdx force:package:uninstall:report -i 06y...
   *    $ sfdx force:package:uninstall:report -i 06y... -u me@example.com
   * force:package:uninstall:report -i <id> [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("uninstall:report")]
    public JToken uninstallReport(PackageUninstallReportOptions p_Options) {
      return ExecuteCommand<PackageUninstallReportOptions, JToken>(nameof(uninstallReport), p_Options);      
    }
  
  /**
   * update package details
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Updates details about a package. Does not create a package version.
   * @example NOTE: This command must be run from within a project.
   * 
   * Specify a new value for each option you want to update.
   * 
   * Examples:
   *    $ sfdx force:package:update -p "Your Package Alias" -n "New Package Name"
   *    $ sfdx force:package:update -p 0Ho... -d "New Package Description"
   * 
   * Run "sfdx force:package:list" to list all packages in the Dev Hub org.
   * force:package:update -p <string> [-n <string>] [-d <string>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("update")]
    public JToken update(PackageUpdateOptions p_Options) {
      return ExecuteCommand<PackageUpdateOptions, JToken>(nameof(update), p_Options);      
    }
  
  /**
   * create a package version
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Creates a package version in the Dev Hub org.
   * @example NOTE: This command must be run from within a project.
   * 
   * The package version is based on the package contents in the specified directory.
   * 
   * To retrieve details about a package version create request, including status and package version ID (04t), run "sfdx force:package:version:create:report -i 08c...".
   * 
   * We recommend specifying the --installationkey to protect the contents of your package and to prevent unauthorized installation of your package.
   * 
   * To list package version creation requests in the org, run "sfdx force:package:version:create:list".
   * 
   * Examples:
   *    $ sfdx force:package:version:create -d common -k password123
   *    $ sfdx force:package:version:create -p "Your Package Alias" -k password123
   *    $ sfdx force:package:version:create -p 0Ho... -k password123
   * force:package:version:create [-p <string>] [-d <directory>] [-f <filepath>] [-b <string>] [-t <string>] [-k <string>] [-x] [-w <minutes>] [-a <string>] [-n <string>] [-e <string>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("version:create")]
    public JToken versionCreate(PackageVersionCreateOptions p_Options) {
      return ExecuteCommand<PackageVersionCreateOptions, JToken>(nameof(versionCreate), p_Options);      
    }
  
  /**
   * list package version creation requests
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Lists all requests to create second-generation package versions in the Dev Hub org.
   * @example Shows the details of each request to create a package version that has run in the Dev Hub org.
   * 
   * All filter parameters are applied using the AND logical operator (not OR).
   * 
   * To get information about a specific request, run "sfdx force:package:version:create:report" and supply the request ID.
   * 
   * Examples:
   *    $ sfdx force:package:version:create:list
   *    $ sfdx force:package:version:create:list --createdlastdays 3
   *    $ sfdx force:package:version:create:list --status Error
   *    $ sfdx force:package:version:create:list -s InProgress
   *    $ sfdx force:package:version:create:list -c 3 -s Success
   * force:package:version:create:list [-c <number>] [-s <string>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("version:create:list")]
    public JToken versionCreateList(PackageVersionCreateListOptions p_Options) {
      return ExecuteCommand<PackageVersionCreateListOptions, JToken>(nameof(versionCreateList), p_Options);      
    }
  
  /**
   * retrieve details about a package version creation request
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Retrieves details about a package version creation request in the Dev Hub org.
   * @example Specify the request ID for which you want to view details. If applicable, the command displays errors related to the request.
   * 
   * Examples:
   *    $ sfdx force:package:version:create:report -i 08c...
   *    $ sfdx force:package:version:create:report -i 08c... -v devhub@example.com
   * 
   * To show all requests in the org, run "sfdx force:package:version:create:list".
   * force:package:version:create:report -i <id> [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("version:create:report")]
    public JToken versionCreateReport(PackageVersionCreateReportOptions p_Options) {
      return ExecuteCommand<PackageVersionCreateReportOptions, JToken>(nameof(versionCreateReport), p_Options);      
    }
  
  /**
   * list all package versions in the Dev Hub org
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Lists all package versions in the Dev Hub org.
   * @example Displays details of each package version in the org.
   * 
   * Use --concise or --verbose to display limited or additional details, respectively.
   * 
   * All filter parameters are applied using the AND logical operator (not OR).
   * 
   * Examples:
   *    $ sfdx force:package:version:list --verbose --createdlastdays 3 --released --orderby PatchVersion
   *    $ sfdx force:package:version:list --packages 0Ho000000000000,0Ho000000000001 --released --modifiedlastdays 0
   *    $ sfdx force:package:version:list --released
   *    $ sfdx force:package:version:list --concise --modifiedlastdays 0
   *    $ sfdx force:package:version:list --concise -c 3 -r
   *    $ sfdx force:package:version:list --packages exp-mgr,exp-mgr-util --released --modifiedlastdays 0
   * force:package:version:list [-c <number>] [-m <number>] [-p <string>...] [-r] [-o <string>...] [-v <string>] [--concise] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("version:list")]
    public JToken versionList(PackageVersionListOptions p_Options) {
      return ExecuteCommand<PackageVersionListOptions, JToken>(nameof(versionList), p_Options);      
    }
  
  /**
   * promote a package version to released
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Promotes a package version to released status.
   * @example NOTE: This command must be run from within a project.
   * 
   * Supply the ID or alias of the package version you want to promote. Promotes the package version to released status.
   * 
   * Examples:
   *    $ sfdx force:package:version:promote -p 04t...
   *    $ sfdx force:package:version:promote -p awesome_package_alias
   *    $ sfdx force:package:version:promote -p "Awesome Package Alias"
   * force:package:version:promote -p <string> [-n] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("version:promote")]
    public JToken versionPromote(PackageVersionPromoteOptions p_Options) {
      return ExecuteCommand<PackageVersionPromoteOptions, JToken>(nameof(versionPromote), p_Options);      
    }
  
  /**
   * retrieve details about a package version in the Dev Hub org
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Retrieves details about a package version in the Dev Hub org.
   * @example NOTE: This command must be run from within a project.
   * 
   * Examples:
   *    $ sfdx force:package:version:report -p 04t...
   *    $ sfdx force:package:version:report -p "Your Package Alias"
   * 
   * To update package version values, run "sfdx force:package:version:update".
   * force:package:version:report -p <string> [-v <string>] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("version:report")]
    public JToken versionReport(PackageVersionReportOptions p_Options) {
      return ExecuteCommand<PackageVersionReportOptions, JToken>(nameof(versionReport), p_Options);      
    }
  
  /**
   * update a package version
   * @returns {(Promise<Object | void>)}
   * @memberof Package
   * @description Updates a second-generation package version in the Dev Hub org.
   * @example NOTE: This command must be run from within a project.
   * 
   * Specify a new value for each option you want to update.
   * 
   * Examples:
   *    $ sfdx force:package:version:update -p "Your Package Alias" -k password123
   *    $ sfdx force:package:version:update -p 04t... -b master -t 'Release 1.0.7'
   *    $ sfdx force:package:version:update -p 04t... -e "New Package Version Description"
   * 
   * To display details about a package version, run "sfdx force:package:version:report".
   * force:package:version:update -p <string> [-a <string>] [-e <string>] [-b <string>] [-t <string>] [-k <string>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("version:update")]
    public JToken versionUpdate(PackageVersionUpdateOptions p_Options) {
      return ExecuteCommand<PackageVersionUpdateOptions, JToken>(nameof(versionUpdate), p_Options);      
    }
  
}

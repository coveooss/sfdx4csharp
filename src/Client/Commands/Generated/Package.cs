// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method create of class Package.
    /// </summary>
    public class PackageCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The path to the directory that contains the contents of the package.
        /// </summary>
        [SwitchName("--path")]
        public string path { get; set; }

        /// <summary>
        /// [Required] Package type for the package.
        /// The options for package type are Managed and Unlocked (Managed=DeveloperManagedSubscriberManaged, Unlocked=DeveloperControlledSubscriberEditable).
        /// These options determine upgrade and editability rules.
        /// </summary>
        [SwitchName("--packagetype")]
        public string packagetype { get; set; }

        /// <summary>
        /// [Required] Name of the package to create.
        /// </summary>
        [SwitchName("--name")]
        public string name { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] Description of the package.
        /// </summary>
        [SwitchName("--description")]
        public string description { get; set; }

        /// <summary>
        /// [Optional] Creates the package with no namespace. Available only for unlocked packages. Useful when you’re migrating an existing org to packages. But, use a namespaced package for new metadata.
        /// </summary>
        [SwitchName("--nonamespace")]
        public bool? nonamespace { get; set; }

        /// <summary>
        /// [Optional] Package depends on unpackaged metadata in the installation org. Applies to unlocked packages only.
        /// Use Source Tracking in Sandboxes to develop your org-dependent unlocked package.
        /// For more information, see "Create Org-Dependent Unlocked Packages" in the Salesforce DX Developer Guide.
        /// </summary>
        [SwitchName("--orgdependent")]
        public bool? orgdependent { get; set; }

        /// <summary>
        /// [Required] An active Dev Hub org user designated to receive email notifications for unhandled Apex exceptions, and install, upgrade, or uninstall failures associated with your package.
        /// </summary>
        [SwitchName("--errornotificationusername")]
        public string errornotificationusername { get; set; }
    }

    /// <summary>
    /// Options for the method delete of class Package.
    /// </summary>
    public class PackageDeleteOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 0Ho) or alias of the package to delete.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Don’t prompt before deleting the package
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }

        /// <summary>
        /// [Optional] Undelete a deleted package.
        /// </summary>
        [SwitchName("--undelete")]
        public bool? undelete { get; set; }
    }

    /// <summary>
    /// Options for the method install of class Package.
    /// </summary>
    public class PackageInstallOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Maximum number of minutes to wait for installation status. The default is 0.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Required] Installation key for installing a key-protected package. The default is null.
        /// </summary>
        [SwitchName("--installationkey")]
        public string installationkey { get; set; }

        /// <summary>
        /// [Optional] Maximum number of minutes to wait for the Subscriber Package Version ID to become available in the target org before canceling the install request. The default is 0.
        /// </summary>
        [SwitchName("--publishwait")]
        public int? publishwait { get; set; }

        /// <summary>
        /// [Optional] Allows the following without an explicit confirmation response: 1) Remote Site Settings and Content Security Policy websites to send or receive data, and 2) --upgradetype Delete to proceed.
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 04t) or alias of the package version to install.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Required] Applies to unlocked packages only. Specifies whether to compile all Apex in the org and package, or only the Apex in the package.
        /// </summary>
        [SwitchName("--apexcompile")]
        public string apexcompile { get; set; }

        /// <summary>
        /// [Required] Security access type for the installed package.
        /// Deprecation notice: The --securitytype parameter's default value will change from AllUsers to AdminsOnly in an upcoming release (v47.0 or later).
        /// </summary>
        [SwitchName("--securitytype")]
        public string securitytype { get; set; }

        /// <summary>
        /// [Required] For package upgrades, specifies whether to mark all removed components as deprecated (DeprecateOnly), to delete removed components that can be safely deleted and deprecate the others (Mixed), or to delete all removed components, except for custom objects and custom fields, that don't have dependencies (Delete). The default is Mixed. Can specify DeprecateOnly or Delete only for unlocked package upgrades.
        /// </summary>
        [SwitchName("--upgradetype")]
        public string upgradetype { get; set; }
    }

    /// <summary>
    /// Options for the method installReport of class Package.
    /// </summary>
    public class PackageInstallReportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID of the package install request you want to check.
        /// </summary>
        [SwitchName("--requestid")]
        public string requestid { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method installedList of class Package.
    /// </summary>
    public class PackageInstalledListOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method list of class Package.
    /// </summary>
    public class PackageListOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Displays extended package details.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method uninstall of class Package.
    /// </summary>
    public class PackageUninstallOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Maximum number of minutes to wait for uninstall status. The default is 0.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 04t) or alias of the package version to uninstall.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }
    }

    /// <summary>
    /// Options for the method uninstallReport of class Package.
    /// </summary>
    public class PackageUninstallReportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID of the package uninstall request you want to check.
        /// </summary>
        [SwitchName("--requestid")]
        public string requestid { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method update of class Package.
    /// </summary>
    public class PackageUpdateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 0Ho) or alias of the package to update.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] New name of the package.
        /// </summary>
        [SwitchName("--name")]
        public string name { get; set; }

        /// <summary>
        /// [Required] New description of the package.
        /// </summary>
        [SwitchName("--description")]
        public string description { get; set; }

        /// <summary>
        /// [Required] An active Dev Hub org user designated to receive email notifications for unhandled Apex exceptions, and install, upgrade, or uninstall failures associated with your package.
        /// </summary>
        [SwitchName("--errornotificationusername")]
        public string errornotificationusername { get; set; }
    }

    /// <summary>
    /// Options for the method versionCreate of class Package.
    /// </summary>
    public class PackageVersionCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 0Ho) or alias of the package to create a version of.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Required] The path to the directory that contains the contents of the package.
        /// </summary>
        [SwitchName("--path")]
        public string path { get; set; }

        /// <summary>
        /// [Required] The path to a definition file similar to scratch org definition file that contains the list of features and org preferences that the metadata of the package version depends on.
        /// </summary>
        [SwitchName("--definitionfile")]
        public string definitionfile { get; set; }

        /// <summary>
        /// [Required] Name of the branch in your source control system that the package version is based on.
        /// </summary>
        [SwitchName("--branch")]
        public string branch { get; set; }

        /// <summary>
        /// [Required] The package version’s tag.
        /// </summary>
        [SwitchName("--tag")]
        public string tag { get; set; }

        /// <summary>
        /// [Required] Installation key for creating the key-protected package. Either an --installationkey value or the --installationkeybypass flag is required.
        /// </summary>
        [SwitchName("--installationkey")]
        public string installationkey { get; set; }

        /// <summary>
        /// [Optional] Bypasses the installation key requirement. If you bypass this requirement, anyone can install your package. Either an --installationkey value or the --installationkeybypass flag is required.
        /// </summary>
        [SwitchName("--installationkeybypass")]
        public bool? installationkeybypass { get; set; }

        /// <summary>
        /// [Optional] Specifies that the temp files are preserved that would otherwise be deleted
        /// </summary>
        [SwitchName("--preserve")]
        public bool? preserve { get; set; }

        /// <summary>
        /// [Optional] Specifies that the sfdx-project.json file should be validated against JSON schema.
        /// </summary>
        [SwitchName("--validateschema")]
        public bool? validateschema { get; set; }

        /// <summary>
        /// [Optional] The number of minutes to wait for the package version to be created.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Required] The instance where the package version will be created——for example, NA50.
        /// </summary>
        [SwitchName("--buildinstance")]
        public string buildinstance { get; set; }

        /// <summary>
        /// [Required] The source org ID used to copy the org shape for the build org.
        /// </summary>
        [SwitchName("--sourceorg")]
        public string sourceorg { get; set; }

        /// <summary>
        /// [Required] The name of the package version to be created. Overrides the sfdx-project.json value.
        /// </summary>
        [SwitchName("--versionname")]
        public string versionname { get; set; }

        /// <summary>
        /// [Required] The version number of the package version to be created. Overrides the sfdx-project.json value.
        /// </summary>
        [SwitchName("--versionnumber")]
        public string versionnumber { get; set; }

        /// <summary>
        /// [Required] The description of the package version to be created. Overrides the sfdx-project.json value.
        /// </summary>
        [SwitchName("--versiondescription")]
        public string versiondescription { get; set; }

        /// <summary>
        /// [Optional] Calculate and store the code coverage percentage by running the Apex tests included in this package version. Before you can promote and release a managed or unlocked package version, the Apex code must meet a minimum 75% code coverage requirement. We don’t calculate code coverage for org-dependent unlocked packages or for package versions that specify --skipvalidation.
        /// </summary>
        [SwitchName("--codecoverage")]
        public bool? codecoverage { get; set; }

        /// <summary>
        /// [Required] The release notes URL. This link is displayed in the package installation UI to provide release notes for this package version to subscribers.
        /// </summary>
        [SwitchName("--releasenotesurl")]
        public string releasenotesurl { get; set; }

        /// <summary>
        /// [Required] The post-install instructions URL. The contents of the post-installation instructions URL are displayed in the UI after installation of the package version.
        /// </summary>
        [SwitchName("--postinstallurl")]
        public string postinstallurl { get; set; }

        /// <summary>
        /// [Required] Applies to managed packages only. The post-install script name. The post-install script is an Apex class within this package that is run in the installing org after installations or upgrades of this package version.
        /// </summary>
        [SwitchName("--postinstallscript")]
        public string postinstallscript { get; set; }

        /// <summary>
        /// [Required] Applies to managed packages only. The uninstall script name. The uninstall script is an Apex class within this package that is run in the installing org after uninstallations of this package.
        /// </summary>
        [SwitchName("--uninstallscript")]
        public string uninstallscript { get; set; }

        /// <summary>
        /// [Optional] Skips validation of dependencies, package ancestors, and metadata during package version creation. Skipping validation reduces the time it takes to create a new package version, but you can promote only validated package versions. Skipping validation can suppress important errors that can surface at a later stage. You can specify skip validation or code coverage, but not both. Code coverage is calculated during validation.
        /// </summary>
        [SwitchName("--skipvalidation")]
        public bool? skipvalidation { get; set; }
    }

    /// <summary>
    /// Options for the method versionCreateList of class Package.
    /// </summary>
    public class PackageVersionCreateListOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Filters the list based on the specified maximum number of days since the request was created (starting at 00:00:00 of first day to now; 0 for today).
        /// </summary>
        [SwitchName("--createdlastdays")]
        public int? createdlastdays { get; set; }

        /// <summary>
        /// [Required] Filters the list based on the status of version creation requests.
        /// </summary>
        [SwitchName("--status")]
        public string status { get; set; }
    }

    /// <summary>
    /// Options for the method versionCreateReport of class Package.
    /// </summary>
    public class PackageVersionCreateReportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 08c) of the package version creation request you want to display.
        /// </summary>
        [SwitchName("--packagecreaterequestid")]
        public string packagecreaterequestid { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method versionDelete of class Package.
    /// </summary>
    public class PackageVersionDeleteOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 04t) or alias of the package version to delete.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Don’t prompt before deleting the package version
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }

        /// <summary>
        /// [Optional] Undelete a deleted package version.
        /// </summary>
        [SwitchName("--undelete")]
        public bool? undelete { get; set; }
    }

    /// <summary>
    /// Options for the method versionDisplayancestry of class Package.
    /// </summary>
    public class PackageVersionDisplayancestryOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID or alias of the package or package version to display ancestry for. If you specify a package ID (starts with 0Ho) or alias, the ancestor tree for every package version associated with the package ID is displayed.
        /// If you specify a package version (starts with 04t) or alias, the ancestry tree of the specified package version is displayed.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Displays the ancestry tree in DOT code. You can use the DOT code output in graph visualization software to create tree visualizations.
        /// </summary>
        [SwitchName("--dotcode")]
        public bool? dotcode { get; set; }

        /// <summary>
        /// [Optional] Displays both the package version ID (starts with 04t) and the version number (major.minor.patch.build) in the ancestry tree.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method versionList of class Package.
    /// </summary>
    public class PackageVersionListOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Filters the list based on the specified maximum number of days since the request was created (starting at 00:00:00 of first day to now; 0 for today).
        /// </summary>
        [SwitchName("--createdlastdays")]
        public int? createdlastdays { get; set; }

        /// <summary>
        /// [Optional] Displays limited package version details.
        /// </summary>
        [SwitchName("--concise")]
        public bool? concise { get; set; }

        /// <summary>
        /// [Optional] Lists the items modified in the specified last number of days, starting at 00:00:00 of first day to now. Use 0 for today.
        /// </summary>
        [SwitchName("--modifiedlastdays")]
        public int? modifiedlastdays { get; set; }

        /// <summary>
        /// [Required] Filters results on the specified comma-delimited packages (aliases or 0Ho IDs).
        /// </summary>
        [SwitchName("--packages")]
        public string packages { get; set; }

        /// <summary>
        /// [Optional] Displays released versions only (IsReleased=true).
        /// </summary>
        [SwitchName("--released")]
        public bool? released { get; set; }

        /// <summary>
        /// [Required] Orders the list by the specified package version fields.
        /// </summary>
        [SwitchName("--orderby")]
        public string orderby { get; set; }

        /// <summary>
        /// [Optional] Displays extended package version details.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method versionPromote of class Package.
    /// </summary>
    public class PackageVersionPromoteOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 04t) or alias of the package version to promote.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Do not prompt to confirm setting the package version as released.
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Options for the method versionReport of class Package.
    /// </summary>
    public class PackageVersionReportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 04t) or alias of the package to retrieve details for.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Displays extended package version details.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method versionUpdate of class Package.
    /// </summary>
    public class PackageVersionUpdateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 04t) or alias of the package to update a version of.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] The new package version name.
        /// </summary>
        [SwitchName("--versionname")]
        public string versionname { get; set; }

        /// <summary>
        /// [Required] The new package version description.
        /// </summary>
        [SwitchName("--versiondescription")]
        public string versiondescription { get; set; }

        /// <summary>
        /// [Required] The new package version branch.
        /// </summary>
        [SwitchName("--branch")]
        public string branch { get; set; }

        /// <summary>
        /// [Required] The new package version tag.
        /// </summary>
        [SwitchName("--tag")]
        public string tag { get; set; }

        /// <summary>
        /// [Required] The new installation key for the key-protected package. The default is null.
        /// </summary>
        [SwitchName("--installationkey")]
        public string installationkey { get; set; }
    }

    /// <summary>
    /// Package
    /// </summary>
    [CommandClass("force:package")]
    public class Package : SFDXCommand
    {
        /// Constructor.
        public Package(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// create a package
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// First, use this command to create a package. Then create a package version.
        /// 
        /// If you don’t have a namespace defined in your sfdx-project.json file, use --nonamespace.
        /// 
        /// Your --name value must be unique within your namespace.
        /// 
        /// Examples:
        ///    $ sfdx force:package:create -n YourPackageName -t Unlocked -r force-app
        ///    $ sfdx force:package:create -n YourPackageName -d "Your Package Descripton" -t Unlocked -r force-app
        /// 
        /// Run 'sfdx force:package:list' to list all packages in the Dev Hub org.
        /// </summary>
        /// <remarks>
        /// create a package
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// First, use this command to create a package. Then create a package version.
        /// 
        /// If you don’t have a namespace defined in your sfdx-project.json file, use --nonamespace.
        /// 
        /// Your --name value must be unique within your namespace.
        /// 
        /// Examples:
        ///    $ sfdx force:package:create -n YourPackageName -t Unlocked -r force-app
        ///    $ sfdx force:package:create -n YourPackageName -d "Your Package Descripton" -t Unlocked -r force-app
        /// 
        /// Run 'sfdx force:package:list' to list all packages in the Dev Hub org.
        /// </remarks>
        /// <example>
        /// First, use this command to create a package. Then create a package version.
        /// 
        /// If you don’t have a namespace defined in your sfdx-project.json file, use --nonamespace.
        /// 
        /// Your --name value must be unique within your namespace.
        /// 
        /// Examples:
        ///    $ sfdx force:package:create -n YourPackageName -t Unlocked -r force-app
        ///    $ sfdx force:package:create -n YourPackageName -d "Your Package Descripton" -t Unlocked -r force-app
        /// 
        /// Run 'sfdx force:package:list' to list all packages in the Dev Hub org.
        /// force:package:create -n <string> -t Managed|Unlocked -r <directory> [-d <string>] [-e] [--orgdependent] [-o <string>] [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("create")]
        public SFDXResponse Create(PackageCreateOptions p_Options)
        {
            return ExecuteCommand<PackageCreateOptions>(nameof(Create), p_Options);
        }

        /// <summary>
        /// delete a package
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Specify the ID or alias of the package you want to delete.
        /// 
        /// Examples:
        ///    $ sfdx force:package:delete -p "Your Package Alias"
        ///    $ sfdx force:package:delete -p 0Ho...
        /// </summary>
        /// <remarks>
        /// delete a package
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Specify the ID or alias of the package you want to delete.
        /// 
        /// Examples:
        ///    $ sfdx force:package:delete -p "Your Package Alias"
        ///    $ sfdx force:package:delete -p 0Ho...
        /// </remarks>
        /// <example>
        /// Specify the ID or alias of the package you want to delete.
        /// 
        /// Examples:
        ///    $ sfdx force:package:delete -p "Your Package Alias"
        ///    $ sfdx force:package:delete -p 0Ho...
        /// force:package:delete -p <string> [-n] [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("delete")]
        public SFDXResponse Delete(PackageDeleteOptions p_Options)
        {
            return ExecuteCommand<PackageDeleteOptions>(nameof(Delete), p_Options);
        }

        /// <summary>
        /// install a package in the target org
        /// 
        /// Supply the ID of the package version to install. The package installs in your default target org unless you supply the username for a different target org.
        /// 
        /// For package upgrades, to specify options for component deprecation or deletion of removed components, include an --upgradetype value. To delete components that can be safely deleted and deprecate the others, specify --upgradetype Mixed (the default). To deprecate all removed components, specify --upgradetype DeprecateOnly. To delete all removed components, except for custom objects and custom fields, that don't have dependencies, specify --upgradetype Delete. (Note: This option can result in the loss of data that is associated with the deleted components.) The default is Mixed.
        /// 
        /// Examples:
        ///    $ sfdx force:package:install --package 04t... -u me@example.com
        ///    $ sfdx force:package:install --package awesome_package_alias
        ///    $ sfdx force:package:install --package "Awesome Package Alias"
        ///    $ sfdx force:package:install --package 04t... -t DeprecateOnly
        /// </summary>
        /// <remarks>
        /// install a package in the target org
        /// 
        /// Supply the ID of the package version to install. The package installs in your default target org unless you supply the username for a different target org.
        /// 
        /// For package upgrades, to specify options for component deprecation or deletion of removed components, include an --upgradetype value. To delete components that can be safely deleted and deprecate the others, specify --upgradetype Mixed (the default). To deprecate all removed components, specify --upgradetype DeprecateOnly. To delete all removed components, except for custom objects and custom fields, that don't have dependencies, specify --upgradetype Delete. (Note: This option can result in the loss of data that is associated with the deleted components.) The default is Mixed.
        /// 
        /// Examples:
        ///    $ sfdx force:package:install --package 04t... -u me@example.com
        ///    $ sfdx force:package:install --package awesome_package_alias
        ///    $ sfdx force:package:install --package "Awesome Package Alias"
        ///    $ sfdx force:package:install --package 04t... -t DeprecateOnly
        /// </remarks>
        /// <example>
        /// Supply the ID of the package version to install. The package installs in your default target org unless you supply the username for a different target org.
        /// 
        /// For package upgrades, to specify options for component deprecation or deletion of removed components, include an --upgradetype value. To delete components that can be safely deleted and deprecate the others, specify --upgradetype Mixed (the default). To deprecate all removed components, specify --upgradetype DeprecateOnly. To delete all removed components, except for custom objects and custom fields, that don't have dependencies, specify --upgradetype Delete. (Note: This option can result in the loss of data that is associated with the deleted components.) The default is Mixed.
        /// 
        /// Examples:
        ///    $ sfdx force:package:install --package 04t... -u me@example.com
        ///    $ sfdx force:package:install --package awesome_package_alias
        ///    $ sfdx force:package:install --package "Awesome Package Alias"
        ///    $ sfdx force:package:install --package 04t... -t DeprecateOnly
        /// force:package:install [-w <minutes>] [-k <string>] [-b <minutes>] [-r] [-p <string>] [-a all|package] [-s AllUsers|AdminsOnly] [-t DeprecateOnly|Mixed|Delete] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("install")]
        public SFDXResponse Install(PackageInstallOptions p_Options)
        {
            return ExecuteCommand<PackageInstallOptions>(nameof(Install), p_Options);
        }

        /// <summary>
        /// retrieve the status of a package installation request
        /// 
        /// Examples:
        ///    $ sfdx force:package:install:report -i 0Hf...
        ///    $ sfdx force:package:install:report -i 0Hf... -u me@example.com
        /// </summary>
        /// <remarks>
        /// retrieve the status of a package installation request
        /// 
        /// Examples:
        ///    $ sfdx force:package:install:report -i 0Hf...
        ///    $ sfdx force:package:install:report -i 0Hf... -u me@example.com
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:package:install:report -i 0Hf...
        ///    $ sfdx force:package:install:report -i 0Hf... -u me@example.com
        /// force:package:install:report -i <id> [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("install:report")]
        public SFDXResponse InstallReport(PackageInstallReportOptions p_Options)
        {
            return ExecuteCommand<PackageInstallReportOptions>(nameof(InstallReport), p_Options);
        }

        /// <summary>
        /// list the org’s installed packages
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Examples:
        ///    $ sfdx force:package:installed:list
        ///    $ sfdx force:package:installed:list -u me@example.com
        /// </summary>
        /// <remarks>
        /// list the org’s installed packages
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Examples:
        ///    $ sfdx force:package:installed:list
        ///    $ sfdx force:package:installed:list -u me@example.com
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:package:installed:list
        ///    $ sfdx force:package:installed:list -u me@example.com
        /// force:package:installed:list [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("installed:list")]
        public SFDXResponse InstalledList(PackageInstalledListOptions p_Options)
        {
            return ExecuteCommand<PackageInstalledListOptions>(nameof(InstalledList), p_Options);
        }

        /// <summary>
        /// list all packages in the Dev Hub org
        /// 
        /// You can view the namespace, IDs, and other details for each package.
        /// 
        /// Examples:
        ///    $ sfdx force:package:list -v devhub@example.com
        ///    $ sfdx force:package:list -v devhub@example.com --verbose
        /// </summary>
        /// <remarks>
        /// list all packages in the Dev Hub org
        /// 
        /// You can view the namespace, IDs, and other details for each package.
        /// 
        /// Examples:
        ///    $ sfdx force:package:list -v devhub@example.com
        ///    $ sfdx force:package:list -v devhub@example.com --verbose
        /// </remarks>
        /// <example>
        /// You can view the namespace, IDs, and other details for each package.
        /// 
        /// Examples:
        ///    $ sfdx force:package:list -v devhub@example.com
        ///    $ sfdx force:package:list -v devhub@example.com --verbose
        /// force:package:list [-v <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("list")]
        public SFDXResponse List(PackageListOptions p_Options)
        {
            return ExecuteCommand<PackageListOptions>(nameof(List), p_Options);
        }

        /// <summary>
        /// uninstall a second-generation package from the target org
        /// 
        /// Specify the package ID for a second-generation package.
        /// 
        /// Examples:
        ///    $ sfdx force:package:uninstall -p 04t... -u me@example.com
        ///    $ sfdx force:package:uninstall -p undesirable_package_alias
        ///    $ sfdx force:package:uninstall -p "Undesirable Package Alias"
        /// 
        /// To list the org’s installed packages, run "sfdx force:package:installed:list".
        /// 
        /// To uninstall a first-generation package, from Setup, enter Installed Packages in the Quick Find box, then select Installed Packages.
        /// </summary>
        /// <remarks>
        /// uninstall a second-generation package from the target org
        /// 
        /// Specify the package ID for a second-generation package.
        /// 
        /// Examples:
        ///    $ sfdx force:package:uninstall -p 04t... -u me@example.com
        ///    $ sfdx force:package:uninstall -p undesirable_package_alias
        ///    $ sfdx force:package:uninstall -p "Undesirable Package Alias"
        /// 
        /// To list the org’s installed packages, run "sfdx force:package:installed:list".
        /// 
        /// To uninstall a first-generation package, from Setup, enter Installed Packages in the Quick Find box, then select Installed Packages.
        /// </remarks>
        /// <example>
        /// Specify the package ID for a second-generation package.
        /// 
        /// Examples:
        ///    $ sfdx force:package:uninstall -p 04t... -u me@example.com
        ///    $ sfdx force:package:uninstall -p undesirable_package_alias
        ///    $ sfdx force:package:uninstall -p "Undesirable Package Alias"
        /// 
        /// To list the org’s installed packages, run "sfdx force:package:installed:list".
        /// 
        /// To uninstall a first-generation package, from Setup, enter Installed Packages in the Quick Find box, then select Installed Packages.
        /// force:package:uninstall [-w <minutes>] [-p <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("uninstall")]
        public SFDXResponse Uninstall(PackageUninstallOptions p_Options)
        {
            return ExecuteCommand<PackageUninstallOptions>(nameof(Uninstall), p_Options);
        }

        /// <summary>
        /// retrieve status of package uninstall request
        /// 
        /// Examples:
        ///    $ sfdx force:package:uninstall:report -i 06y...
        ///    $ sfdx force:package:uninstall:report -i 06y... -u me@example.com
        /// </summary>
        /// <remarks>
        /// retrieve status of package uninstall request
        /// 
        /// Examples:
        ///    $ sfdx force:package:uninstall:report -i 06y...
        ///    $ sfdx force:package:uninstall:report -i 06y... -u me@example.com
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:package:uninstall:report -i 06y...
        ///    $ sfdx force:package:uninstall:report -i 06y... -u me@example.com
        /// force:package:uninstall:report -i <id> [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("uninstall:report")]
        public SFDXResponse UninstallReport(PackageUninstallReportOptions p_Options)
        {
            return ExecuteCommand<PackageUninstallReportOptions>(nameof(UninstallReport), p_Options);
        }

        /// <summary>
        /// update package details
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Specify a new value for each option you want to update.
        /// 
        /// Examples:
        ///    $ sfdx force:package:update -p "Your Package Alias" -n "New Package Name"
        ///    $ sfdx force:package:update -p 0Ho... -d "New Package Description"
        /// 
        /// Run "sfdx force:package:list" to list all packages in the Dev Hub org.
        /// </summary>
        /// <remarks>
        /// update package details
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Specify a new value for each option you want to update.
        /// 
        /// Examples:
        ///    $ sfdx force:package:update -p "Your Package Alias" -n "New Package Name"
        ///    $ sfdx force:package:update -p 0Ho... -d "New Package Description"
        /// 
        /// Run "sfdx force:package:list" to list all packages in the Dev Hub org.
        /// </remarks>
        /// <example>
        /// Specify a new value for each option you want to update.
        /// 
        /// Examples:
        ///    $ sfdx force:package:update -p "Your Package Alias" -n "New Package Name"
        ///    $ sfdx force:package:update -p 0Ho... -d "New Package Description"
        /// 
        /// Run "sfdx force:package:list" to list all packages in the Dev Hub org.
        /// force:package:update -p <string> [-n <string>] [-d <string>] [-o <string>] [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("update")]
        public SFDXResponse Update(PackageUpdateOptions p_Options)
        {
            return ExecuteCommand<PackageUpdateOptions>(nameof(Update), p_Options);
        }

        /// <summary>
        /// create a package version
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// The package version is based on the package contents in the specified directory.
        /// 
        /// To retrieve details about a package version create request, including status and package version ID (04t), run "sfdx force:package:version:create:report -i 08c...".
        /// 
        /// We recommend that you specify the --installationkey parameter to protect the contents of your package and to prevent unauthorized installation of your package.
        /// 
        /// To list package version creation requests in the org, run "sfdx force:package:version:create:list".
        /// 
        /// To promote a package version to released, you must use the --codecoverage parameter. The package must also meet the code coverage requirements. This requirement applies to both managed and unlocked packages.
        /// 
        /// We don’t calculate code coverage for org-dependent unlocked packages, or for package versions that specify --skipvalidation.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create -d common -k password123
        ///    $ sfdx force:package:version:create -p "Your Package Alias" -k password123
        ///    $ sfdx force:package:version:create -p 0Ho... -k password123
        ///    $ sfdx force:package:version:create -d common -k password123 --skipvalidation
        /// </summary>
        /// <remarks>
        /// create a package version
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// The package version is based on the package contents in the specified directory.
        /// 
        /// To retrieve details about a package version create request, including status and package version ID (04t), run "sfdx force:package:version:create:report -i 08c...".
        /// 
        /// We recommend that you specify the --installationkey parameter to protect the contents of your package and to prevent unauthorized installation of your package.
        /// 
        /// To list package version creation requests in the org, run "sfdx force:package:version:create:list".
        /// 
        /// To promote a package version to released, you must use the --codecoverage parameter. The package must also meet the code coverage requirements. This requirement applies to both managed and unlocked packages.
        /// 
        /// We don’t calculate code coverage for org-dependent unlocked packages, or for package versions that specify --skipvalidation.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create -d common -k password123
        ///    $ sfdx force:package:version:create -p "Your Package Alias" -k password123
        ///    $ sfdx force:package:version:create -p 0Ho... -k password123
        ///    $ sfdx force:package:version:create -d common -k password123 --skipvalidation
        /// </remarks>
        /// <example>
        /// The package version is based on the package contents in the specified directory.
        /// 
        /// To retrieve details about a package version create request, including status and package version ID (04t), run "sfdx force:package:version:create:report -i 08c...".
        /// 
        /// We recommend that you specify the --installationkey parameter to protect the contents of your package and to prevent unauthorized installation of your package.
        /// 
        /// To list package version creation requests in the org, run "sfdx force:package:version:create:list".
        /// 
        /// To promote a package version to released, you must use the --codecoverage parameter. The package must also meet the code coverage requirements. This requirement applies to both managed and unlocked packages.
        /// 
        /// We don’t calculate code coverage for org-dependent unlocked packages, or for package versions that specify --skipvalidation.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create -d common -k password123
        ///    $ sfdx force:package:version:create -p "Your Package Alias" -k password123
        ///    $ sfdx force:package:version:create -p 0Ho... -k password123
        ///    $ sfdx force:package:version:create -d common -k password123 --skipvalidation
        /// force:package:version:create [-p <string>] [-d <directory>] [-f <filepath>] [-b <string>] [-t <string>] [-k <string>] [-x] [-w <minutes>] [-a <string>] [-n <string>] [-e <string>] [-c] [--releasenotesurl <url>] [--postinstallurl <url>] [--postinstallscript <string>] [--uninstallscript <string>] [--skipvalidation] [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:create")]
        public SFDXResponse VersionCreate(PackageVersionCreateOptions p_Options)
        {
            return ExecuteCommand<PackageVersionCreateOptions>(nameof(VersionCreate), p_Options);
        }

        /// <summary>
        /// list package version creation requests
        /// 
        /// Shows the details of each request to create a package version in the Dev Hub org.
        /// 
        /// All filter parameters are applied using the AND logical operator (not OR).
        /// 
        /// To get information about a specific request, run "sfdx force:package:version:create:report" and supply the request ID.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create:list
        ///    $ sfdx force:package:version:create:list --createdlastdays 3
        ///    $ sfdx force:package:version:create:list --status Error
        ///    $ sfdx force:package:version:create:list -s InProgress
        ///    $ sfdx force:package:version:create:list -c 3 -s Success
        /// </summary>
        /// <remarks>
        /// list package version creation requests
        /// 
        /// Shows the details of each request to create a package version in the Dev Hub org.
        /// 
        /// All filter parameters are applied using the AND logical operator (not OR).
        /// 
        /// To get information about a specific request, run "sfdx force:package:version:create:report" and supply the request ID.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create:list
        ///    $ sfdx force:package:version:create:list --createdlastdays 3
        ///    $ sfdx force:package:version:create:list --status Error
        ///    $ sfdx force:package:version:create:list -s InProgress
        ///    $ sfdx force:package:version:create:list -c 3 -s Success
        /// </remarks>
        /// <example>
        /// Shows the details of each request to create a package version in the Dev Hub org.
        /// 
        /// All filter parameters are applied using the AND logical operator (not OR).
        /// 
        /// To get information about a specific request, run "sfdx force:package:version:create:report" and supply the request ID.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create:list
        ///    $ sfdx force:package:version:create:list --createdlastdays 3
        ///    $ sfdx force:package:version:create:list --status Error
        ///    $ sfdx force:package:version:create:list -s InProgress
        ///    $ sfdx force:package:version:create:list -c 3 -s Success
        /// force:package:version:create:list [-c <number>] [-s Queued|InProgress|Success|Error] [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:create:list")]
        public SFDXResponse VersionCreateList(PackageVersionCreateListOptions p_Options)
        {
            return ExecuteCommand<PackageVersionCreateListOptions>(nameof(VersionCreateList), p_Options);
        }

        /// <summary>
        /// retrieve details about a package version creation request
        /// 
        /// Specify the request ID for which you want to view details. If applicable, the command displays errors related to the request.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create:report -i 08c...
        ///    $ sfdx force:package:version:create:report -i 08c... -v devhub@example.com
        /// 
        /// To show all requests in the org, run "sfdx force:package:version:create:list".
        /// </summary>
        /// <remarks>
        /// retrieve details about a package version creation request
        /// 
        /// Specify the request ID for which you want to view details. If applicable, the command displays errors related to the request.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create:report -i 08c...
        ///    $ sfdx force:package:version:create:report -i 08c... -v devhub@example.com
        /// 
        /// To show all requests in the org, run "sfdx force:package:version:create:list".
        /// </remarks>
        /// <example>
        /// Specify the request ID for which you want to view details. If applicable, the command displays errors related to the request.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create:report -i 08c...
        ///    $ sfdx force:package:version:create:report -i 08c... -v devhub@example.com
        /// 
        /// To show all requests in the org, run "sfdx force:package:version:create:list".
        /// force:package:version:create:report -i <id> [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:create:report")]
        public SFDXResponse VersionCreateReport(PackageVersionCreateReportOptions p_Options)
        {
            return ExecuteCommand<PackageVersionCreateReportOptions>(nameof(VersionCreateReport), p_Options);
        }

        /// <summary>
        /// delete a package version
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Specify the ID or alias of the package version you want to delete.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:delete -p "Your Package Alias"
        ///    $ sfdx force:package:version:delete -p 04t...
        /// </summary>
        /// <remarks>
        /// delete a package version
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Specify the ID or alias of the package version you want to delete.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:delete -p "Your Package Alias"
        ///    $ sfdx force:package:version:delete -p 04t...
        /// </remarks>
        /// <example>
        /// Specify the ID or alias of the package version you want to delete.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:delete -p "Your Package Alias"
        ///    $ sfdx force:package:version:delete -p 04t...
        /// force:package:version:delete -p <string> [-n] [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:delete")]
        public SFDXResponse VersionDelete(PackageVersionDeleteOptions p_Options)
        {
            return ExecuteCommand<PackageVersionDeleteOptions>(nameof(VersionDelete), p_Options);
        }

        /// <summary>
        /// display the ancestry tree for a 2GP managed package version
        /// </summary>
        /// <remarks>
        /// display the ancestry tree for a 2GP managed package version
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:package:version:displayancestry -p package_version_alias
        ///    $ sfdx force:package:version:displayancestry -p package_version_alias --dotcode
        ///    $ sfdx force:package:version:displayancestry -p OHo...
        ///    $ sfdx force:package:version:displayancestry -p 04t...
        /// force:package:version:displayancestry -p <string> [--dotcode] [-v <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:displayancestry")]
        public SFDXResponse VersionDisplayancestry(PackageVersionDisplayancestryOptions p_Options)
        {
            return ExecuteCommand<PackageVersionDisplayancestryOptions>(nameof(VersionDisplayancestry), p_Options);
        }

        /// <summary>
        /// list all package versions in the Dev Hub org
        /// 
        /// Displays details of each package version in the org.
        /// 
        /// Use --concise or --verbose to display limited or additional details, respectively.
        /// 
        /// All filter parameters are applied using the AND logical operator (not OR).
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:list --verbose --createdlastdays 3 --released --orderby PatchVersion
        ///    $ sfdx force:package:version:list --packages 0Ho000000000000,0Ho000000000001 --released --modifiedlastdays 0
        ///    $ sfdx force:package:version:list --released
        ///    $ sfdx force:package:version:list --concise --modifiedlastdays 0
        ///    $ sfdx force:package:version:list --concise -c 3 -r
        ///    $ sfdx force:package:version:list --packages exp-mgr,exp-mgr-util --released --modifiedlastdays 0
        /// </summary>
        /// <remarks>
        /// list all package versions in the Dev Hub org
        /// 
        /// Displays details of each package version in the org.
        /// 
        /// Use --concise or --verbose to display limited or additional details, respectively.
        /// 
        /// All filter parameters are applied using the AND logical operator (not OR).
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:list --verbose --createdlastdays 3 --released --orderby PatchVersion
        ///    $ sfdx force:package:version:list --packages 0Ho000000000000,0Ho000000000001 --released --modifiedlastdays 0
        ///    $ sfdx force:package:version:list --released
        ///    $ sfdx force:package:version:list --concise --modifiedlastdays 0
        ///    $ sfdx force:package:version:list --concise -c 3 -r
        ///    $ sfdx force:package:version:list --packages exp-mgr,exp-mgr-util --released --modifiedlastdays 0
        /// </remarks>
        /// <example>
        /// Displays details of each package version in the org.
        /// 
        /// Use --concise or --verbose to display limited or additional details, respectively.
        /// 
        /// All filter parameters are applied using the AND logical operator (not OR).
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:list --verbose --createdlastdays 3 --released --orderby PatchVersion
        ///    $ sfdx force:package:version:list --packages 0Ho000000000000,0Ho000000000001 --released --modifiedlastdays 0
        ///    $ sfdx force:package:version:list --released
        ///    $ sfdx force:package:version:list --concise --modifiedlastdays 0
        ///    $ sfdx force:package:version:list --concise -c 3 -r
        ///    $ sfdx force:package:version:list --packages exp-mgr,exp-mgr-util --released --modifiedlastdays 0
        /// force:package:version:list [-c <number>] [-m <number>] [-p <array>] [-r] [-o <array>] [-v <string>] [--apiversion <string>] [--concise] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:list")]
        public SFDXResponse VersionList(PackageVersionListOptions p_Options)
        {
            return ExecuteCommand<PackageVersionListOptions>(nameof(VersionList), p_Options);
        }

        /// <summary>
        /// promote a package version to released
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Supply the ID or alias of the package version you want to promote. Promotes the package version to released status.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:promote -p 04t...
        ///    $ sfdx force:package:version:promote -p awesome_package_alias
        ///    $ sfdx force:package:version:promote -p "Awesome Package Alias"
        /// </summary>
        /// <remarks>
        /// promote a package version to released
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Supply the ID or alias of the package version you want to promote. Promotes the package version to released status.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:promote -p 04t...
        ///    $ sfdx force:package:version:promote -p awesome_package_alias
        ///    $ sfdx force:package:version:promote -p "Awesome Package Alias"
        /// </remarks>
        /// <example>
        /// Supply the ID or alias of the package version you want to promote. Promotes the package version to released status.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:promote -p 04t...
        ///    $ sfdx force:package:version:promote -p awesome_package_alias
        ///    $ sfdx force:package:version:promote -p "Awesome Package Alias"
        /// force:package:version:promote -p <string> [-n] [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:promote")]
        public SFDXResponse VersionPromote(PackageVersionPromoteOptions p_Options)
        {
            return ExecuteCommand<PackageVersionPromoteOptions>(nameof(VersionPromote), p_Options);
        }

        /// <summary>
        /// retrieve details about a package version in the Dev Hub org
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:report -p 04t...
        ///    $ sfdx force:package:version:report -p "Your Package Alias"
        /// 
        /// To update package version values, run "sfdx force:package:version:update".
        /// </summary>
        /// <remarks>
        /// retrieve details about a package version in the Dev Hub org
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:report -p 04t...
        ///    $ sfdx force:package:version:report -p "Your Package Alias"
        /// 
        /// To update package version values, run "sfdx force:package:version:update".
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:package:version:report -p 04t...
        ///    $ sfdx force:package:version:report -p "Your Package Alias"
        /// 
        /// To update package version values, run "sfdx force:package:version:update".
        /// force:package:version:report -p <string> [-v <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:report")]
        public SFDXResponse VersionReport(PackageVersionReportOptions p_Options)
        {
            return ExecuteCommand<PackageVersionReportOptions>(nameof(VersionReport), p_Options);
        }

        /// <summary>
        /// update a package version
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Specify a new value for each option you want to update.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:update -p "Your Package Alias" -k password123
        ///    $ sfdx force:package:version:update -p 04t... -b master -t 'Release 1.0.7'
        ///    $ sfdx force:package:version:update -p 04t... -e "New Package Version Description"
        /// 
        /// To display details about a package version, run "sfdx force:package:version:report".
        /// </summary>
        /// <remarks>
        /// update a package version
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Specify a new value for each option you want to update.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:update -p "Your Package Alias" -k password123
        ///    $ sfdx force:package:version:update -p 04t... -b master -t 'Release 1.0.7'
        ///    $ sfdx force:package:version:update -p 04t... -e "New Package Version Description"
        /// 
        /// To display details about a package version, run "sfdx force:package:version:report".
        /// </remarks>
        /// <example>
        /// Specify a new value for each option you want to update.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:update -p "Your Package Alias" -k password123
        ///    $ sfdx force:package:version:update -p 04t... -b master -t 'Release 1.0.7'
        ///    $ sfdx force:package:version:update -p 04t... -e "New Package Version Description"
        /// 
        /// To display details about a package version, run "sfdx force:package:version:report".
        /// force:package:version:update -p <string> [-a <string>] [-e <string>] [-b <string>] [-t <string>] [-k <string>] [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:update")]
        public SFDXResponse VersionUpdate(PackageVersionUpdateOptions p_Options)
        {
            return ExecuteCommand<PackageVersionUpdateOptions>(nameof(VersionUpdate), p_Options);
        }
    }
}

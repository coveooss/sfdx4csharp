// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Create of class Package.
    /// </summary>
    public class PackageCreateOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for path
        /// </summary>
        [SwitchName("--path")]
        public string Path { get; set; }

        /// <summary>
        /// [Required] The options for package type are Managed and Unlocked (Managed=DeveloperManagedSubscriberManaged, Unlocked=DeveloperControlledSubscriberEditable). These options determine upgrade and editability rules.
        /// </summary>
        [SwitchName("--package-type")]
        public string PackageType { get; set; }

        /// <summary>
        /// [Required] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for description
        /// </summary>
        [SwitchName("--description")]
        public string Description { get; set; }

        /// <summary>
        /// [Optional] This flag is useful when you’re migrating an existing org to packages. But use a namespaced package for new metadata.
        /// </summary>
        [SwitchName("--no-namespace")]
        public bool? NoNamespace { get; set; }

        /// <summary>
        /// [Optional] Use Source Tracking in Sandboxes to develop your org-dependent unlocked package. For more information, see "Create Org-Dependent Unlocked Packages" in the Salesforce DX Developer Guide.
        /// </summary>
        [SwitchName("--org-dependent")]
        public bool? OrgDependent { get; set; }

        /// <summary>
        /// [Required] Email notifications include information about unhandled Apex exceptions, and install, upgrade, or uninstall failures associated with your package.
        /// </summary>
        [SwitchName("--error-notification-username")]
        public string ErrorNotificationUsername { get; set; }
    }

    /// <summary>
    /// Options for the method Delete of class Package.
    /// </summary>
    public class PackageDeleteOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for package
        /// </summary>
        [SwitchName("--package")]
        public string Package { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Optional] No description for undelete
        /// </summary>
        [SwitchName("--undelete")]
        public bool? Undelete { get; set; }
    }

    /// <summary>
    /// Options for the method Install of class Package.
    /// </summary>
    public class PackageInstallOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for package
        /// </summary>
        [SwitchName("--package")]
        public string Package { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for wait
        /// </summary>
        [SwitchName("--wait")]
        public string Wait { get; set; }

        /// <summary>
        /// [Required] No description for installation-key
        /// </summary>
        [SwitchName("--installation-key")]
        public string InstallationKey { get; set; }

        /// <summary>
        /// [Required] No description for publish-wait
        /// </summary>
        [SwitchName("--publish-wait")]
        public string PublishWait { get; set; }

        /// <summary>
        /// [Optional] Allows the following without an explicit confirmation response: 1) Remote Site Settings and Content Security Policy websites to send or receive data, and 2) --upgrade-type Delete to proceed.
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Required] Applies to unlocked packages only. Specifies whether to compile all Apex in the org and package, or only the Apex in the package.
        /// 
        /// For package installs into production orgs, or any org that has Apex Compile on Deploy enabled, the platform compiles all Apex in the org after the package install or upgrade operation completes.
        /// 
        /// This approach assures that package installs and upgrades don’t impact the performance of an org, and is done even if --apex-compile package is specified.
        /// </summary>
        [SwitchName("--apex-compile")]
        public string ApexCompile { get; set; }

        /// <summary>
        /// [Required] No description for security-type
        /// </summary>
        [SwitchName("--security-type")]
        public string SecurityType { get; set; }

        /// <summary>
        /// [Required] For package upgrades, specifies whether to mark all removed components as deprecated (DeprecateOnly), to delete removed components that can be safely deleted and deprecate the others (Mixed), or to delete all removed components, except for custom objects and custom fields, that don't have dependencies (Delete). The default is Mixed. Can specify DeprecateOnly or Delete only for unlocked package upgrades.
        /// </summary>
        [SwitchName("--upgrade-type")]
        public string UpgradeType { get; set; }

        /// <summary>
        /// [Required] Allows the installer of a package to optionally skip install handlers in order to decrease overall installation time (available handlers: FeatureEnforcement).
        /// </summary>
        [SwitchName("--skip-handlers")]
        public string SkipHandlers { get; set; }
    }

    /// <summary>
    /// Options for the method InstallReport of class Package.
    /// </summary>
    public class PackageInstallReportOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for request-id
        /// </summary>
        [SwitchName("--request-id")]
        public string RequestId { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method InstalledList of class Package.
    /// </summary>
    public class PackageInstalledListOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }
    }

    /// <summary>
    /// Options for the method List of class Package.
    /// </summary>
    public class PackageListOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method Uninstall of class Package.
    /// </summary>
    public class PackageUninstallOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for package
        /// </summary>
        [SwitchName("--package")]
        public string Package { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for wait
        /// </summary>
        [SwitchName("--wait")]
        public string Wait { get; set; }
    }

    /// <summary>
    /// Options for the method UninstallReport of class Package.
    /// </summary>
    public class PackageUninstallReportOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for request-id
        /// </summary>
        [SwitchName("--request-id")]
        public string RequestId { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }
    }

    /// <summary>
    /// Options for the method Update of class Package.
    /// </summary>
    public class PackageUpdateOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for package
        /// </summary>
        [SwitchName("--package")]
        public string Package { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Required] No description for description
        /// </summary>
        [SwitchName("--description")]
        public string Description { get; set; }

        /// <summary>
        /// [Required] Email notifications include information about unhandled Apex exceptions, and install, upgrade, or uninstall failures associated with your package.
        /// </summary>
        [SwitchName("--error-notification-username")]
        public string ErrorNotificationUsername { get; set; }

        /// <summary>
        /// [Optional] No description for enable-app-analytics
        /// </summary>
        [SwitchName("--enable-app-analytics")]
        public bool? EnableAppAnalytics { get; set; }
    }

    /// <summary>
    /// Options for the method VersionCreate of class Package.
    /// </summary>
    public class PackageVersionCreateOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for branch
        /// </summary>
        [SwitchName("--branch")]
        public string Branch { get; set; }

        /// <summary>
        /// [Required] No description for build-instance
        /// </summary>
        [SwitchName("--build-instance")]
        public string BuildInstance { get; set; }

        /// <summary>
        /// [Optional] Before you can promote and release a managed or unlocked package version, the Apex code must meet a minimum 75% code coverage requirement. We don’t calculate code coverage for org-dependent unlocked packages or for package versions that specify --skip-validation.
        /// </summary>
        [SwitchName("--code-coverage")]
        public bool? CodeCoverage { get; set; }

        /// <summary>
        /// [Required] No description for definition-file
        /// </summary>
        [SwitchName("--definition-file")]
        public string DefinitionFile { get; set; }

        /// <summary>
        /// [Required] No description for installation-key
        /// </summary>
        [SwitchName("--installation-key")]
        public string InstallationKey { get; set; }

        /// <summary>
        /// [Optional] If you bypass this requirement, anyone can install your package.
        /// </summary>
        [SwitchName("--installation-key-bypass")]
        public bool? InstallationKeyBypass { get; set; }

        /// <summary>
        /// [Required] No description for package
        /// </summary>
        [SwitchName("--package")]
        public string Package { get; set; }

        /// <summary>
        /// [Required] No description for path
        /// </summary>
        [SwitchName("--path")]
        public string Path { get; set; }

        /// <summary>
        /// [Required] The post-install script is an Apex class within this package that is run in the installing org after installations or upgrades of this package version.
        /// </summary>
        [SwitchName("--post-install-script")]
        public string PostInstallScript { get; set; }

        /// <summary>
        /// [Required] The contents of the post-installation instructions URL are displayed in the UI after installation of the package version.
        /// </summary>
        [SwitchName("--post-install-url")]
        public string PostInstallUrl { get; set; }

        /// <summary>
        /// [Optional] No description for preserve
        /// </summary>
        [SwitchName("--preserve")]
        public bool? Preserve { get; set; }

        /// <summary>
        /// [Required] This link is displayed in the package installation UI to provide release notes for this package version to subscribers.
        /// </summary>
        [SwitchName("--releasenotes-url")]
        public string ReleasenotesUrl { get; set; }

        /// <summary>
        /// [Optional] No description for skip-ancestor-check
        /// </summary>
        [SwitchName("--skip-ancestor-check")]
        public bool? SkipAncestorCheck { get; set; }

        /// <summary>
        /// [Optional] Skips validation of dependencies, package ancestors, and metadata during package version creation. Skipping validation reduces the time it takes to create a new package version, but you can promote only validated package versions. Skipping validation can suppress important errors that can surface at a later stage. You can specify skip validation or code coverage, but not both. Code coverage is calculated during validation.
        /// </summary>
        [SwitchName("--skip-validation")]
        public bool? SkipValidation { get; set; }

        /// <summary>
        /// [Required] No description for tag
        /// </summary>
        [SwitchName("--tag")]
        public string Tag { get; set; }

        /// <summary>
        /// [Required] The uninstall script is an Apex class within this package that is run in the installing org after uninstallations of this package.
        /// </summary>
        [SwitchName("--uninstall-script")]
        public string UninstallScript { get; set; }

        /// <summary>
        /// [Optional] No description for validate-schema
        /// </summary>
        [SwitchName("--validate-schema")]
        public bool? ValidateSchema { get; set; }

        /// <summary>
        /// [Required] No description for version-description
        /// </summary>
        [SwitchName("--version-description")]
        public string VersionDescription { get; set; }

        /// <summary>
        /// [Required] No description for version-name
        /// </summary>
        [SwitchName("--version-name")]
        public string VersionName { get; set; }

        /// <summary>
        /// [Required] For information about the format of the version number, see https://developer.salesforce.com/docs/atlas.en-us.pkg2_dev.meta/pkg2_dev/sfdx_dev2gp_config_file.htm.
        /// </summary>
        [SwitchName("--version-number")]
        public string VersionNumber { get; set; }

        /// <summary>
        /// [Required] No description for wait
        /// </summary>
        [SwitchName("--wait")]
        public string Wait { get; set; }

        /// <summary>
        /// [Required] Specify the language using a language code listed under "Supported Languages" in Salesforce Help. If no language is specified, the language defaults to the language of the Dev Hub user who created the package.
        /// </summary>
        [SwitchName("--language")]
        public string Language { get; set; }

        /// <summary>
        /// [Optional] Display verbose command output. When polling for the status of the creation, this will output status and timeout data on a separate line for each poll request, which is useful in CI systems where timeouts can occur with long periods of no output from commands.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method VersionCreateList of class Package.
    /// </summary>
    public class PackageVersionCreateListOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for created-last-days
        /// </summary>
        [SwitchName("--created-last-days")]
        public string CreatedLastDays { get; set; }

        /// <summary>
        /// [Required] No description for status
        /// </summary>
        [SwitchName("--status")]
        public string Status { get; set; }

        /// <summary>
        /// [Optional] No description for show-conversions-only
        /// </summary>
        [SwitchName("--show-conversions-only")]
        public bool? ShowConversionsOnly { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method VersionCreateReport of class Package.
    /// </summary>
    public class PackageVersionCreateReportOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for package-create-request-id
        /// </summary>
        [SwitchName("--package-create-request-id")]
        public string PackageCreateRequestId { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }
    }

    /// <summary>
    /// Options for the method VersionDelete of class Package.
    /// </summary>
    public class PackageVersionDeleteOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for package
        /// </summary>
        [SwitchName("--package")]
        public string Package { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Optional] No description for undelete
        /// </summary>
        [SwitchName("--undelete")]
        public bool? Undelete { get; set; }
    }

    /// <summary>
    /// Options for the method VersionDisplayancestry of class Package.
    /// </summary>
    public class PackageVersionDisplayancestryOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] If you specify a package ID (starts with 0Ho) or alias, the ancestor tree for every package version associated with the package ID is displayed. If you specify a package version (starts with 04t) or alias, the ancestry tree of the specified package version is displayed.
        /// </summary>
        [SwitchName("--package")]
        public string Package { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] You can use the DOT code output in graph visualization software to create tree visualizations.
        /// </summary>
        [SwitchName("--dot-code")]
        public bool? DotCode { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method VersionList of class Package.
    /// </summary>
    public class PackageVersionListOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for created-last-days
        /// </summary>
        [SwitchName("--created-last-days")]
        public string CreatedLastDays { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }

        /// <summary>
        /// [Optional] No description for show-conversions-only
        /// </summary>
        [SwitchName("--show-conversions-only")]
        public bool? ShowConversionsOnly { get; set; }

        /// <summary>
        /// [Required] No description for modified-last-days
        /// </summary>
        [SwitchName("--modified-last-days")]
        public string ModifiedLastDays { get; set; }

        /// <summary>
        /// [Required] No description for packages
        /// </summary>
        [SwitchName("--packages")]
        public string Packages { get; set; }

        /// <summary>
        /// [Optional] No description for released
        /// </summary>
        [SwitchName("--released")]
        public bool? Released { get; set; }

        /// <summary>
        /// [Required] No description for order-by
        /// </summary>
        [SwitchName("--order-by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method VersionPromote of class Package.
    /// </summary>
    public class PackageVersionPromoteOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for package
        /// </summary>
        [SwitchName("--package")]
        public string Package { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }
    }

    /// <summary>
    /// Options for the method VersionReport of class Package.
    /// </summary>
    public class PackageVersionReportOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for package
        /// </summary>
        [SwitchName("--package")]
        public string Package { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method VersionUpdate of class Package.
    /// </summary>
    public class PackageVersionUpdateOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for package
        /// </summary>
        [SwitchName("--package")]
        public string Package { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for version-name
        /// </summary>
        [SwitchName("--version-name")]
        public string VersionName { get; set; }

        /// <summary>
        /// [Required] No description for version-description
        /// </summary>
        [SwitchName("--version-description")]
        public string VersionDescription { get; set; }

        /// <summary>
        /// [Required] No description for branch
        /// </summary>
        [SwitchName("--branch")]
        public string Branch { get; set; }

        /// <summary>
        /// [Required] No description for tag
        /// </summary>
        [SwitchName("--tag")]
        public string Tag { get; set; }

        /// <summary>
        /// [Required] No description for installation-key
        /// </summary>
        [SwitchName("--installation-key")]
        public string InstallationKey { get; set; }
    }

    /// <summary>
    /// Package
    /// </summary>
    [CommandClass("package")]
    public class Package : SfdxCommand
    {
        /// Constructor.
        public Package(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// First, use this command to create a package. Then create a package version.
        /// 
        /// If you don’t have a namespace defined in your sfdx-project.json file, use --no-namespace.
        /// 
        /// Your --name value must be unique within your namespace.
        /// 
        /// Run '<%= config.bin %> package list to list all packages in the Dev Hub org.
        /// </summary>
        /// <remarks>
        /// First, use this command to create a package. Then create a package version.
        /// 
        /// If you don’t have a namespace defined in your sfdx-project.json file, use --no-namespace.
        /// 
        /// Your --name value must be unique within your namespace.
        /// 
        /// Run '<%= config.bin %> package list to list all packages in the Dev Hub org.
        /// </remarks>
        /// <example>
        /// 
        /// Create an unlocked package from the files in the "force-app" directory; uses your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --name MyUnlockedPackage --package-type Unlocked --path force-app
        /// Create a managed packaged from the "force-app" directory files, give the package a description, and use the specified Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --name MyManagedPackage --description "Your Package Descripton" --package-type Managed --path force-app --target-dev-hub devhub@example.com
        /// </example>
        [Command("create")]
        public SfdxResponse Create(PackageCreateOptions options)
        {
            return ExecuteCommand(nameof(Create), options);
        }

        /// <summary>
        /// Specify the ID or alias of the package you want to delete.
        /// 
        /// Delete unlocked and second-generation managed packages. Before you delete a package, first delete all associated package versions.
        /// </summary>
        /// <remarks>
        /// Specify the ID or alias of the package you want to delete.
        /// 
        /// Delete unlocked and second-generation managed packages. Before you delete a package, first delete all associated package versions.
        /// </remarks>
        /// <example>
        /// 
        /// Delete a package using its alias from your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package "Your Package Alias"
        /// Delete a package using its ID from the specified Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package 0Ho... --target-dev-hub devhub@example.com
        /// </example>
        [Command("delete")]
        public SfdxResponse Delete(PackageDeleteOptions options)
        {
            return ExecuteCommand(nameof(Delete), options);
        }

        /// <summary>
        /// To install a package, specify a specific version of the package using the 04t package ID. The package and the version you specified installs in your default target org unless you supply the username for a different target org.
        /// 
        /// For package upgrades, to specify options for component deprecation or deletion of removed components, include an --upgrade-type value. To delete components that can be safely deleted and deprecate the others, specify --upgrade-type Mixed (the default). To deprecate all removed components, specify --upgrade-type DeprecateOnly. To delete all removed components, except for custom objects and custom fields, that don't have dependencies, specify --upgrade-type Delete. (Note: This option can result in the loss of data that is associated with the deleted components.) The default is Mixed.
        /// </summary>
        /// <remarks>
        /// To install a package, specify a specific version of the package using the 04t package ID. The package and the version you specified installs in your default target org unless you supply the username for a different target org.
        /// 
        /// For package upgrades, to specify options for component deprecation or deletion of removed components, include an --upgrade-type value. To delete components that can be safely deleted and deprecate the others, specify --upgrade-type Mixed (the default). To deprecate all removed components, specify --upgrade-type DeprecateOnly. To delete all removed components, except for custom objects and custom fields, that don't have dependencies, specify --upgrade-type Delete. (Note: This option can result in the loss of data that is associated with the deleted components.) The default is Mixed.
        /// </remarks>
        /// <example>
        /// 
        /// Install a package version with the specified ID in the org with username "me@example.com":
        /// <%= config.bin %> <%= command.id %> --package 04t... --target-org me@example.com
        /// Install a package version with the specified alias into your default org:
        /// <%= config.bin %> <%= command.id %> --package awesome_package_alias
        /// Install a package version with an alias that includes spaces into your default org:
        /// <%= config.bin %> <%= command.id %> --package "Awesome Package Alias"
        /// Install an unlocked package version with the specified ID and deprecate all removed components:
        /// <%= config.bin %> <%= command.id %> --package 04t... --upgrade-type DeprecateOnly
        /// </example>
        [Command("install")]
        public SfdxResponse Install(PackageInstallOptions options)
        {
            return ExecuteCommand(nameof(Install), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// Retrieve the status of a package installation request with the specified ID on your default org:
        /// <%= config.bin %> <%= command.id %> --request-id 0Hf...
        /// Similar to previous example, except use the org with username me@example.com:
        /// <%= config.bin %> <%= command.id %> --request-id 0Hf... --target-org me@example.com
        /// </example>
        [Command("install report")]
        public SfdxResponse InstallReport(PackageInstallReportOptions options)
        {
            return ExecuteCommand(nameof(InstallReport), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// List the installed packages in your default org:
        /// <%= config.bin %> <%= command.id %>
        /// List the installed packages in the org with username me@example.com:
        /// <%= config.bin %> <%= command.id %> --target-org me@example.com
        /// </example>
        [Command("installed list")]
        public SfdxResponse InstalledList(PackageInstalledListOptions options)
        {
            return ExecuteCommand(nameof(InstalledList), options);
        }

        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// Description
        /// </remarks>
        /// <example>
        /// 
        /// List all packages in the specified Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --target-dev-hub devhub@example.com
        /// List all packages details in the specified Dev Hub org, and show extended details about each package:
        /// <%= config.bin %> <%= command.id %> --target-dev-hub devhub@example.com --verbose
        /// </example>
        [Command("list")]
        public SfdxResponse List(PackageListOptions options)
        {
            return ExecuteCommand(nameof(List), options);
        }

        /// <summary>
        /// Specify the package ID for a second-generation package.
        /// 
        /// To list the org’s installed packages, run "<%= config.bin %> package installed list".
        /// 
        /// To uninstall a first-generation package, from Setup, enter Installed Packages in the Quick Find box, then select Installed Packages.
        /// </summary>
        /// <remarks>
        /// Specify the package ID for a second-generation package.
        /// 
        /// To list the org’s installed packages, run "<%= config.bin %> package installed list".
        /// 
        /// To uninstall a first-generation package, from Setup, enter Installed Packages in the Quick Find box, then select Installed Packages.
        /// </remarks>
        /// <example>
        /// 
        /// Uninstall a package with specified ID from an org with username me@example.com:
        /// <%= config.bin %> <%= command.id %> --package 04t... --target-org me@example.com
        /// Uninstall a package with the specified alias from your default org:
        /// <%= config.bin %> <%= command.id %> --package undesirable_package_alias
        /// Uninstall a package with an alias that contains spaces from your default org:
        /// <%= config.bin %> <%= command.id %> --package "Undesirable Package Alias"
        /// </example>
        [Command("uninstall")]
        public SfdxResponse Uninstall(PackageUninstallOptions options)
        {
            return ExecuteCommand(nameof(Uninstall), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// Retrieve the status of a package uninstall in your default org using the specified request ID:
        /// <%= config.bin %> <%= command.id %> --request-id 06y...
        /// Similar to previous example, but use the org with username me@example.com:
        /// <%= config.bin %> <%= command.id %> --request-id 06y... --target-org me@example.com
        /// </example>
        [Command("uninstall report")]
        public SfdxResponse UninstallReport(PackageUninstallReportOptions options)
        {
            return ExecuteCommand(nameof(UninstallReport), options);
        }

        /// <summary>
        /// Specify a new value for each option you want to update.
        /// 
        /// Run "<%= config.bin %> package list" to list all packages in the Dev Hub org.
        /// </summary>
        /// <remarks>
        /// Specify a new value for each option you want to update.
        /// 
        /// Run "<%= config.bin %> package list" to list all packages in the Dev Hub org.
        /// </remarks>
        /// <example>
        /// 
        /// Update the name of the package with the specified alias; uses your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package "Your Package Alias" --name "New Package Name"
        /// Update the description of the package with the specified ID; uses the specified Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package 0Ho... --description "New Package Description" --target-dev-hub devhub@example.com
        /// </example>
        [Command("update")]
        public SfdxResponse Update(PackageUpdateOptions options)
        {
            return ExecuteCommand(nameof(Update), options);
        }

        /// <summary>
        /// The package version is based on the package contents in the specified directory.
        /// 
        /// To retrieve details about a package version create request, including status and package version ID (04t), run "<%= config.bin %> package version create report -i 08c...".
        /// 
        /// We recommend that you specify the --installation-key parameter to protect the contents of your package and to prevent unauthorized installation of your package.
        /// 
        /// To list package version creation requests in the org, run "<%= config.bin %> package version create list".
        /// To promote a package version to released, you must use the --code-coverage parameter. The package must also meet the code coverage requirements. This requirement applies to both managed and unlocked packages.
        /// 
        /// We don’t calculate code coverage for org-dependent unlocked packages, or for package versions that specify --skip-validation.
        /// </summary>
        /// <remarks>
        /// The package version is based on the package contents in the specified directory.
        /// 
        /// To retrieve details about a package version create request, including status and package version ID (04t), run "<%= config.bin %> package version create report -i 08c...".
        /// 
        /// We recommend that you specify the --installation-key parameter to protect the contents of your package and to prevent unauthorized installation of your package.
        /// 
        /// To list package version creation requests in the org, run "<%= config.bin %> package version create list".
        /// To promote a package version to released, you must use the --code-coverage parameter. The package must also meet the code coverage requirements. This requirement applies to both managed and unlocked packages.
        /// 
        /// We don’t calculate code coverage for org-dependent unlocked packages, or for package versions that specify --skip-validation.
        /// </remarks>
        /// <example>
        /// 
        /// Create a package version from the contents of the "common" directory and give it an installation key of "password123"; uses your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --path common --installation-key password123
        /// Create a package version from a package with the specified alias; uses the Dev Hub org with username devhub@example.com:
        /// <%= config.bin %> <%= command.id %> --package "Your Package Alias" --installation-key password123 --target-dev-hub devhub@example.com
        /// Create a package version from a package with the specified ID:
        /// <%= config.bin %> <%= command.id %> --package 0Ho... --installation-key password123
        /// Create a package version and skip the validation step:
        /// <%= config.bin %> <%= command.id %> --path common --installation-key password123 --skip-validation
        /// </example>
        [Command("version create")]
        public SfdxResponse VersionCreate(PackageVersionCreateOptions options)
        {
            return ExecuteCommand(nameof(VersionCreate), options);
        }

        /// <summary>
        /// Shows the details of each request to create a package version in the Dev Hub org.
        /// 
        /// All filter parameters are applied using the AND logical operator (not OR).
        /// 
        /// To get information about a specific request, run "<%= config.bin %> package version create report" and supply the request ID.
        /// </summary>
        /// <remarks>
        /// Shows the details of each request to create a package version in the Dev Hub org.
        /// 
        /// All filter parameters are applied using the AND logical operator (not OR).
        /// 
        /// To get information about a specific request, run "<%= config.bin %> package version create report" and supply the request ID.
        /// </remarks>
        /// <example>
        /// 
        /// List all package version creation requests in your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %>
        /// List package version creation requests from the last 3 days in the Dev Hub org with username devhub@example.com:
        /// <%= config.bin %> <%= command.id %> --created-last-days 3 --target-dev-hub
        /// List package version creation requests with status Error:
        /// <%= config.bin %> <%= command.id %> --status Error
        /// List package version creation requests with status InProgress:
        /// <%= config.bin %> <%= command.id %> --status InProgress
        /// List package version creation requests with status Success that were created today:
        /// <%= config.bin %> <%= command.id %> --created-last-days 0 --status Success
        /// </example>
        [Command("version create list")]
        public SfdxResponse VersionCreateList(PackageVersionCreateListOptions options)
        {
            return ExecuteCommand(nameof(VersionCreateList), options);
        }

        /// <summary>
        /// Specify the request ID for which you want to view details. If applicable, the command displays errors related to the request.
        /// 
        /// To show all requests in the org, run "<%= config.bin %> package version create list".
        /// </summary>
        /// <remarks>
        /// Specify the request ID for which you want to view details. If applicable, the command displays errors related to the request.
        /// 
        /// To show all requests in the org, run "<%= config.bin %> package version create list".
        /// </remarks>
        /// <example>
        /// 
        /// Retrieve details about the package version creation request with the specified ID; uses your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package-create-request-id 08c...
        /// Retrieve details about the specified package version creation request in the Dev Hub org with username devhub@example.com:
        /// <%= config.bin %> <%= command.id %> --package-create-request-id 08c... --target-dev-hub devhub@example.com
        /// </example>
        [Command("version create report")]
        public SfdxResponse VersionCreateReport(PackageVersionCreateReportOptions options)
        {
            return ExecuteCommand(nameof(VersionCreateReport), options);
        }

        /// <summary>
        /// Specify the ID or alias of the package version you want to delete.
        /// </summary>
        /// <remarks>
        /// Specify the ID or alias of the package version you want to delete.
        /// </remarks>
        /// <example>
        /// 
        /// Delete a package version with the specified alias using your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package "Your Package Alias"
        /// Delete a package version with the specified ID using the Dev Hub org with username "devhub@example.com":
        /// <%= config.bin %> <%= command.id %> --package 04t... --target-org devhub@example.com
        /// </example>
        [Command("version delete")]
        public SfdxResponse VersionDelete(PackageVersionDeleteOptions options)
        {
            return ExecuteCommand(nameof(VersionDelete), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// Display the ancestry tree for a package version with the specified alias, using your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package package_version_alias
        /// Similar to previous example, but display the output in DOT code:
        /// <%= config.bin %> <%= command.id %> --package package_version_alias --dot-code
        /// Display the ancestry tree for a package with the specified ID, using the Dev Hub org with username devhub@example.com:
        /// <%= config.bin %> <%= command.id %> --package OHo... --target-dev-hub devhub@example.com
        /// Display the ancestry tree of a package version with the specified ID, using your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package 04t...
        /// </example>
        [Command("version displayancestry")]
        public SfdxResponse VersionDisplayancestry(PackageVersionDisplayancestryOptions options)
        {
            return ExecuteCommand(nameof(VersionDisplayancestry), options);
        }

        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// Description
        /// </remarks>
        /// <example>
        /// 
        /// List package versions in your default Dev Hub org that were created in the last 3 days; show only the released versions and order the list using the PatchVersion field. Display extended details about each package version:
        /// <%= config.bin %> <%= command.id %> --verbose --created-last-days 3 --released --order-by PatchVersion
        /// List the released package versions for the two specified packages that were modified today; use the Dev Hub org with username devhub@example.com:
        /// <%= config.bin %> <%= command.id %> --packages 0Ho000000000000,0Ho000000000001 --released --modified-last-days 0 --target-dev-hub devhub@example.com
        /// List all released package versions in your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --released
        /// List package versions that were modified today in your default Dev Hub org; show limited details about each one:
        /// <%= config.bin %> <%= command.id %> --concise --modified-last-days 0
        /// List released package versions that were created in the last 3 days in your default Dev Hub org; show limited details:
        /// <%= config.bin %> <%= command.id %> --concise --created-last-days 3 --released
        /// List released package versions that were modified today for the two packages with specified aliases in your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --packages exp-mgr,exp-mgr-util --released --modified-last-days 0
        /// </example>
        [Command("version list")]
        public SfdxResponse VersionList(PackageVersionListOptions options)
        {
            return ExecuteCommand(nameof(VersionList), options);
        }

        /// <summary>
        /// Supply the ID or alias of the package version you want to promote. Promotes the package version to released status.
        /// </summary>
        /// <remarks>
        /// Supply the ID or alias of the package version you want to promote. Promotes the package version to released status.
        /// </remarks>
        /// <example>
        /// 
        /// Promote the package version with the specified ID to released; uses your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package 04t...
        /// Promote the package version with the specified alias to released; uses the Dev Hub org with username devhub@example.com:
        /// <%= config.bin %> <%= command.id %> --package awesome_package_alias --target-dev-hub devhub@example.com
        /// Promote the package version with an alias that has spaces to released:
        /// <%= config.bin %> <%= command.id %> --package "Awesome Package Alias"
        /// </example>
        [Command("version promote")]
        public SfdxResponse VersionPromote(PackageVersionPromoteOptions options)
        {
            return ExecuteCommand(nameof(VersionPromote), options);
        }

        /// <summary>
        /// To update package version values, run "<%= config.bin %> package version update".
        /// </summary>
        /// <remarks>
        /// To update package version values, run "<%= config.bin %> package version update".
        /// </remarks>
        /// <example>
        /// 
        /// Retrieve details about the package version with the specified ID from your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package 04t...
        /// Retrieve details about the package version with the specified alias (that contains spaces) from the Dev Hub org with username devhub@example.com:
        /// <%= config.bin %> <%= command.id %> --package "Your Package Alias" --target-dev-hub devhub@example.com
        /// </example>
        [Command("version report")]
        public SfdxResponse VersionReport(PackageVersionReportOptions options)
        {
            return ExecuteCommand(nameof(VersionReport), options);
        }

        /// <summary>
        /// Specify a new value for each option you want to update.
        /// 
        /// To display details about a package version, run "<%= config.bin %> package version display".
        /// </summary>
        /// <remarks>
        /// Specify a new value for each option you want to update.
        /// 
        /// To display details about a package version, run "<%= config.bin %> package version display".
        /// </remarks>
        /// <example>
        /// 
        /// Update the package version that has the specified alias (that contains spaces) with a new installation key "password123"; uses your default Dev Hub org:
        /// <%= config.bin %> <%= command.id %> --package "Your Package Alias" --installation-key password123
        /// Update the package version that has the specified ID with a new branch and tag; use the Dev Hub org with username devhub@example.com:
        /// <%= config.bin %> <%= command.id %> --package 04t... --branch main --tag 'Release 1.0.7' --target-dev-hub devhub@example.com
        /// Update the package version that has the specified ID with a new description:
        /// <%= config.bin %> <%= command.id %> --package 04t... --version-description "New Package Version Description"
        /// </example>
        [Command("version update")]
        public SfdxResponse VersionUpdate(PackageVersionUpdateOptions options)
        {
            return ExecuteCommand(nameof(VersionUpdate), options);
        }
    }
}

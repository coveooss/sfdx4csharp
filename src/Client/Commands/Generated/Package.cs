// Generated on November 19th 2018, 12:30:00 pm using sfdx-cli/6.40.0-384e0c6cf2 (windows-x64) node-v8.9.4. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

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
        /// [Required] Name of the package to create.
        /// </summary>
        [SwitchName("--name")]
        public string name { get; set; }

        /// <summary>
        /// [Required] Package type for the package.
        /// The options for package type are Managed and Unlocked (Managed=DeveloperManagedSubscriberManaged, Unlocked=DeveloperControlledSubscriberEditable). Managed packages are currently in beta.
        /// These options determine upgrade and editability rules.
        /// </summary>
        [SwitchName("--packagetype")]
        public string packagetype { get; set; }

        /// <summary>
        /// [Required] The path to the directory that contains the contents of the package.
        /// </summary>
        [SwitchName("--path")]
        public string path { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Optional] Creates the package with no namespace. Available only for unlocked packages. Useful when you’re migrating an existing org to packages. But, use a namespaced package for new metadata.
        /// </summary>
        [SwitchName("--nonamespace")]
        public bool? nonamespace { get; set; }

        /// <summary>
        /// [Required] Description of the package.
        /// </summary>
        [SwitchName("--description")]
        public string description { get; set; }
    }

    /// <summary>
    /// Options for the method install of class Package.
    /// </summary>
    public class PackageInstallOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Security access type for the installed package.
        /// </summary>
        [SwitchName("--securitytype")]
        public string securitytype { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 04t) or alias of the package version to install.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] Allow Remote Site Settings and Content Security Policy websites to send or receive data without confirmation.
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }

        /// <summary>
        /// [Optional] Maximum number of minutes to wait for the Subscriber Package Version ID to become available in the target org before canceling the install request. The default is 0.
        /// </summary>
        [SwitchName("--publishwait")]
        public int? publishwait { get; set; }

        /// <summary>
        /// [Required] Installation key for installing a key-protected package. The default is null.
        /// </summary>
        [SwitchName("--installationkey")]
        public string installationkey { get; set; }

        /// <summary>
        /// [Optional] Maximum number of minutes to wait for installation status. The default is 0.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }
    }

    /// <summary>
    /// Options for the method installReport of class Package.
    /// </summary>
    public class PackageInstallReportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The ID of the package install request you want to check.
        /// </summary>
        [SwitchName("--requestid")]
        public string requestid { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }
    }

    /// <summary>
    /// Options for the method installedList of class Package.
    /// </summary>
    public class PackageInstalledListOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }
    }

    /// <summary>
    /// Options for the method list of class Package.
    /// </summary>
    public class PackageListOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] Displays extended package details.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }
    }

    /// <summary>
    /// Options for the method uninstall of class Package.
    /// </summary>
    public class PackageUninstallOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 04t) or alias of the package version to uninstall.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] Maximum number of minutes to wait for uninstall status. The default is 0.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }
    }

    /// <summary>
    /// Options for the method uninstallReport of class Package.
    /// </summary>
    public class PackageUninstallReportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The ID of the package uninstall request you want to check.
        /// </summary>
        [SwitchName("--requestid")]
        public string requestid { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }
    }

    /// <summary>
    /// Options for the method update of class Package.
    /// </summary>
    public class PackageUpdateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The ID (starts with 0Ho) or alias of the package to update.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] New description of the package.
        /// </summary>
        [SwitchName("--description")]
        public string description { get; set; }

        /// <summary>
        /// [Required] New name of the package.
        /// </summary>
        [SwitchName("--name")]
        public string name { get; set; }
    }

    /// <summary>
    /// Options for the method versionCreate of class Package.
    /// </summary>
    public class PackageVersionCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] The number of minutes to wait for the package version to be created.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The instance where the package version will be created——for example, NA50.
        /// </summary>
        [SwitchName("--buildinstance")]
        public string buildinstance { get; set; }

        /// <summary>
        /// [Required] The ID (starts with 0Ho) or alias of the package to create a version of.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Required] The source org ID used to copy the org shape for the build org.
        /// </summary>
        [SwitchName("--sourceorg")]
        public string sourceorg { get; set; }

        /// <summary>
        /// [Required] The path to a definition file similar to scratch org definition file that contains the list of features and org preferences that the metadata of the package version depends on.
        /// </summary>
        [SwitchName("--definitionfile")]
        public string definitionfile { get; set; }

        /// <summary>
        /// [Required] The name of the package version to be created. Overrides the sfdx-project.json value.
        /// </summary>
        [SwitchName("--versionname")]
        public string versionname { get; set; }

        /// <summary>
        /// [Required] The package version’s tag.
        /// </summary>
        [SwitchName("--tag")]
        public string tag { get; set; }

        /// <summary>
        /// [Required] Bypasses the installation key requirement. If you bypass this requirement, anyone can install your package. Either an --installationkey value or the --installationkeybypass flag is required.
        /// </summary>
        [SwitchName("--installationkeybypass")]
        public string installationkeybypass { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] The description of the package version to be created. Overrides the sfdx-project.json value.
        /// </summary>
        [SwitchName("--versiondescription")]
        public string versiondescription { get; set; }

        /// <summary>
        /// [Required] The version number of the package version to be created. Overrides the sfdx-project.json value.
        /// </summary>
        [SwitchName("--versionnumber")]
        public string versionnumber { get; set; }

        /// <summary>
        /// [Required] Specifies that the temp files are preserved that would otherwise be deleted
        /// </summary>
        [SwitchName("--preserve")]
        public string preserve { get; set; }

        /// <summary>
        /// [Required] Installation key for creating the key-protected package. Either an --installationkey value or the --installationkeybypass flag is required.
        /// </summary>
        [SwitchName("--installationkey")]
        public string installationkey { get; set; }

        /// <summary>
        /// [Required] The package version’s branch.
        /// </summary>
        [SwitchName("--branch")]
        public string branch { get; set; }

        /// <summary>
        /// [Required] The path to the directory that contains the contents of the package.
        /// </summary>
        [SwitchName("--path")]
        public string path { get; set; }

        /// <summary>
        /// [Required] Specifies that the sfdx-project.json file should be validated against JSON schema.
        /// </summary>
        [SwitchName("--validateschema")]
        public string validateschema { get; set; }
    }

    /// <summary>
    /// Options for the method versionCreateList of class Package.
    /// </summary>
    public class PackageVersionCreateListOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Filters the list based on the status of version creation requests.
        /// </summary>
        [SwitchName("--status")]
        public string status { get; set; }

        /// <summary>
        /// [Optional] Filters the list based on the specified maximum number of days since the request was created (starting at 00:00:00 of first day to now; 0 for today).
        /// </summary>
        [SwitchName("--createdlastdays")]
        public int? createdlastdays { get; set; }
    }

    /// <summary>
    /// Options for the method versionCreateReport of class Package.
    /// </summary>
    public class PackageVersionCreateReportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The ID (starts with 08c) of the package version creation request you want to display.
        /// </summary>
        [SwitchName("--packagecreaterequestid")]
        public string packagecreaterequestid { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }
    }

    /// <summary>
    /// Options for the method versionList of class Package.
    /// </summary>
    public class PackageVersionListOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] Displays extended package version details.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Optional] Displays limited package version details.
        /// </summary>
        [SwitchName("--concise")]
        public bool? concise { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Orders the list by the specified package version fields.
        /// </summary>
        [SwitchName("--orderby")]
        public string orderby { get; set; }

        /// <summary>
        /// [Optional] Displays released versions only (IsReleased=true).
        /// </summary>
        [SwitchName("--released")]
        public bool? released { get; set; }

        /// <summary>
        /// [Required] Filters results on the specified comma-delimited packages (aliases or 0Ho IDs).
        /// </summary>
        [SwitchName("--packages")]
        public string packages { get; set; }

        /// <summary>
        /// [Optional] Lists the items modified in the specified last number of days, starting at 00:00:00 of first day to now. Use 0 for today.
        /// </summary>
        [SwitchName("--modifiedlastdays")]
        public int? modifiedlastdays { get; set; }

        /// <summary>
        /// [Optional] Filters the list based on the specified maximum number of days since the request was created (starting at 00:00:00 of first day to now; 0 for today).
        /// </summary>
        [SwitchName("--createdlastdays")]
        public int? createdlastdays { get; set; }
    }

    /// <summary>
    /// Options for the method versionPromote of class Package.
    /// </summary>
    public class PackageVersionPromoteOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The ID (starts with 04t) or alias of the package version to promote.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

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
        /// [Required] The ID (starts with 04t) or alias of the package to retrieve details for.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] Displays extended package version details.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }
    }

    /// <summary>
    /// Options for the method versionUpdate of class Package.
    /// </summary>
    public class PackageVersionUpdateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The ID (starts with 04t) or alias of the package to update a version of.
        /// </summary>
        [SwitchName("--package")]
        public string package { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] The new installation key for the key-protected package. The default is null.
        /// </summary>
        [SwitchName("--installationkey")]
        public string installationkey { get; set; }

        /// <summary>
        /// [Required] The new package version tag.
        /// </summary>
        [SwitchName("--tag")]
        public string tag { get; set; }

        /// <summary>
        /// [Required] The new package version branch.
        /// </summary>
        [SwitchName("--branch")]
        public string branch { get; set; }

        /// <summary>
        /// [Required] The new package version description.
        /// </summary>
        [SwitchName("--versiondescription")]
        public string versiondescription { get; set; }

        /// <summary>
        /// [Required] The new package version name.
        /// </summary>
        [SwitchName("--versionname")]
        public string versionname { get; set; }
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
        /// </summary>
        /// <remarks>
        /// Creates a package.
        /// </remarks>
        /// <example>
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
        /// force:package:create -n <string> -t <string> -r <directory> [-d <string>] [-e] [-v <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("create")]
        public SFDXResponse Create(PackageCreateOptions p_Options)
        {
            return ExecuteCommand<PackageCreateOptions>(nameof(Create), p_Options);
        }

        /// <summary>
        /// install a package in the target org
        /// </summary>
        /// <remarks>
        /// Installs a package in the target org.
        /// </remarks>
        /// <example>
        /// Supply the ID of the package version to install. The package installs in your default target org unless you supply the username for a different target org.
        /// 
        /// Examples:
        ///    $ sfdx force:package:install --package 04t... -u me@example.com
        ///    $ sfdx force:package:install --package awesome_package_alias
        ///    $ sfdx force:package:install --package "Awesome Package Alias"
        /// force:package:install [-w <minutes>] [-k <string>] [-b <minutes>] [-r] [-p <string>] [-s <string>] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("install")]
        public SFDXResponse Install(PackageInstallOptions p_Options)
        {
            return ExecuteCommand<PackageInstallOptions>(nameof(Install), p_Options);
        }

        /// <summary>
        /// retrieve the status of a package installation request
        /// </summary>
        /// <remarks>
        /// Retrieves the status of a package installation request.
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:package:install:report -i 0Hf...
        ///    $ sfdx force:package:install:report -i 0Hf... -u me@example.com
        /// force:package:install:report -i <id> [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("install:report")]
        public SFDXResponse InstallReport(PackageInstallReportOptions p_Options)
        {
            return ExecuteCommand<PackageInstallReportOptions>(nameof(InstallReport), p_Options);
        }

        /// <summary>
        /// list the org’s installed packages
        /// </summary>
        /// <remarks>
        /// Lists all packages installed in the target org.
        /// </remarks>
        /// <example>
        /// NOTE: This command must be run from within a project.
        /// 
        /// Examples:
        ///    $ sfdx force:package:installed:list
        ///    $ sfdx force:package:installed:list -u me@example.com
        /// force:package:installed:list [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("installed:list")]
        public SFDXResponse InstalledList(PackageInstalledListOptions p_Options)
        {
            return ExecuteCommand<PackageInstalledListOptions>(nameof(InstalledList), p_Options);
        }

        /// <summary>
        /// list all packages in the Dev Hub org
        /// </summary>
        /// <remarks>
        /// Lists all packages in the Dev Hub org.
        /// </remarks>
        /// <example>
        /// You can view the namespace, IDs, and other details for each package.
        /// 
        /// Examples:
        ///    $ sfdx force:package:list -v devhub@example.com
        ///    $ sfdx force:package:list -v devhub@example.com --verbose
        /// force:package:list [-v <string>] [--json] [--loglevel <string>] [--verbose]
        /// </example>
        [Command("list")]
        public SFDXResponse List(PackageListOptions p_Options)
        {
            return ExecuteCommand<PackageListOptions>(nameof(List), p_Options);
        }

        /// <summary>
        /// uninstall a second-generation package from the target org
        /// </summary>
        /// <remarks>
        /// Uninstalls a second-generation package from the target org. To uninstall a first-generation package, use the Salesforce user interface.
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
        /// force:package:uninstall [-w <minutes>] [-p <string>] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("uninstall")]
        public SFDXResponse Uninstall(PackageUninstallOptions p_Options)
        {
            return ExecuteCommand<PackageUninstallOptions>(nameof(Uninstall), p_Options);
        }

        /// <summary>
        /// retrieve status of package uninstall request
        /// </summary>
        /// <remarks>
        /// Retrieves the status of a package uninstall request.
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:package:uninstall:report -i 06y...
        ///    $ sfdx force:package:uninstall:report -i 06y... -u me@example.com
        /// force:package:uninstall:report -i <id> [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("uninstall:report")]
        public SFDXResponse UninstallReport(PackageUninstallReportOptions p_Options)
        {
            return ExecuteCommand<PackageUninstallReportOptions>(nameof(UninstallReport), p_Options);
        }

        /// <summary>
        /// update package details
        /// </summary>
        /// <remarks>
        /// Updates details about a package. Does not create a package version.
        /// </remarks>
        /// <example>
        /// NOTE: This command must be run from within a project.
        /// 
        /// Specify a new value for each option you want to update.
        /// 
        /// Examples:
        ///    $ sfdx force:package:update -p "Your Package Alias" -n "New Package Name"
        ///    $ sfdx force:package:update -p 0Ho... -d "New Package Description"
        /// 
        /// Run "sfdx force:package:list" to list all packages in the Dev Hub org.
        /// force:package:update -p <string> [-n <string>] [-d <string>] [-v <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("update")]
        public SFDXResponse Update(PackageUpdateOptions p_Options)
        {
            return ExecuteCommand<PackageUpdateOptions>(nameof(Update), p_Options);
        }

        /// <summary>
        /// create a package version
        /// </summary>
        /// <remarks>
        /// Creates a package version in the Dev Hub org.
        /// </remarks>
        /// <example>
        /// NOTE: This command must be run from within a project.
        /// 
        /// The package version is based on the package contents in the specified directory.
        /// 
        /// To retrieve details about a package version create request, including status and package version ID (04t), run "sfdx force:package:version:create:report -i 08c...".
        /// 
        /// We recommend specifying the --installationkey to protect the contents of your package and to prevent unauthorized installation of your package.
        /// 
        /// To list package version creation requests in the org, run "sfdx force:package:version:create:list".
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create -d common -k password123
        ///    $ sfdx force:package:version:create -p "Your Package Alias" -k password123
        ///    $ sfdx force:package:version:create -p 0Ho... -k password123
        /// force:package:version:create [-p <string>] [-d <directory>] [-f <filepath>] [-b <string>] [-t <string>] [-k <string>] [-x] [-w <minutes>] [-a <string>] [-n <string>] [-e <string>] [-v <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("version:create")]
        public SFDXResponse VersionCreate(PackageVersionCreateOptions p_Options)
        {
            return ExecuteCommand<PackageVersionCreateOptions>(nameof(VersionCreate), p_Options);
        }

        /// <summary>
        /// list package version creation requests
        /// </summary>
        /// <remarks>
        /// Lists all requests to create second-generation package versions in the Dev Hub org.
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
        /// force:package:version:create:list [-c <number>] [-s <string>] [-v <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("version:create:list")]
        public SFDXResponse VersionCreateList(PackageVersionCreateListOptions p_Options)
        {
            return ExecuteCommand<PackageVersionCreateListOptions>(nameof(VersionCreateList), p_Options);
        }

        /// <summary>
        /// retrieve details about a package version creation request
        /// </summary>
        /// <remarks>
        /// Retrieves details about a package version creation request in the Dev Hub org.
        /// </remarks>
        /// <example>
        /// Specify the request ID for which you want to view details. If applicable, the command displays errors related to the request.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:create:report -i 08c...
        ///    $ sfdx force:package:version:create:report -i 08c... -v devhub@example.com
        /// 
        /// To show all requests in the org, run "sfdx force:package:version:create:list".
        /// force:package:version:create:report -i <id> [-v <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("version:create:report")]
        public SFDXResponse VersionCreateReport(PackageVersionCreateReportOptions p_Options)
        {
            return ExecuteCommand<PackageVersionCreateReportOptions>(nameof(VersionCreateReport), p_Options);
        }

        /// <summary>
        /// list all package versions in the Dev Hub org
        /// </summary>
        /// <remarks>
        /// Lists all package versions in the Dev Hub org.
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
        /// force:package:version:list [-c <number>] [-m <number>] [-p <string>...] [-r] [-o <string>...] [-v <string>] [--concise] [--json] [--loglevel <string>] [--verbose]
        /// </example>
        [Command("version:list")]
        public SFDXResponse VersionList(PackageVersionListOptions p_Options)
        {
            return ExecuteCommand<PackageVersionListOptions>(nameof(VersionList), p_Options);
        }

        /// <summary>
        /// promote a package version to released
        /// </summary>
        /// <remarks>
        /// Promotes a package version to released status.
        /// </remarks>
        /// <example>
        /// NOTE: This command must be run from within a project.
        /// 
        /// Supply the ID or alias of the package version you want to promote. Promotes the package version to released status.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:promote -p 04t...
        ///    $ sfdx force:package:version:promote -p awesome_package_alias
        ///    $ sfdx force:package:version:promote -p "Awesome Package Alias"
        /// force:package:version:promote -p <string> [-n] [-v <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("version:promote")]
        public SFDXResponse VersionPromote(PackageVersionPromoteOptions p_Options)
        {
            return ExecuteCommand<PackageVersionPromoteOptions>(nameof(VersionPromote), p_Options);
        }

        /// <summary>
        /// retrieve details about a package version in the Dev Hub org
        /// </summary>
        /// <remarks>
        /// Retrieves details about a package version in the Dev Hub org.
        /// </remarks>
        /// <example>
        /// NOTE: This command must be run from within a project.
        /// 
        /// Examples:
        ///    $ sfdx force:package:version:report -p 04t...
        ///    $ sfdx force:package:version:report -p "Your Package Alias"
        /// 
        /// To update package version values, run "sfdx force:package:version:update".
        /// force:package:version:report -p <string> [-v <string>] [--json] [--loglevel <string>] [--verbose]
        /// </example>
        [Command("version:report")]
        public SFDXResponse VersionReport(PackageVersionReportOptions p_Options)
        {
            return ExecuteCommand<PackageVersionReportOptions>(nameof(VersionReport), p_Options);
        }

        /// <summary>
        /// update a package version
        /// </summary>
        /// <remarks>
        /// Updates a second-generation package version in the Dev Hub org.
        /// </remarks>
        /// <example>
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
        /// force:package:version:update -p <string> [-a <string>] [-e <string>] [-b <string>] [-t <string>] [-k <string>] [-v <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("version:update")]
        public SFDXResponse VersionUpdate(PackageVersionUpdateOptions p_Options)
        {
            return ExecuteCommand<PackageVersionUpdateOptions>(nameof(VersionUpdate), p_Options);
        }
    }
}

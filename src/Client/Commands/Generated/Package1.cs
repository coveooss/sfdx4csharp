// Generated on Tue Mar 10 2020 using sfdx-cli/7.43.1 win32-x64 node-v12.16.1. DO NOT MODIFY
// Copyright (c) 2005-2020, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method versionCreate of class Package1.
    /// </summary>
    public class Package1VersionCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Package version name.
        /// </summary>
        [SwitchName("--name")]
        public string name { get; set; }

        /// <summary>
        /// [Required] ID of the metadata package (starts with 033) of which you’re creating a new version.
        /// </summary>
        [SwitchName("--packageid")]
        public string packageid { get; set; }

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
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] Package version description.
        /// </summary>
        [SwitchName("--description")]
        public string description { get; set; }

        /// <summary>
        /// [Required] Package version in major.minor format, for example, 3.2.
        /// </summary>
        [SwitchName("--version")]
        public string version { get; set; }

        /// <summary>
        /// [Optional] Creates a managed package version. To create a beta version, don’t include this parameter.
        /// </summary>
        [SwitchName("--managedreleased")]
        public bool? managedreleased { get; set; }

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
        /// [Required] Installation key for creating the key-protected package. The default is null.
        /// </summary>
        [SwitchName("--installationkey")]
        public string installationkey { get; set; }

        /// <summary>
        /// [Optional] Minutes to wait for the package version to be created. The default is 2 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }
    }

    /// <summary>
    /// Options for the method versionCreateGet of class Package1.
    /// </summary>
    public class Package1VersionCreateGetOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The ID of the PackageUploadRequest.
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

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method versionDisplay of class Package1.
    /// </summary>
    public class Package1VersionDisplayOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] ID (starts with 04t) of the metadata package version whose details you want to display.
        /// </summary>
        [SwitchName("--packageversionid")]
        public string packageversionid { get; set; }

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
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method versionList of class Package1.
    /// </summary>
    public class Package1VersionListOptions : SFDXOptions
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
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] Metadata package ID (starts with 033) whose package versions you want to list. If not specified, shows all versions for all packages (managed and unmanaged) in the org.
        /// </summary>
        [SwitchName("--packageid")]
        public string packageid { get; set; }
    }

    /// <summary>
    /// Package1
    /// </summary>
    [CommandClass("force:package1")]
    public class Package1 : SFDXCommand
    {
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
        /// The package version is based on the contents of the specified metadata package. Omit -m if you want to create an unmanaged package version.
        /// force:package1:version:create -i <id> -n <string> [-d <string>] [-v <string>] [-m] [-r <url>] [-p <url>] [-k <string>] [-w <number>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:create")]
        public SFDXResponse VersionCreate(Package1VersionCreateOptions p_Options)
        {
            return ExecuteCommand<Package1VersionCreateOptions>(nameof(VersionCreate), p_Options);
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
        /// force:package1:version:create:get -i <id> [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:create:get")]
        public SFDXResponse VersionCreateGet(Package1VersionCreateGetOptions p_Options)
        {
            return ExecuteCommand<Package1VersionCreateGetOptions>(nameof(VersionCreateGet), p_Options);
        }

        /// <summary>
        /// display details about a first-generation package version
        /// </summary>
        /// <remarks>
        /// Displays detailed information about an individual first-generation package version.
        /// </remarks>
        /// <example>
        /// Display detailed information about an individual package version, including metadata package ID, name, the release state, and build number.
        /// force:package1:version:display -i <id> [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:display")]
        public SFDXResponse VersionDisplay(Package1VersionDisplayOptions p_Options)
        {
            return ExecuteCommand<Package1VersionDisplayOptions>(nameof(VersionDisplay), p_Options);
        }

        /// <summary>
        /// list package versions for the specified first-generation package or for the org
        /// </summary>
        /// <remarks>
        /// Lists the versions for the specified package or all first-generation packages in the org.
        /// </remarks>
        /// <example>
        /// If a metadata package ID is specified, lists all versions of the specified package. Otherwise, lists all package versions for the org. For each package version, the list includes the package version ID, metadata package ID, name, version number, and release state.
        /// force:package1:version:list [-i <id>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("version:list")]
        public SFDXResponse VersionList(Package1VersionListOptions p_Options)
        {
            return ExecuteCommand<Package1VersionListOptions>(nameof(VersionList), p_Options);
        }
    }
}

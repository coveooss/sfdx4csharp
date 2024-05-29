// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method VersionCreate of class Package1.
    /// </summary>
    public class Package1VersionCreateOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Required] No description for package-id
        /// </summary>
        [SwitchName("--package-id")]
        public string PackageId { get; set; }

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
        /// [Required] No description for description
        /// </summary>
        [SwitchName("--description")]
        public string Description { get; set; }

        /// <summary>
        /// [Required] No description for version
        /// </summary>
        [SwitchName("--version")]
        public string Version { get; set; }

        /// <summary>
        /// [Optional] To create a beta version, don’t include this parameter.
        /// </summary>
        [SwitchName("--managed-released")]
        public bool? ManagedReleased { get; set; }

        /// <summary>
        /// [Required] This link is displayed in the package installation UI to provide release notes for this package version to subscribers.
        /// </summary>
        [SwitchName("--release-notes-url")]
        public string ReleaseNotesUrl { get; set; }

        /// <summary>
        /// [Required] The contents of the post-installation instructions URL are displayed in the UI after installation of the package version.
        /// </summary>
        [SwitchName("--post-install-url")]
        public string PostInstallUrl { get; set; }

        /// <summary>
        /// [Required] No description for installation-key
        /// </summary>
        [SwitchName("--installation-key")]
        public string InstallationKey { get; set; }

        /// <summary>
        /// [Required] No description for wait
        /// </summary>
        [SwitchName("--wait")]
        public string Wait { get; set; }
    }

    /// <summary>
    /// Options for the method VersionCreateGet of class Package1.
    /// </summary>
    public class Package1VersionCreateGetOptions : SfdxOptions
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
    /// Options for the method VersionDisplay of class Package1.
    /// </summary>
    public class Package1VersionDisplayOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for package-version-id
        /// </summary>
        [SwitchName("--package-version-id")]
        public string PackageVersionId { get; set; }

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
    /// Options for the method VersionList of class Package1.
    /// </summary>
    public class Package1VersionListOptions : SfdxOptions
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

        /// <summary>
        /// [Required] If not specified, shows all versions for all packages (managed and unmanaged) in the org.
        /// </summary>
        [SwitchName("--package-id")]
        public string PackageId { get; set; }
    }

    /// <summary>
    /// Package1
    /// </summary>
    [CommandClass("package1")]
    public class Package1 : SfdxCommand
    {
        /// Constructor.
        public Package1(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// The package version is based on the contents of the specified metadata package. Omit --managed-released if you want to create an unmanaged package version.
        /// </summary>
        /// <remarks>
        /// The package version is based on the contents of the specified metadata package. Omit --managed-released if you want to create an unmanaged package version.
        /// </remarks>
        /// <example>
        /// 
        /// Create a first-generation package version from the package with the specified ID and name the package version "example"; use your default org:
        /// <%= config.bin %> <%= command.id %> --package-id 033... --name example
        /// Same as previous example, but provide a description and wait for 30 minutes for the package version to be created; use the specified org:
        /// <%= config.bin %> <%= command.id %> --package-id 033... --name example --description "example description" --wait 30 --target-org myorg@example.com
        /// </example>
        [Command("version create")]
        public SfdxResponse VersionCreate(Package1VersionCreateOptions options)
        {
            return ExecuteCommand(nameof(VersionCreate), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// Get the status of the creation request for the package version with the specified ID in your default org:
        /// <%= config.bin %> <%= command.id %> --request-id 0HD...
        /// Same as previous example, but use the specified org:
        /// <%= config.bin %> <%= command.id %> --request-id 0HD... --target-org myorg@example.com
        /// </example>
        [Command("version create get")]
        public SfdxResponse VersionCreateGet(Package1VersionCreateGetOptions options)
        {
            return ExecuteCommand(nameof(VersionCreateGet), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// Display details about the first-generation package version with the specified ID in your default org:
        /// <%= config.bin %> <%= command.id %> --package-version-id 04t...
        /// Same as previous example, but use the specified org:
        /// <%= config.bin %> <%= command.id %> --package-version-id 04t... --target-org myorg@example.com
        /// </example>
        [Command("version display")]
        public SfdxResponse VersionDisplay(Package1VersionDisplayOptions options)
        {
            return ExecuteCommand(nameof(VersionDisplay), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// List all first-generation package versions in your default org:
        /// <%= config.bin %> <%= command.id %>
        /// List package versions for the specified first-generation package in the specifief org:
        /// <%= config.bin %> <%= command.id %> --package-id 033... --target-org myorg@example.com
        /// </example>
        [Command("version list")]
        public SfdxResponse VersionList(Package1VersionListOptions options)
        {
            return ExecuteCommand(nameof(VersionList), options);
        }
    }
}

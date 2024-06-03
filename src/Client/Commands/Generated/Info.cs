// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method ReleasenotesDisplay of class Info.
    /// </summary>
    public class InfoReleasenotesDisplayOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for version
        /// </summary>
        [SwitchName("--version")]
        public string Version { get; set; }

        /// <summary>
        /// [Optional] No description for hook
        /// </summary>
        [SwitchName("--hook")]
        public bool? Hook { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Info
    /// </summary>
    [CommandClass("info")]
    public class Info : SfCommand
    {
        /// Constructor.
        public Info(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Display Salesforce CLI release notes on the command line.
        /// </summary>
        /// <remarks>
        /// By default, this command displays release notes for the currently installed CLI version on your computer. Use the --version flag to view release notes for a different release.
        /// </remarks>
        /// <example>
        /// Display release notes for the currently installed CLI version:
        /// $ sf releasenotes display stable, stable-rc, latest, latest-rc, rc
        /// Display release notes for CLI version 7.120.0:
        /// $ sf releasenotes display --version 7.120.0 stable, stable-rc, latest, latest-rc, rc
        /// Display release notes for the CLI version that corresponds to a tag (stable, stable-rc, latest, latest-rc, rc):
        /// $ sf releasenotes display --version latest
        /// </example>
        [Command("releasenotes display")]
        public SfResponse ReleasenotesDisplay(InfoReleasenotesDisplayOptions options = null)
        {
            return ExecuteCommand(nameof(ReleasenotesDisplay), options);
        }
    }
}

// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method ReleasenotesDisplay of class Info.
    /// </summary>
    public class InfoReleasenotesDisplayOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for version
        /// </summary>
        [SwitchName("--version")]
        public string Version { get; set; }

        /// <summary>
        /// [Optional] No description for hook
        /// </summary>
        [SwitchName("--hook")]
        public bool? Hook { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Info
    /// </summary>
    [CommandClass("info")]
    public class Info : SfdxCommand
    {
        /// Constructor.
        public Info(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// By default, this command displays release notes for the currently installed CLI version on your computer. Use the --version flag to view release notes for a different release.
        /// </summary>
        /// <remarks>
        /// By default, this command displays release notes for the currently installed CLI version on your computer. Use the --version flag to view release notes for a different release.
        /// </remarks>
        /// <example>
        /// 
        /// Display release notes for the currently installed CLI version:
        /// <%= config.bin %> <%= command.id %> stable, stable-rc, latest, latest-rc, rc
        /// Display release notes for CLI version 7.120.0:
        /// <%= config.bin %> <%= command.id %> --version 7.120.0 stable, stable-rc, latest, latest-rc, rc
        /// Display release notes for the CLI version that corresponds to a tag (stable, stable-rc, latest, latest-rc, rc):
        /// <%= config.bin %> <%= command.id %> --version latest
        /// </example>
        [Command("releasenotes display")]
        public SfdxResponse ReleasenotesDisplay(InfoReleasenotesDisplayOptions options)
        {
            return ExecuteCommand(nameof(ReleasenotesDisplay), options);
        }
    }
}

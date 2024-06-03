// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Execute of class Update.
    /// </summary>
    public class UpdateExecuteOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for autoupdate
        /// </summary>
        [SwitchName("--autoupdate")]
        public bool? Autoupdate { get; set; }

        /// <summary>
        /// [Optional] See available versions.
        /// </summary>
        [SwitchName("--available")]
        public bool? Available { get; set; }

        /// <summary>
        /// [Optional] Force a re-download of the requested version.
        /// </summary>
        [SwitchName("--force")]
        public bool? Force { get; set; }

        /// <summary>
        /// [Optional] Interactively select version to install. This is ignored if a channel is provided.
        /// </summary>
        [SwitchName("--interactive")]
        public bool? Interactive { get; set; }

        /// <summary>
        /// [Optional] Install a specific version.
        /// </summary>
        [SwitchName("--version")]
        public string Version { get; set; }
    }

    /// <summary>
    /// Update
    /// </summary>
    [CommandClass("update")]
    public class Update : SfCommand
    {
        /// Constructor.
        public Update(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// update the $ sf CLI
        /// </remarks>
        /// <example>
        /// Update to the stable channel:
        /// $ sf  stable
        /// 
        /// </example>
        [Command("")]
        public SfResponse Execute(UpdateExecuteOptions options = null)
        {
            return ExecuteCommand(nameof(Execute), options);
        }
    }
}

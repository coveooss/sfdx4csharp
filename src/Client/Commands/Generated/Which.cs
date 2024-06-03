// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Execute of class Which.
    /// </summary>
    public class WhichExecuteOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }
    }

    /// <summary>
    /// Which
    /// </summary>
    [CommandClass("which")]
    public class Which : SfCommand
    {
        /// Constructor.
        public Which(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Show which plugin a command is in.
        /// </remarks>
        /// <example>
        /// See which plugin the `help` command is in:
        /// $ sf  help
        /// 
        /// </example>
        [Command("")]
        public SfResponse Execute(WhichExecuteOptions options = null)
        {
            return ExecuteCommand(nameof(Execute), options);
        }
    }
}

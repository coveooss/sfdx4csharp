// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Execute of class Help.
    /// </summary>
    public class HelpExecuteOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Include all nested commands in the output.
        /// </summary>
        [SwitchName("--nested-commands")]
        public bool? NestedCommands { get; set; }
    }

    /// <summary>
    /// Help
    /// </summary>
    [CommandClass("help")]
    public class Help : SfCommand
    {
        /// Constructor.
        public Help(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Display help for $ sf.
        /// </remarks>
        /// <example>
        /// 
        /// </example>
        [Command("")]
        public SfResponse Execute(HelpExecuteOptions options = null)
        {
            return ExecuteCommand(nameof(Execute), options);
        }
    }
}

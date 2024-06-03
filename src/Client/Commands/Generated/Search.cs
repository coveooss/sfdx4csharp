// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Execute of class Search.
    /// </summary>
    public class SearchExecuteOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }
    }

    /// <summary>
    /// Search
    /// </summary>
    [CommandClass("search")]
    public class Search : SfCommand
    {
        /// Constructor.
        public Search(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Search for a command.
        /// </summary>
        /// <remarks>
        /// Once you select a command, hit enter and it will show the help for that command.
        /// </remarks>
        /// <example>
        /// 
        /// </example>
        [Command("")]
        public SfResponse Execute(SearchExecuteOptions options = null)
        {
            return ExecuteCommand(nameof(Execute), options);
        }
    }
}

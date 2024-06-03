// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Execute of class Commands.
    /// </summary>
    public class CommandsExecuteOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Show deprecated commands
        /// </summary>
        [SwitchName("--deprecated")]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// [Optional] Show CLI help.
        /// </summary>
        [SwitchName("--help")]
        public bool? Help { get; set; }

        /// <summary>
        /// [Optional] Show hidden commands
        /// </summary>
        [SwitchName("--hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// [Optional] Show tree of commands
        /// </summary>
        [SwitchName("--tree")]
        public bool? Tree { get; set; }

        /// <summary>
        /// [Optional] Only show provided columns (comma-separated)
        /// </summary>
        [SwitchName("--columns")]
        public string Columns { get; set; }

        /// <summary>
        /// [Optional] Output is csv format [alias: --output=csv]
        /// </summary>
        [SwitchName("--csv")]
        public bool? Csv { get; set; }

        /// <summary>
        /// [Optional] Show extra columns
        /// </summary>
        [SwitchName("--extended")]
        public bool? Extended { get; set; }

        /// <summary>
        /// [Optional] Filter property by partial string matching, ex: name=foo
        /// </summary>
        [SwitchName("--filter")]
        public string Filter { get; set; }

        /// <summary>
        /// [Optional] Hide table header from output
        /// </summary>
        [SwitchName("--no-header")]
        public bool? NoHeader { get; set; }

        /// <summary>
        /// [Optional] Do not truncate output to fit screen
        /// </summary>
        [SwitchName("--no-truncate")]
        public bool? NoTruncate { get; set; }

        /// <summary>
        /// [Optional] Output in a more machine friendly format
        /// </summary>
        [SwitchName("--output")]
        public string Output { get; set; }

        /// <summary>
        /// [Optional] Property to sort by (prepend '-' for descending)
        /// </summary>
        [SwitchName("--sort")]
        public string Sort { get; set; }
    }

    /// <summary>
    /// Commands
    /// </summary>
    [CommandClass("commands")]
    public class Commands : SfCommand
    {
        /// Constructor.
        public Commands(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// list all the commands
        /// </remarks>
        /// <example>
        /// 
        /// </example>
        [Command("")]
        public SfResponse Execute(CommandsExecuteOptions options = null)
        {
            return ExecuteCommand(nameof(Execute), options);
        }
    }
}

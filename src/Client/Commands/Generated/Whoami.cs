// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Functions of class Whoami.
    /// </summary>
    public class WhoamiFunctionsOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] Show the stored functions token.
        /// </summary>
        [SwitchName("--show-token")]
        public bool? ShowToken { get; set; }
    }

    /// <summary>
    /// Whoami
    /// </summary>
    [CommandClass("whoami")]
    public class Whoami : SfdxCommand
    {
        /// Constructor.
        public Whoami(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Returns your email and ID. Use '--show-token' to show your Salesforce Functions token.
        /// </summary>
        /// <remarks>
        /// Returns your email and ID. Use '--show-token' to show your Salesforce Functions token.
        /// </remarks>
        /// <example>
        /// 
        /// Get account information:
        /// <%= config.bin %> <%= command.id %>
        /// Show token and output result as JSON:
        /// <%= config.bin %> <%= command.id %> --show-token --json
        /// </example>
        [Command("functions")]
        public SfdxResponse Functions(WhoamiFunctionsOptions options)
        {
            return ExecuteCommand(nameof(Functions), options);
        }
    }
}

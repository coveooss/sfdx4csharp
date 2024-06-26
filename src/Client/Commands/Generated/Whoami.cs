// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Functions of class Whoami.
    /// </summary>
    public class WhoamiFunctionsOptions : SfOptions
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
    public class Whoami : SfCommand
    {
        /// Constructor.
        public Whoami(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Show information on your Salesforce Functions login.
        /// </summary>
        /// <remarks>
        /// Returns your email and ID. Use '--show-token' to show your Salesforce Functions token.
        /// </remarks>
        /// <example>
        /// Get account information:
        /// $ sf functions
        /// Show token and output result as JSON:
        /// $ sf functions --show-token --json
        /// </example>
        [Command("functions")]
        public SfResponse Functions(WhoamiFunctionsOptions options = null)
        {
            return ExecuteCommand(nameof(Functions), options);
        }
    }
}

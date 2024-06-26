// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Functions of class Logout.
    /// </summary>
    public class LogoutFunctionsOptions : SfOptions
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
    /// Logout
    /// </summary>
    [CommandClass("logout")]
    public class Logout : SfCommand
    {
        /// Constructor.
        public Logout(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Log out of your Salesforce Functions account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// Log out:
        /// $ sf functions
        /// </example>
        [Command("functions")]
        public SfResponse Functions(LogoutFunctionsOptions options = null)
        {
            return ExecuteCommand(nameof(Functions), options);
        }
    }
}

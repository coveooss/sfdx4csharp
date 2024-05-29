// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Functions of class Logout.
    /// </summary>
    public class LogoutFunctionsOptions : SfdxOptions
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
    }

    /// <summary>
    /// Logout
    /// </summary>
    [CommandClass("logout")]
    public class Logout : SfdxCommand
    {
        /// Constructor.
        public Logout(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// Log out:
        /// <%= config.bin %> <%= command.id %>
        /// </example>
        [Command("functions")]
        public SfdxResponse Functions(LogoutFunctionsOptions options)
        {
            return ExecuteCommand(nameof(Functions), options);
        }
    }
}

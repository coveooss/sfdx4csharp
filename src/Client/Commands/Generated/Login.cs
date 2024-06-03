// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Functions of class Login.
    /// </summary>
    public class LoginFunctionsOptions : SfOptions
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
    /// Options for the method FunctionsJwt of class Login.
    /// </summary>
    public class LoginFunctionsJwtOptions : SfOptions
    {
        /// <summary>
        /// [Required] OAuth client ID.
        /// </summary>
        [SwitchName("--clientid")]
        public string Clientid { get; set; }

        /// <summary>
        /// [Required] Path to JWT keyfile.
        /// </summary>
        [SwitchName("--keyfile")]
        public string Keyfile { get; set; }

        /// <summary>
        /// [Required] Authentication username.
        /// </summary>
        [SwitchName("--username")]
        public string Username { get; set; }

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
        /// [Optional] The login URL of the instance the org lives on.
        /// </summary>
        [SwitchName("--instance-url")]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// [Optional] The login URL of the instance the org lives on.
        /// </summary>
        [SwitchName("--instanceurl")]
        public string Instanceurl { get; set; }

        /// <summary>
        /// [Optional] Alias for the org.
        /// </summary>
        [SwitchName("--alias")]
        public string Alias { get; set; }

        /// <summary>
        /// [Optional] Set the org as the default that all org-related commands run against.
        /// </summary>
        [SwitchName("--set-default")]
        public bool? SetDefault { get; set; }

        /// <summary>
        /// [Optional] Set the org as the default Dev Hub for scratch org creation.
        /// </summary>
        [SwitchName("--set-default-dev-hub")]
        public bool? SetDefaultDevHub { get; set; }
    }

    /// <summary>
    /// Login
    /// </summary>
    [CommandClass("login")]
    public class Login : SfCommand
    {
        /// Constructor.
        public Login(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Log in to Salesforce Functions.
        /// </summary>
        /// <remarks>
        /// This step is required to develop or deploy Salesforce Functions.
        /// </remarks>
        /// <example>
        /// Log in to Salesforce Functions:
        /// $ sf functions
        /// </example>
        [Command("functions")]
        public SfResponse Functions(LoginFunctionsOptions options = null)
        {
            return ExecuteCommand(nameof(Functions), options);
        }

        /// <summary>
        /// Login using JWT instead of default web-based flow. This will authenticate you with both sf and Salesforce Functions.
        /// </summary>
        /// <remarks>
        /// Use this command when executing from a script.
        /// </remarks>
        /// <example>
        /// Log in using JWT:
        /// $ sf functions jwt --username example@username.org --keyfile file.key --clientid 123456
        /// Log in and specify the org alias and URL, set as default org and default Dev Hub, and format output as JSON:
        /// $ sf functions jwt --username example@username.org --keyfile file.key --clientid 123456 --alias org-alias --set-default --set-default-dev-hub --instance-url https://path/to/instance --json
        /// </example>
        [Command("functions jwt")]
        public SfResponse FunctionsJwt(LoginFunctionsJwtOptions options)
        {
            return ExecuteCommand(nameof(FunctionsJwt), options);
        }
    }
}

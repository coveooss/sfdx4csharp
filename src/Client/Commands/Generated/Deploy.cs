// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Functions of class Deploy.
    /// </summary>
    public class DeployFunctionsOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] Username or alias for the org that the compute environment should be connected to.
        /// </summary>
        [SwitchName("--connected-org")]
        public string ConnectedOrg { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Required] Deploy the latest commit from a branch different from the currently active branch.
        /// </summary>
        [SwitchName("--branch")]
        public string Branch { get; set; }

        /// <summary>
        /// [Optional] Ignore warnings and overwrite remote repository (not allowed in production).
        /// </summary>
        [SwitchName("--force")]
        public bool? Force { get; set; }

        /// <summary>
        /// [Optional] Limit the amount of output displayed from the deploy process.
        /// </summary>
        [SwitchName("--quiet")]
        public bool? Quiet { get; set; }
    }

    /// <summary>
    /// Deploy
    /// </summary>
    [CommandClass("deploy")]
    public class Deploy : SfdxCommand
    {
        /// Constructor.
        public Deploy(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// You must run this command from within a git repository. Only committed changes to Functions are deployed. The active branch is deployed unless specified otherwise with `--branch`.
        /// </summary>
        /// <remarks>
        /// You must run this command from within a git repository. Only committed changes to Functions are deployed. The active branch is deployed unless specified otherwise with `--branch`.
        /// </remarks>
        /// <example>
        /// 
        /// Deploy a Salesforce Function:
        /// <%= config.bin %> <%= command.id %> --connected-org org-alias
        /// Deploy to 'deploy-branch':
        /// <%= config.bin %> <%= command.id %> --connected-org org-alias --branch deploy-branch
        /// Overwrite the remote repository:
        /// <%= config.bin %> <%= command.id %> --connected-org org-alias --force
        /// </example>
        [Command("functions")]
        public SfdxResponse Functions(DeployFunctionsOptions options)
        {
            return ExecuteCommand(nameof(Functions), options);
        }
    }
}

// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method ComputeCollaboratorAdd of class Env.
    /// </summary>
    public class EnvComputeCollaboratorAddOptions : SfOptions
    {
        /// <summary>
        /// [Required] Email address of the Heroku user you're adding as a collaborator.
        /// </summary>
        [SwitchName("--heroku-user")]
        public string HerokuUser { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }
    }

    /// <summary>
    /// Options for the method CreateCompute of class Env.
    /// </summary>
    public class EnvCreateComputeOptions : SfOptions
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
        /// [Optional] Username or alias for the org that the compute environment should be connected to.
        /// </summary>
        [SwitchName("--connected-org")]
        public string ConnectedOrg { get; set; }

        /// <summary>
        /// [Optional] Alias for the created environment.
        /// </summary>
        [SwitchName("--alias")]
        public string Alias { get; set; }
    }

    /// <summary>
    /// Options for the method Delete of class Env.
    /// </summary>
    public class EnvDeleteOptions : SfOptions
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
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--target-compute")]
        public string TargetCompute { get; set; }

        /// <summary>
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--environment")]
        public string Environment { get; set; }

        /// <summary>
        /// [Optional] Confirmation name.
        /// </summary>
        [SwitchName("--confirm")]
        public string Confirm { get; set; }
    }

    /// <summary>
    /// Options for the method Display of class Env.
    /// </summary>
    public class EnvDisplayOptions : SfOptions
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
        /// [Optional] No description for target-env
        /// </summary>
        [SwitchName("--target-env")]
        public string TargetEnv { get; set; }
    }

    /// <summary>
    /// Options for the method List of class Env.
    /// </summary>
    public class EnvListOptions : SfOptions
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
        /// [Optional] No description for all
        /// </summary>
        [SwitchName("--all")]
        public bool? All { get; set; }

        /// <summary>
        /// [Optional] No description for columns
        /// </summary>
        [SwitchName("--columns")]
        public string Columns { get; set; }

        /// <summary>
        /// [Optional] No description for csv
        /// </summary>
        [SwitchName("--csv")]
        public bool? Csv { get; set; }

        /// <summary>
        /// [Optional] No description for filter
        /// </summary>
        [SwitchName("--filter")]
        public string Filter { get; set; }

        /// <summary>
        /// [Optional] No description for no-header
        /// </summary>
        [SwitchName("--no-header")]
        public bool? NoHeader { get; set; }

        /// <summary>
        /// [Optional] No description for no-truncate
        /// </summary>
        [SwitchName("--no-truncate")]
        public bool? NoTruncate { get; set; }

        /// <summary>
        /// [Optional] No description for output
        /// </summary>
        [SwitchName("--output")]
        public string Output { get; set; }

        /// <summary>
        /// [Optional] No description for sort
        /// </summary>
        [SwitchName("--sort")]
        public string Sort { get; set; }
    }

    /// <summary>
    /// Options for the method Log of class Env.
    /// </summary>
    public class EnvLogOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Compute environment name to retrieve logs.
        /// </summary>
        [SwitchName("--target-compute")]
        public string TargetCompute { get; set; }

        /// <summary>
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--environment")]
        public string Environment { get; set; }

        /// <summary>
        /// [Optional] Number of lines to display.
        /// </summary>
        [SwitchName("--num")]
        public string Num { get; set; }
    }

    /// <summary>
    /// Options for the method LogTail of class Env.
    /// </summary>
    public class EnvLogTailOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Compute environment name to retrieve logs.
        /// </summary>
        [SwitchName("--target-compute")]
        public string TargetCompute { get; set; }

        /// <summary>
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--environment")]
        public string Environment { get; set; }
    }

    /// <summary>
    /// Options for the method LogdrainAdd of class Env.
    /// </summary>
    public class EnvLogdrainAddOptions : SfOptions
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
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--target-compute")]
        public string TargetCompute { get; set; }

        /// <summary>
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--environment")]
        public string Environment { get; set; }

        /// <summary>
        /// [Optional] Endpoint that will receive sent logs.
        /// </summary>
        [SwitchName("--drain-url")]
        public string DrainUrl { get; set; }

        /// <summary>
        /// [Optional] Endpoint that will receive sent logs.
        /// </summary>
        [SwitchName("--url")]
        public string Url { get; set; }
    }

    /// <summary>
    /// Options for the method LogdrainList of class Env.
    /// </summary>
    public class EnvLogdrainListOptions : SfOptions
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
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--target-compute")]
        public string TargetCompute { get; set; }

        /// <summary>
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--environment")]
        public string Environment { get; set; }
    }

    /// <summary>
    /// Options for the method LogdrainRemove of class Env.
    /// </summary>
    public class EnvLogdrainRemoveOptions : SfOptions
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
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--target-compute")]
        public string TargetCompute { get; set; }

        /// <summary>
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--environment")]
        public string Environment { get; set; }

        /// <summary>
        /// [Optional] Log drain url to remove.
        /// </summary>
        [SwitchName("--drain-url")]
        public string DrainUrl { get; set; }

        /// <summary>
        /// [Optional] Log drain url to remove.
        /// </summary>
        [SwitchName("--url")]
        public string Url { get; set; }
    }

    /// <summary>
    /// Options for the method Open of class Env.
    /// </summary>
    public class EnvOpenOptions : SfOptions
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
        /// [Optional] No description for path
        /// </summary>
        [SwitchName("--path")]
        public string Path { get; set; }

        /// <summary>
        /// [Optional] No description for url-only
        /// </summary>
        [SwitchName("--url-only")]
        public bool? UrlOnly { get; set; }

        /// <summary>
        /// [Optional] No description for target-env
        /// </summary>
        [SwitchName("--target-env")]
        public string TargetEnv { get; set; }

        /// <summary>
        /// [Optional] You can specify that the environment open in one of the following browsers: Firefox, Safari, Google Chrome, or Windows Edge. If you don’t specify --browser, the environment opens in your default browser. The exact names of the browser applications differ depending on the operating system you're on; check your documentation for details.
        /// </summary>
        [SwitchName("--browser")]
        public string Browser { get; set; }
    }

    /// <summary>
    /// Options for the method VarGet of class Env.
    /// </summary>
    public class EnvVarGetOptions : SfOptions
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
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--target-compute")]
        public string TargetCompute { get; set; }

        /// <summary>
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--environment")]
        public string Environment { get; set; }
    }

    /// <summary>
    /// Options for the method VarList of class Env.
    /// </summary>
    public class EnvVarListOptions : SfOptions
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
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--target-compute")]
        public string TargetCompute { get; set; }

        /// <summary>
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--environment")]
        public string Environment { get; set; }
    }

    /// <summary>
    /// Options for the method VarSet of class Env.
    /// </summary>
    public class EnvVarSetOptions : SfOptions
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
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--target-compute")]
        public string TargetCompute { get; set; }

        /// <summary>
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--environment")]
        public string Environment { get; set; }
    }

    /// <summary>
    /// Options for the method VarUnset of class Env.
    /// </summary>
    public class EnvVarUnsetOptions : SfOptions
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
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--target-compute")]
        public string TargetCompute { get; set; }

        /// <summary>
        /// [Optional] Environment name.
        /// </summary>
        [SwitchName("--environment")]
        public string Environment { get; set; }
    }

    /// <summary>
    /// Env
    /// </summary>
    [CommandClass("env")]
    public class Env : SfCommand
    {
        /// Constructor.
        public Env(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Add a Heroku user as a collaborator on this Functions account, allowing them to attach Heroku add-ons to compute environments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// Add a Heroku user as a collaborator on this Functions account.
        /// $ sf compute collaborator add --heroku-user example@heroku.com
        /// </example>
        [Command("compute collaborator add")]
        public SfResponse ComputeCollaboratorAdd(EnvComputeCollaboratorAddOptions options)
        {
            return ExecuteCommand(nameof(ComputeCollaboratorAdd), options);
        }

        /// <summary>
        /// Create a compute environment for use with Salesforce Functions.
        /// </summary>
        /// <remarks>
        /// Compute environments must be connected to a Salesforce org. By default the command uses your local environment's connected org. Use the '--connected-org' flag to specify a specific org. Run 'sf env list' to see a list of environments.
        /// </remarks>
        /// <example>
        /// Create a compute environment to run Salesforce Functions:
        /// $ sf create compute
        /// Connect the environment to a specific org:
        /// $ sf create compute --connected-org=org-alias
        /// Create an alias for the compute environment:
        /// $ sf create compute --alias environment-alias
        /// </example>
        [Command("create compute")]
        public SfResponse CreateCompute(EnvCreateComputeOptions options = null)
        {
            return ExecuteCommand(nameof(CreateCompute), options);
        }

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <remarks>
        /// You must include the name of the environment to delete using '--target-compute'. Run 'sf env list' to see a list of environments.
        /// 
        /// Running this command will prompt a confirmation. If you want to skip this confirmation, use the '--confirm' flag and the environment alias to skip confirmation.
        /// </remarks>
        /// <example>
        /// Delete a compute environment:
        /// $ sf delete --target-compute environment-alias
        /// Delete without a confirmation step:
        /// $ sf delete --target-compute environment-alias --confirm environment-alias
        /// </example>
        [Command("delete")]
        public SfResponse Delete(EnvDeleteOptions options = null)
        {
            return ExecuteCommand(nameof(Delete), options);
        }

        /// <summary>
        /// Display details about an environment.
        /// </summary>
        /// <remarks>
        /// Specify an environment with either the username you used when you logged into the environment with "sf login", or the alias you gave the environment when you created it. Run "sf env list" to view all your environments and their aliases.
        /// 
        /// Output depends on the type of environment.
        /// </remarks>
        /// <example>
        /// Display details about the "myEnv" environment:
        /// [%- config.bin %] [%- command.id %] --target-env myEnv
        /// </example>
        [Command("display")]
        public SfResponse Display(EnvDisplayOptions options = null)
        {
            return ExecuteCommand(nameof(Display), options);
        }

        /// <summary>
        /// List the environments you’ve created or logged into.
        /// </summary>
        /// <remarks>
        /// By default, the command displays active environments.
        /// 
        /// Output is displayed in multiple tables, one for each environment type.
        /// 
        /// The compute environment table shows the alias, information about the connected orgs, the project name, and more.
        /// 
        /// Use the table manipulation flags, such as --filter and --sort, to change how the data is displayed.
        /// 
        /// Run "sf env display" to view details about a specific environment.
        /// </remarks>
        /// <example>
        /// List all active environments:
        /// $ sf list
        /// List both active and inactive environments:
        /// $ sf list --all
        /// Don't truncate the displayed output and instead wrap text that's wider than your terminal:
        /// $ sf list --no-truncate
        /// Display only the table data, not the headers, in comma-separated value (csv) format:
        /// $ sf list --csv --no-header
        /// </example>
        [Command("list")]
        public SfResponse List(EnvListOptions options = null)
        {
            return ExecuteCommand(nameof(List), options);
        }

        /// <summary>
        /// Stream log output for an environment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// Stream log output:
        /// $ sf log --target-compute environment-alias
        /// </example>
        [Command("log")]
        public SfResponse Log(EnvLogOptions options = null)
        {
            return ExecuteCommand(nameof(Log), options);
        }

        /// <summary>
        /// Stream log output for an environment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// Stream log output:
        /// $ sf log tail --target-compute environment-alias
        /// </example>
        [Command("log tail")]
        public SfResponse LogTail(EnvLogTailOptions options = null)
        {
            return ExecuteCommand(nameof(LogTail), options);
        }

        /// <summary>
        /// Add log drain to a specified environment.
        /// </summary>
        /// <remarks>
        /// Both '--target-compute' and '--url' are required flags. '--url' should be a HTTP or HTTPS URL that can receive the log drain messages.
        /// </remarks>
        /// <example>
        /// Add a log drain:
        /// $ sf logdrain add --target-compute environment-name --url https://path/to/logdrain
        /// </example>
        [Command("logdrain add")]
        public SfResponse LogdrainAdd(EnvLogdrainAddOptions options = null)
        {
            return ExecuteCommand(nameof(LogdrainAdd), options);
        }

        /// <summary>
        /// List log drains connected to a specified environment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// List log drains:
        /// $ sf logdrain list --target-compute environment-alias
        /// List log drains as json:
        /// $ sf logdrain list --target-compute environment-alias --json
        /// </example>
        [Command("logdrain list")]
        public SfResponse LogdrainList(EnvLogdrainListOptions options = null)
        {
            return ExecuteCommand(nameof(LogdrainList), options);
        }

        /// <summary>
        /// Remove log drain from a specified environment.
        /// </summary>
        /// <remarks>
        /// Both '--target-compute' and '--drain-url' are required flags.
        /// </remarks>
        /// <example>
        /// Remove a logdrain:
        /// $ sf logdrain remove --target-compute environment-alias --url https://path/to/logdrain
        /// </example>
        [Command("logdrain remove")]
        public SfResponse LogdrainRemove(EnvLogdrainRemoveOptions options = null)
        {
            return ExecuteCommand(nameof(LogdrainRemove), options);
        }

        /// <summary>
        /// Open an environment in a web browser.
        /// </summary>
        /// <remarks>
        /// Each of your environments is associated with an instance URL, such as https://login.salesforce.com. To open a specific web page, specify the portion of the URL after "[URL]/" with the --path flag.
        /// </remarks>
        /// <example>
        /// Open the compute environment with alias "test-compute":
        /// $ sf open --target-env test-compute
        /// View the URL but don't launch it in a browser:
        /// $ sf open --target-env test-compute --url-only
        /// Open the environment in the Google Chrome browser:
        /// $ sf open --target-env test-compute --url-only --browser chrome
        /// </example>
        [Command("open")]
        public SfResponse Open(EnvOpenOptions options = null)
        {
            return ExecuteCommand(nameof(Open), options);
        }

        /// <summary>
        /// Display a single config variable for an environment.
        /// </summary>
        /// <remarks>
        /// You must provide the '--target-compute' flag and the key to retrieve.
        /// </remarks>
        /// <example>
        /// Get a config variable:
        /// $ sf var get [KEY] --target-compute environment-alias
        /// </example>
        [Command("var get")]
        public SfResponse VarGet(EnvVarGetOptions options = null)
        {
            return ExecuteCommand(nameof(VarGet), options);
        }

        /// <summary>
        /// List your environment's config vars in a table.
        /// </summary>
        /// <remarks>
        /// Use the '--json' flag to return config vars in JSON format.
        /// </remarks>
        /// <example>
        /// List config vars:
        /// $ sf var list --target-compute environment-alias
        /// List in JSON format:
        /// $ sf var list --target-compute environment-alias --json
        /// </example>
        [Command("var list")]
        public SfResponse VarList(EnvVarListOptions options = null)
        {
            return ExecuteCommand(nameof(VarList), options);
        }

        /// <summary>
        /// Set a single config value for an environment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// Set a config value:
        /// $ sf var set [KEY]=[VALUE] --target-compute environment-alias
        /// </example>
        [Command("var set")]
        public SfResponse VarSet(EnvVarSetOptions options = null)
        {
            return ExecuteCommand(nameof(VarSet), options);
        }

        /// <summary>
        /// Unset a single config value for an environment.
        /// </summary>
        /// <remarks>
        /// Run 'sf env var list' to see a list of config values that can be unset.
        /// </remarks>
        /// <example>
        /// Unset a value:
        /// $ sf var unset --target-compute environment-alias
        /// </example>
        [Command("var unset")]
        public SfResponse VarUnset(EnvVarUnsetOptions options = null)
        {
            return ExecuteCommand(nameof(VarUnset), options);
        }
    }
}

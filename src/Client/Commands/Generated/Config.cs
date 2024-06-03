// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Get of class Config.
    /// </summary>
    public class ConfigGetOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method List of class Config.
    /// </summary>
    public class ConfigListOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method Set of class Config.
    /// </summary>
    public class ConfigSetOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for global
        /// </summary>
        [SwitchName("--global")]
        public bool? Global { get; set; }
    }

    /// <summary>
    /// Options for the method Unset of class Config.
    /// </summary>
    public class ConfigUnsetOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for global
        /// </summary>
        [SwitchName("--global")]
        public bool? Global { get; set; }
    }

    /// <summary>
    /// Config
    /// </summary>
    [CommandClass("config")]
    public class Config : SfCommand
    {
        /// Constructor.
        public Config(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Get the value of a configuration variable.
        /// </summary>
        /// <remarks>
        /// Run "sf config list" to see the configuration variables you've already set and their level (local or global).
        /// 
        /// Run "sf config set" to set a configuration variable. For the full list of available configuration variables, see https://developer.salesforce.com/docs/atlas.en-us.sfdx_setup.meta/sfdx_setup/sfdx_dev_cli_config_values.htm.
        /// </remarks>
        /// <example>
        /// Get the value of the "target-org" configuration variable.
        /// $ sf get target-org
        /// Get multiple configuration variables and display whether they're set locally or globally:
        /// $ sf get target-org api-version --verbose
        /// </example>
        [Command("get")]
        public SfResponse Get(ConfigGetOptions options = null)
        {
            return ExecuteCommand(nameof(Get), options);
        }

        /// <summary>
        /// List the configuration variables that you've previously set.
        /// </summary>
        /// <remarks>
        /// A config variable can be global or local, depending on whether you used the --global flag when you set it. Local config variables apply only to the current project and override global config variables, which apply to all projects.  You can set all config variables as environment variables. Environment variables override their equivalent local and global config variables.
        /// 
        /// The output of this command takes into account your current context. For example, let's say you run this command from a Salesforce DX project in which you've locally set the "target-org" config variable. The command displays the local value, even if you've also set "target-org" globally. If you haven't set the config variable locally, then the global value is displayed, if set. If you set the SF_TARGET_ORG environment variable, it's displayed as such and overrides any locally or globally set "target-org" config variable. 
        /// 
        /// For the full list of available configuration variables, see https://developer.salesforce.com/docs/atlas.en-us.sfdx_setup.meta/sfdx_setup/sfdx_dev_cli_config_values.htm.
        /// </remarks>
        /// <example>
        /// List the global and local configuration variables that apply to your current context:
        /// $ $ sf list
        /// </example>
        [Command("list")]
        public SfResponse List(ConfigListOptions options = null)
        {
            return ExecuteCommand(nameof(List), options);
        }

        /// <summary>
        /// Set one or more configuration variables, such as your default org.
        /// </summary>
        /// <remarks>
        /// Use configuration variables to set CLI defaults, such as your default org or the API version you want the CLI to use. For example, if you set the "target-org" configuration variable, you don't need to specify it as a "sf deploy metadata" flag if you're deploying to your default org.
        /// 
        /// Local configuration variables apply only to your current project. Global variables, specified with the --global flag, apply in any Salesforce DX project.
        /// 
        /// The resolution order if you've set a flag value in multiple ways is as follows:
        /// 
        ///     1. Flag value specified at the command line.
        ///     2. Local (project-level) configuration variable.
        ///     3. Global configuration variable.
        /// 
        /// Run "sf config list" to see the configuration variables you've already set and their level (local or global).
        /// 
        /// If you're setting a single config variable, you don't need to use an equal sign between the variable and value. But you must use the equal sign if setting multiple config variables.
        /// 
        /// For the full list of available configuration variables, see https://developer.salesforce.com/docs/atlas.en-us.sfdx_setup.meta/sfdx_setup/sfdx_dev_cli_config_values.htm.
        /// </remarks>
        /// <example>
        /// Set the local target-org configuration variable to an org username:
        /// $ sf set target-org me@my.org
        /// Set the local target-org configuration variable to an alias:
        /// $ sf set target-org my-scratch-org
        /// Set the global target-org and target-dev-hub configuration variables using aliases:
        /// $ sf set --global target-org=my-scratch-org target-dev-hub=my-dev-hub
        /// </example>
        [Command("set")]
        public SfResponse Set(ConfigSetOptions options = null)
        {
            return ExecuteCommand(nameof(Set), options);
        }

        /// <summary>
        /// Unset local or global configuration variables.
        /// </summary>
        /// <remarks>
        /// Local configuration variables apply only to your current project. Global configuration variables apply in any Salesforce DX project.
        /// 
        /// For the full list of available configuration variables, see https://developer.salesforce.com/docs/atlas.en-us.sfdx_setup.meta/sfdx_setup/sfdx_dev_cli_config_values.htm.
        /// </remarks>
        /// <example>
        /// Unset the local "target-org" configuration variable:
        /// $ sf unset target-org
        /// Unset multiple configuration variables globally:
        /// $ sf unset target-org api-version --global
        /// </example>
        [Command("unset")]
        public SfResponse Unset(ConfigUnsetOptions options = null)
        {
            return ExecuteCommand(nameof(Unset), options);
        }
    }
}

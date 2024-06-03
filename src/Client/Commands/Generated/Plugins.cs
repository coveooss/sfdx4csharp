// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Execute of class Plugins.
    /// </summary>
    public class PluginsExecuteOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Show core plugins.
        /// </summary>
        [SwitchName("--core")]
        public bool? Core { get; set; }
    }

    /// <summary>
    /// Options for the method Install of class Plugins.
    /// </summary>
    public class PluginsInstallOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Force npm to fetch remote resources even if a local copy exists on disk.
        /// </summary>
        [SwitchName("--force")]
        public bool? Force { get; set; }

        /// <summary>
        /// [Optional] Show CLI help.
        /// </summary>
        [SwitchName("--help")]
        public bool? Help { get; set; }

        /// <summary>
        /// [Optional] No description for jit
        /// </summary>
        [SwitchName("--jit")]
        public bool? Jit { get; set; }

        /// <summary>
        /// [Optional] Silences npm output.
        /// </summary>
        [SwitchName("--silent")]
        public bool? Silent { get; set; }

        /// <summary>
        /// [Optional] Show verbose npm output.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method Discover of class Plugins.
    /// </summary>
    public class PluginsDiscoverOptions : SfOptions
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
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }
    }

    /// <summary>
    /// Options for the method Inspect of class Plugins.
    /// </summary>
    public class PluginsInspectOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Show CLI help.
        /// </summary>
        [SwitchName("--help")]
        public bool? Help { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method Link of class Plugins.
    /// </summary>
    public class PluginsLinkOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Show CLI help.
        /// </summary>
        [SwitchName("--help")]
        public bool? Help { get; set; }

        /// <summary>
        /// [Optional] Install dependencies after linking the plugin.
        /// </summary>
        [SwitchName("--install")]
        public bool? Install { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method Uninstall of class Plugins.
    /// </summary>
    public class PluginsUninstallOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Show CLI help.
        /// </summary>
        [SwitchName("--help")]
        public bool? Help { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method Reset of class Plugins.
    /// </summary>
    public class PluginsResetOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for hard
        /// </summary>
        [SwitchName("--hard")]
        public bool? Hard { get; set; }

        /// <summary>
        /// [Optional] No description for reinstall
        /// </summary>
        [SwitchName("--reinstall")]
        public bool? Reinstall { get; set; }
    }

    /// <summary>
    /// Options for the method TrustVerify of class Plugins.
    /// </summary>
    public class PluginsTrustVerifyOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for npm
        /// </summary>
        [SwitchName("--npm")]
        public string Npm { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for registry
        /// </summary>
        [SwitchName("--registry")]
        public string Registry { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method Update of class Plugins.
    /// </summary>
    public class PluginsUpdateOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Show CLI help.
        /// </summary>
        [SwitchName("--help")]
        public bool? Help { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Plugins
    /// </summary>
    [CommandClass("plugins")]
    public class Plugins : SfCommand
    {
        /// Constructor.
        public Plugins(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// List installed plugins.
        /// </remarks>
        /// <example>
        /// $ sf 
        /// </example>
        [Command("")]
        public SfResponse Execute(PluginsExecuteOptions options = null)
        {
            return ExecuteCommand(nameof(Execute), options);
        }

        /// <summary>
        /// Installs a plugin into $ sf.
        /// </summary>
        /// <remarks>
        /// Uses bundled npm executable to install plugins into [%= config.dataDir %]
        /// 
        /// Installation of a user-installed plugin will override a core plugin.
        /// 
        /// Use the [%= config.scopedEnvVarKey('NPM_LOG_LEVEL') %] environment variable to set the npm loglevel.
        /// Use the [%= config.scopedEnvVarKey('NPM_REGISTRY') %] environment variable to set the npm registry.
        /// </remarks>
        /// <example>
        /// Install a plugin from npm registry.
        /// $ sf install [%- config.pjson.oclif.examplePlugin || "myplugin" %] 
        /// 
        /// </example>
        [Command("install")]
        public SfResponse Install(PluginsInstallOptions options = null)
        {
            return ExecuteCommand(nameof(Install), options);
        }

        /// <summary>
        /// See a list of 3rd-party sf plugins you can install.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// $ sf discover
        /// </example>
        [Command("discover")]
        public SfResponse Discover(PluginsDiscoverOptions options = null)
        {
            return ExecuteCommand(nameof(Discover), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Displays installation properties of a plugin.
        /// </remarks>
        /// <example>
        /// $ sf inspect [%- config.pjson.oclif.examplePlugin || "myplugin" %] 
        /// plugins:inspect PLUGIN...
        /// </example>
        [Command("inspect")]
        public SfResponse Inspect(PluginsInspectOptions options = null)
        {
            return ExecuteCommand(nameof(Inspect), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Links a plugin into the CLI for development.
        /// Installation of a linked plugin will override a user-installed or core plugin.
        /// 
        /// e.g. If you have a user-installed or core plugin that has a 'hello' command, installing a linked plugin with a 'hello' command will override the user-installed or core plugin implementation. This is useful for development work.
        /// 
        /// </remarks>
        /// <example>
        /// $ sf link [%- config.pjson.oclif.examplePlugin || "myplugin" %] 
        /// </example>
        [Command("link")]
        public SfResponse Link(PluginsLinkOptions options = null)
        {
            return ExecuteCommand(nameof(Link), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Removes a plugin from the CLI.
        /// </remarks>
        /// <example>
        /// $ sf uninstall [%- config.pjson.oclif.examplePlugin || "myplugin" %]
        /// </example>
        [Command("uninstall")]
        public SfResponse Uninstall(PluginsUninstallOptions options = null)
        {
            return ExecuteCommand(nameof(Uninstall), options);
        }

        /// <summary>
        /// Remove all user-installed and linked plugins.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// </example>
        [Command("reset")]
        public SfResponse Reset(PluginsResetOptions options = null)
        {
            return ExecuteCommand(nameof(Reset), options);
        }

        /// <summary>
        /// Validate a digital signature.
        /// </summary>
        /// <remarks>
        /// Verifies the digital signature on an npm package matches the signature and key stored at the expected URLs.
        /// </remarks>
        /// <example>
        /// $ sf trust verify --npm @scope/npmName --registry https://npm.pkg.github.com
        /// $ sf trust verify --npm @scope/npmName
        /// </example>
        [Command("trust verify")]
        public SfResponse TrustVerify(PluginsTrustVerifyOptions options)
        {
            return ExecuteCommand(nameof(TrustVerify), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update installed plugins.
        /// </remarks>
        /// <example>
        /// 
        /// </example>
        [Command("update")]
        public SfResponse Update(PluginsUpdateOptions options = null)
        {
            return ExecuteCommand(nameof(Update), options);
        }
    }
}

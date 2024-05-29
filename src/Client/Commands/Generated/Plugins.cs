// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Install of class Plugins.
    /// </summary>
    public class PluginsInstallOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
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
    public class PluginsDiscoverOptions : SfdxOptions
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
        /// [Required] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }
    }

    /// <summary>
    /// Options for the method Inspect of class Plugins.
    /// </summary>
    public class PluginsInspectOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
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
    public class PluginsLinkOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
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
    public class PluginsUninstallOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
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
    public class PluginsResetOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
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
    public class PluginsTrustVerifyOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for npm
        /// </summary>
        [SwitchName("--npm")]
        public string Npm { get; set; }

        /// <summary>
        /// [Required] No description for registry
        /// </summary>
        [SwitchName("--registry")]
        public string Registry { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method Update of class Plugins.
    /// </summary>
    public class PluginsUpdateOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
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
    public class Plugins : SfdxCommand
    {
        /// Constructor.
        public Plugins(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Uses bundled npm executable to install plugins into <%= config.dataDir %>
        /// 
        /// Installation of a user-installed plugin will override a core plugin.
        /// 
        /// Use the <%= config.scopedEnvVarKey('NPM_LOG_LEVEL') %> environment variable to set the npm loglevel.
        /// Use the <%= config.scopedEnvVarKey('NPM_REGISTRY') %> environment variable to set the npm registry.
        /// </summary>
        /// <remarks>
        /// Uses bundled npm executable to install plugins into <%= config.dataDir %>
        /// 
        /// Installation of a user-installed plugin will override a core plugin.
        /// 
        /// Use the <%= config.scopedEnvVarKey('NPM_LOG_LEVEL') %> environment variable to set the npm loglevel.
        /// Use the <%= config.scopedEnvVarKey('NPM_REGISTRY') %> environment variable to set the npm registry.
        /// </remarks>
        /// <example>
        /// 
        /// [object Object]
        /// [object Object]
        /// [object Object]
        /// </example>
        [Command("install")]
        public SfdxResponse Install(PluginsInstallOptions options)
        {
            return ExecuteCommand(nameof(Install), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// <%= config.bin %> <%= command.id %>
        /// </example>
        [Command("discover")]
        public SfdxResponse Discover(PluginsDiscoverOptions options)
        {
            return ExecuteCommand(nameof(Discover), options);
        }

        /// <summary>
        /// Displays installation properties of a plugin.
        /// </summary>
        /// <remarks>
        /// Displays installation properties of a plugin.
        /// </remarks>
        /// <example>
        /// 
        /// <%= config.bin %> <%= command.id %> <%- config.pjson.oclif.examplePlugin || "myplugin" %> 
        /// plugins:inspect PLUGIN...
        /// </example>
        [Command("inspect")]
        public SfdxResponse Inspect(PluginsInspectOptions options)
        {
            return ExecuteCommand(nameof(Inspect), options);
        }

        /// <summary>
        /// Links a plugin into the CLI for development.
        /// Installation of a linked plugin will override a user-installed or core plugin.
        /// 
        /// e.g. If you have a user-installed or core plugin that has a 'hello' command, installing a linked plugin with a 'hello' command will override the user-installed or core plugin implementation. This is useful for development work.
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
        /// 
        /// <%= config.bin %> <%= command.id %> <%- config.pjson.oclif.examplePlugin || "myplugin" %> 
        /// </example>
        [Command("link")]
        public SfdxResponse Link(PluginsLinkOptions options)
        {
            return ExecuteCommand(nameof(Link), options);
        }

        /// <summary>
        /// Removes a plugin from the CLI.
        /// </summary>
        /// <remarks>
        /// Removes a plugin from the CLI.
        /// </remarks>
        /// <example>
        /// 
        /// <%= config.bin %> <%= command.id %> <%- config.pjson.oclif.examplePlugin || "myplugin" %>
        /// </example>
        [Command("uninstall")]
        public SfdxResponse Uninstall(PluginsUninstallOptions options)
        {
            return ExecuteCommand(nameof(Uninstall), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// 
        /// </example>
        [Command("reset")]
        public SfdxResponse Reset(PluginsResetOptions options)
        {
            return ExecuteCommand(nameof(Reset), options);
        }

        /// <summary>
        /// Verifies the digital signature on an npm package matches the signature and key stored at the expected URLs.
        /// </summary>
        /// <remarks>
        /// Verifies the digital signature on an npm package matches the signature and key stored at the expected URLs.
        /// </remarks>
        /// <example>
        /// 
        /// <%= config.bin %> <%= command.id %> --npm @scope/npmName --registry https://npm.pkg.github.com
        /// <%= config.bin %> <%= command.id %> --npm @scope/npmName
        /// </example>
        [Command("trust verify")]
        public SfdxResponse TrustVerify(PluginsTrustVerifyOptions options)
        {
            return ExecuteCommand(nameof(TrustVerify), options);
        }

        /// <summary>
        /// Update installed plugins.
        /// </summary>
        /// <remarks>
        /// Update installed plugins.
        /// </remarks>
        /// <example>
        /// 
        /// 
        /// </example>
        [Command("update")]
        public SfdxResponse Update(PluginsUpdateOptions options)
        {
            return ExecuteCommand(nameof(Update), options);
        }
    }
}

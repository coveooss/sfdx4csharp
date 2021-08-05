// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method generate of class Plugins.
    /// </summary>
    public class PluginsGenerateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Use defaults for every setting
        /// </summary>
        [SwitchName("--defaults")]
        public bool? defaults { get; set; }

        /// <summary>
        /// [Optional] Overwrite existing files
        /// </summary>
        [SwitchName("--force")]
        public bool? force { get; set; }
    }

    /// <summary>
    /// Options for the method inspect of class Plugins.
    /// </summary>
    public class PluginsInspectOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Show CLI help
        /// </summary>
        [SwitchName("--help")]
        public bool? help { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method install of class Plugins.
    /// </summary>
    public class PluginsInstallOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Show CLI help
        /// </summary>
        [SwitchName("--help")]
        public bool? help { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Optional] Yarn install with force flag
        /// </summary>
        [SwitchName("--force")]
        public bool? force { get; set; }
    }

    /// <summary>
    /// Options for the method link of class Plugins.
    /// </summary>
    public class PluginsLinkOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Show CLI help
        /// </summary>
        [SwitchName("--help")]
        public bool? help { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method uninstall of class Plugins.
    /// </summary>
    public class PluginsUninstallOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Show CLI help
        /// </summary>
        [SwitchName("--help")]
        public bool? help { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method update of class Plugins.
    /// </summary>
    public class PluginsUpdateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Show CLI help
        /// </summary>
        [SwitchName("--help")]
        public bool? help { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Plugins
    /// </summary>
    [CommandClass("plugins")]
    public class Plugins : SFDXCommand
    {
        /// Constructor.
        public Plugins(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// create a new sfdx-cli plugin
        /// </summary>
        /// <remarks>
        /// create a new sfdx-cli plugin
        /// </remarks>
        /// <example>
        /// 
        /// 
        /// </example>
        [Command("generate")]
        public SFDXResponse Generate(PluginsGenerateOptions p_Options)
        {
            return ExecuteCommand<PluginsGenerateOptions>(nameof(Generate), p_Options);
        }

        /// <summary>
        /// displays installation properties of a plugin
        /// </summary>
        /// <remarks>
        /// displays installation properties of a plugin
        /// </remarks>
        /// <example>
        /// 
        /// $ <%= config.bin %> plugins:inspect <%- config.pjson.oclif.examplePlugin || "myplugin" %> 
        /// plugins:inspect PLUGIN...
        /// </example>
        [Command("inspect")]
        public SFDXResponse Inspect(PluginsInspectOptions p_Options)
        {
            return ExecuteCommand<PluginsInspectOptions>(nameof(Inspect), p_Options);
        }

        /// <summary>
        /// installs a plugin into the CLI
        /// Can be installed from npm or a git url.
        /// 
        /// Installation of a user-installed plugin will override a core plugin.
        /// 
        /// e.g. If you have a core plugin that has a 'hello' command, installing a user-installed plugin with a 'hello' command will override the core plugin implementation. This is useful if a user needs to update core plugin functionality in the CLI without the need to patch and update the whole CLI.
        /// 
        /// </summary>
        /// <remarks>
        /// installs a plugin into the CLI
        /// Can be installed from npm or a git url.
        /// 
        /// Installation of a user-installed plugin will override a core plugin.
        /// 
        /// e.g. If you have a core plugin that has a 'hello' command, installing a user-installed plugin with a 'hello' command will override the core plugin implementation. This is useful if a user needs to update core plugin functionality in the CLI without the need to patch and update the whole CLI.
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// $ <%= config.bin %> plugins:install <%- config.pjson.oclif.examplePlugin || "myplugin" %> 
        /// $ <%= config.bin %> plugins:install https://github.com/someuser/someplugin
        /// $ <%= config.bin %> plugins:install someuser/someplugin
        /// plugins:install PLUGIN...
        /// </example>
        [Command("install")]
        public SFDXResponse Install(PluginsInstallOptions p_Options)
        {
            return ExecuteCommand<PluginsInstallOptions>(nameof(Install), p_Options);
        }

        /// <summary>
        /// links a plugin into the CLI for development
        /// Installation of a linked plugin will override a user-installed or core plugin.
        /// 
        /// e.g. If you have a user-installed or core plugin that has a 'hello' command, installing a linked plugin with a 'hello' command will override the user-installed or core plugin implementation. This is useful for development work.
        /// 
        /// </summary>
        /// <remarks>
        /// links a plugin into the CLI for development
        /// Installation of a linked plugin will override a user-installed or core plugin.
        /// 
        /// e.g. If you have a user-installed or core plugin that has a 'hello' command, installing a linked plugin with a 'hello' command will override the user-installed or core plugin implementation. This is useful for development work.
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// $ <%= config.bin %> plugins:link <%- config.pjson.oclif.examplePlugin || "myplugin" %> 
        /// plugins:link PLUGIN
        /// </example>
        [Command("link")]
        public SFDXResponse Link(PluginsLinkOptions p_Options)
        {
            return ExecuteCommand<PluginsLinkOptions>(nameof(Link), p_Options);
        }

        /// <summary>
        /// removes a plugin from the CLI
        /// </summary>
        /// <remarks>
        /// removes a plugin from the CLI
        /// </remarks>
        /// <example>
        /// 
        ///   Example:
        ///     $ <%- config.bin %> plugins:uninstall <%- config.pjson.oclif.examplePlugin || "myplugin" %>
        ///   
        /// plugins:uninstall PLUGIN...
        /// </example>
        [Command("uninstall")]
        public SFDXResponse Uninstall(PluginsUninstallOptions p_Options)
        {
            return ExecuteCommand<PluginsUninstallOptions>(nameof(Uninstall), p_Options);
        }

        /// <summary>
        /// update installed plugins
        /// </summary>
        /// <remarks>
        /// update installed plugins
        /// </remarks>
        /// <example>
        /// 
        /// 
        /// </example>
        [Command("update")]
        public SFDXResponse Update(PluginsUpdateOptions p_Options)
        {
            return ExecuteCommand<PluginsUpdateOptions>(nameof(Update), p_Options);
        }
    }
}

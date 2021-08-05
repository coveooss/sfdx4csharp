// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method get of class Config.
    /// </summary>
    public class ConfigGetOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Optional] Emit additional command output to stdout
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method list of class Config.
    /// </summary>
    public class ConfigListOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method set of class Config.
    /// </summary>
    public class ConfigSetOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Optional] Sets the configuration variables globally, so they can be used from any directory.
        /// </summary>
        [SwitchName("--global")]
        public bool? global { get; set; }
    }

    /// <summary>
    /// Options for the method unset of class Config.
    /// </summary>
    public class ConfigUnsetOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Optional] Unsets the configuration variables globally, so they can be used from any directory.
        /// </summary>
        [SwitchName("--global")]
        public bool? global { get; set; }
    }

    /// <summary>
    /// Config
    /// </summary>
    [CommandClass("config")]
    public class Config : SFDXCommand
    {
        /// Constructor.
        public Config(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// get config var values for given names
        /// Gets the Salesforce CLI configuration values for your default scratch org, your default Dev Hub org, your default instance URL, or any combination of the three. To see your default scratch org username, include 'defaultusername'.
        /// To see your default Dev Hub, include 'defaultdevhubusername'.
        /// To see your default instance URL, include 'instanceUrl'.
        /// To see the locations where your values are set, include the --verbose flag.
        /// </summary>
        /// <remarks>
        /// get config var values for given names
        /// Gets the Salesforce CLI configuration values for your default scratch org, your default Dev Hub org, your default instance URL, or any combination of the three. To see your default scratch org username, include 'defaultusername'.
        /// To see your default Dev Hub, include 'defaultdevhubusername'.
        /// To see your default instance URL, include 'instanceUrl'.
        /// To see the locations where your values are set, include the --verbose flag.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx config:get defaultusername
        /// sfdx config:get defaultusername defaultdevhubusername instanceUrl
        /// sfdx config:get defaultusername defaultdevhubusername --verbose
        /// config:get [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("get")]
        public SFDXResponse Get(ConfigGetOptions p_Options)
        {
            return ExecuteCommand<ConfigGetOptions>(nameof(Get), p_Options);
        }

        /// <summary>
        /// lists the config variables that the Salesforce CLI uses for various commands and tasks.
        /// </summary>
        /// <remarks>
        /// lists the config variables that the Salesforce CLI uses for various commands and tasks.
        /// </remarks>
        /// <example>
        /// 
        /// config:list [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("list")]
        public SFDXResponse List(ConfigListOptions p_Options)
        {
            return ExecuteCommand<ConfigListOptions>(nameof(List), p_Options);
        }

        /// <summary>
        /// sets the configuration variables that the Salesforce CLI uses for various commands and tasks.
        ///  Local variables apply only to your current project. Global variables apply in any directory.
        /// </summary>
        /// <remarks>
        /// sets the configuration variables that the Salesforce CLI uses for various commands and tasks.
        ///  Local variables apply only to your current project. Global variables apply in any directory.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx config:set defaultusername=me@my.org defaultdevhubusername=me@myhub.org
        /// sfdx config:set defaultdevhubusername=me@myhub.org -g
        /// config:set name=value... [-g] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("set")]
        public SFDXResponse Set(ConfigSetOptions p_Options)
        {
            return ExecuteCommand<ConfigSetOptions>(nameof(Set), p_Options);
        }

        /// <summary>
        /// unsets the local and global configuration variables for the Salesforce CLI.
        ///  Local variables apply only to your current project. Global variables apply in any directory.
        /// </summary>
        /// <remarks>
        /// unsets the local and global configuration variables for the Salesforce CLI.
        ///  Local variables apply only to your current project. Global variables apply in any directory.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx config:unset defaultusername defaultdevhubusername
        /// sfdx config:unset defaultdevhubusername -g
        /// config:unset [-g] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("unset")]
        public SFDXResponse Unset(ConfigUnsetOptions p_Options)
        {
            return ExecuteCommand<ConfigUnsetOptions>(nameof(Unset), p_Options);
        }
    }
}

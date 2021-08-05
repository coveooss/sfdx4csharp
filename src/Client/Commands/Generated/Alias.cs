// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method list of class Alias.
    /// </summary>
    public class AliasListOptions : SFDXOptions
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
    /// Options for the method set of class Alias.
    /// </summary>
    public class AliasSetOptions : SFDXOptions
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
    /// Options for the method unset of class Alias.
    /// </summary>
    public class AliasUnsetOptions : SFDXOptions
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
    /// Alias
    /// </summary>
    [CommandClass("alias")]
    public class Alias : SFDXCommand
    {
        /// Constructor.
        public Alias(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// list username aliases for the Salesforce CLI
        /// </summary>
        /// <remarks>
        /// list username aliases for the Salesforce CLI
        /// </remarks>
        /// <example>
        /// 
        /// alias:list [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("list")]
        public SFDXResponse List(AliasListOptions p_Options)
        {
            return ExecuteCommand<AliasListOptions>(nameof(List), p_Options);
        }

        /// <summary>
        /// set username aliases for the Salesforce CLI
        /// You can associate an alias with only one username at a time. If you’ve set an alias multiple times, the alias points to the most recent username.
        /// </summary>
        /// <remarks>
        /// set username aliases for the Salesforce CLI
        /// You can associate an alias with only one username at a time. If you’ve set an alias multiple times, the alias points to the most recent username.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx alias:set YourAlias=username@example.com
        /// sfdx alias:set YourAlias=username@example.com YourOtherAlias=devhub@example.com
        /// alias:set name=value... [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("set")]
        public SFDXResponse Set(AliasSetOptions p_Options)
        {
            return ExecuteCommand<AliasSetOptions>(nameof(Set), p_Options);
        }

        /// <summary>
        /// unsets aliases for the Salesforce CLI
        /// </summary>
        /// <remarks>
        /// unsets aliases for the Salesforce CLI
        /// </remarks>
        /// <example>
        /// 
        /// alias:unset [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("unset")]
        public SFDXResponse Unset(AliasUnsetOptions p_Options)
        {
            return ExecuteCommand<AliasUnsetOptions>(nameof(Unset), p_Options);
        }
    }
}

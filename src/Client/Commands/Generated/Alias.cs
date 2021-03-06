// Generated on Tue Mar 10 2020 using sfdx-cli/7.43.1 win32-x64 node-v12.16.1. DO NOT MODIFY
// Copyright (c) 2005-2020, Coveo Solutions Inc.

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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
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
        /// [Required] The key pair expression for the command
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Alias
    /// </summary>
    [CommandClass("force:alias")]
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
        /// Lists the aliases that the Salesforce CLI can use for various commands and tasks.
        /// </remarks>
        /// <example>
        /// Example: 
        ///    $ sfdx force:alias:list
        /// force:alias:list [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("list")]
        public SFDXResponse List(AliasListOptions p_Options = null)
        {
            return ExecuteCommand<AliasListOptions>(nameof(List), p_Options);
        }

        /// <summary>
        /// set username aliases for the Salesforce CLI
        /// </summary>
        /// <remarks>
        /// Sets an alias that the Salesforce CLI can use for various commands and tasks.
        /// </remarks>
        /// <example>
        /// You can associate an alias with only one username at a time. If you’ve set an alias multiple times, the alias points to the most recent username.
        /// 
        /// To delete an alias, run "sfdx force:alias:set" with no username.
        /// 
        /// Examples:
        ///    $ sfdx force:alias:set YourAlias=username@example.com
        ///    $ sfdx force:alias:set YourAlias=username@example.com YourOtherAlias=devhub@example.com
        ///    $ sfdx force:alias:set AliasToDelete=
        /// force:alias:set name=value... [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("set")]
        public SFDXResponse Set(AliasSetOptions p_Options)
        {
            return ExecuteCommand<AliasSetOptions>(nameof(Set), p_Options);
        }
    }
}

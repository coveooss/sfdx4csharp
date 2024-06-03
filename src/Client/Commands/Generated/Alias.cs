// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method List of class Alias.
    /// </summary>
    public class AliasListOptions : SfOptions
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
    /// Options for the method Set of class Alias.
    /// </summary>
    public class AliasSetOptions : SfOptions
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
    /// Options for the method Unset of class Alias.
    /// </summary>
    public class AliasUnsetOptions : SfOptions
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
        /// [Optional] No description for all
        /// </summary>
        [SwitchName("--all")]
        public bool? All { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }
    }

    /// <summary>
    /// Alias
    /// </summary>
    [CommandClass("alias")]
    public class Alias : SfCommand
    {
        /// Constructor.
        public Alias(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// List all aliases currently set on your local computer.
        /// </summary>
        /// <remarks>
        /// Aliases are global, which means that you can use all the listed aliases in any Salesforce DX project on your computer.
        /// </remarks>
        /// <example>
        /// List all the aliases you've set:
        /// $ sf list
        /// </example>
        [Command("list")]
        public SfResponse List(AliasListOptions options = null)
        {
            return ExecuteCommand(nameof(List), options);
        }

        /// <summary>
        /// Set one or more aliases on your local computer.
        /// </summary>
        /// <remarks>
        /// Aliases are user-defined short names that make it easier to use the CLI. For example, users often set an alias for a scratch org usernames because they're long and unintuitive.  Check the --help of a CLI command to determine where you can use an alias.
        /// 
        /// You can associate an alias with only one value at a time. If you set an alias multiple times, the alias points to the most recent value. Aliases are global; after you set an alias, you can use it in any Salesforce DX project on your computer.
        /// 
        /// Use quotes to specify an alias value that contains spaces. You typically use an equal sign to set your alias, although you don't need it if you're setting a single alias in a command.
        /// </remarks>
        /// <example>
        /// Set an alias for a scratch org username:
        /// $ sf set my-scratch-org=test-sadbiytjsupn@example.com
        /// Set multiple aliases with a single command:
        /// $ sf set my-scratch-org=test-sadbiytjsupn@example.com my-other-scratch-org=test-ss0xut7txzxf@example.com
        /// Set an alias that contains spaces:
        /// $ sf set my-alias='alias with spaces'
        /// Set a single alias without using an equal sign:
        /// $ sf set my-scratch-org test-ss0xut7txzxf@example.com
        /// </example>
        [Command("set")]
        public SfResponse Set(AliasSetOptions options = null)
        {
            return ExecuteCommand(nameof(Set), options);
        }

        /// <summary>
        /// Unset one or more aliases that are currently set on your local computer.
        /// </summary>
        /// <remarks>
        /// Aliases are global, so when you unset one it's no longer available in any Salesforce DX project.
        /// </remarks>
        /// <example>
        /// Unset an alias:
        /// $ sf unset my-alias
        /// Unset multiple aliases with a single command:
        /// $ sf unset my-alias my-other-alias
        /// Unset all aliases:
        /// $ sf unset --all [--no-prompt]
        /// </example>
        [Command("unset")]
        public SfResponse Unset(AliasUnsetOptions options = null)
        {
            return ExecuteCommand(nameof(Unset), options);
        }
    }
}

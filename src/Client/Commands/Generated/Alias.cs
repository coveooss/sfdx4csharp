// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method List of class Alias.
    /// </summary>
    public class AliasListOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method Set of class Alias.
    /// </summary>
    public class AliasSetOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method Unset of class Alias.
    /// </summary>
    public class AliasUnsetOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
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
    public class Alias : SfdxCommand
    {
        /// Constructor.
        public Alias(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Aliases are global, which means that you can use all the listed aliases in any Salesforce DX project on your computer.
        /// </summary>
        /// <remarks>
        /// Aliases are global, which means that you can use all the listed aliases in any Salesforce DX project on your computer.
        /// </remarks>
        /// <example>
        /// 
        /// List all the aliases you've set:
        /// <%= config.bin %> <%= command.id %>
        /// </example>
        [Command("list")]
        public SfdxResponse List(AliasListOptions options)
        {
            return ExecuteCommand(nameof(List), options);
        }

        /// <summary>
        /// Aliases are user-defined short names that make it easier to use the CLI. For example, users often set an alias for a scratch org usernames because they're long and unintuitive.  Check the --help of a CLI command to determine where you can use an alias.
        /// 
        /// You can associate an alias with only one value at a time. If you set an alias multiple times, the alias points to the most recent value. Aliases are global; after you set an alias, you can use it in any Salesforce DX project on your computer.
        /// 
        /// Use quotes to specify an alias value that contains spaces. You typically use an equal sign to set your alias, although you don't need it if you're setting a single alias in a command.
        /// </summary>
        /// <remarks>
        /// Aliases are user-defined short names that make it easier to use the CLI. For example, users often set an alias for a scratch org usernames because they're long and unintuitive.  Check the --help of a CLI command to determine where you can use an alias.
        /// 
        /// You can associate an alias with only one value at a time. If you set an alias multiple times, the alias points to the most recent value. Aliases are global; after you set an alias, you can use it in any Salesforce DX project on your computer.
        /// 
        /// Use quotes to specify an alias value that contains spaces. You typically use an equal sign to set your alias, although you don't need it if you're setting a single alias in a command.
        /// </remarks>
        /// <example>
        /// 
        /// Set an alias for a scratch org username:
        /// <%= config.bin %> <%= command.id %> my-scratch-org=test-sadbiytjsupn@example.com
        /// Set multiple aliases with a single command:
        /// <%= config.bin %> <%= command.id %> my-scratch-org=test-sadbiytjsupn@example.com my-other-scratch-org=test-ss0xut7txzxf@example.com
        /// Set an alias that contains spaces:
        /// <%= config.bin %> <%= command.id %> my-alias='alias with spaces'
        /// Set a single alias without using an equal sign:
        /// <%= config.bin %> <%= command.id %> my-scratch-org test-ss0xut7txzxf@example.com
        /// </example>
        [Command("set")]
        public SfdxResponse Set(AliasSetOptions options)
        {
            return ExecuteCommand(nameof(Set), options);
        }

        /// <summary>
        /// Aliases are global, so when you unset one it's no longer available in any Salesforce DX project.
        /// </summary>
        /// <remarks>
        /// Aliases are global, so when you unset one it's no longer available in any Salesforce DX project.
        /// </remarks>
        /// <example>
        /// 
        /// Unset an alias:
        /// <%= config.bin %> <%= command.id %> my-alias
        /// Unset multiple aliases with a single command:
        /// <%= config.bin %> <%= command.id %> my-alias my-other-alias
        /// Unset all aliases:
        /// <%= config.bin %> <%= command.id %> --all [--no-prompt]
        /// </example>
        [Command("unset")]
        public SfdxResponse Unset(AliasUnsetOptions options)
        {
            return ExecuteCommand(nameof(Unset), options);
        }
    }
}

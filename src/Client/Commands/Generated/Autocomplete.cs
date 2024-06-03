// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Execute of class Autocomplete.
    /// </summary>
    public class AutocompleteExecuteOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Refresh cache (ignores displaying instructions)
        /// </summary>
        [SwitchName("--refresh-cache")]
        public bool? RefreshCache { get; set; }
    }

    /// <summary>
    /// Autocomplete
    /// </summary>
    [CommandClass("autocomplete")]
    public class Autocomplete : SfCommand
    {
        /// Constructor.
        public Autocomplete(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Display autocomplete installation instructions.
        /// </remarks>
        /// <example>
        /// $ $ sf autocomplete
        /// $ $ sf autocomplete bash
        /// $ $ sf autocomplete zsh
        /// $ $ sf autocomplete powershell
        /// $ $ sf autocomplete --refresh-cache
        /// </example>
        [Command("")]
        public SfResponse Execute(AutocompleteExecuteOptions options = null)
        {
            return ExecuteCommand(nameof(Execute), options);
        }
    }
}

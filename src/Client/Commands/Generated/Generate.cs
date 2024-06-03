// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Function of class Generate.
    /// </summary>
    public class GenerateFunctionOptions : SfOptions
    {
        /// <summary>
        /// [Required] The language in which the function is written.
        /// </summary>
        [SwitchName("--language")]
        public string Language { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Function name. Must start with a capital letter.
        /// </summary>
        [SwitchName("--function-name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// [Optional] Function name. Must start with a capital letter.
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }
    }

    /// <summary>
    /// Generate
    /// </summary>
    [CommandClass("generate")]
    public class Generate : SfCommand
    {
        /// Constructor.
        public Generate(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Create a Salesforce Function with basic scaffolding specific to a given language.
        /// </summary>
        /// <remarks>
        /// Both '--language' and '--name' are required flags. Function names must start with a capital letter.
        /// </remarks>
        /// <example>
        /// Create a JavaScript function:
        /// $ sf function --function-name myfunction --language javascript
        /// </example>
        [Command("function")]
        public SfResponse Function(GenerateFunctionOptions options)
        {
            return ExecuteCommand(nameof(Function), options);
        }
    }
}

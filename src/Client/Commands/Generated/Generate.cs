// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Function of class Generate.
    /// </summary>
    public class GenerateFunctionOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] The language in which the function is written.
        /// </summary>
        [SwitchName("--language")]
        public string Language { get; set; }

        /// <summary>
        /// [Required] Function name. Must start with a capital letter.
        /// </summary>
        [SwitchName("--function-name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// [Required] Function name. Must start with a capital letter.
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }
    }

    /// <summary>
    /// Generate
    /// </summary>
    [CommandClass("generate")]
    public class Generate : SfdxCommand
    {
        /// Constructor.
        public Generate(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Both '--language' and '--name' are required flags. Function names must start with a capital letter.
        /// </summary>
        /// <remarks>
        /// Both '--language' and '--name' are required flags. Function names must start with a capital letter.
        /// </remarks>
        /// <example>
        /// 
        /// Create a JavaScript function:
        /// <%= config.bin %> <%= command.id %> --function-name myfunction --language javascript
        /// </example>
        [Command("function")]
        public SfdxResponse Function(GenerateFunctionOptions options)
        {
            return ExecuteCommand(nameof(Function), options);
        }
    }
}

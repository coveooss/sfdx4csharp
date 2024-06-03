using System.Diagnostics;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI command's wrapper.
    /// </summary>
    public abstract class SfCommand
    {
        private readonly CommandExecutioner _commandExecutioner;

        /// <summary>
        /// Constructor.
        /// </summary>
        protected SfCommand(CommandExecutioner commandExecutioner)
        {
            Debug.Assert(commandExecutioner != null);

            _commandExecutioner = commandExecutioner;
        }

        /// <summary>
        /// Executes a Salesforce CLI command.
        /// </summary>
        protected SfResponse ExecuteCommand<TOptions>(string methodName, TOptions commandOptions) where TOptions : SfOptions, new()
        {
            Debug.Assert(methodName != null);

            var methodInfo = GetType().GetMethod(methodName);
            Debug.Assert(methodInfo != null);

            var apiCommandClass = CommandClassAttribute.GetCommandClassValue(GetType());
            var apiCommand = CommandAttribute.GetCommandValue(methodInfo);
            var command = $"{apiCommandClass} {apiCommand}";

            SfOptions options = commandOptions ?? new TOptions();
            var output = _commandExecutioner.Execute(command, options);
            var parsedResponse = options.json
                ? ResponseParser.Parse(output.RawOutput)
                : new SfResponse();

            parsedResponse.CommandOutput = output;
            return parsedResponse;
        }
    }
}
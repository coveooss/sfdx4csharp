using System.Diagnostics;
using System.Reflection;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI command's wrapper.
    /// </summary>
    public abstract class SfdxCommand
    {
        private readonly CommandExecutioner _commandExecutioner;

        protected SfdxCommand(CommandExecutioner commandExecutioner)
        {
            Debug.Assert(commandExecutioner != null);

            _commandExecutioner = commandExecutioner;
        }

        protected SfdxResponse ExecuteCommand<TOptions>(string methodName, TOptions commandOptions) where TOptions : SfdxOptions, new()
        {
            Debug.Assert(methodName != null);

            var methodInfo = GetType().GetMethod(methodName);
            Debug.Assert(methodInfo != null);

            var apiCommandClass = CommandClassAttribute.GetCommandClassValue(GetType());
            var apiCommand = CommandAttribute.GetCommandValue(methodInfo);
            var command = $"{apiCommandClass} {apiCommand}";

            SfdxOptions options = commandOptions ?? new TOptions();
            var output = _commandExecutioner.Execute(command, options);
            return new SfdxResponse
            {
                AdditionalInfo = output,
                Result = options.json ? ResponseParser.Parse(output.RawOutput) : null
            };
        }
    }
}
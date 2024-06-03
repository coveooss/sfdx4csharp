// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Function of class Run.
    /// </summary>
    public class RunFunctionOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] URL of the function to run.
        /// </summary>
        [SwitchName("--function-url")]
        public string FunctionUrl { get; set; }

        /// <summary>
        /// [Optional] URL of the function to run.
        /// </summary>
        [SwitchName("--url")]
        public string Url { get; set; }

        /// <summary>
        /// [Optional] Set headers.
        /// </summary>
        [SwitchName("--headers")]
        public string Headers { get; set; }

        /// <summary>
        /// [Optional] Set the payload of the cloudevent as a JSON object or a path to a file via @file.json.
        /// </summary>
        [SwitchName("--payload")]
        public string Payload { get; set; }

        /// <summary>
        /// [Optional] Set the cloudevent to be emitted as a structured JSON cloudevent.
        /// </summary>
        [SwitchName("--structured")]
        public bool? Structured { get; set; }

        /// <summary>
        /// [Optional] Username or alias for the target org; overrides default target org.
        /// </summary>
        [SwitchName("--connected-org")]
        public string ConnectedOrg { get; set; }
    }

    /// <summary>
    /// Options for the method FunctionStart of class Run.
    /// </summary>
    public class RunFunctionStartOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Path to function directory.
        /// </summary>
        [SwitchName("--path")]
        public string Path { get; set; }

        /// <summary>
        /// [Optional] Port for running the function.
        /// </summary>
        [SwitchName("--port")]
        public string Port { get; set; }

        /// <summary>
        /// [Optional] Port for remote debugging.
        /// </summary>
        [SwitchName("--debug-port")]
        public string DebugPort { get; set; }

        /// <summary>
        /// [Optional] The language that the function runs in.
        /// </summary>
        [SwitchName("--language")]
        public string Language { get; set; }

        /// <summary>
        /// [Optional] Output additional logs.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method FunctionStartContainer of class Run.
    /// </summary>
    public class RunFunctionStartContainerOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }
    }

    /// <summary>
    /// Options for the method FunctionStartLocal of class Run.
    /// </summary>
    public class RunFunctionStartLocalOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Path to function directory.
        /// </summary>
        [SwitchName("--path")]
        public string Path { get; set; }

        /// <summary>
        /// [Optional] Port to bind the invoker to.
        /// </summary>
        [SwitchName("--port")]
        public string Port { get; set; }

        /// <summary>
        /// [Optional] Port to use for debugging the function.
        /// </summary>
        [SwitchName("--debug-port")]
        public string DebugPort { get; set; }

        /// <summary>
        /// [Optional] The language in which the function is written.
        /// </summary>
        [SwitchName("--language")]
        public string Language { get; set; }
    }

    /// <summary>
    /// Run
    /// </summary>
    [CommandClass("run")]
    public class Run : SfCommand
    {
        /// Constructor.
        public Run(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Send a cloudevent to a function.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// Run a function:
        /// $ sf function --url http://path/to/function
        /// Run a function with a payload and a JSON response:
        /// $ sf function --url http://path/to/function --payload '@file.json' --structured
        /// </example>
        [Command("function")]
        public SfResponse Function(RunFunctionOptions options = null)
        {
            return ExecuteCommand(nameof(Function), options);
        }

        /// <summary>
        /// Build and run a Salesforce Function.
        /// </summary>
        /// <remarks>
        /// Run this command from the directory of your Salesforce Functions project.
        /// 
        /// This command will run the target function locally (on the same operating system as this CLI), just like the `local` subcommand.
        /// </remarks>
        /// <example>
        /// Build a function and start the invoker
        /// $ sf function start
        /// Start the invoker with a specific language and port
        /// $ sf function start --port 5000 --language javascript
        /// </example>
        [Command("function start")]
        public SfResponse FunctionStart(RunFunctionStartOptions options = null)
        {
            return ExecuteCommand(nameof(FunctionStart), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// </example>
        [Command("function start container")]
        public SfResponse FunctionStartContainer(RunFunctionStartContainerOptions options = null)
        {
            return ExecuteCommand(nameof(FunctionStartContainer), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Build and run a Salesforce Function locally.
        /// </remarks>
        /// <example>
        /// Build a function and start the invoker
        /// $ sf function start local
        /// Start the invoker with a specific language and port
        /// $ sf function start local --port 5000 --language javascript
        /// </example>
        [Command("function start local")]
        public SfResponse FunctionStartLocal(RunFunctionStartLocalOptions options = null)
        {
            return ExecuteCommand(nameof(FunctionStartLocal), options);
        }
    }
}

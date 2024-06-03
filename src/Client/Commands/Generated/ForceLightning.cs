// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method LwcTestCreate of class ForceLightning.
    /// </summary>
    public class ForceLightningLwcTestCreateOptions : SfOptions
    {
        /// <summary>
        /// [Required] Path to Lightning web component .js file to create a test for.
        /// </summary>
        [SwitchName("--filepath")]
        public string Filepath { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method LwcTestRun of class ForceLightning.
    /// </summary>
    public class ForceLightningLwcTestRunOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }

        /// <summary>
        /// [Optional] Runs tests in a Node process that an external debugger can connect to. The run pauses until the debugger is connected. For more information, see: https://jestjs.io/docs/en/troubleshooting
        /// </summary>
        [SwitchName("--debug")]
        public bool? Debug { get; set; }

        /// <summary>
        /// [Optional] Runs tests when a watched file changes. Watched files include the component under test and any files it references.
        /// </summary>
        [SwitchName("--watch")]
        public bool? Watch { get; set; }
    }

    /// <summary>
    /// Options for the method LwcTestSetup of class ForceLightning.
    /// </summary>
    public class ForceLightningLwcTestSetupOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }
    }

    /// <summary>
    /// ForceLightning
    /// </summary>
    [CommandClass("force lightning")]
    public class ForceLightning : SfCommand
    {
        /// Constructor.
        public ForceLightning(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// creates a Lightning web component test file with boilerplate code inside a __tests__ directory.
        /// </remarks>
        /// <example>
        /// $ sfdx force:lightning:lwc:test:create -f force-app/main/default/lwc/myButton/myButton.js
        /// force:lightning:lwc:test:create -f [string] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("lwc test create")]
        public SfResponse LwcTestCreate(ForceLightningLwcTestCreateOptions options)
        {
            return ExecuteCommand(nameof(LwcTestCreate), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// invokes Lightning Web Components Jest unit tests.
        /// </remarks>
        /// <example>
        /// $ sfdx force:lightning:lwc:test:run
        /// $ sfdx force:lightning:lwc:test:run -w
        /// force:lightning:lwc:test:run [-d | --watch] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("lwc test run")]
        public SfResponse LwcTestRun(ForceLightningLwcTestRunOptions options = null)
        {
            return ExecuteCommand(nameof(LwcTestRun), options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// install Jest unit testing tools for Lightning Web Components.
        /// </remarks>
        /// <example>
        /// $ sfdx force:lightning:lwc:test:setup
        /// force:lightning:lwc:test:setup [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("lwc test setup")]
        public SfResponse LwcTestSetup(ForceLightningLwcTestSetupOptions options = null)
        {
            return ExecuteCommand(nameof(LwcTestSetup), options);
        }
    }
}

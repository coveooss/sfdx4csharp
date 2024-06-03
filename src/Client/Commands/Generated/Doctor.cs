// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Execute of class Doctor.
    /// </summary>
    public class DoctorExecuteOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for command
        /// </summary>
        [SwitchName("--command")]
        public string Command { get; set; }

        /// <summary>
        /// [Optional] No description for plugin
        /// </summary>
        [SwitchName("--plugin")]
        public string Plugin { get; set; }

        /// <summary>
        /// [Optional] No description for output-dir
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

        /// <summary>
        /// [Optional] No description for create-issue
        /// </summary>
        [SwitchName("--create-issue")]
        public bool? CreateIssue { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Doctor
    /// </summary>
    [CommandClass("doctor")]
    public class Doctor : SfCommand
    {
        /// Constructor.
        public Doctor(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Gather CLI configuration data and run diagnostic tests to discover and report potential problems in your environment.
        /// </summary>
        /// <remarks>
        /// When you run the doctor command without parameters, it first displays a diagnostic overview of your environment. It then writes a detailed diagnosis to a JSON file in the current directory. Use the --outputdir to specify a different directory. To run diagnostic tests on a specific plugin, use the --plugin parameter. If the plugin isn't listening to the doctor, then you get a warning.
        /// 
        /// Use the --command parameter to run a specific command in debug mode; the doctor writes both stdout and stderr to \*.log files that you can provide to Salesforce Customer Support or attach to a GitHub issue.
        /// 
        /// Plugin providers can also implement their own doctor diagnostic tests by listening to the "sf-doctor" event and running plugin specific tests that are then included in the doctor diagnostics log.
        /// </remarks>
        /// <example>
        /// Run CLI doctor diagnostics:
        /// $ sf doctor
        /// Run CLI doctor diagnostics and the specified command, and write the debug output to a file:
        /// $ sf doctor --command "force:org:list --all"
        /// Run CLI doctor diagnostics for a specific plugin:
        /// $ sf doctor --plugin @salesforce/plugin-source
        /// </example>
        [Command("")]
        public SfResponse Execute(DoctorExecuteOptions options = null)
        {
            return ExecuteCommand(nameof(Execute), options);
        }
    }
}

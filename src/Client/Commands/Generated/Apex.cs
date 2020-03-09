// Generated on March 9th 2020 using sfdx-cli/7.43.1 win32-x64 node-v8.15.0. DO NOT MODIFY
// Copyright (c) 2005-2020, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method classCreate of class Apex.
    /// </summary>
    public class ApexClassCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The name of the new Apex class. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--classname")]
        public string classname { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string template { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method execute of class Apex.
    /// </summary>
    public class ApexExecuteOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Path to a local file that contains Apex code.
        /// </summary>
        [SwitchName("--apexcodefile")]
        public string apexcodefile { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method logGet of class Apex.
    /// </summary>
    public class ApexLogGetOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] Number of most recent logs to display.
        /// </summary>
        [SwitchName("--number")]
        public int? number { get; set; }

        /// <summary>
        /// [Required] ID of the log to display.
        /// </summary>
        [SwitchName("--logid")]
        public string logid { get; set; }

        /// <summary>
        /// [Optional] Applies default colors to noteworthy log lines.
        /// </summary>
        [SwitchName("--color")]
        public bool? color { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method logList of class Apex.
    /// </summary>
    public class ApexLogListOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method logTail of class Apex.
    /// </summary>
    public class ApexLogTailOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] Skips trace flag setup. Assumes that a trace flag and debug level are fully set up.
        /// </summary>
        [SwitchName("--skiptraceflag")]
        public bool? skiptraceflag { get; set; }

        /// <summary>
        /// [Required] Debug level to set on the DEVELOPER_LOG trace flag for your user.
        /// </summary>
        [SwitchName("--debuglevel")]
        public string debuglevel { get; set; }

        /// <summary>
        /// [Optional] Applies default colors to noteworthy log lines.
        /// </summary>
        [SwitchName("--color")]
        public bool? color { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method testReport of class Apex.
    /// </summary>
    public class ApexTestReportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The ID of test run.
        /// </summary>
        [SwitchName("--testrunid")]
        public string testrunid { get; set; }

        /// <summary>
        /// [Required] Format to use when displaying results. If you also specify the --json flag, --json overrides this parameter.
        /// </summary>
        [SwitchName("--resultformat")]
        public string resultformat { get; set; }

        /// <summary>
        /// [Optional] Displays Apex test processing details. If JSON format is specified, processing details aren’t displayed.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Optional] Sets the streaming client socket timeout, in minutes. If the streaming client socket has no contact from the server for a number of minutes, the client exits. Specify a longer wait time if timeouts occur frequently.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Required] Directory to store test run files.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Optional] Retrieves code coverage results.
        /// </summary>
        [SwitchName("--codecoverage")]
        public bool? codecoverage { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method testRun of class Apex.
    /// </summary>
    public class ApexTestRunOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] Retrieves code coverage results.
        /// </summary>
        [SwitchName("--codecoverage")]
        public bool? codecoverage { get; set; }

        /// <summary>
        /// [Required] Format to use when displaying results. If you also specify the --json flag, --json overrides this parameter.
        /// </summary>
        [SwitchName("--resultformat")]
        public string resultformat { get; set; }

        /// <summary>
        /// [Required] Directory to store test run files.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] Specifies which tests to run, using one of these TestLevel enum values:
        /// RunSpecifiedTests—Only the tests that you specify are run.
        /// RunLocalTests—All tests in your org are run, except the ones that originate from installed managed packages.
        /// RunAllTestsInOrg—All tests are in your org and in installed managed packages are run.
        /// </summary>
        [SwitchName("--testlevel")]
        public string testlevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of Apex test class names to run. You can specify only one of classnames, suitenames, or tests.
        /// </summary>
        [SwitchName("--classnames")]
        public string classnames { get; set; }

        /// <summary>
        /// [Optional] Displays Apex test processing details. If JSON format is specified, processing details aren’t displayed.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Optional] Runs test methods from a single Apex class synchronously. If you don't specify this flag, tests are run asynchronously.
        /// </summary>
        [SwitchName("--synchronous")]
        public bool? synchronous { get; set; }

        /// <summary>
        /// [Optional] Specifies how long to wait (in minutes) for Apex pre-compilation to complete before running the tests or timing out.
        /// </summary>
        [SwitchName("--precompilewait")]
        public int? precompilewait { get; set; }

        /// <summary>
        /// [Optional] Sets the streaming client socket timeout, in minutes. If the streaming client socket has no contact from the server for a number of minutes, the client exits. Specify a longer wait time if timeouts occur frequently.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of Apex test suite names to run. You can only specify one of classnames, suitenames, or tests.
        /// </summary>
        [SwitchName("--suitenames")]
        public string suitenames { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of Apex test class names or IDs and test methods, if applicable, to run. You can only specify one of classnames, suitenames, or tests.
        /// </summary>
        [SwitchName("--tests")]
        public string tests { get; set; }
    }

    /// <summary>
    /// Options for the method triggerCreate of class Apex.
    /// </summary>
    public class ApexTriggerCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The name of the new Apex trigger. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--triggername")]
        public string triggername { get; set; }

        /// <summary>
        /// [Required] The events that cause the trigger to fire.
        /// </summary>
        [SwitchName("--triggerevents")]
        public string triggerevents { get; set; }

        /// <summary>
        /// [Required] The sObject to create an Apex trigger on.
        /// </summary>
        [SwitchName("--sobject")]
        public string sobject { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string template { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Apex
    /// </summary>
    [CommandClass("force:apex")]
    public class Apex : SFDXCommand
    {
        /// Constructor.
        public Apex(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// create an Apex class
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </summary>
        /// <remarks>
        /// Creates an Apex class in the specified directory or the current working directory. If you don’t explicitly set the API version, it defaults to the current API version. The .cls file and associated metadata file are created.
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:apex:class:create -n MyClass
        ///    $ sfdx force:apex:class:create -n MyClass -d classes
        /// 
        /// force:apex:class:create -n <string> [-t <string>] [-d <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("class:create")]
        public SFDXResponse ClassCreate(ApexClassCreateOptions p_Options)
        {
            return ExecuteCommand<ApexClassCreateOptions>(nameof(ClassCreate), p_Options);
        }

        /// <summary>
        /// execute anonymous Apex code
        /// </summary>
        /// <remarks>
        /// Executes one or more lines of anonymous Apex code, or executes the code in a local file.
        /// </remarks>
        /// <example>
        /// Executes one or more lines of Apex code, or executes the code in a local file.
        /// Before you enter code, run this command with no parameters to get a prompt.
        /// From the prompt, all commands are executed in a single execute anonymous request.
        /// For more information, see "Anonymous Blocks" in the Apex Developer Guide.
        /// 
        /// Examples:
        ///    $ sfdx force:apex:execute -f ~/test.apex
        /// 
        ///    $ sfdx force:apex:execute 
        ///    >> Start typing Apex code. Press the Enter key after each line, 
        ///    >> then press CTRL+D when finished.
        /// force:apex:execute [-f <filepath>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("execute")]
        public SFDXResponse Execute(ApexExecuteOptions p_Options)
        {
            return ExecuteCommand<ApexExecuteOptions>(nameof(Execute), p_Options);
        }

        /// <summary>
        /// fetch the last debug log
        /// </summary>
        /// <remarks>
        /// Fetches the last debug log.
        /// </remarks>
        /// <example>
        /// When you execute this command in a project, it fetches the specified log or given number of last logs from your default scratch org.
        /// 
        /// To get the IDs for your debug logs, run "sfdx force:apex:log:list".
        /// 
        /// To specify a count of logs to return, use the --number parameter to return the most recent logs.
        /// 
        /// Executing this command without parameters returns the most recent log.
        /// 
        /// Examples:
        ///    $ sfdx force:apex:log:get -i <log id>
        ///    $ sfdx force:apex:log:get -i <log id> -u me@my.org
        ///    $ sfdx force:apex:log:get -n 2 -c
        /// force:apex:log:get [-c] [-i <id> | -n <number>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("log:get")]
        public SFDXResponse LogGet(ApexLogGetOptions p_Options)
        {
            return ExecuteCommand<ApexLogGetOptions>(nameof(LogGet), p_Options);
        }

        /// <summary>
        /// list debug logs
        /// </summary>
        /// <remarks>
        /// Displays a list of debug log IDs, along with general information about the logs.
        /// </remarks>
        /// <example>
        /// When you execute this command in a project, it lists the log IDs for your default scratch org.
        /// 
        /// Examples:
        ///    $ sfdx force:apex:log:list
        ///    $ sfdx force:apex:log:list -u me@my.org
        /// force:apex:log:list [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("log:list")]
        public SFDXResponse LogList(ApexLogListOptions p_Options)
        {
            return ExecuteCommand<ApexLogListOptions>(nameof(LogList), p_Options);
        }

        /// <summary>
        /// start debug logging and display logs
        /// </summary>
        /// <remarks>
        /// Activates debug logging and displays logs in the terminal. You can also pipe the logs to a file.
        /// </remarks>
        /// <example>
        /// Tails logs from your target org for 30 minutes.
        /// 
        /// If a DEVELOPER_LOG trace flag does not exist, this command creates one in the target org.
        /// 
        /// If the active trace flag's expiration date is within this command's timeout window, the command sets the trace flag's expiration date to 30 minutes from the current time.
        /// 
        /// The --debuglevel parameter assigns a debug level to the active DEVELOPER_LOG trace flag.
        /// 
        /// Use --skiptraceflag to skip trace flag setup, including setting expiration date and debug level. Include this flag only if there is an active user-based trace flag for your user.
        /// 
        /// The --json parameter emits log lines in JSON, but does not follow the standard Salesforce CLI JSON format (which includes status and result values).
        /// 
        /// Examples:
        ///    $ sfdx force:apex:log:tail
        ///    $ sfdx force:apex:log:tail --debuglevel MyDebugLevel
        ///    $ sfdx force:apex:log:tail -c -s
        /// force:apex:log:tail [-c] [-d <string>] [-s] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("log:tail")]
        public SFDXResponse LogTail(ApexLogTailOptions p_Options)
        {
            return ExecuteCommand<ApexLogTailOptions>(nameof(LogTail), p_Options);
        }

        /// <summary>
        /// display test results
        /// </summary>
        /// <remarks>
        /// Displays the test results for a specific test run.
        /// </remarks>
        /// <example>
        /// Displays test results for an enqueued or completed asynchronous Apex test run.
        /// 
        /// Examples:
        ///    $ sfdx force:apex:test:report -i <test run id>
        ///    $ sfdx force:apex:test:report -i <test run id> -r junit
        ///    $ sfdx force:apex:test:report -i <test run id> -c --json
        /// force:apex:test:report -i <id> [-c] [-d <directory>] [-w <minutes>] [-r human|tap|junit|json] [-u <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("test:report")]
        public SFDXResponse TestReport(ApexTestReportOptions p_Options)
        {
            return ExecuteCommand<ApexTestReportOptions>(nameof(TestReport), p_Options);
        }

        /// <summary>
        /// invoke Apex tests
        /// </summary>
        /// <remarks>
        /// Runs Apex tests.
        /// </remarks>
        /// <example>
        /// By default, runs all Apex tests in the org’s namespace.
        /// 
        /// To run specific test classes, specify class names or suite names, or set a --testlevel value.
        /// 
        /// To run specific test methods, use --tests.
        /// 
        /// Examples:
        ///    $ sfdx force:apex:test:run
        ///    $ sfdx force:apex:test:run -n MyClassTest,MyOtherClassTest -r human
        ///    $ sfdx force:apex:test:run -s MySuite,MyOtherSuite -c --json
        ///    $ sfdx force:apex:test:run -t MyClassTest.testCoolFeature,MyClassTest.testAwesomeFeature,AnotherClassTest,namespace.TheirClassTest.testThis -r human
        ///    $ sfdx force:apex:test:run -l RunLocalTests -d <path to outputdir> -u me@my.org
        /// force:apex:test:run [-n <array> | -s <array> | -t <array>] [-c] [-d <directory>] [-l RunLocalTests|RunAllTestsInOrg|RunSpecifiedTests] [-w <minutes>] [-y] [-r human|tap|junit|json] [-u <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("test:run")]
        public SFDXResponse TestRun(ApexTestRunOptions p_Options)
        {
            return ExecuteCommand<ApexTestRunOptions>(nameof(TestRun), p_Options);
        }

        /// <summary>
        /// create an Apex trigger
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </summary>
        /// <remarks>
        /// Creates an Apex trigger in the specified directory or the current working directory. If you don’t explicitly set the API version, it defaults to the current API version. The .trigger file and associated metadata file are created.
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:apex:trigger:create -n MyTrigger
        ///    $ sfdx force:apex:trigger:create -n MyTrigger -s Account -e 'before insert, after insert'
        ///    $ sfdx force:apex:trigger:create -n MyTrigger -d triggers
        /// 
        /// force:apex:trigger:create -n <string> [-t <string>] [-d <string>] [-s <string>] [-e <array>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("trigger:create")]
        public SFDXResponse TriggerCreate(ApexTriggerCreateOptions p_Options)
        {
            return ExecuteCommand<ApexTriggerCreateOptions>(nameof(TriggerCreate), p_Options);
        }
    }
}

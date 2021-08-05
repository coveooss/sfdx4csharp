// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

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
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The name of the new Apex class. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--classname")]
        public string classname { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string template { get; set; }

        /// <summary>
        /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method execute of class Apex.
    /// </summary>
    public class ApexExecuteOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] Path to a local file that contains Apex code
        /// </summary>
        [SwitchName("--apexcodefile")]
        public string apexcodefile { get; set; }
    }

    /// <summary>
    /// Options for the method logGet of class Apex.
    /// </summary>
    public class ApexLogGetOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] Id of the log to display
        /// </summary>
        [SwitchName("--logid")]
        public string logid { get; set; }

        /// <summary>
        /// [Required] Number of most recent logs to display
        /// </summary>
        [SwitchName("--number")]
        public string number { get; set; }

        /// <summary>
        /// [Required] The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }
    }

    /// <summary>
    /// Options for the method logList of class Apex.
    /// </summary>
    public class ApexLogListOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method logTail of class Apex.
    /// </summary>
    public class ApexLogTailOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Colorize noteworthy log lines
        /// </summary>
        [SwitchName("--color")]
        public bool? color { get; set; }

        /// <summary>
        /// [Required] Debug level for trace flag
        /// </summary>
        [SwitchName("--debuglevel")]
        public string debuglevel { get; set; }

        /// <summary>
        /// [Optional] Skip trace flag setup
        /// </summary>
        [SwitchName("--skiptraceflag")]
        public bool? skiptraceflag { get; set; }
    }

    /// <summary>
    /// Options for the method testReport of class Apex.
    /// </summary>
    public class ApexTestReportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID of the test run
        /// </summary>
        [SwitchName("--testrunid")]
        public string testrunid { get; set; }

        /// <summary>
        /// [Optional] Permissible values are: trace, debug, info, warn, error, fatal, TRACE, DEBUG, INFO, WARN, ERROR, FATAL
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Retrieves code coverage results
        /// </summary>
        [SwitchName("--codecoverage")]
        public bool? codecoverage { get; set; }

        /// <summary>
        /// [Required] Directory to store test result files
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] Permissible values are: human, tap, junit, json
        /// </summary>
        [SwitchName("--resultformat")]
        public string resultformat { get; set; }

        /// <summary>
        /// [Required] Sets the streaming client socket timeout in minutes; specify a longer wait time if timeouts occur frequently
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }

        /// <summary>
        /// [Optional] Display Apex test processing details; if JSON is specified, processing details aren't displayed
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method testRun of class Apex.
    /// </summary>
    public class ApexTestRunOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Permissible values are: trace, debug, info, warn, error, fatal, TRACE, DEBUG, INFO, WARN, ERROR, FATAL
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Retrieves code coverage results
        /// </summary>
        [SwitchName("--codecoverage")]
        public bool? codecoverage { get; set; }

        /// <summary>
        /// [Required] Directory to store test run files
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] Specifies which tests to run, using one of these TestLevel enum values:
        /// RunSpecifiedTests—Only the tests that you specify are run.
        /// RunLocalTests—All tests in your org are run, except the ones that originate from installed managed packages.
        /// RunAllTestsInOrg—All tests are in your org and in installed managed packages are run
        /// </summary>
        [SwitchName("--testlevel")]
        public string testlevel { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of Apex test class names to run; if you select --classnames, you can't specify --suitenames or --tests
        /// </summary>
        [SwitchName("--classnames")]
        public string classnames { get; set; }

        /// <summary>
        /// [Required] Permissible values are: human, tap, junit, json
        /// </summary>
        [SwitchName("--resultformat")]
        public string resultformat { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of Apex test suite names to run; if you select --suitenames, you can't specify --classnames or --tests
        /// </summary>
        [SwitchName("--suitenames")]
        public string suitenames { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of Apex test class names or IDs and, if applicable, test methods to run; if you specify --tests, you can't specify --classnames or --suitenames
        /// </summary>
        [SwitchName("--tests")]
        public string tests { get; set; }

        /// <summary>
        /// [Required] Sets the streaming client socket timeout in minutes; specify a longer wait time if timeouts occur frequently
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }

        /// <summary>
        /// [Optional] Runs test methods from a single Apex class synchronously; if not specified, tests are run ansynchronously
        /// </summary>
        [SwitchName("--synchronous")]
        public bool? synchronous { get; set; }

        /// <summary>
        /// [Optional] Display Apex test processing details; if JSON is specified, processing details aren't displayed
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Optional] Display detailed code coverage per test
        /// </summary>
        [SwitchName("--detailedcoverage")]
        public bool? detailedcoverage { get; set; }
    }

    /// <summary>
    /// Options for the method triggerCreate of class Apex.
    /// </summary>
    public class ApexTriggerCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The name of the new Apex trigger. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--triggername")]
        public string triggername { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string template { get; set; }

        /// <summary>
        /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] The sObject to create an Apex trigger on.
        /// </summary>
        [SwitchName("--sobject")]
        public string sobject { get; set; }

        /// <summary>
        /// [Required] The events that cause the trigger to fire.
        /// </summary>
        [SwitchName("--triggerevents")]
        public string triggerevents { get; set; }
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
        /// create an Apex class
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:apex:class:create -n MyClass
        ///    $ sfdx force:apex:class:create -n MyClass -d classes
        /// 
        /// $ sfdx force:apex:class:create -n MyClass
        /// $ sfdx force:apex:class:create -n MyClass -d classes
        /// force:apex:class:create -n <string> [-t <string>] [-d <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("class:create")]
        public SFDXResponse ClassCreate(ApexClassCreateOptions p_Options)
        {
            return ExecuteCommand<ApexClassCreateOptions>(nameof(ClassCreate), p_Options);
        }

        /// <summary>
        /// executes anonymous Apex code
        /// Executes one or more lines of anonymous Apex code entered on the command line, or executes the code in a local file.
        /// If you don’t run this command from within a Salesforce DX project, —-targetusername is required.
        /// To execute your code interactively, run this command with no parameters. At the prompt, enter all your Apex code; press CTRL-D when you're finished. Your code is then executed in a single execute anonymous request.
        /// For more information, see "Anonymous Blocks" in the Apex Developer Guide.
        /// 
        /// 
        /// </summary>
        /// <remarks>
        /// executes anonymous Apex code
        /// Executes one or more lines of anonymous Apex code entered on the command line, or executes the code in a local file.
        /// If you don’t run this command from within a Salesforce DX project, —-targetusername is required.
        /// To execute your code interactively, run this command with no parameters. At the prompt, enter all your Apex code; press CTRL-D when you're finished. Your code is then executed in a single execute anonymous request.
        /// For more information, see "Anonymous Blocks" in the Apex Developer Guide.
        /// 
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:apex:execute -u testusername@salesforce.org -f ~/test.apex
        /// $ sfdx force:apex:execute -f ~/test.apex
        /// $ sfdx force:apex:execute 
        /// Start typing Apex code. Press the Enter key after each line, then press CTRL+D when finished.
        /// force:apex:execute [-f <filepath>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("execute")]
        public SFDXResponse Execute(ApexExecuteOptions p_Options)
        {
            return ExecuteCommand<ApexExecuteOptions>(nameof(Execute), p_Options);
        }

        /// <summary>
        /// fetch debug logs
        /// Fetches the specified log or given number of most recent logs from the scratch org. 
        /// To get the IDs for your debug logs, run "sfdx force:apex:log:list". 
        /// Use the --logid parameter to return a specific log. 
        /// Use the --number parameter to return the specified number of recent logs.
        /// Use the --outputdir parameter to specify the directory to store the logs in.
        /// Executing this command without parameters returns the most recent log.
        /// </summary>
        /// <remarks>
        /// fetch debug logs
        /// Fetches the specified log or given number of most recent logs from the scratch org. 
        /// To get the IDs for your debug logs, run "sfdx force:apex:log:list". 
        /// Use the --logid parameter to return a specific log. 
        /// Use the --number parameter to return the specified number of recent logs.
        /// Use the --outputdir parameter to specify the directory to store the logs in.
        /// Executing this command without parameters returns the most recent log.
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:apex:log:get -i <log id>
        /// $ sfdx force:apex:log:get -i <log id> -u me@my.org
        /// $ sfdx force:apex:log:get -n 2 -c
        /// $ sfdx force:apex:log:get -d Users/Desktop/logs -n 2
        /// force:apex:log:get [-i <id>] [-n <number>] [-d <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("log:get")]
        public SFDXResponse LogGet(ApexLogGetOptions p_Options)
        {
            return ExecuteCommand<ApexLogGetOptions>(nameof(LogGet), p_Options);
        }

        /// <summary>
        /// display a list of IDs and general information about debug logs
        /// Run this command in a project to list the IDs and general information for all debug logs in your default org.
        /// To fetch a specific log from your org, obtain the ID from this command's output, then run the “sfdx force:apex:log:get” command.
        /// </summary>
        /// <remarks>
        /// display a list of IDs and general information about debug logs
        /// Run this command in a project to list the IDs and general information for all debug logs in your default org.
        /// To fetch a specific log from your org, obtain the ID from this command's output, then run the “sfdx force:apex:log:get” command.
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:apex:log:list
        /// $ sfdx force:apex:log:list -u me@my.org
        /// force:apex:log:list [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("log:list")]
        public SFDXResponse LogList(ApexLogListOptions p_Options)
        {
            return ExecuteCommand<ApexLogListOptions>(nameof(LogList), p_Options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:apex:log:tail
        /// sfdx force:apex:log:tail --debuglevel MyDebugLevel
        /// sfdx force:apex:log:tail -c -s
        /// force:apex:log:tail [-c] [-d <string>] [-s] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("log:tail")]
        public SFDXResponse LogTail(ApexLogTailOptions p_Options)
        {
            return ExecuteCommand<ApexLogTailOptions>(nameof(LogTail), p_Options);
        }

        /// <summary>
        /// display test results for a specific asynchronous test run
        /// Provide a test run ID to display test results for an enqueued or completed asynchronous test run. The test run ID is displayed after running the "sfdx force:apex:test:run" command.
        /// </summary>
        /// <remarks>
        /// display test results for a specific asynchronous test run
        /// Provide a test run ID to display test results for an enqueued or completed asynchronous test run. The test run ID is displayed after running the "sfdx force:apex:test:run" command.
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:apex:test:report -i <test run id>
        /// $ sfdx force:apex:test:report -i <test run id> -r junit
        /// $ sfdx force:apex:test:report -i <test run id> -c --json
        /// $ sfdx force:apex:test:report -i <test run id> -c -d <path to outputdir> -u me@myorg
        /// force:apex:test:report -i <string> [-c] [-d <string>] [-r human|tap|junit|json] [-w <string>] [-u <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("test:report")]
        public SFDXResponse TestReport(ApexTestReportOptions p_Options)
        {
            return ExecuteCommand<ApexTestReportOptions>(nameof(TestReport), p_Options);
        }

        /// <summary>
        /// invoke Apex tests
        /// Specify which tests to run by using the --classnames, --suites, or --tests parameters. Alternatively, use the --testlevel parameter to run all the tests in your org, local tests, or specified tests.
        /// To see code coverage results, use the --codecoverage parameter with --resultformat. The output displays a high-level summary of the test run and the code coverage values for classes in your org. If you specify human-readable result format, use the --detailedcoverage parameter to see detailed coverage results for each test method run.
        /// 
        /// NOTE: The testRunCoverage value (JSON and JUnit result formats) is a percentage of the covered lines and total lines from all the Apex classes evaluated by the tests in this run.
        /// </summary>
        /// <remarks>
        /// invoke Apex tests
        /// Specify which tests to run by using the --classnames, --suites, or --tests parameters. Alternatively, use the --testlevel parameter to run all the tests in your org, local tests, or specified tests.
        /// To see code coverage results, use the --codecoverage parameter with --resultformat. The output displays a high-level summary of the test run and the code coverage values for classes in your org. If you specify human-readable result format, use the --detailedcoverage parameter to see detailed coverage results for each test method run.
        /// 
        /// NOTE: The testRunCoverage value (JSON and JUnit result formats) is a percentage of the covered lines and total lines from all the Apex classes evaluated by the tests in this run.
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:apex:test:run
        /// $ sfdx force:apex:test:run -n "MyClassTest,MyOtherClassTest" -r human
        /// $ sfdx force:apex:test:run -s "MySuite,MyOtherSuite" -c -v --json
        /// $ sfdx force:apex:test:run -t "MyClassTest.testCoolFeature,MyClassTest.testAwesomeFeature,AnotherClassTest,namespace.TheirClassTest.testThis" -r human
        /// $ sfdx force:apex:test:run -l RunLocalTests -d <path to outputdir> -u me@my.org
        /// force:apex:test:run [-d <string>] [-l RunLocalTests|RunAllTestsInOrg|RunSpecifiedTests] [-n <string>] [-r human|tap|junit|json] [-s <string>] [-t <string>] [-w <string>] [-y] [-v -c] [-u <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
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
        /// create an Apex trigger
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:apex:trigger:create -n MyTrigger
        ///    $ sfdx force:apex:trigger:create -n MyTrigger -s Account -e 'before insert,after insert'
        ///    $ sfdx force:apex:trigger:create -n MyTrigger -d triggers
        /// 
        /// $ sfdx force:apex:trigger:create -n MyTrigger
        /// $ sfdx force:apex:trigger:create -n MyTrigger -s Account -e 'before insert,after insert'
        /// $ sfdx force:apex:trigger:create -n MyTrigger -d triggers
        /// force:apex:trigger:create -n <string> [-t <string>] [-d <string>] [-s <string>] [-e <array>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("trigger:create")]
        public SFDXResponse TriggerCreate(ApexTriggerCreateOptions p_Options)
        {
            return ExecuteCommand<ApexTriggerCreateOptions>(nameof(TriggerCreate), p_Options);
        }
    }
}

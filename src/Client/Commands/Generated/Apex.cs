// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method GenerateClass of class Apex.
    /// </summary>
    public class ApexGenerateClassOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Required] Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string Template { get; set; }

        /// <summary>
        /// [Required] The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateTrigger of class Apex.
    /// </summary>
    public class ApexGenerateTriggerOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Required] Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string Template { get; set; }

        /// <summary>
        /// [Required] The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }

        /// <summary>
        /// [Required] No description for event
        /// </summary>
        [SwitchName("--event")]
        public string Event { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method GetLog of class Apex.
    /// </summary>
    public class ApexGetLogOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] No description for log-id
        /// </summary>
        [SwitchName("--log-id")]
        public string LogId { get; set; }

        /// <summary>
        /// [Required] No description for number
        /// </summary>
        [SwitchName("--number")]
        public string Number { get; set; }

        /// <summary>
        /// [Required] The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }
    }

    /// <summary>
    /// Options for the method GetTest of class Apex.
    /// </summary>
    public class ApexGetTestOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for test-run-id
        /// </summary>
        [SwitchName("--test-run-id")]
        public string TestRunId { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for code-coverage
        /// </summary>
        [SwitchName("--code-coverage")]
        public bool? CodeCoverage { get; set; }

        /// <summary>
        /// [Required] No description for output-dir
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

        /// <summary>
        /// [Required] No description for result-format
        /// </summary>
        [SwitchName("--result-format")]
        public string ResultFormat { get; set; }
    }

    /// <summary>
    /// Options for the method ListLog of class Apex.
    /// </summary>
    public class ApexListLogOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method Run of class Apex.
    /// </summary>
    public class ApexRunOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Required] No description for file
        /// </summary>
        [SwitchName("--file")]
        public string File { get; set; }
    }

    /// <summary>
    /// Options for the method RunTest of class Apex.
    /// </summary>
    public class ApexRunTestOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for code-coverage
        /// </summary>
        [SwitchName("--code-coverage")]
        public bool? CodeCoverage { get; set; }

        /// <summary>
        /// [Required] No description for output-dir
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

        /// <summary>
        /// [Required] Here's what the levels mean:
        /// 
        /// - RunSpecifiedTests — Only the tests that you specify are run.
        /// - RunLocalTests — All tests in your org are run, except the ones that originate from installed managed packages.
        /// - RunAllTestsInOrg — All tests are in your org and in installed managed packages are run
        /// </summary>
        [SwitchName("--test-level")]
        public string TestLevel { get; set; }

        /// <summary>
        /// [Required] If you select --class-names, you can't specify --suite-names or --tests.
        /// For multiple classes, repeat the flag for each.
        /// --class-names Class1 --class-names Class2
        /// </summary>
        [SwitchName("--class-names")]
        public string ClassNames { get; set; }

        /// <summary>
        /// [Required] No description for result-format
        /// </summary>
        [SwitchName("--result-format")]
        public string ResultFormat { get; set; }

        /// <summary>
        /// [Required] If you select --suite-names, you can't specify --class-names or --tests.
        /// For multiple suites, repeat the flag for each.
        /// --suite-names Suite1 --suite-names Suite2
        /// </summary>
        [SwitchName("--suite-names")]
        public string SuiteNames { get; set; }

        /// <summary>
        /// [Required] If you specify --tests, you can't specify --class-names or --suite-names
        /// For multiple tests, repeat the flag for each.
        /// --tests Test1 --tests Test2
        /// </summary>
        [SwitchName("--tests")]
        public string Tests { get; set; }

        /// <summary>
        /// [Required] No description for wait
        /// </summary>
        [SwitchName("--wait")]
        public string Wait { get; set; }

        /// <summary>
        /// [Optional] No description for synchronous
        /// </summary>
        [SwitchName("--synchronous")]
        public bool? Synchronous { get; set; }

        /// <summary>
        /// [Optional] No description for detailed-coverage
        /// </summary>
        [SwitchName("--detailed-coverage")]
        public bool? DetailedCoverage { get; set; }
    }

    /// <summary>
    /// Options for the method TailLog of class Apex.
    /// </summary>
    public class ApexTailLogOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for color
        /// </summary>
        [SwitchName("--color")]
        public bool? Color { get; set; }

        /// <summary>
        /// [Required] No description for debug-level
        /// </summary>
        [SwitchName("--debug-level")]
        public string DebugLevel { get; set; }

        /// <summary>
        /// [Optional] No description for skip-trace-flag
        /// </summary>
        [SwitchName("--skip-trace-flag")]
        public bool? SkipTraceFlag { get; set; }
    }

    /// <summary>
    /// Apex
    /// </summary>
    [CommandClass("apex")]
    public class Apex : SfdxCommand
    {
        /// Constructor.
        public Apex(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Generates the Apex *.cls file and associated metadata file. These files must be contained in a parent directory called "classes" in your package directory. Either run this command from an existing directory of this name, or use the --output-dir flag to generate one or point to an existing one.
        /// </summary>
        /// <remarks>
        /// Generates the Apex *.cls file and associated metadata file. These files must be contained in a parent directory called "classes" in your package directory. Either run this command from an existing directory of this name, or use the --output-dir flag to generate one or point to an existing one.
        /// </remarks>
        /// <example>
        /// 
        /// Generate two metadata files associated with the MyClass Apex class (MyClass.cls and MyClass.cls-meta.xml) in the current directory:
        /// <%= config.bin %> <%= command.id %> --name MyClass
        /// Similar to previous example, but generates the files in the "force-app/main/default/classes" directory:
        /// <%= config.bin %> <%= command.id %> --name MyClass --output-dir force-app/main/default/classes
        /// </example>
        [Command("generate class")]
        public SfdxResponse GenerateClass(ApexGenerateClassOptions options)
        {
            return ExecuteCommand(nameof(GenerateClass), options);
        }

        /// <summary>
        /// Generates the Apex trigger *.trigger file and associated metadata file. These files must be contained in a parent directory called "triggers" in your package directory. Either run this command from an existing directory of this name, or use the --output-dir flag to generate one or point to an existing one.
        /// 
        /// If you don't specify the --sobject flag, the .trigger file contains the generic placeholder SOBJECT; replace it with the Salesforce object you want to generate a trigger for. If you don't specify --event, "before insert" is used.
        /// </summary>
        /// <remarks>
        /// Generates the Apex trigger *.trigger file and associated metadata file. These files must be contained in a parent directory called "triggers" in your package directory. Either run this command from an existing directory of this name, or use the --output-dir flag to generate one or point to an existing one.
        /// 
        /// If you don't specify the --sobject flag, the .trigger file contains the generic placeholder SOBJECT; replace it with the Salesforce object you want to generate a trigger for. If you don't specify --event, "before insert" is used.
        /// </remarks>
        /// <example>
        /// 
        /// Generate two files associated with the MyTrigger Apex trigger (MyTrigger.trigger and MyTrigger.trigger-meta.xml) in the current directory:
        /// <%= config.bin %> <%= command.id %> --name MyTrigger
        /// Similar to the previous example, but generate the files in the "force-app/main/default/triggers" directory:
        /// <%= config.bin %> <%= command.id %> --name MyTrigger --output-dir force-app/main/default/triggers
        /// Generate files for a trigger that fires on the Account object before and after an insert:
        /// <%= config.bin %> <%= command.id %> --name MyTrigger --sobject Account --event "before insert,after insert"
        /// </example>
        [Command("generate trigger")]
        public SfdxResponse GenerateTrigger(ApexGenerateTriggerOptions options)
        {
            return ExecuteCommand(nameof(GenerateTrigger), options);
        }

        /// <summary>
        /// To get the IDs for your debug logs, run "<%= config.bin %> apex log list". Executing this command without flags returns the most recent log.
        /// </summary>
        /// <remarks>
        /// To get the IDs for your debug logs, run "<%= config.bin %> apex log list". Executing this command without flags returns the most recent log.
        /// </remarks>
        /// <example>
        /// 
        /// Fetch the log in your default org using an ID:
        /// <%= config.bin %> <%= command.id %> --log-id <log id>
        /// Fetch the log in the org with the specified username using an ID:
        /// <%= config.bin %> <%= command.id %> --log-id <log id> --target-org me@my.org
        /// Fetch the two most recent logs in your default org:
        /// <%= config.bin %> <%= command.id %> --number 2
        /// Similar to previous example, but save the two log files in the specified directory:
        /// <%= config.bin %> <%= command.id %> --output-dir /Users/sfdxUser/logs --number 2
        /// </example>
        [Command("get log")]
        public SfdxResponse GetLog(ApexGetLogOptions options)
        {
            return ExecuteCommand(nameof(GetLog), options);
        }

        /// <summary>
        /// Provide a test run ID to display test results for an enqueued or completed asynchronous test run. The test run ID is displayed after running the "<%= config.bin %> apex test run" command.
        /// </summary>
        /// <remarks>
        /// Provide a test run ID to display test results for an enqueued or completed asynchronous test run. The test run ID is displayed after running the "<%= config.bin %> apex test run" command.
        /// </remarks>
        /// <example>
        /// 
        /// Display test results for your default org using a test run ID:
        /// <%= config.bin %> <%= command.id %> --test-run-id <test run id>
        /// Similar to previous example, but output the result in JUnit format:
        /// <%= config.bin %> <%= command.id %> --test-run-id <test run id> --result-format junit
        /// Also retrieve code coverage results and output in JSON format:
        /// <%= config.bin %> <%= command.id %> --test-run-id <test run id> --code-coverage --json
        /// Specify a directory in which to save the test results from the org with the specified username (rather than your default org):
        /// <%= config.bin %> <%= command.id %> --test-run-id <test run id> --code-coverage --output-dir <path to outputdir> --target-org me@myorg',
        /// </example>
        [Command("get test")]
        public SfdxResponse GetTest(ApexGetTestOptions options)
        {
            return ExecuteCommand(nameof(GetTest), options);
        }

        /// <summary>
        /// Run this command in a project to list the IDs and general information for all debug logs in your default org.
        /// 
        /// To fetch a specific log from your org, obtain the ID from this command's output, then run the “<%= config.bin %> apex log get” command.
        /// </summary>
        /// <remarks>
        /// Run this command in a project to list the IDs and general information for all debug logs in your default org.
        /// 
        /// To fetch a specific log from your org, obtain the ID from this command's output, then run the “<%= config.bin %> apex log get” command.
        /// </remarks>
        /// <example>
        /// 
        /// List the IDs and information about the debug logs in your default org:
        /// <%= config.bin %> <%= command.id %>
        /// Similar to previous example, but use the org with the specified username:
        /// <%= config.bin %> <%= command.id %> --target-org me@my.org
        /// </example>
        [Command("list log")]
        public SfdxResponse ListLog(ApexListLogOptions options)
        {
            return ExecuteCommand(nameof(ListLog), options);
        }

        /// <summary>
        /// If you don’t run this command from within a Salesforce DX project, you must specify the —-target-org flag.
        /// 
        /// To execute your code interactively, run this command with no flags. At the prompt, enter all your Apex code; press CTRL-D when you're finished. Your code is then executed in a single execute anonymous request.
        /// For more information, see "Anonymous Blocks" in the Apex Developer Guide.
        /// </summary>
        /// <remarks>
        /// If you don’t run this command from within a Salesforce DX project, you must specify the —-target-org flag.
        /// 
        /// To execute your code interactively, run this command with no flags. At the prompt, enter all your Apex code; press CTRL-D when you're finished. Your code is then executed in a single execute anonymous request.
        /// For more information, see "Anonymous Blocks" in the Apex Developer Guide.
        /// </remarks>
        /// <example>
        /// 
        /// Execute the Apex code that's in the ~/test.apex file in the org with the specified username:
        /// <%= config.bin %> <%= command.id %> --target-org testusername@salesforce.org --file ~/test.apex
        /// Similar to previous example, but execute the code in your default org:
        /// <%= config.bin %> <%= command.id %> --file ~/test.apex
        /// Run the command with no flags to start interactive mode; the code will execute in your default org when you exit. At the prompt, start type Apex code and press the Enter key after each line. Press CTRL+D when finished.
        /// <%= config.bin %> <%= command.id %>
        /// </example>
        [Command("run")]
        public SfdxResponse Run(ApexRunOptions options)
        {
            return ExecuteCommand(nameof(Run), options);
        }

        /// <summary>
        /// Specify which tests to run by using the --class-names, --suite-names, or --tests flags. Alternatively, use the --test-level flag to run all the tests in your org, local tests, or specified tests.
        /// 
        /// To see code coverage results, use the --code-coverage flag with --result-format. The output displays a high-level summary of the test run and the code coverage values for classes in your org. If you specify human-readable result format, use the --detailed-coverage flag to see detailed coverage results for each test method run.
        /// 
        /// By default, Apex tests run asynchronously and immediately return a test run ID. You can use the --wait flag to specify the number of minutes to wait; if the tests finish in that timeframe, the command displays the results. If the tests haven't finished by the end of the wait time, the command displays a test run ID. Use the "<%= config.bin %> apex get test --test-run-id" command to get the results.
        /// 
        /// NOTE: The testRunCoverage value (JSON and JUnit result formats) is a percentage of the covered lines and total lines from all the Apex classes evaluated by the tests in this run.
        /// </summary>
        /// <remarks>
        /// Specify which tests to run by using the --class-names, --suite-names, or --tests flags. Alternatively, use the --test-level flag to run all the tests in your org, local tests, or specified tests.
        /// 
        /// To see code coverage results, use the --code-coverage flag with --result-format. The output displays a high-level summary of the test run and the code coverage values for classes in your org. If you specify human-readable result format, use the --detailed-coverage flag to see detailed coverage results for each test method run.
        /// 
        /// By default, Apex tests run asynchronously and immediately return a test run ID. You can use the --wait flag to specify the number of minutes to wait; if the tests finish in that timeframe, the command displays the results. If the tests haven't finished by the end of the wait time, the command displays a test run ID. Use the "<%= config.bin %> apex get test --test-run-id" command to get the results.
        /// 
        /// NOTE: The testRunCoverage value (JSON and JUnit result formats) is a percentage of the covered lines and total lines from all the Apex classes evaluated by the tests in this run.
        /// </remarks>
        /// <example>
        /// 
        /// Run all Apex tests and suites in your default org:
        /// <%= config.bin %> <%= command.id %>
        /// Run the specified Apex test classes in your default org and display results in human-readable form:
        /// <%= config.bin %> <%= command.id %> --class-names MyClassTest --class-names MyOtherClassTest --result-format human
        /// Run the specified Apex test suites in your default org and include code coverage results and additional details:
        /// <%= config.bin %> <%= command.id %> --suite-names MySuite --suite-names MyOtherSuite --code-coverage --detailed-coverage
        /// Run the specified Apex tests in your default org and display results in human-readable output:
        /// <%= config.bin %> <%= command.id %> --tests MyClassTest.testCoolFeature --tests MyClassTest.testAwesomeFeature --tests AnotherClassTest --tests namespace.TheirClassTest.testThis --result-format human
        /// Run all tests in the org with the specified username with the specified test level; save the output to the specified directory:
        /// <%= config.bin %> <%= command.id %> --test-level RunLocalTests --output-dir <path to outputdir> --target-org me@my.org
        /// </example>
        [Command("run test")]
        public SfdxResponse RunTest(ApexRunTestOptions options)
        {
            return ExecuteCommand(nameof(RunTest), options);
        }

        /// <summary>
        /// You can also pipe the logs to a file.
        /// </summary>
        /// <remarks>
        /// You can also pipe the logs to a file.
        /// </remarks>
        /// <example>
        /// 
        /// Activate debug logging:
        /// <%= config.bin %> <%= command.id %>
        /// Specify a debug level:
        /// <%= config.bin %> <%= command.id %> --debug-level MyDebugLevel
        /// Skip the trace flag setup and apply default colors:
        /// <%= config.bin %> <%= command.id %> --color --skip-trace-flag
        /// </example>
        [Command("tail log")]
        public SfdxResponse TailLog(ApexTailLogOptions options)
        {
            return ExecuteCommand(nameof(TailLog), options);
        }
    }
}

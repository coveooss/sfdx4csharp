// Generated on November 2nd 2018, 11:11:11 am using sfdx-cli/6.38.0-0d66175ccf (windows-x64) node-v8.9.4. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method classCreate of class Apex.
  /// </summary>
  public class ApexClassCreateOptions : SFDXOptions {
    /// <summary>
    /// [Required] The name of the new Apex class. The name can be up to 40 characters and must start with a letter.
    /// </summary>  
    [SwitchName("--classname")]
    public string classname  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Required] Formats output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public string json  {get; set;}
  
    /// <summary>
    /// [Required] The API version of the created source.
    /// </summary>  
    [SwitchName("--apiversion")]
    public string apiversion  {get; set;}
  
    /// <summary>
    /// [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
    /// </summary>  
    [SwitchName("--reflect")]
    public string reflect  {get; set;}
  
    /// <summary>
    /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
    /// </summary>  
    [SwitchName("--outputdir")]
    public string outputdir  {get; set;}
  
    /// <summary>
    /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
    /// </summary>  
    [SwitchName("--template")]
    public string template  {get; set;}
  }
  
  /// <summary>
  /// Options for the method execute of class Apex.
  /// </summary>
  public class ApexExecuteOptions : SFDXOptions {
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Required] Path to a local file that contains Apex code.
    /// </summary>  
    [SwitchName("--apexcodefile")]
    public string apexcodefile  {get; set;}
  }
  
  /// <summary>
  /// Options for the method logGet of class Apex.
  /// </summary>
  public class ApexLogGetOptions : SFDXOptions {
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Optional] Number of most recent logs to display.
    /// </summary>  
    [SwitchName("--number")]
    public int? number  {get; set;}
  
    /// <summary>
    /// [Required] ID of the log to display.
    /// </summary>  
    [SwitchName("--logid")]
    public string logid  {get; set;}
  
    /// <summary>
    /// [Optional] Applies default colors to noteworthy log lines.
    /// </summary>  
    [SwitchName("--color")]
    public bool? color  {get; set;}
  }
  
  /// <summary>
  /// Options for the method logList of class Apex.
  /// </summary>
  public class ApexLogListOptions : SFDXOptions {
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  }
  
  /// <summary>
  /// Options for the method logTail of class Apex.
  /// </summary>
  public class ApexLogTailOptions : SFDXOptions {
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Optional] Skips trace flag setup. Assumes that a trace flag and debug level are fully set up.
    /// </summary>  
    [SwitchName("--skiptraceflag")]
    public bool? skiptraceflag  {get; set;}
  
    /// <summary>
    /// [Required] Debug level to set on the DEVELOPER_LOG trace flag for your user.
    /// </summary>  
    [SwitchName("--debuglevel")]
    public string debuglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Applies default colors to noteworthy log lines.
    /// </summary>  
    [SwitchName("--color")]
    public bool? color  {get; set;}
  }
  
  /// <summary>
  /// Options for the method testReport of class Apex.
  /// </summary>
  public class ApexTestReportOptions : SFDXOptions {
    /// <summary>
    /// [Required] The ID of test run.
    /// </summary>  
    [SwitchName("--testrunid")]
    public string testrunid  {get; set;}
  
    /// <summary>
    /// [Optional] Displays Apex test processing details. If JSON format is specified, processing details aren’t displayed.
    /// </summary>  
    [SwitchName("--verbose")]
    public bool? verbose  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Optional] Sets the streaming client socket timeout, in minutes. If the streaming client socket has no contact from the server for a number of minutes, the client exits. Specify a longer wait time if timeouts occur frequently.
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  
    /// <summary>
    /// [Required] Format to use when displaying test results. If you also specify the --json flag, --json overrides this parameter.
    /// </summary>  
    [SwitchName("--resultformat")]
    public string resultformat  {get; set;}
  
    /// <summary>
    /// [Required] Directory to store test run files.
    /// </summary>  
    [SwitchName("--outputdir")]
    public string outputdir  {get; set;}
  
    /// <summary>
    /// [Optional] Retrieves code coverage results.
    /// </summary>  
    [SwitchName("--codecoverage")]
    public bool? codecoverage  {get; set;}
  }
  
  /// <summary>
  /// Options for the method testRun of class Apex.
  /// </summary>
  public class ApexTestRunOptions : SFDXOptions {
    /// <summary>
    /// [Optional] Sets the streaming client socket timeout, in minutes. If the streaming client socket has no contact from the server for a number of minutes, the client exits. Specify a longer wait time if timeouts occur frequently.
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  
    /// <summary>
    /// [Optional] Displays Apex test processing details. If JSON format is specified, processing details aren’t displayed.
    /// </summary>  
    [SwitchName("--verbose")]
    public bool? verbose  {get; set;}
  
    /// <summary>
    /// [Optional] Specifies how long to wait (in minutes) for Apex pre-compilation to complete before running the tests or timing out.
    /// </summary>  
    [SwitchName("--precompilewait")]
    public int? precompilewait  {get; set;}
  
    /// <summary>
    /// [Required] Comma-separated list of Apex test class names to run. You can specify only one of classnames, suitenames, or tests.
    /// </summary>  
    [SwitchName("--classnames")]
    public string classnames  {get; set;}
  
    /// <summary>
    /// [Required] Comma-separated list of Apex test class names or IDs and test methods, if applicable, to run. You can only specify one of classnames, suitenames, or tests.
    /// </summary>  
    [SwitchName("--tests")]
    public string tests  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Optional] Runs test methods from a single Apex class synchronously. If you don't specify this flag, tests are run asynchronously.
    /// </summary>  
    [SwitchName("--synchronous")]
    public bool? synchronous  {get; set;}
  
    /// <summary>
    /// [Optional] Retrieves code coverage results.
    /// </summary>  
    [SwitchName("--codecoverage")]
    public bool? codecoverage  {get; set;}
  
    /// <summary>
    /// [Required] Comma-separated list of Apex test suite names to run. You can only specify one of classnames, suitenames, or tests.
    /// </summary>  
    [SwitchName("--suitenames")]
    public string suitenames  {get; set;}
  
    /// <summary>
    /// [Required] Format to use when displaying test results. If you also specify the --json flag, --json overrides this parameter.
    /// </summary>  
    [SwitchName("--resultformat")]
    public string resultformat  {get; set;}
  
    /// <summary>
    /// [Required] Specifies which tests to run, using one of these TestLevel enum values:
    /// RunSpecifiedTests—Only the tests that you specify are run.
    /// RunLocalTests—All tests in your org are run, except the ones that originate from installed managed packages.
    /// RunAllTestsInOrg—All tests are in your org and in installed managed packages are run.
    /// </summary>  
    [SwitchName("--testlevel")]
    public string testlevel  {get; set;}
  
    /// <summary>
    /// [Required] Directory to store test run files.
    /// </summary>  
    [SwitchName("--outputdir")]
    public string outputdir  {get; set;}
  }
  
  /// <summary>
  /// Options for the method triggerCreate of class Apex.
  /// </summary>
  public class ApexTriggerCreateOptions : SFDXOptions {
    /// <summary>
    /// [Required] The name of the new Apex trigger. The name can be up to 40 characters and must start with a letter.
    /// </summary>  
    [SwitchName("--triggername")]
    public string triggername  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Required] Formats output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public string json  {get; set;}
  
    /// <summary>
    /// [Required] The events that cause the trigger to fire.
    /// </summary>  
    [SwitchName("--triggerevents")]
    public string triggerevents  {get; set;}
  
    /// <summary>
    /// [Required] The sObject to create an Apex trigger on.
    /// </summary>  
    [SwitchName("--sobject")]
    public string sobject  {get; set;}
  
    /// <summary>
    /// [Required] The API version of the created source.
    /// </summary>  
    [SwitchName("--apiversion")]
    public string apiversion  {get; set;}
  
    /// <summary>
    /// [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
    /// </summary>  
    [SwitchName("--reflect")]
    public string reflect  {get; set;}
  
    /// <summary>
    /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
    /// </summary>  
    [SwitchName("--outputdir")]
    public string outputdir  {get; set;}
  
    /// <summary>
    /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
    /// </summary>  
    [SwitchName("--template")]
    public string template  {get; set;}
  }
  

  /// <summary>
  /// Apex
  /// </summary>
  [CommandClass("force:apex")]
  public class Apex : SFDXCommand {

    /// Constructor.
    public Apex(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// create an Apex class
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
    /// force:apex:class:create -n <string> [-t <string>] [-d <string>] [-a <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("class:create")]
      public JToken ClassCreate(ApexClassCreateOptions p_Options) {
        return ExecuteCommand<ApexClassCreateOptions, JToken>(nameof(ClassCreate), p_Options);      
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
    /// force:apex:execute [-f <filepath>] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("execute")]
      public JToken Execute(ApexExecuteOptions p_Options) {
        return ExecuteCommand<ApexExecuteOptions, JToken>(nameof(Execute), p_Options);      
      }
    
    /// <summary>
    /// fetch a debug log
    /// </summary>
    /// <remarks>
    /// Fetches a specific debug log.
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
    /// force:apex:log:get (-i <id> | -n <number>) [-c] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("log:get")]
      public JToken LogGet(ApexLogGetOptions p_Options) {
        return ExecuteCommand<ApexLogGetOptions, JToken>(nameof(LogGet), p_Options);      
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
    /// force:apex:log:list [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("log:list")]
      public JToken LogList(ApexLogListOptions p_Options) {
        return ExecuteCommand<ApexLogListOptions, JToken>(nameof(LogList), p_Options);      
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
    /// force:apex:log:tail [-c] [-d <string>] [-s] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("log:tail")]
      public JToken LogTail(ApexLogTailOptions p_Options) {
        return ExecuteCommand<ApexLogTailOptions, JToken>(nameof(LogTail), p_Options);      
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
    /// force:apex:test:report -i <id> [-c] [-d <directory>] [-r <string>] [-w <minutes>] [-u <string>] [--json] [--loglevel <string>] [--verbose]
    /// </example>
    [Command("test:report")]
      public JToken TestReport(ApexTestReportOptions p_Options) {
        return ExecuteCommand<ApexTestReportOptions, JToken>(nameof(TestReport), p_Options);      
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
    /// force:apex:test:run (-n <string>... | -s <string>... | -t <string>...) [-c] [-d <directory>] [-l <string>] [-r <string>] [-w <minutes>] [-y] [-u <string>] [--json] [--loglevel <string>] [--verbose]
    /// </example>
    [Command("test:run")]
      public JToken TestRun(ApexTestRunOptions p_Options) {
        return ExecuteCommand<ApexTestRunOptions, JToken>(nameof(TestRun), p_Options);      
      }
    
    /// <summary>
    /// create an Apex trigger
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
    ///    $ sfdx force:apex:trigger:create -n MyTrigger -s Account -e 'before insert, after upsert'
    ///    $ sfdx force:apex:trigger:create -n MyTrigger -d triggers
    /// 
    /// force:apex:trigger:create -n <string> [-t <string>] [-d <string>] [-a <string>] [-s <string>] [-e <string>...] [--json] [--loglevel <string>]
    /// </example>
    [Command("trigger:create")]
      public JToken TriggerCreate(ApexTriggerCreateOptions p_Options) {
        return ExecuteCommand<ApexTriggerCreateOptions, JToken>(nameof(TriggerCreate), p_Options);      
      }
    
  }
}

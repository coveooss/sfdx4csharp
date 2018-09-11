// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method classCreate of class Apex.
 *
 * IApexClassCreate
 */
public class ApexClassCreateOptions : SFDXOptions {

  /**
   * [Required] The name of the new Apex class. The name can be up to 40 characters and must start with a letter.
   * @type {string}
   * @memberof ApexClassCreateOptions
   */
  [SwitchName("--classname")]
  public string classname  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ApexClassCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] Formats output as JSON.
   * @type {string}
   * @memberof ApexClassCreateOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] The API version of the created source.
   * @type {string}
   * @memberof ApexClassCreateOptions
   */
  [SwitchName("--apiversion")]
  public string apiversion  {get; set;}

  /**
   * [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
   * @type {string}
   * @memberof ApexClassCreateOptions
   */
  [SwitchName("--reflect")]
  public string reflect  {get; set;}

  /**
   * [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
   * @type {string}
   * @memberof ApexClassCreateOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
   * @type {string}
   * @memberof ApexClassCreateOptions
   */
  [SwitchName("--template")]
  public string template  {get; set;}
}

/**
 * Options for the method execute of class Apex.
 *
 * IApexExecute
 */
public class ApexExecuteOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ApexExecuteOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof ApexExecuteOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof ApexExecuteOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Path to a local file that contains Apex code.
   * @type {string}
   * @memberof ApexExecuteOptions
   */
  [SwitchName("--apexcodefile")]
  public string apexcodefile  {get; set;}
}

/**
 * Options for the method logGet of class Apex.
 *
 * IApexLogGet
 */
public class ApexLogGetOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ApexLogGetOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof ApexLogGetOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof ApexLogGetOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Number of most recent logs to display.
   * @type {string}
   * @memberof ApexLogGetOptions
   */
  [SwitchName("--number")]
  public string number  {get; set;}

  /**
   * [Required] ID of the log to display.
   * @type {string}
   * @memberof ApexLogGetOptions
   */
  [SwitchName("--logid")]
  public string logid  {get; set;}

  /**
   * [Optional] Applies default colors to noteworthy log lines.
   * @type {bool}
   * @memberof ApexLogGetOptions
   */
  [SwitchName("--color")]
  public bool? color  {get; set;}
}

/**
 * Options for the method logList of class Apex.
 *
 * IApexLogList
 */
public class ApexLogListOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ApexLogListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof ApexLogListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof ApexLogListOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method logTail of class Apex.
 *
 * IApexLogTail
 */
public class ApexLogTailOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ApexLogTailOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof ApexLogTailOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof ApexLogTailOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Skips trace flag setup. Assumes that a trace flag and debug level are fully set up.
   * @type {bool}
   * @memberof ApexLogTailOptions
   */
  [SwitchName("--skiptraceflag")]
  public bool? skiptraceflag  {get; set;}

  /**
   * [Required] Debug level to set on the DEVELOPER_LOG trace flag for your user.
   * @type {string}
   * @memberof ApexLogTailOptions
   */
  [SwitchName("--debuglevel")]
  public string debuglevel  {get; set;}

  /**
   * [Optional] Applies default colors to noteworthy log lines.
   * @type {bool}
   * @memberof ApexLogTailOptions
   */
  [SwitchName("--color")]
  public bool? color  {get; set;}
}

/**
 * Options for the method testReport of class Apex.
 *
 * IApexTestReport
 */
public class ApexTestReportOptions : SFDXOptions {

  /**
   * [Required] The ID of test run.
   * @type {string}
   * @memberof ApexTestReportOptions
   */
  [SwitchName("--testrunid")]
  public string testrunid  {get; set;}

  /**
   * [Optional] Displays Apex test processing details. If JSON format is specified, processing details aren’t displayed.
   * @type {bool}
   * @memberof ApexTestReportOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ApexTestReportOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof ApexTestReportOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof ApexTestReportOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Sets the streaming client socket timeout, in minutes. If the streaming client socket has no contact from the server for a number of minutes, the client exits. Specify a longer wait time if timeouts occur frequently.
   * @type {string}
   * @memberof ApexTestReportOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Required] Format to use when displaying test results. If you also specify the --json flag, --json overrides this parameter.
   * @type {string}
   * @memberof ApexTestReportOptions
   */
  [SwitchName("--resultformat")]
  public string resultformat  {get; set;}

  /**
   * [Required] Directory to store test run files.
   * @type {string}
   * @memberof ApexTestReportOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Optional] Retrieves code coverage results.
   * @type {bool}
   * @memberof ApexTestReportOptions
   */
  [SwitchName("--codecoverage")]
  public bool? codecoverage  {get; set;}
}

/**
 * Options for the method testRun of class Apex.
 *
 * IApexTestRun
 */
public class ApexTestRunOptions : SFDXOptions {

  /**
   * [Required] Sets the streaming client socket timeout, in minutes. If the streaming client socket has no contact from the server for a number of minutes, the client exits. Specify a longer wait time if timeouts occur frequently.
   * @type {string}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Optional] Displays Apex test processing details. If JSON format is specified, processing details aren’t displayed.
   * @type {bool}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Required] Specifies how long to wait (in minutes) for Apex pre-compilation to complete before running the tests or timing out.
   * @type {string}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--precompilewait")]
  public string precompilewait  {get; set;}

  /**
   * [Required] Comma-separated list of Apex test class names to run. You can specify only one of classnames, suitenames, or tests.
   * @type {string}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--classnames")]
  public string classnames  {get; set;}

  /**
   * [Required] Comma-separated list of Apex test class names or IDs and test methods, if applicable, to run. You can only specify one of classnames, suitenames, or tests.
   * @type {string}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--tests")]
  public string tests  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Runs test methods from a single Apex class synchronously. If you don't specify this flag, tests are run asynchronously.
   * @type {bool}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--synchronous")]
  public bool? synchronous  {get; set;}

  /**
   * [Optional] Retrieves code coverage results.
   * @type {bool}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--codecoverage")]
  public bool? codecoverage  {get; set;}

  /**
   * [Required] Comma-separated list of Apex test suite names to run. You can only specify one of classnames, suitenames, or tests.
   * @type {string}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--suitenames")]
  public string suitenames  {get; set;}

  /**
   * [Required] Format to use when displaying test results. If you also specify the --json flag, --json overrides this parameter.
   * @type {string}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--resultformat")]
  public string resultformat  {get; set;}

  /**
   * [Required] Specifies which tests to run, using one of these TestLevel enum values:
   * RunSpecifiedTests—Only the tests that you specify are run.
   * RunLocalTests—All tests in your org are run, except the ones that originate from installed managed packages.
   * RunAllTestsInOrg—All tests are in your org and in installed managed packages are run.
   * @type {string}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--testlevel")]
  public string testlevel  {get; set;}

  /**
   * [Required] Directory to store test run files.
   * @type {string}
   * @memberof ApexTestRunOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}
}

/**
 * Options for the method triggerCreate of class Apex.
 *
 * IApexTriggerCreate
 */
public class ApexTriggerCreateOptions : SFDXOptions {

  /**
   * [Required] The name of the new Apex trigger. The name can be up to 40 characters and must start with a letter.
   * @type {string}
   * @memberof ApexTriggerCreateOptions
   */
  [SwitchName("--triggername")]
  public string triggername  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ApexTriggerCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] Formats output as JSON.
   * @type {string}
   * @memberof ApexTriggerCreateOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] The events that cause the trigger to fire.
   * @type {string}
   * @memberof ApexTriggerCreateOptions
   */
  [SwitchName("--triggerevents")]
  public string triggerevents  {get; set;}

  /**
   * [Required] The sObject to create an Apex trigger on.
   * @type {string}
   * @memberof ApexTriggerCreateOptions
   */
  [SwitchName("--sobject")]
  public string sobject  {get; set;}

  /**
   * [Required] The API version of the created source.
   * @type {string}
   * @memberof ApexTriggerCreateOptions
   */
  [SwitchName("--apiversion")]
  public string apiversion  {get; set;}

  /**
   * [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
   * @type {string}
   * @memberof ApexTriggerCreateOptions
   */
  [SwitchName("--reflect")]
  public string reflect  {get; set;}

  /**
   * [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
   * @type {string}
   * @memberof ApexTriggerCreateOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
   * @type {string}
   * @memberof ApexTriggerCreateOptions
   */
  [SwitchName("--template")]
  public string template  {get; set;}
}


/**
 * Apex
 *
 * @class Apex
 */
[CommandClass("force:apex")]
public class Apex : SFDXCommand {
        /// <inheritDoc />
    public Apex(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * create an Apex class
   * @returns {(Promise<Object | void>)}
   * @memberof Apex
   * @description Creates an Apex class in the specified directory or the current working directory. If you don’t explicitly set the API version, it defaults to the current API version. The .cls file and associated metadata file are created.
   * @example If not supplied, the apiversion, template, and outputdir use default values.
   * The outputdir can be an absolute path or relative to the current working directory.
   * 
   * Examples:
   *    $ sfdx force:apex:class:create -n MyClass
   *    $ sfdx force:apex:class:create -n MyClass -d classes
   * 
   * force:apex:class:create -n <string> [-t <string>] [-d <string>] [-a <string>] [--json] [--loglevel <string>]
   */
   [Command("class:create")]
    public JToken classCreate(ApexClassCreateOptions p_Options) {
      return ExecuteCommand<ApexClassCreateOptions, JToken>(nameof(classCreate), p_Options);      
    }
  
  /**
   * execute anonymous Apex code
   * @returns {(Promise<Object | void>)}
   * @memberof Apex
   * @description Executes one or more lines of anonymous Apex code, or executes the code in a local file.
   * @example Executes one or more lines of Apex code, or executes the code in a local file.
   * Before you enter code, run this command with no parameters to get a prompt.
   * From the prompt, all commands are executed in a single execute anonymous request.
   * For more information, see "Anonymous Blocks" in the Apex Developer Guide.
   * 
   * Examples:
   *    $ sfdx force:apex:execute -f ~/test.apex
   * 
   *    $ sfdx force:apex:execute 
   *    >> Start typing Apex code. Press the Enter key after each line, 
   *    >> then press CTRL+D when finished.
   * force:apex:execute [-f <filepath>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("execute")]
    public JToken execute(ApexExecuteOptions p_Options) {
      return ExecuteCommand<ApexExecuteOptions, JToken>(nameof(execute), p_Options);      
    }
  
  /**
   * fetch a debug log
   * @returns {(Promise<Object | void>)}
   * @memberof Apex
   * @description Fetches a specific debug log.
   * @example When you execute this command in a project, it fetches the specified log or given number of last logs from your default scratch org.
   * 
   * To get the IDs for your debug logs, run "sfdx force:apex:log:list".
   * 
   * To specify a count of logs to return, use the --number parameter to return the most recent logs.
   * 
   * Executing this command without parameters returns the most recent log.
   * 
   * Examples:
   *    $ sfdx force:apex:log:get -i <log id>
   *    $ sfdx force:apex:log:get -i <log id> -u me@my.org
   *    $ sfdx force:apex:log:get -n 2 -c
   * force:apex:log:get (-i <id> | -n <number>) [-c] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("log:get")]
    public JToken logGet(ApexLogGetOptions p_Options) {
      return ExecuteCommand<ApexLogGetOptions, JToken>(nameof(logGet), p_Options);      
    }
  
  /**
   * list debug logs
   * @returns {(Promise<Object | void>)}
   * @memberof Apex
   * @description Displays a list of debug log IDs, along with general information about the logs.
   * @example When you execute this command in a project, it lists the log IDs for your default scratch org.
   * 
   * Examples:
   *    $ sfdx force:apex:log:list
   *    $ sfdx force:apex:log:list -u me@my.org
   * force:apex:log:list [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("log:list")]
    public JToken logList(ApexLogListOptions p_Options) {
      return ExecuteCommand<ApexLogListOptions, JToken>(nameof(logList), p_Options);      
    }
  
  /**
   * start debug logging and display logs
   * @returns {(Promise<Object | void>)}
   * @memberof Apex
   * @description Activates debug logging and displays logs in the terminal. You can also pipe the logs to a file.
   * @example Tails logs from your target org for 30 minutes.
   * 
   * If a DEVELOPER_LOG trace flag does not exist, this command creates one in the target org.
   * 
   * If the active trace flag's expiration date is within this command's timeout window, the command sets the trace flag's expiration date to 30 minutes from the current time.
   * 
   * The --debuglevel parameter assigns a debug level to the active DEVELOPER_LOG trace flag.
   * 
   * Use --skiptraceflag to skip trace flag setup, including setting expiration date and debug level. Include this flag only if there is an active user-based trace flag for your user.
   * 
   * The --json parameter emits log lines in JSON, but does not follow the standard Salesforce CLI JSON format (which includes status and result values).
   * 
   * Examples:
   *    $ sfdx force:apex:log:tail
   *    $ sfdx force:apex:log:tail --debuglevel MyDebugLevel
   *    $ sfdx force:apex:log:tail -c -s
   * force:apex:log:tail [-c] [-d <string>] [-s] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("log:tail")]
    public JToken logTail(ApexLogTailOptions p_Options) {
      return ExecuteCommand<ApexLogTailOptions, JToken>(nameof(logTail), p_Options);      
    }
  
  /**
   * display test results
   * @returns {(Promise<Object | void>)}
   * @memberof Apex
   * @description Displays the test results for a specific test run.
   * @example Displays test results for an enqueued or completed asynchronous Apex test run.
   * 
   * Examples:
   *    $ sfdx force:apex:test:report -i <test run id>
   *    $ sfdx force:apex:test:report -i <test run id> -r junit
   *    $ sfdx force:apex:test:report -i <test run id> -c --json
   * force:apex:test:report -i <id> [-c] [-d <directory>] [-r <string>] [-w <minutes>] [-u <string>] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("test:report")]
    public JToken testReport(ApexTestReportOptions p_Options) {
      return ExecuteCommand<ApexTestReportOptions, JToken>(nameof(testReport), p_Options);      
    }
  
  /**
   * invoke Apex tests
   * @returns {(Promise<Object | void>)}
   * @memberof Apex
   * @description Runs Apex tests.
   * @example By default, runs all Apex tests in the org’s namespace.
   * 
   * To run specific test classes, specify class names or suite names, or set a --testlevel value.
   * 
   * To run specific test methods, use --tests.
   * 
   * Examples:
   *    $ sfdx force:apex:test:run
   *    $ sfdx force:apex:test:run -n MyClassTest,MyOtherClassTest -r human
   *    $ sfdx force:apex:test:run -s MySuite,MyOtherSuite -c --json
   *    $ sfdx force:apex:test:run -t MyClassTest.testCoolFeature,MyClassTest.testAwesomeFeature,AnotherClassTest,namespace.TheirClassTest.testThis -r human
   *    $ sfdx force:apex:test:run -l RunLocalTests -d <path to outputdir> -u me@my.org
   * force:apex:test:run (-n <string>... | -s <string>... | -t <string>...) [-c] [-d <directory>] [-l <string>] [-r <string>] [-w <minutes>] [-y] [-u <string>] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("test:run")]
    public JToken testRun(ApexTestRunOptions p_Options) {
      return ExecuteCommand<ApexTestRunOptions, JToken>(nameof(testRun), p_Options);      
    }
  
  /**
   * create an Apex trigger
   * @returns {(Promise<Object | void>)}
   * @memberof Apex
   * @description Creates an Apex trigger in the specified directory or the current working directory. If you don’t explicitly set the API version, it defaults to the current API version. The .trigger file and associated metadata file are created.
   * @example If not supplied, the apiversion, template, and outputdir use default values.
   * The outputdir can be an absolute path or relative to the current working directory.
   * 
   * Examples:
   *    $ sfdx force:apex:trigger:create -n MyTrigger
   *    $ sfdx force:apex:trigger:create -n MyTrigger -s Account -e 'before insert, after upsert'
   *    $ sfdx force:apex:trigger:create -n MyTrigger -d triggers
   * 
   * force:apex:trigger:create -n <string> [-t <string>] [-d <string>] [-a <string>] [-s <string>] [-e <string>...] [--json] [--loglevel <string>]
   */
   [Command("trigger:create")]
    public JToken triggerCreate(ApexTriggerCreateOptions p_Options) {
      return ExecuteCommand<ApexTriggerCreateOptions, JToken>(nameof(triggerCreate), p_Options);      
    }
  
}

// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method appCreate of class Lightning.
 *
 * ILightningAppCreate
 */
public class LightningAppCreateOptions : SFDXOptions {

  /**
   * [Required] The Lightning app name. The name can be up to 40 characters and must start with a letter.
   * @type {string}
   * @memberof LightningAppCreateOptions
   */
  [SwitchName("--appname")]
  public string appname  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof LightningAppCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] Formats output as JSON.
   * @type {string}
   * @memberof LightningAppCreateOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] The API version of the created source.
   * @type {string}
   * @memberof LightningAppCreateOptions
   */
  [SwitchName("--apiversion")]
  public string apiversion  {get; set;}

  /**
   * [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
   * @type {string}
   * @memberof LightningAppCreateOptions
   */
  [SwitchName("--reflect")]
  public string reflect  {get; set;}

  /**
   * [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
   * @type {string}
   * @memberof LightningAppCreateOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
   * @type {string}
   * @memberof LightningAppCreateOptions
   */
  [SwitchName("--template")]
  public string template  {get; set;}
}

/**
 * Options for the method componentCreate of class Lightning.
 *
 * ILightningComponentCreate
 */
public class LightningComponentCreateOptions : SFDXOptions {

  /**
   * [Required] The Lightning component name. The name can be up to 40 characters and must start with a letter.
   * @type {string}
   * @memberof LightningComponentCreateOptions
   */
  [SwitchName("--componentname")]
  public string componentname  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof LightningComponentCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] Formats output as JSON.
   * @type {string}
   * @memberof LightningComponentCreateOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] The type of the new Lightning component.
   * @type {string}
   * @memberof LightningComponentCreateOptions
   */
  [SwitchName("--type")]
  public string type  {get; set;}

  /**
   * [Required] The API version of the created source.
   * @type {string}
   * @memberof LightningComponentCreateOptions
   */
  [SwitchName("--apiversion")]
  public string apiversion  {get; set;}

  /**
   * [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
   * @type {string}
   * @memberof LightningComponentCreateOptions
   */
  [SwitchName("--reflect")]
  public string reflect  {get; set;}

  /**
   * [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
   * @type {string}
   * @memberof LightningComponentCreateOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
   * @type {string}
   * @memberof LightningComponentCreateOptions
   */
  [SwitchName("--template")]
  public string template  {get; set;}
}

/**
 * Options for the method eventCreate of class Lightning.
 *
 * ILightningEventCreate
 */
public class LightningEventCreateOptions : SFDXOptions {

  /**
   * [Required] The Lightning event name. The name can be up to 40 characters and must start with a letter.
   * @type {string}
   * @memberof LightningEventCreateOptions
   */
  [SwitchName("--eventname")]
  public string eventname  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof LightningEventCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] Formats output as JSON.
   * @type {string}
   * @memberof LightningEventCreateOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] The API version of the created source.
   * @type {string}
   * @memberof LightningEventCreateOptions
   */
  [SwitchName("--apiversion")]
  public string apiversion  {get; set;}

  /**
   * [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
   * @type {string}
   * @memberof LightningEventCreateOptions
   */
  [SwitchName("--reflect")]
  public string reflect  {get; set;}

  /**
   * [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
   * @type {string}
   * @memberof LightningEventCreateOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
   * @type {string}
   * @memberof LightningEventCreateOptions
   */
  [SwitchName("--template")]
  public string template  {get; set;}
}

/**
 * Options for the method interfaceCreate of class Lightning.
 *
 * ILightningInterfaceCreate
 */
public class LightningInterfaceCreateOptions : SFDXOptions {

  /**
   * [Required] The Lightning interface name. The name can be up to 40 characters and must start with a letter.
   * @type {string}
   * @memberof LightningInterfaceCreateOptions
   */
  [SwitchName("--interfacename")]
  public string interfacename  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof LightningInterfaceCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] Formats output as JSON.
   * @type {string}
   * @memberof LightningInterfaceCreateOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] The API version of the created source.
   * @type {string}
   * @memberof LightningInterfaceCreateOptions
   */
  [SwitchName("--apiversion")]
  public string apiversion  {get; set;}

  /**
   * [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
   * @type {string}
   * @memberof LightningInterfaceCreateOptions
   */
  [SwitchName("--reflect")]
  public string reflect  {get; set;}

  /**
   * [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
   * @type {string}
   * @memberof LightningInterfaceCreateOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
   * @type {string}
   * @memberof LightningInterfaceCreateOptions
   */
  [SwitchName("--template")]
  public string template  {get; set;}
}

/**
 * Options for the method lint of class Lightning.
 *
 * ILightningLint
 */
public class LightningLintOptions : SFDXOptions {

  /**
   * [Required] Exit with error code 1 if there are lint issues. The default exits without an error code.
   * @type {string}
   * @memberof LightningLintOptions
   */
  [SwitchName("--exit")]
  public string exit  {get; set;}

  /**
   * [Required] Report both warnings and errors. The default is to report only errors.
   * @type {string}
   * @memberof LightningLintOptions
   */
  [SwitchName("--verbose")]
  public string verbose  {get; set;}

  /**
   * [Required] Path to a custom ESLint configuration file. Only code style rules are used, while the rest are ignored. For example: --config path/to/.eslintrc.
   * @type {string}
   * @memberof LightningLintOptions
   */
  [SwitchName("--config")]
  public string config  {get; set;}

  /**
   * [Required] Format output as JSON, usually for integration with other tools. The default is standard text output format.
   * @type {string}
   * @memberof LightningLintOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] A “glob” pattern used to add specific files to the analysis. For example, to only analyse your controller files, use --files ** /*Controller.js. When specified, this value overrides the --ignore flag. The default is all .js files.
   * @type {string}
   * @memberof LightningLintOptions
   */
  [SwitchName("--files")]
  public string files  {get; set;}

  /**
   * [Required] A “glob” pattern used to filter folders (and their contents) out of the analysis. For example: --ignore ** /foo/**.
   * @type {string}
   * @memberof LightningLintOptions
   */
  [SwitchName("--ignore")]
  public string ignore  {get; set;}
}

/**
 * Options for the method testCreate of class Lightning.
 *
 * ILightningTestCreate
 */
public class LightningTestCreateOptions : SFDXOptions {

  /**
   * [Required] The name of the new Lightning test. The name can be up to 40 characters and must start with a letter.
   * @type {string}
   * @memberof LightningTestCreateOptions
   */
  [SwitchName("--testname")]
  public string testname  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof LightningTestCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Required] Formats output as JSON.
   * @type {string}
   * @memberof LightningTestCreateOptions
   */
  [SwitchName("--json")]
  public string json  {get; set;}

  /**
   * [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
   * @type {string}
   * @memberof LightningTestCreateOptions
   */
  [SwitchName("--reflect")]
  public string reflect  {get; set;}

  /**
   * [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
   * @type {string}
   * @memberof LightningTestCreateOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
   * @type {string}
   * @memberof LightningTestCreateOptions
   */
  [SwitchName("--template")]
  public string template  {get; set;}
}

/**
 * Options for the method testInstall of class Lightning.
 *
 * ILightningTestInstall
 */
public class LightningTestInstallOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof LightningTestInstallOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof LightningTestInstallOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof LightningTestInstallOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Type of LTS unmanaged package to install. 'jasmine' and 'mocha' contains the essentials for development, 'full' contains both, and adds sample components and tests in the package. 'full' is best for 'kicking the tires' of LTS.
   * @type {string}
   * @memberof LightningTestInstallOptions
   */
  [SwitchName("--packagetype")]
  public string packagetype  {get; set;}

  /**
   * [Required] The release version of LTS unmanaged package you want to install.
   * @type {string}
   * @memberof LightningTestInstallOptions
   */
  [SwitchName("--releaseversion")]
  public string releaseversion  {get; set;}

  /**
   * [Required] Maximum number of minutes to wait for installation status.
   * @type {string}
   * @memberof LightningTestInstallOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}
}

/**
 * Options for the method testRun of class Lightning.
 *
 * ILightningTestRun
 */
public class LightningTestRunOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof LightningTestRunOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof LightningTestRunOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof LightningTestRunOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Time, in milliseconds, to wait for the results element to be present in the DOM, before failing and moving on to the next test.
   * @type {string}
   * @memberof LightningTestRunOptions
   */
  [SwitchName("--timeout")]
  public string timeout  {get; set;}

  /**
   * [Optional] Leaves browser open after the test finishes so that you can view the test suite results.
   * @type {bool}
   * @memberof LightningTestRunOptions
   */
  [SwitchName("--leavebrowseropen")]
  public bool? leavebrowseropen  {get; set;}

  /**
   * [Required] Path to a test configuration file to configure WebDriver and other settings. For details, see the LTS documentation.
   * @type {string}
   * @memberof LightningTestRunOptions
   */
  [SwitchName("--configfile")]
  public string configfile  {get; set;}

  /**
   * [Required] Format to use when displaying test results. If you also specify the --json flag, --json overrides this parameter.
   * @type {string}
   * @memberof LightningTestRunOptions
   */
  [SwitchName("--resultformat")]
  public string resultformat  {get; set;}

  /**
   * [Required] Directory path to store test run artifacts: log files, test results, and so on.
   * @type {string}
   * @memberof LightningTestRunOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] Name of your Lightning test application. The name is case insensitive, and ".app" is optional, so "Test" and "test.app" are equivalent.
   * Default value: Test.app
   * @type {string}
   * @memberof LightningTestRunOptions
   */
  [SwitchName("--appname")]
  public string appname  {get; set;}
}


/**
 * Lightning
 *
 * @class Lightning
 */
[CommandClass("force:lightning")]
public class Lightning : SFDXCommand {
        /// <inheritDoc />
    public Lightning(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * create a Lightning app
   * @returns {(Promise<Object | void>)}
   * @memberof Lightning
   * @description Creates a Lightning app bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
   * @example If not supplied, the apiversion, template, and outputdir use default values.
   * The outputdir can be an absolute path or relative to the current working directory.
   * If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
   * 
   * Examples:
   *    $ sfdx force:lightning:app:create -n myapp
   *    $ sfdx force:lightning:app:create -n myapp -d lightning
   * 
   * force:lightning:app:create -n <string> [-t <string>] [-d <string>] [-a <string>] [--json] [--loglevel <string>]
   */
   [Command("app:create")]
    public JToken appCreate(LightningAppCreateOptions p_Options) {
      return ExecuteCommand<LightningAppCreateOptions, JToken>(nameof(appCreate), p_Options);      
    }
  
  /**
   * create a Lightning component
   * @returns {(Promise<Object | void>)}
   * @memberof Lightning
   * @description Creates a Lightning component bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
   * @example If not supplied, the apiversion, template, and outputdir use default values.
   * The outputdir can be an absolute path or relative to the current working directory.
   * If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
   * 
   * Examples:
   *    $ sfdx force:lightning:component:create -n mycomponent
   *    $ sfdx force:lightning:component:create -n mycomponent -d lightning
   * 
   * force:lightning:component:create -n <string> [-t <string>] [-d <string>] [-a <string>] [--json] [--loglevel <string>]
   */
   [Command("component:create")]
    public JToken componentCreate(LightningComponentCreateOptions p_Options) {
      return ExecuteCommand<LightningComponentCreateOptions, JToken>(nameof(componentCreate), p_Options);      
    }
  
  /**
   * create a Lightning event
   * @returns {(Promise<Object | void>)}
   * @memberof Lightning
   * @description Creates a Lightning event bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
   * @example If not supplied, the apiversion, template, and outputdir use default values.
   * The outputdir can be an absolute path or relative to the current working directory.
   * If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
   * 
   * Examples:
   *    $ sfdx force:lightning:event:create -n myevent
   *    $ sfdx force:lightning:event:create -n myevent -d lightning
   * 
   * force:lightning:event:create -n <string> [-t <string>] [-d <string>] [-a <string>] [--json] [--loglevel <string>]
   */
   [Command("event:create")]
    public JToken eventCreate(LightningEventCreateOptions p_Options) {
      return ExecuteCommand<LightningEventCreateOptions, JToken>(nameof(eventCreate), p_Options);      
    }
  
  /**
   * create a Lightning interface
   * @returns {(Promise<Object | void>)}
   * @memberof Lightning
   * @description Creates a Lightning interface bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
   * @example If not supplied, the apiversion, template, and outputdir use default values.
   * The outputdir can be an absolute path or relative to the current working directory.
   * If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
   * 
   * Examples:
   *    $ sfdx force:lightning:interface:create -n myinterface
   *    $ sfdx force:lightning:interface:create -n myinterface -d lightning
   * 
   * force:lightning:interface:create -n <string> [-t <string>] [-d <string>] [-a <string>] [--json] [--loglevel <string>]
   */
   [Command("interface:create")]
    public JToken interfaceCreate(LightningInterfaceCreateOptions p_Options) {
      return ExecuteCommand<LightningInterfaceCreateOptions, JToken>(nameof(interfaceCreate), p_Options);      
    }
  
  /**
   * analyse (lint) Lightning component code
   * @returns {(Promise<Object | void>)}
   * @memberof Lightning
   * @description Runs a static analysis, or “lint,” tool on your Lightning component code. The default rules include recommended best practices and LockerService requirements. For details, including how to customize the rules for your org, see the Lightning Components Developer Guide.
   * @example Examples: 
   *    $ sfdx force:lightning:lint ./path/to/be/linted/
   *    $ heroku lightning:lint ./path/to/be/linted/
   * 
   */
   [Command("lint")]
    public JToken lint(LightningLintOptions p_Options) {
      return ExecuteCommand<LightningLintOptions, JToken>(nameof(lint), p_Options);      
    }
  
  /**
   * create a Lightning test
   * @returns {(Promise<Object | void>)}
   * @memberof Lightning
   * @description Creates a Lightning test in the specified directory or the current working directory. The .resource file and associated metadata file are created.
   * @example The outputdir can be an absolute path or relative to the current working directory.
   * 
   * Examples:
   *    $ sfdx force:lightning:test:create -n MyLightningTest
   *    $ sfdx force:lightning:test:create -n MyLightningTest -d lightningTests
   * 
   * force:lightning:test:create -n <string> [-t <string>] [-d <string>] [--json] [--loglevel <string>]
   */
   [Command("test:create")]
    public JToken testCreate(LightningTestCreateOptions p_Options) {
      return ExecuteCommand<LightningTestCreateOptions, JToken>(nameof(testCreate), p_Options);      
    }
  
  /**
   * install Lightning Testing Service unmanaged package in your org
   * @returns {(Promise<Object | void>)}
   * @memberof Lightning
   * @description Installs a Lightning Testing Service (LTS) unmanaged package into your org.
   * @example Examples:
   *    $ sfdx force:lightning:test:install
   *    $ sfdx force:lightning:test:install -w 0 -r v1.0
   *    $ sfdx force:lightning:test:install -t jasmine
   * force:lightning:test:install [-w <minutes>] [-r <string>] [-t <string>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("test:install")]
    public JToken testInstall(LightningTestInstallOptions p_Options) {
      return ExecuteCommand<LightningTestInstallOptions, JToken>(nameof(testInstall), p_Options);      
    }
  
  /**
   * invoke Lightning component tests
   * @returns {(Promise<Object | void>)}
   * @memberof Lightning
   * @description Runs Lightning component tests. The Lightning Testing Service (LTS) unmanaged package must be installed in your org. For details, see the LTS documentation.
   * @example Examples:
   *    $ sfdx force:lightning:test:run
   *    $ sfdx force:lightning:test:run -a tests -r human
   *    $ sfdx force:lightning:test:run -f config/myConfigFile.json -d testResultFolder
   * force:lightning:test:run [-a <string>] [-d <directory>] [-r <string>] [-f <filepath>] [-o] [-t <number>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("test:run")]
    public JToken testRun(LightningTestRunOptions p_Options) {
      return ExecuteCommand<LightningTestRunOptions, JToken>(nameof(testRun), p_Options);      
    }
  
}

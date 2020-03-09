// Generated on March 9th 2020 using sfdx-cli/7.43.1 win32-x64 node-v8.15.0. DO NOT MODIFY
// Copyright (c) 2005-2020, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method appCreate of class Lightning.
    /// </summary>
    public class LightningAppCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The Lightning app name. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--appname")]
        public string appname { get; set; }

        /// <summary>
        /// [Optional] 
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }

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
    /// Options for the method componentCreate of class Lightning.
    /// </summary>
    public class LightningComponentCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The Lightning component name. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--componentname")]
        public string componentname { get; set; }

        /// <summary>
        /// [Optional] 
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }

        /// <summary>
        /// [Required] The type of the new Lightning component.
        /// </summary>
        [SwitchName("--type")]
        public string type { get; set; }

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
    /// Options for the method eventCreate of class Lightning.
    /// </summary>
    public class LightningEventCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The Lightning event name. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--eventname")]
        public string eventname { get; set; }

        /// <summary>
        /// [Optional] 
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }

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
    /// Options for the method interfaceCreate of class Lightning.
    /// </summary>
    public class LightningInterfaceCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The Lightning interface name. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--interfacename")]
        public string interfacename { get; set; }

        /// <summary>
        /// [Optional] 
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }

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
    /// Options for the method lint of class Lightning.
    /// </summary>
    public class LightningLintOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] Exit with error code 1 if there are lint issues. The default exits without an error code.
        /// </summary>
        [SwitchName("--exit")]
        public bool? exit { get; set; }

        /// <summary>
        /// [Optional] Report both warnings and errors. The default is to report only errors.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Required] Path to a custom ESLint configuration file. Only code style rules are used, while the rest are ignored. For example: --config path/to/.eslintrc.
        /// </summary>
        [SwitchName("--config")]
        public string config { get; set; }

        /// <summary>
        /// [Required] A “glob” pattern used to add specific files to the analysis. For example, to only analyse your controller files, use --files ** /*Controller.js. When specified, this value overrides the --ignore flag. The default is all .js files.
        /// </summary>
        [SwitchName("--files")]
        public string files { get; set; }

        /// <summary>
        /// [Required] A “glob” pattern used to filter folders (and their contents) out of the analysis. For example: --ignore ** /foo/**.
        /// </summary>
        [SwitchName("--ignore")]
        public string ignore { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method testCreate of class Lightning.
    /// </summary>
    public class LightningTestCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The name of the new Lightning test. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--testname")]
        public string testname { get; set; }

        /// <summary>
        /// [Optional] 
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }

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
    /// Options for the method testInstall of class Lightning.
    /// </summary>
    public class LightningTestInstallOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Type of LTS unmanaged package to install. 'jasmine' and 'mocha' contains the essentials for development, 'full' contains both, and adds sample components and tests in the package. 'full' is best for 'kicking the tires' of LTS.
        /// </summary>
        [SwitchName("--packagetype")]
        public string packagetype { get; set; }

        /// <summary>
        /// [Required] The release version of LTS unmanaged package you want to install.
        /// </summary>
        [SwitchName("--releaseversion")]
        public string releaseversion { get; set; }

        /// <summary>
        /// [Optional] Maximum number of minutes to wait for installation status.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

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
    /// Options for the method testRun of class Lightning.
    /// </summary>
    public class LightningTestRunOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Format to use when displaying results. If you also specify the --json flag, --json overrides this parameter.
        /// </summary>
        [SwitchName("--resultformat")]
        public string resultformat { get; set; }

        /// <summary>
        /// [Optional] Time, in milliseconds, to wait for the results element to be present in the DOM, before failing and moving on to the next test.
        /// </summary>
        [SwitchName("--timeout")]
        public int? timeout { get; set; }

        /// <summary>
        /// [Optional] Leaves browser open after the test finishes so that you can view the test suite results.
        /// </summary>
        [SwitchName("--leavebrowseropen")]
        public bool? leavebrowseropen { get; set; }

        /// <summary>
        /// [Required] Path to a test configuration file to configure WebDriver and other settings. For details, see the LTS documentation.
        /// </summary>
        [SwitchName("--configfile")]
        public string configfile { get; set; }

        /// <summary>
        /// [Required] Directory path to store test run artifacts: log files, test results, and so on.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] Name of your Lightning test application. The name is case insensitive, and ".app" is optional, so "Test" and "test.app" are equivalent.
        /// Default value: Test.app
        /// </summary>
        [SwitchName("--appname")]
        public string appname { get; set; }

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
    /// Lightning
    /// </summary>
    [CommandClass("force:lightning")]
    public class Lightning : SFDXCommand
    {
        /// Constructor.
        public Lightning(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// create a Lightning app
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a Lightning app bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// Examples:
        ///    $ sfdx force:lightning:app:create -n myapp
        ///    $ sfdx force:lightning:app:create -n myapp -d aura
        /// 
        /// force:lightning:app:create -n <string> [-t <string>] [-d <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("app:create")]
        public SFDXResponse AppCreate(LightningAppCreateOptions p_Options)
        {
            return ExecuteCommand<LightningAppCreateOptions>(nameof(AppCreate), p_Options);
        }

        /// <summary>
        /// create a bundle for an Aura component or a Lightning web component
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// To create a Lightning web component, pass --type lwc to the command. If you don’t include a --type value, Salesforce CLI creates an Aura component by default.
        /// </summary>
        /// <remarks>
        /// Creates a bundle for an Aura component or a Lightning web component in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// To create a Lightning web component, pass --type lwc to the command. If you don’t include a --type value, Salesforce CLI creates an Aura component by default.
        /// Examples:
        ///    $ sfdx force:lightning:component:create -n mycomponent
        ///    $ sfdx force:lightning:component:create -n mycomponent --type lwc
        ///    $ sfdx force:lightning:component:create -n mycomponent -d aura
        ///    $ sfdx force:lightning:component:create -n mycomponent --type lwc -d lwc
        /// 
        /// force:lightning:component:create -n <string> [-t <string>] [-d <string>] [--type <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("component:create")]
        public SFDXResponse ComponentCreate(LightningComponentCreateOptions p_Options)
        {
            return ExecuteCommand<LightningComponentCreateOptions>(nameof(ComponentCreate), p_Options);
        }

        /// <summary>
        /// create a Lightning event
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a Lightning event bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// Examples:
        ///    $ sfdx force:lightning:app:create -n myevent
        ///    $ sfdx force:lightning:event:create -n myevent -d aura
        /// 
        /// force:lightning:event:create -n <string> [-t <string>] [-d <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("event:create")]
        public SFDXResponse EventCreate(LightningEventCreateOptions p_Options)
        {
            return ExecuteCommand<LightningEventCreateOptions>(nameof(EventCreate), p_Options);
        }

        /// <summary>
        /// create a Lightning interface
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a Lightning interface bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// Examples:
        ///    $ sfdx force:lightning:interface:create -n myinterface
        ///    $ sfdx force:lightning:interface:create -n myinterface -d aura
        /// 
        /// force:lightning:interface:create -n <string> [-t <string>] [-d <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("interface:create")]
        public SFDXResponse InterfaceCreate(LightningInterfaceCreateOptions p_Options)
        {
            return ExecuteCommand<LightningInterfaceCreateOptions>(nameof(InterfaceCreate), p_Options);
        }

        /// <summary>
        /// analyze (lint) Aura component code
        /// </summary>
        /// <remarks>
        /// Runs a static analysis, or “lint,” tool on your Aura component code. The default rules include recommended best practices and Lightning Locker requirements. For details, including how to customize the rules for your org, see the Lightning Aura Components Developer Guide.
        /// </remarks>
        /// <example>
        /// 
        /// force:lightning:lint [-i <string>] [--files <string>] [--config <string>] [--exit] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("lint")]
        public SFDXResponse Lint(LightningLintOptions p_Options)
        {
            return ExecuteCommand<LightningLintOptions>(nameof(Lint), p_Options);
        }

        /// <summary>
        /// create a Lightning test
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a Lightning test in the specified directory or the current working directory. The .resource file and associated metadata file are created.
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:lightning:test:create -n MyLightningTest
        ///    $ sfdx force:lightning:test:create -n MyLightningTest -d lightningTests
        /// 
        /// force:lightning:test:create -n <string> [-t <string>] [-d <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("test:create")]
        public SFDXResponse TestCreate(LightningTestCreateOptions p_Options)
        {
            return ExecuteCommand<LightningTestCreateOptions>(nameof(TestCreate), p_Options);
        }

        /// <summary>
        /// install Lightning Testing Service unmanaged package in your org
        /// </summary>
        /// <remarks>
        /// Installs a Lightning Testing Service (LTS) unmanaged package into your org.
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:lightning:test:install
        ///    $ sfdx force:lightning:test:install -w 0 -r v1.0
        ///    $ sfdx force:lightning:test:install -t jasmine
        /// force:lightning:test:install [-w <minutes>] [-r <string>] [-t jasmine|mocha|full] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("test:install")]
        public SFDXResponse TestInstall(LightningTestInstallOptions p_Options)
        {
            return ExecuteCommand<LightningTestInstallOptions>(nameof(TestInstall), p_Options);
        }

        /// <summary>
        /// invoke Aura component tests
        /// </summary>
        /// <remarks>
        /// Runs Aura component tests. The Lightning Testing Service (LTS) unmanaged package must be installed in your org. For details, see the LTS documentation.
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:lightning:test:run
        ///    $ sfdx force:lightning:test:run -a tests -r human
        ///    $ sfdx force:lightning:test:run -f config/myConfigFile.json -d testResultFolder
        /// force:lightning:test:run [-a <string>] [-d <directory>] [-f <filepath>] [-o] [-t <number>] [-r human|tap|junit|json] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("test:run")]
        public SFDXResponse TestRun(LightningTestRunOptions p_Options)
        {
            return ExecuteCommand<LightningTestRunOptions>(nameof(TestRun), p_Options);
        }
    }
}

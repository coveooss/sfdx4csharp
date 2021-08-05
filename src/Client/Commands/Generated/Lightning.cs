// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

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
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The Lightning app name. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--appname")]
        public string appname { get; set; }

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
        /// [Optional] Create lightning bundles without creating a -meta.xml file
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }
    }

    /// <summary>
    /// Options for the method componentCreate of class Lightning.
    /// </summary>
    public class LightningComponentCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The Lightning component name. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--componentname")]
        public string componentname { get; set; }

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
        /// [Required] The type of the new Lightning component.
        /// </summary>
        [SwitchName("--type")]
        public string type { get; set; }

        /// <summary>
        /// [Optional] Create lightning bundles without creating a -meta.xml file
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }
    }

    /// <summary>
    /// Options for the method eventCreate of class Lightning.
    /// </summary>
    public class LightningEventCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The Lightning event name. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--eventname")]
        public string eventname { get; set; }

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
        /// [Optional] Create lightning bundles without creating a -meta.xml file
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }
    }

    /// <summary>
    /// Options for the method interfaceCreate of class Lightning.
    /// </summary>
    public class LightningInterfaceCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The Lightning interface name. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--interfacename")]
        public string interfacename { get; set; }

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
        /// [Optional] Create lightning bundles without creating a -meta.xml file
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }
    }

    /// <summary>
    /// Options for the method lint of class Lightning.
    /// </summary>
    public class LightningLintOptions : SFDXOptions
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
        /// [Required] A “glob” pattern used to filter folders (and their contents) out of the analysis. For example: --ignore ** /foo/**.
        /// </summary>
        [SwitchName("--ignore")]
        public string ignore { get; set; }

        /// <summary>
        /// [Required] A “glob” pattern used to add specific files to the analysis. For example, to only analyse your controller files, use --files ** /*Controller.js. When specified, this value overrides the --ignore flag. The default is all .js files.
        /// </summary>
        [SwitchName("--files")]
        public string files { get; set; }

        /// <summary>
        /// [Required] Path to a custom ESLint configuration file. Only code style rules are used, while the rest are ignored. For example: --config path/to/.eslintrc.
        /// </summary>
        [SwitchName("--config")]
        public string config { get; set; }

        /// <summary>
        /// [Optional] Report both warnings and errors. The default is to report only errors.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Optional] Exit with error code 1 if there are lint issues. The default exits without an error code.
        /// </summary>
        [SwitchName("--exit")]
        public bool? exit { get; set; }
    }

    /// <summary>
    /// Options for the method lwcTestCreate of class Lightning.
    /// </summary>
    public class LightningLwcTestCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] Path to Lightning web component .js file to create a test for.
        /// </summary>
        [SwitchName("--filepath")]
        public string filepath { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method lwcTestRun of class Lightning.
    /// </summary>
    public class LightningLwcTestRunOptions : SFDXOptions
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
        /// [Optional] Runs tests in a Node process that an external debugger can connect to. The run pauses until the debugger is connected. For more information, see: https://jestjs.io/docs/en/troubleshooting
        /// </summary>
        [SwitchName("--debug")]
        public bool? debug { get; set; }

        /// <summary>
        /// [Optional] Runs tests when a watched file changes. Watched files include the component under test and any files it references.
        /// </summary>
        [SwitchName("--watch")]
        public bool? watch { get; set; }
    }

    /// <summary>
    /// Options for the method lwcTestSetup of class Lightning.
    /// </summary>
    public class LightningLwcTestSetupOptions : SFDXOptions
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
    }

    /// <summary>
    /// Options for the method testCreate of class Lightning.
    /// </summary>
    public class LightningTestCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The name of the new Lightning test. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--testname")]
        public string testname { get; set; }

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
        /// [Optional] Create lightning bundles without creating a -meta.xml file
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }
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
        /// create a Lightning app
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
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
        /// $ sfdx force:lightning:app:create -n myapp
        /// $ sfdx force:lightning:app:create -n myapp -d aura
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
        /// create a bundle for an Aura component or a Lightning web component
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// To create a Lightning web component, pass --type lwc to the command. If you don’t include a --type value, Salesforce CLI creates an Aura component by default.
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
        /// $ sfdx force:lightning:component:create -n mycomponent
        /// $ sfdx force:lightning:component:create -n mycomponent --type lwc
        /// $ sfdx force:lightning:component:create -n mycomponent -d aura
        /// $ sfdx force:lightning:component:create -n mycomponent --type lwc -d lwc
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
        /// create a Lightning event
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
        /// Examples:
        ///    $ sfdx force:lightning:event:create -n myevent
        ///    $ sfdx force:lightning:event:create -n myevent -d aura
        /// 
        /// $ sfdx force:lightning:event:create -n myevent
        /// $ sfdx force:lightning:event:create -n myevent -d aura
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
        /// create a Lightning interface
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// If you don’t specify an outputdir, we create a subfolder in your current working directory with the name of your bundle. For example, if the current working directory is force-app and your Lightning bundle is called myBundle, we create force-app/myBundle/ to store the files in the bundle.
        /// 
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
        /// $ sfdx force:lightning:interface:create -n myinterface
        /// $ sfdx force:lightning:interface:create -n myinterface -d aura
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
        /// analyze (lint) Aura component code
        /// </remarks>
        /// <example>
        /// 
        /// <%= config.bin %> <%= command.id %> ./path/to/be/linted/
        /// force:lightning:lint [-i <string>] [--files <string>] [--config <string>] [--exit] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("lint")]
        public SFDXResponse Lint(LightningLintOptions p_Options)
        {
            return ExecuteCommand<LightningLintOptions>(nameof(Lint), p_Options);
        }

        /// <summary>
        /// creates a Lightning web component test file with boilerplate code inside a __tests__ directory.
        /// </summary>
        /// <remarks>
        /// creates a Lightning web component test file with boilerplate code inside a __tests__ directory.
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:lightning:lwc:test:create -f force-app/main/default/lwc/myButton/myButton.js
        /// force:lightning:lwc:test:create -f <string> [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("lwc:test:create")]
        public SFDXResponse LwcTestCreate(LightningLwcTestCreateOptions p_Options)
        {
            return ExecuteCommand<LightningLwcTestCreateOptions>(nameof(LwcTestCreate), p_Options);
        }

        /// <summary>
        /// invokes Lightning Web Components Jest unit tests.
        /// </summary>
        /// <remarks>
        /// invokes Lightning Web Components Jest unit tests.
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:lightning:lwc:test:run
        /// $ sfdx force:lightning:lwc:test:run -w
        /// force:lightning:lwc:test:run [-d] [--watch] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("lwc:test:run")]
        public SFDXResponse LwcTestRun(LightningLwcTestRunOptions p_Options)
        {
            return ExecuteCommand<LightningLwcTestRunOptions>(nameof(LwcTestRun), p_Options);
        }

        /// <summary>
        /// install Jest unit testing tools for Lightning Web Components.
        /// </summary>
        /// <remarks>
        /// install Jest unit testing tools for Lightning Web Components.
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:lightning:lwc:test:setup
        /// force:lightning:lwc:test:setup [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("lwc:test:setup")]
        public SFDXResponse LwcTestSetup(LightningLwcTestSetupOptions p_Options)
        {
            return ExecuteCommand<LightningLwcTestSetupOptions>(nameof(LwcTestSetup), p_Options);
        }

        /// <summary>
        /// create a Lightning test
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </summary>
        /// <remarks>
        /// create a Lightning test
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:lightning:test:create -n MyLightningTest
        ///    $ sfdx force:lightning:test:create -n MyLightningTest -d lightningTests
        /// 
        /// $ sfdx force:lightning:test:create -n MyLightningTest
        /// $ sfdx force:lightning:test:create -n MyLightningTest -d lightningTests
        /// force:lightning:test:create -n <string> [-t <string>] [-d <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("test:create")]
        public SFDXResponse TestCreate(LightningTestCreateOptions p_Options)
        {
            return ExecuteCommand<LightningTestCreateOptions>(nameof(TestCreate), p_Options);
        }
    }
}

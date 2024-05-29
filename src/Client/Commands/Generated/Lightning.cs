// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method GenerateApp of class Lightning.
    /// </summary>
    public class LightningGenerateAppOptions : SfdxOptions
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
        /// [Optional] No description for internal
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateComponent of class Lightning.
    /// </summary>
    public class LightningGenerateComponentOptions : SfdxOptions
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
        /// [Required] No description for type
        /// </summary>
        [SwitchName("--type")]
        public string Type { get; set; }

        /// <summary>
        /// [Optional] No description for internal
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateEvent of class Lightning.
    /// </summary>
    public class LightningGenerateEventOptions : SfdxOptions
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
        /// [Optional] No description for internal
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateInterface of class Lightning.
    /// </summary>
    public class LightningGenerateInterfaceOptions : SfdxOptions
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
        /// [Optional] No description for internal
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateTest of class Lightning.
    /// </summary>
    public class LightningGenerateTestOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] Name of the new Lightning test; can be up to 40 characters and must start with a letter.
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
        /// [Optional] No description for internal
        /// </summary>
        [SwitchName("--internal")]
        public bool? _internal { get; set; }

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
    /// Lightning
    /// </summary>
    [CommandClass("lightning")]
    public class Lightning : SfdxCommand
    {
        /// Constructor.
        public Lightning(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Generates a Lightning App bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
        /// </summary>
        /// <remarks>
        /// Generates a Lightning App bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
        /// </remarks>
        /// <example>
        /// 
        /// Generate the metadata files for a Lightning app bundle called "myapp" in the current directory:
        /// <%= config.bin %> <%= command.id %> --name myapp
        /// Similar to the previous example, but generate the files in the "force-app/main/default/aura" directory:
        /// <%= config.bin %> <%= command.id %> --name myapp --output-dir force-app/main/default/aura
        /// </example>
        [Command("generate app")]
        public SfdxResponse GenerateApp(LightningGenerateAppOptions options)
        {
            return ExecuteCommand(nameof(GenerateApp), options);
        }

        /// <summary>
        /// Generates the bundle in the specified directory or the current working directory. The bundle consists of multiple files in a directory with the designated name. Lightning web components are contained in the directory with name "lwc", Aura components in "aura".
        /// 
        /// To generate a Lightning web component, pass "--type lwc" to the command. If you don’t specify --type, Salesforce CLI generates an Aura component by default.
        /// </summary>
        /// <remarks>
        /// Generates the bundle in the specified directory or the current working directory. The bundle consists of multiple files in a directory with the designated name. Lightning web components are contained in the directory with name "lwc", Aura components in "aura".
        /// 
        /// To generate a Lightning web component, pass "--type lwc" to the command. If you don’t specify --type, Salesforce CLI generates an Aura component by default.
        /// </remarks>
        /// <example>
        /// 
        /// Generate the metadata files for an Aura component bundle in the current directory:
        /// <%= config.bin %> <%= command.id %> --name mycomponent
        /// Generate a Lightning web component bundle in the current directory:
        /// <%= config.bin %> <%= command.id %> --name mycomponent --type lwc
        /// Generate an Aura component bundle in the "force-app/main/default/aura" directory:
        /// <%= config.bin %> <%= command.id %> --name mycomponent --output-dir force-app/main/default/aura
        /// Generate a Lightning web component bundle in the "force-app/main/default/lwc" directory:
        /// <%= config.bin %> <%= command.id %> --name mycomponent --type lwc --output-dir force-app/main/default/lwc
        /// </example>
        [Command("generate component")]
        public SfdxResponse GenerateComponent(LightningGenerateComponentOptions options)
        {
            return ExecuteCommand(nameof(GenerateComponent), options);
        }

        /// <summary>
        /// Generates a Lightning Event bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
        /// </summary>
        /// <remarks>
        /// Generates a Lightning Event bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
        /// </remarks>
        /// <example>
        /// 
        /// Generate the metadata files for a Lightning event bundle called "myevent" in the current directory:
        /// <%= config.bin %> <%= command.id %> --name myevent
        /// Similar to previous example, but generate the files in the "force-app/main/default/aura" directory:
        /// <%= config.bin %> <%= command.id %> --name myevent --output-dir force-app/main/default/aura
        /// </example>
        [Command("generate event")]
        public SfdxResponse GenerateEvent(LightningGenerateEventOptions options)
        {
            return ExecuteCommand(nameof(GenerateEvent), options);
        }

        /// <summary>
        /// Generates a Lightning Interface bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
        /// </summary>
        /// <remarks>
        /// Generates a Lightning Interface bundle in the specified directory or the current working directory. The bundle consists of multiple files in a folder with the designated name.
        /// </remarks>
        /// <example>
        /// 
        /// Generate the metadata files for a Lightning interface bundle called "myinterface" in the current directory:
        /// <%= config.bin %> <%= command.id %> --name myinterface
        /// Similar to the previous example but generate the files in the "force-app/main/default/aura" directory:
        /// <%= config.bin %> <%= command.id %> --name myinterface --output-dir force-app/main/default/aura
        /// </example>
        [Command("generate interface")]
        public SfdxResponse GenerateInterface(LightningGenerateInterfaceOptions options)
        {
            return ExecuteCommand(nameof(GenerateInterface), options);
        }

        /// <summary>
        /// Generates the test in the specified directory or the current working directory. The .resource file and associated metadata file are generated.
        /// </summary>
        /// <remarks>
        /// Generates the test in the specified directory or the current working directory. The .resource file and associated metadata file are generated.
        /// </remarks>
        /// <example>
        /// 
        /// Generate the metadata files for the Lightning test called MyLightningTest in the current directory:
        /// <%= config.bin %> <%= command.id %> --name MyLightningTest
        /// Similar to the previous example but generate the files in the "force-app/main/default/lightningTests" directory:
        /// <%= config.bin %> <%= command.id %> --name MyLightningTest --output-dir force-app/main/default/lightningTests
        /// </example>
        [Command("generate test")]
        public SfdxResponse GenerateTest(LightningGenerateTestOptions options)
        {
            return ExecuteCommand(nameof(GenerateTest), options);
        }
    }
}

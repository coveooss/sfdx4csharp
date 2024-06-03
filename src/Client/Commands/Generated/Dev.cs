// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method AuditMessages of class Dev.
    /// </summary>
    public class DevAuditMessagesOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] No description for project-dir
        /// </summary>
        [SwitchName("--project-dir")]
        public string ProjectDir { get; set; }

        /// <summary>
        /// [Optional] The default is the "messages" directory in the current working directory.
        /// </summary>
        [SwitchName("--messages-dir")]
        public string MessagesDir { get; set; }

        /// <summary>
        /// [Optional] The default is the "src" directory in the current working directory.
        /// </summary>
        [SwitchName("--source-dir")]
        public string SourceDir { get; set; }
    }

    /// <summary>
    /// Options for the method ConvertMessages of class Dev.
    /// </summary>
    public class DevConvertMessagesOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for file-name
        /// </summary>
        [SwitchName("--file-name")]
        public string FileName { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] No description for project-dir
        /// </summary>
        [SwitchName("--project-dir")]
        public string ProjectDir { get; set; }
    }

    /// <summary>
    /// Options for the method ConvertScript of class Dev.
    /// </summary>
    public class DevConvertScriptOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for script
        /// </summary>
        [SwitchName("--script")]
        public string Script { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateCommand of class Dev.
    /// </summary>
    public class DevGenerateCommandOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] No description for force
        /// </summary>
        [SwitchName("--force")]
        public bool? Force { get; set; }

        /// <summary>
        /// [Optional] No description for nuts
        /// </summary>
        [SwitchName("--nuts")]
        public bool? Nuts { get; set; }

        /// <summary>
        /// [Optional] No description for unit
        /// </summary>
        [SwitchName("--unit")]
        public bool? Unit { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateFlag of class Dev.
    /// </summary>
    public class DevGenerateFlagOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] No description for dry-run
        /// </summary>
        [SwitchName("--dry-run")]
        public bool? DryRun { get; set; }
    }

    /// <summary>
    /// Options for the method GeneratePlugin of class Dev.
    /// </summary>
    public class DevGeneratePluginOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }
    }

    /// <summary>
    /// Dev
    /// </summary>
    [CommandClass("dev")]
    public class Dev : SfCommand
    {
        /// Constructor.
        public Dev(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Audit messages in a plugin's messages directory to locate unused messages and missing messages that have references in source code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// Audit messages using default directories:
        /// $ sf audit messages
        /// Audit messages in the "messages" directory in the current working directory; the plugin's source directory is in "src":
        /// $ sf audit messages --messages-dir ./messages --source-dir ./src
        /// </example>
        [Command("audit messages")]
        public SfResponse AuditMessages(DevAuditMessagesOptions options = null)
        {
            return ExecuteCommand(nameof(AuditMessages), options);
        }

        /// <summary>
        /// Convert a .json messages file into Markdown.
        /// </summary>
        /// <remarks>
        /// Preserves the filename and the original messages file, then creates a new file with the Markdown extension and standard headers for the command and flag summaries, descriptions, and so on. After you review the new Markdown file, delete the old .json file.
        /// </remarks>
        /// <example>
        /// Convert the my-command.json message file into my-command.md with the standard messages headers:
        /// $ sf convert messages --filename my-command.json
        /// Similar to previous example, but specify the plugin project directory:
        /// $ sf convert messages --project-dir ./path/to/plugin --filename my-command.json
        /// </example>
        [Command("convert messages")]
        public SfResponse ConvertMessages(DevConvertMessagesOptions options)
        {
            return ExecuteCommand(nameof(ConvertMessages), options);
        }

        /// <summary>
        /// Convert a script file that contains deprecated sfdx-style commands to use the new sf-style commands instead.
        /// </summary>
        /// <remarks>
        /// Important: Use this command only to get started on the sfdx-]sf script migration. We don't guarantee that the new sf-style command replacements work correctly or as you expect. You must test, and probably update, the new script before putting it into production. We also don't guarantee that the JSON results are the same as before. 
        /// 
        /// This command can convert a large part of your script, but possibly not all. There are some sfdx-style commands that don't have an obvious sf-style equivalent. In this case, this command doesn't replace the sfdx-style command but instead adds a comment to remind you that you must convert it manually. See the Salesforce CLI Command Reference for migration information about each deprecated sfdx-style command: https://developer.salesforce.com/docs/atlas.en-us.sfdx_cli_reference.meta/sfdx_cli_reference/cli_reference.htm.
        /// 
        /// This command is interactive; as it scans your script, it prompts you when it finds an sfdx-style command or flag and asks if you want to convert it to the displayed suggestion. The command doesn't update the script file directly; rather, it creates a new file whose name is the original name but with "-converted" appended to it. The script replaces all instances of "sfdx" with "sf". For each prompt you answer "y" to, the command replaces the sfdx-style names with their equivalent sf-style ones. For example, "sfdx force:apex:execute --targetusername myscratch" is replaced with "sf apex run --target-org myscratch".
        /// </remarks>
        /// <example>
        /// Convert the YAML file called "myScript.yml" located in the current directory; the new file that contains the replacements is called "myScript-converted.yml":
        /// $ sf convert script --script ./myScript.yml
        /// </example>
        [Command("convert script")]
        public SfResponse ConvertScript(DevConvertScriptOptions options)
        {
            return ExecuteCommand(nameof(ConvertScript), options);
        }

        /// <summary>
        /// Generate a new sf command.
        /// </summary>
        /// <remarks>
        /// You must run this command from within a plugin directory, such as the directory created with the "sf dev generate plugin" command.
        /// 
        /// The command generates basic source files, messages (\*.md), and test files for your new command.  The Typescript files contain import statements for the minimum required Salesforce libraries, and scaffold some basic code. The new type names come from the value you passed to the --name flag.
        /// 
        /// The command updates the package.json file, so if it detects conflicts with the existing file, you're prompted whether you want to overwrite the file. There are a number of package.json updates required for a new command, so we recommend you answer "y" so the command takes care of them all. If you answer "n", you must update the package.json file manually.
        /// </remarks>
        /// <example>
        /// Generate the files for a new "sf my exciting command":
        /// $ sf generate command --name my:exciting:command
        /// </example>
        [Command("generate command")]
        public SfResponse GenerateCommand(DevGenerateCommandOptions options)
        {
            return ExecuteCommand(nameof(GenerateCommand), options);
        }

        /// <summary>
        /// Generate a flag for an existing command.
        /// </summary>
        /// <remarks>
        /// You must run this command from within a plugin directory, such as the directory created with the "sf dev generate plugin" command.
        /// 
        /// This command is interactive. It first discovers all the commands currently implemented in the plugin, and asks you which you want to create a new flag for. It then prompts for other flag properties, such as its long name, optional short name, type, whether it's required, and so on. Long flag names must be kebab-case and not camelCase. The command doesn't let you use an existing long or short flag name. When the command completes, the Typescript file for the command is updated with the code for the new flag.
        /// 
        /// Use the --dry-run flag to review new code for the command file without actually updating it.
        /// </remarks>
        /// <example>
        /// Generate a new flag and update the command file:
        /// $ sf generate flag
        /// Don't actually update the command file, just view the generated code:
        /// $ sf generate flag --dry-run
        /// </example>
        [Command("generate flag")]
        public SfResponse GenerateFlag(DevGenerateFlagOptions options = null)
        {
            return ExecuteCommand(nameof(GenerateFlag), options);
        }

        /// <summary>
        /// Generate a new sf plugin.
        /// </summary>
        /// <remarks>
        /// This command is interactive. You're prompted for information to populate your new plugin, such as its name, description, author, and percentage of code coverage you want. The command clones the 'salesforcecli/plugin-template-sf' GitHub repository, installs the plug-in's npm package dependencies using yarn install, and updates the package properties.
        /// 
        /// When the command completes, your new plugin contains the source, message, and test files for a sample "sf hello world" command.
        /// </remarks>
        /// <example>
        /// $ sf generate plugin
        /// </example>
        [Command("generate plugin")]
        public SfResponse GeneratePlugin(DevGeneratePluginOptions options = null)
        {
            return ExecuteCommand(nameof(GeneratePlugin), options);
        }
    }
}

// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method GenerateField of class Schema.
    /// </summary>
    public class SchemaGenerateFieldOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for label
        /// </summary>
        [SwitchName("--label")]
        public string Label { get; set; }

        /// <summary>
        /// [Required] The object source files in your local project are grouped in a directoy with the same name as the object. Custom object names always end in "__c". An example of the object directory for the Account standard object is "force-app/main/default/objects/Account" An example custom object directory is "force-app/main/default/objects/MyObject__c"
        /// 
        /// If you don't specify this flag, the command prompts you to choose from your local objects.
        /// </summary>
        [SwitchName("--object")]
        public string Object { get; set; }
    }

    /// <summary>
    /// Options for the method GeneratePlatformevent of class Schema.
    /// </summary>
    public class SchemaGeneratePlatformeventOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for label
        /// </summary>
        [SwitchName("--label")]
        public string Label { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateSobject of class Schema.
    /// </summary>
    public class SchemaGenerateSobjectOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for label
        /// </summary>
        [SwitchName("--label")]
        public string Label { get; set; }

        /// <summary>
        /// [Optional] Enables these features:
        /// 
        /// - Search: Allows users to find the custom object's records when they search, including SOSL.
        /// - Feeds: Enables feed tracking.
        /// - Reports: Allows reporting of the data in the custom object records.
        /// - History: Enables object history tracking.
        /// - Activities: Allows users to associate tasks and scheduled calendar events related to the custom object records.
        /// - Bulk API: With Sharing and Streaming API, classifies the custom object as an Enterprise Application object.
        /// - Sharing: With Bulk API and Streaming API, classifies the custom object as an Enterprise Application object.
        /// - Streaming API: With Bulk API and Sharing, classifies the custom object as an Enterprise Application object.
        /// </summary>
        [SwitchName("--use-default-features")]
        public bool? UseDefaultFeatures { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateTab of class Schema.
    /// </summary>
    public class SchemaGenerateTabOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] See https://lightningdesignsystem.com/icons/#custom for the available icons.
        /// </summary>
        [SwitchName("--icon")]
        public string Icon { get; set; }

        /// <summary>
        /// [Required] No description for directory
        /// </summary>
        [SwitchName("--directory")]
        public string Directory { get; set; }

        /// <summary>
        /// [Required] The API name for a custom object always ends in `__c`, such as `MyObject__c`.
        /// </summary>
        [SwitchName("--object")]
        public string Object { get; set; }
    }

    /// <summary>
    /// Schema
    /// </summary>
    [CommandClass("schema")]
    public class Schema : SfdxCommand
    {
        /// Constructor.
        public Schema(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// This command is interactive and must be run in a Salesforce DX project directory. You're required to specify the field's label with the "--label" flag. The command uses this label to provide intelligent suggestions for other field properties, such as its API name.
        /// 
        /// You can generate a custom field on either a standard object, such as Account, or a custom object. In both cases, the source files for the object must already exist in your local project before you run this command. If you create a relationship field, the source files for the parent object must also exist in your local directory.  Use the command "sf metadata retrieve -m CustomObject:<object>" to retrieve source files for both standard and custom objects from your org.  To create a custom object, run the "sf generate metadata sobject" command or use the Object Manager UI in your Salesforce org.
        /// </summary>
        /// <remarks>
        /// This command is interactive and must be run in a Salesforce DX project directory. You're required to specify the field's label with the "--label" flag. The command uses this label to provide intelligent suggestions for other field properties, such as its API name.
        /// 
        /// You can generate a custom field on either a standard object, such as Account, or a custom object. In both cases, the source files for the object must already exist in your local project before you run this command. If you create a relationship field, the source files for the parent object must also exist in your local directory.  Use the command "sf metadata retrieve -m CustomObject:<object>" to retrieve source files for both standard and custom objects from your org.  To create a custom object, run the "sf generate metadata sobject" command or use the Object Manager UI in your Salesforce org.
        /// </remarks>
        /// <example>
        /// 
        /// Create a field with the specified label; the command prompts you for the object:
        /// <%= config.bin %> <%= command.id %> --label "My Field"
        /// Specify the local path to the object's folder:
        /// <%= config.bin %> <%= command.id %> --label "My Field" --object force-app/main/default/objects/MyObject__c
        /// </example>
        [Command("generate field")]
        public SfdxResponse GenerateField(SchemaGenerateFieldOptions options)
        {
            return ExecuteCommand(nameof(GenerateField), options);
        }

        /// <summary>
        /// This command is interactive and must be run in a Salesforce DX project directory. You're required to specify the event's label with the "--label" flag. The command uses this label to provide intelligent suggestions for other event properties, such as its API name.
        /// </summary>
        /// <remarks>
        /// This command is interactive and must be run in a Salesforce DX project directory. You're required to specify the event's label with the "--label" flag. The command uses this label to provide intelligent suggestions for other event properties, such as its API name.
        /// </remarks>
        /// <example>
        /// 
        /// Create a platform event with the specified label:
        /// <%= config.bin %> <%= command.id %> --label "My Platform Event"
        /// </example>
        [Command("generate platformevent")]
        public SfdxResponse GeneratePlatformevent(SchemaGeneratePlatformeventOptions options)
        {
            return ExecuteCommand(nameof(GeneratePlatformevent), options);
        }

        /// <summary>
        /// This command is interactive and must be run in a Salesforce DX project directory. You're required to specify the object's label with the "--label" flag. The command uses this label to provide intelligent suggestions for other object properties, such as its API name and plural label.
        /// 
        /// All Salesforce objects are required to have a Name field, so this command also prompts you for the label and type of the Name field. Run the "sf metadata generate field" command to create additional fields for the object.
        /// 
        /// To reduce the number of prompts, use the "--use-default-features" flag to automatically enable some features, such as reporting and search on the object.
        /// </summary>
        /// <remarks>
        /// This command is interactive and must be run in a Salesforce DX project directory. You're required to specify the object's label with the "--label" flag. The command uses this label to provide intelligent suggestions for other object properties, such as its API name and plural label.
        /// 
        /// All Salesforce objects are required to have a Name field, so this command also prompts you for the label and type of the Name field. Run the "sf metadata generate field" command to create additional fields for the object.
        /// 
        /// To reduce the number of prompts, use the "--use-default-features" flag to automatically enable some features, such as reporting and search on the object.
        /// </remarks>
        /// <example>
        /// 
        /// Create a custom object with the specified label and be prompted for additional information:
        /// <%= config.bin %> <%= command.id %> --label "My Object"
        /// Create a custom object and enable optional features without prompting:
        /// <%= config.bin %> <%= command.id %> --label "My Object" --use-default-features
        /// </example>
        [Command("generate sobject")]
        public SfdxResponse GenerateSobject(SchemaGenerateSobjectOptions options)
        {
            return ExecuteCommand(nameof(GenerateSobject), options);
        }

        /// <summary>
        /// Custom tabs let you display custom object data or other web content in Salesforce. Custom tabs appear in Salesforce as an item in the app’s navigation bar and in the App Launcher.
        /// 
        /// This command must be run in a Salesforce DX project directory. You must pass all required information to it with the required flags. The source files for the custom object for which you're generating a tab don't need to exist in your local project.
        /// </summary>
        /// <remarks>
        /// Custom tabs let you display custom object data or other web content in Salesforce. Custom tabs appear in Salesforce as an item in the app’s navigation bar and in the App Launcher.
        /// 
        /// This command must be run in a Salesforce DX project directory. You must pass all required information to it with the required flags. The source files for the custom object for which you're generating a tab don't need to exist in your local project.
        /// </remarks>
        /// <example>
        /// 
        /// Create a tab on the `MyObject__c` custom object:
        /// <%= config.bin %> <%= command.id %> --object `MyObject__c` --icon 54 --directory force-app/main/default/tabs
        /// </example>
        [Command("generate tab")]
        public SfdxResponse GenerateTab(SchemaGenerateTabOptions options)
        {
            return ExecuteCommand(nameof(GenerateTab), options);
        }
    }
}

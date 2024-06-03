// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method GenerateField of class Cmdt.
    /// </summary>
    public class CmdtGenerateFieldOptions : SfOptions
    {
        /// <summary>
        /// [Required] You can't use this command to create a custom metadata type field of type "Metadata Relationship". Use the Salesforce Setup UI instead.
        /// </summary>
        [SwitchName("--type")]
        public string Type { get; set; }

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
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for picklist-values
        /// </summary>
        [SwitchName("--picklist-values")]
        public string PicklistValues { get; set; }

        /// <summary>
        /// [Optional] The value must be greater than or equal to zero. Default value is 0.
        /// </summary>
        [SwitchName("--decimal-places")]
        public string DecimalPlaces { get; set; }

        /// <summary>
        /// [Optional] No description for label
        /// </summary>
        [SwitchName("--label")]
        public string Label { get; set; }

        /// <summary>
        /// [Optional] New files are automatically created in the "fields" directory. The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--output-directory")]
        public string OutputDirectory { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateFromorg of class Cmdt.
    /// </summary>
    public class CmdtGenerateFromorgOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }

        /// <summary>
        /// [Required] No description for dev-name
        /// </summary>
        [SwitchName("--dev-name")]
        public string DevName { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for label
        /// </summary>
        [SwitchName("--label")]
        public string Label { get; set; }

        /// <summary>
        /// [Optional] No description for plural-label
        /// </summary>
        [SwitchName("--plural-label")]
        public string PluralLabel { get; set; }

        /// <summary>
        /// [Optional] For more information on what each option means, see this topic in Salesforce Help: https://help.salesforce.com/s/articleView?id=sf.custommetadatatypes_ui_create.htm&amp;type=5.
        /// </summary>
        [SwitchName("--visibility")]
        public string Visibility { get; set; }

        /// <summary>
        /// [Optional] In this context, "ignore" means that the fields aren't created. The default behavior is to create fields of type text and convert the field values to text.
        /// </summary>
        [SwitchName("--ignore-unsupported")]
        public bool? IgnoreUnsupported { get; set; }

        /// <summary>
        /// [Optional] No description for type-output-directory
        /// </summary>
        [SwitchName("--type-output-directory")]
        public string TypeOutputDirectory { get; set; }

        /// <summary>
        /// [Optional] No description for records-output-dir
        /// </summary>
        [SwitchName("--records-output-dir")]
        public string RecordsOutputDir { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateObject of class Cmdt.
    /// </summary>
    public class CmdtGenerateObjectOptions : SfOptions
    {
        /// <summary>
        /// [Required] The name can contain only underscores and alphanumeric characters, and must be unique in your org. It must begin with a letter, not include spaces, not end with an underscore, and not contain two consecutive underscores.
        /// </summary>
        [SwitchName("--type-name")]
        public string TypeName { get; set; }

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
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for label
        /// </summary>
        [SwitchName("--label")]
        public string Label { get; set; }

        /// <summary>
        /// [Optional] No description for plural-label
        /// </summary>
        [SwitchName("--plural-label")]
        public string PluralLabel { get; set; }

        /// <summary>
        /// [Optional] For more information on what each option means, see this topic in Salesforce Help: https://help.salesforce.com/s/articleView?id=sf.custommetadatatypes_ui_create.htm&amp;type=5.
        /// </summary>
        [SwitchName("--visibility")]
        public string Visibility { get; set; }

        /// <summary>
        /// [Optional] The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--output-directory")]
        public string OutputDirectory { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateRecord of class Cmdt.
    /// </summary>
    public class CmdtGenerateRecordOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for record-name
        /// </summary>
        [SwitchName("--record-name")]
        public string RecordName { get; set; }

        /// <summary>
        /// [Required] No description for type-name
        /// </summary>
        [SwitchName("--type-name")]
        public string TypeName { get; set; }

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
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for label
        /// </summary>
        [SwitchName("--label")]
        public string Label { get; set; }

        /// <summary>
        /// [Optional] Protected records can only be accessed by code in the same managed package namespace.
        /// </summary>
        [SwitchName("--protected")]
        public string Isprotected { get; set; }

        /// <summary>
        /// [Optional] No description for input-directory
        /// </summary>
        [SwitchName("--input-directory")]
        public string InputDirectory { get; set; }

        /// <summary>
        /// [Optional] No description for output-directory
        /// </summary>
        [SwitchName("--output-directory")]
        public string OutputDirectory { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateRecords of class Cmdt.
    /// </summary>
    public class CmdtGenerateRecordsOptions : SfOptions
    {
        /// <summary>
        /// [Required] The '__mdt' suffix is appended to the end of the name if it's omitted.
        /// </summary>
        [SwitchName("--type-name")]
        public string TypeName { get; set; }

        /// <summary>
        /// [Required] No description for csv
        /// </summary>
        [SwitchName("--csv")]
        public string Csv { get; set; }

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
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for input-directory
        /// </summary>
        [SwitchName("--input-directory")]
        public string InputDirectory { get; set; }

        /// <summary>
        /// [Optional] No description for output-directory
        /// </summary>
        [SwitchName("--output-directory")]
        public string OutputDirectory { get; set; }

        /// <summary>
        /// [Optional] No description for name-column
        /// </summary>
        [SwitchName("--name-column")]
        public string NameColumn { get; set; }
    }

    /// <summary>
    /// Cmdt
    /// </summary>
    [CommandClass("cmdt")]
    public class Cmdt : SfCommand
    {
        /// Constructor.
        public Cmdt(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Generate a field for a custom metadata type based on the provided field type.
        /// </summary>
        /// <remarks>
        /// Similar to a custom object, a custom metadata type has a list of custom fields that represent aspects of the metadata.
        /// 
        /// This command creates a metadata file that describes the new custom metadata type field. By default, the file is created in a "fields" directory in the current directory. Use the --output-directory to generate the file in the directory that contains the custom metadata type metdata files, such as "force-app/main/default/objects/MyCmdt__mdt" for the custom metadata type called MyCmdt.
        /// </remarks>
        /// <example>
        /// Generate a metadata file for a custom checkbox field and add the file to the MyCmdt__mdt/fields directory:
        /// $ sf generate field --name MyCheckboxField --type Checkbox --output-directory force-app/main/default/objects/MyCmdt__mdt
        /// Generate a metadata file for a custom picklist field and add a few values:
        /// $ sf generate field --name MyPicklistField --type Picklist --picklist-values A --picklist-values B --picklist-values C --output-directory force-app/main/default/objects/MyCmdt__mdt
        /// Generate a metadata file for a custom number field and specify 2 decimal places:
        /// $ sf generate field --name MyNumberField --type Number --decimal-places 2 --output-directory force-app/main/default/objects/MyCmdt__mdt
        /// </example>
        [Command("generate field")]
        public SfResponse GenerateField(CmdtGenerateFieldOptions options)
        {
            return ExecuteCommand(nameof(GenerateField), options);
        }

        /// <summary>
        /// Generate a custom metadata type and all its records from a Salesforce object.
        /// </summary>
        /// <remarks>
        /// Use this command to migrate existing custom objects or custom settings in an org to custom metadata types. If a field of the Salesforce object is of an unsupported type, the field type is automatically converted to text. Run "sf cmdt generate field --help" to see the list of supported cmdt field types, listed in the --type flag summary. Use the --ignore-unsupported to ignore these fields.
        /// 
        /// This command creates the metadata files that describe the new custom metadata type and its fields in the "force-app/main/default/objects/TypeName__mdt" directory by default, where "TypeName" is the value of the required --dev-name flag. Use --type-output-directory to create them in a different directory.
        /// </remarks>
        /// <example>
        /// Generate a custom metadata type from a custom object called MySourceObject__c in your default org:
        /// $ sf generate fromorg --dev-name MyCMDT --sobject MySourceObject__c
        /// Generate a custom metadata type from a custom object in an org with alias my-scratch-org; ignore unsupported field types instead of converting them to text:
        /// $ sf generate fromorg --dev-name MyCMDT --sobject MySourceObject__c --ignore-unsupported --target-org my-scratch-org
        /// Generate a protected custom metadata type from a custom object:
        /// $ sf generate fromorg --dev-name MyCMDT --sobject MySourceObject__c --visibility Protected
        /// Generate a protected custom metadata type from a custom setting with a specific singular and plural label:
        /// $ sf generate fromorg --dev-name MyCMDT --label "My CMDT" --plural-label "My CMDTs" --sobject MySourceSetting__c --visibility Protected
        /// Generate a custom metadata type and put the resulting metadata files in the specified directory:
        /// $ sf generate fromorg --dev-name MyCMDT --sobject MySourceObject__c --type-output-directory path/to/my/cmdt/directory
        /// Generate a custom metadata type and put the resulting record metadata file(s) in the specified directory:
        /// $ sf generate fromorg --dev-name MyCMDT --sobject MySourceObject__c --records-output-dir path/to/my/cmdt/record/directory
        /// </example>
        [Command("generate fromorg")]
        public SfResponse GenerateFromorg(CmdtGenerateFromorgOptions options)
        {
            return ExecuteCommand(nameof(GenerateFromorg), options);
        }

        /// <summary>
        /// Generate a new custom metadata type in the current project.
        /// </summary>
        /// <remarks>
        /// This command creates a metadata file that describes the new custom metadata type. By default, the file is created in the MyCustomType__mdt directory in the current directory, where MyCustomType is the value of the required --type-name flag. Use the --output-directory to generate the file in a package directory with other custom metadata types, such as "force-app/main/default/objects".
        /// </remarks>
        /// <example>
        /// Generate a custom metadata type with developer name 'MyCustomType'; this name is also used as the label:
        /// $ sf generate object --type-name MyCustomType
        /// Generate a protected custom metadata type with a specific label:
        /// $ sf generate object --type-name MyCustomType --label "Custom Type" --plural-label "Custom Types" --visibility Protected
        /// </example>
        [Command("generate object")]
        public SfResponse GenerateObject(CmdtGenerateObjectOptions options)
        {
            return ExecuteCommand(nameof(GenerateObject), options);
        }

        /// <summary>
        /// Generate a new record for a given custom metadata type in the current project.
        /// </summary>
        /// <remarks>
        /// The custom metadata type must already exist in your project. You must specify a name for the new record. Use name=value pairs to specify the values for the fields, such as MyTextField="some text here" or MyNumberField=32.
        /// </remarks>
        /// <example>
        /// Create a record metadata file for custom metadata type 'MyCMT' with specified values for two custom fields:
        /// $ sf generate record --type-name MyCMT__mdt --record-name MyRecord My_Custom_Field_1=Foo My_Custom_Field_2=Bar
        /// Create a protected record metadata file for custom metadata type 'MyCMT' with a specific label and values specified for two custom fields:
        /// $ sf generate record --type-name MyCMT__mdt --record-name MyRecord --label "My Record" --protected true My_Custom_Field_1=Foo My_Custom_Field_2=Bar
        /// </example>
        [Command("generate record")]
        public SfResponse GenerateRecord(CmdtGenerateRecordOptions options)
        {
            return ExecuteCommand(nameof(GenerateRecord), options);
        }

        /// <summary>
        /// Generate new custom metadata type records from a CSV file.
        /// </summary>
        /// <remarks>
        /// The custom metadata type must already exist in your project. By default, the Name column is used to determine the record name; use the --name-column flag to specify a different column.
        /// </remarks>
        /// <example>
        /// Generate record metadata files from values in a CSV file for the custom metadata type MyCmdt. Use 'Name' as the column that specifies the record name:
        /// $ sf generate records --csv path/to/my.csv --type-name MyCmdt
        /// Generate record metadata files from a CSV file in the directory different from the default, and use 'PrimaryKey' as the column that specifies the record name:
        /// $ sf generate records --csv path/to/my.csv --type-name MyCmdt --input-directory path/to/my/cmdt/directory --name-column "PrimaryKey"
        /// </example>
        [Command("generate records")]
        public SfResponse GenerateRecords(CmdtGenerateRecordsOptions options)
        {
            return ExecuteCommand(nameof(GenerateRecords), options);
        }
    }
}

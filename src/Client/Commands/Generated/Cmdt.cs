// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method create of class Cmdt.
    /// </summary>
    public class CmdtCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The unique name of the object in the API. This name can contain only underscores and alphanumeric characters, and must be unique in your org. It must begin with a letter, not include spaces, not end with an underscore, and not contain two consecutive underscores.
        /// </summary>
        [SwitchName("--typename")]
        public string typename { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A label for the custom metadata type.
        /// </summary>
        [SwitchName("--label")]
        public string label { get; set; }

        /// <summary>
        /// [Required] The plural version of the label value. If this flag is missing or blank, the singular label is used as the plural label.
        /// </summary>
        [SwitchName("--plurallabel")]
        public string plurallabel { get; set; }

        /// <summary>
        /// [Required] The visibility of the custom metadata type.
        /// </summary>
        [SwitchName("--visibility")]
        public string visibility { get; set; }

        /// <summary>
        /// [Required] The directory to store the newly-created custom metadata type files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }
    }

    /// <summary>
    /// Options for the method fieldCreate of class Cmdt.
    /// </summary>
    public class CmdtFieldCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The unique name for the field.
        /// </summary>
        [SwitchName("--fieldtype")]
        public string fieldtype { get; set; }

        /// <summary>
        /// [Required] The unique name for the field.
        /// </summary>
        [SwitchName("--fieldname")]
        public string fieldname { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of picklist values. These values are required when creating a Picklist field.
        /// </summary>
        [SwitchName("--picklistvalues")]
        public string picklistvalues { get; set; }

        /// <summary>
        /// [Required] The number of decimal places to use for Number or Percent fields. The value must be greater than or equal to zero.
        /// </summary>
        [SwitchName("--decimalplaces")]
        public string decimalplaces { get; set; }

        /// <summary>
        /// [Required] The label for the field.
        /// </summary>
        [SwitchName("--label")]
        public string label { get; set; }

        /// <summary>
        /// [Required] The directory to store the newly-created field definition files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }
    }

    /// <summary>
    /// Options for the method generate of class Cmdt.
    /// </summary>
    public class CmdtGenerateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The API name of the sObject source for custom metadata generation.
        /// </summary>
        [SwitchName("--sobjectname")]
        public string sobjectname { get; set; }

        /// <summary>
        /// [Required] The name of the custom metadata type.
        /// </summary>
        [SwitchName("--devname")]
        public string devname { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] The label for the custom metadata type.
        /// </summary>
        [SwitchName("--label")]
        public string label { get; set; }

        /// <summary>
        /// [Required] The plural version of the label value. If this flag is missing or blank, the singular label is used as the plural label.
        /// </summary>
        [SwitchName("--plurallabel")]
        public string plurallabel { get; set; }

        /// <summary>
        /// [Required] The visibility of the custom metadata type.
        /// </summary>
        [SwitchName("--visibility")]
        public string visibility { get; set; }

        /// <summary>
        /// [Optional] Ignore unsupported field types (these fields will not be created). The default is to create Text fields and convert the source value to text.
        /// </summary>
        [SwitchName("--ignoreunsupported")]
        public bool? ignoreunsupported { get; set; }

        /// <summary>
        /// [Required] The directory to store newly-created custom metadata type files.
        /// </summary>
        [SwitchName("--typeoutputdir")]
        public string typeoutputdir { get; set; }

        /// <summary>
        /// [Required] The directory to store newly-created custom metadata record files.
        /// </summary>
        [SwitchName("--recordsoutputdir")]
        public string recordsoutputdir { get; set; }
    }

    /// <summary>
    /// Options for the method recordCreate of class Cmdt.
    /// </summary>
    public class CmdtRecordCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The name for the new record.
        /// </summary>
        [SwitchName("--recordname")]
        public string recordname { get; set; }

        /// <summary>
        /// [Required] The API name of the custom metadata type to create a record for.
        /// </summary>
        [SwitchName("--typename")]
        public string typename { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The label for the new record.
        /// </summary>
        [SwitchName("--label")]
        public string label { get; set; }

        /// <summary>
        /// [Required] Protect the record when it is in a managed package. Protected records can only be accessed by code in the same managed package namespace.
        /// </summary>
        [SwitchName("--protected")]
        public string protected { get; set; }

        /// <summary>
        /// [Required] The directory to pull the custom metadata type definition from.
        /// </summary>
        [SwitchName("--inputdir")]
        public string inputdir { get; set; }

        /// <summary>
        /// [Required] The directory to store newly-created custom metadata record files.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }
    }

    /// <summary>
    /// Options for the method recordInsert of class Cmdt.
    /// </summary>
    public class CmdtRecordInsertOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The API Name of the custom metadata type. The '__mdt' suffix will be appended to the end of the name if it is omitted.
        /// </summary>
        [SwitchName("--typename")]
        public string typename { get; set; }

        /// <summary>
        /// [Required] The path to the CSV file.
        /// </summary>
        [SwitchName("--filepath")]
        public string filepath { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The directory to pull the custom metadata type definition from.
        /// </summary>
        [SwitchName("--inputdir")]
        public string inputdir { get; set; }

        /// <summary>
        /// [Required] The directory to store newly-created custom metadata record files.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] The column that is used to determine the name of the record.
        /// </summary>
        [SwitchName("--namecolumn")]
        public string namecolumn { get; set; }
    }

    /// <summary>
    /// Cmdt
    /// </summary>
    [CommandClass("force:cmdt")]
    public class Cmdt : SFDXCommand
    {
        /// Constructor.
        public Cmdt(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// creates a new custom metadata type in the current project
        /// </summary>
        /// <remarks>
        /// creates a new custom metadata type in the current project
        /// </remarks>
        /// <example>
        /// 
        /// Create a custom metadata type with developer name 'MyCustomType'; this name will also be used as the label:
        ///     $ sfdx force:cmdt:create --typename MyCustomType
        /// Create a protected custom metadata type with a specific label:
        ///     $ sfdx force:cmdt:create --typename MyCustomType --label "Custom Type" --plurallabel "Custom Types" --visibility Protected
        /// force:cmdt:create -n <string> [-l <string>] [-p <string>] [-v PackageProtected|Protected|Public] [-d <directory>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("create")]
        public SFDXResponse Create(CmdtCreateOptions p_Options)
        {
            return ExecuteCommand<CmdtCreateOptions>(nameof(Create), p_Options);
        }

        /// <summary>
        /// generate a custom metadata field based on the field type provided
        /// </summary>
        /// <remarks>
        /// generate a custom metadata field based on the field type provided
        /// </remarks>
        /// <example>
        /// 
        /// Create a metadata file for a custom checkbox field:
        ///     $ sfdx force:cmdt:field:create --fieldname MyField --fieldtype Checkbox
        /// Create a metadata file for a custom picklist field:
        ///     $ sfdx force:cmdt:field:create --fieldname MyField --fieldtype Picklist --picklistvalues "A,B,C"
        /// Create a metadata file for a custom number field:
        ///     $ sfdx force:cmdt:field:create --fieldname MyField --fieldtype Number --decimalplaces 2
        /// force:cmdt:field:create -n <string> -f Checkbox|Date|DateTime|Email|Number|Percent|Phone|Picklist|Text|TextArea|LongTextArea|Url [-p <array>] [-s <number>] [-l <string>] [-d <directory>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("field:create")]
        public SFDXResponse FieldCreate(CmdtFieldCreateOptions p_Options)
        {
            return ExecuteCommand<CmdtFieldCreateOptions>(nameof(FieldCreate), p_Options);
        }

        /// <summary>
        /// generates a custom metadata type and all its records for the provided sObject
        /// </summary>
        /// <remarks>
        /// generates a custom metadata type and all its records for the provided sObject
        /// </remarks>
        /// <example>
        /// 
        /// Generate a custom metadata type from an sObject in the default target org:
        ///     $ sfdx force:cmdt:generate --devname MyCMDT --sobjectname MySourceObject__c
        /// Generate a custom metadata type from an sObject in the specified target org; ignore unsupported field types instead of converting them to text:
        ///     $ sfdx force:cmdt:generate --devname MyCMDT --sobjectname MySourceObject__c  --ignoreunsupported --targetusername 'alias or user email of the org containing the source type'
        /// Generate a protected custom metadata type from an sObject in the default target org:
        ///     $ sfdx force:cmdt:generate --devname MyCMDT --sobjectname SourceCustomObject__c  --visibility Protected
        /// Generate a protected custom metadata type with a specific label from an sObject in the default target org:
        ///     $ sfdx force:cmdt:generate --devname MyCMDT --label "My CMDT" --plurallabel "My CMDTs" --sobjectname SourceCustomSetting__c  --visibility Protected
        /// Generate a custom metadata type from an sObject in the default target org; put the resulting type metadata file in the specified directory:
        ///     $ sfdx force:cmdt:generate --devname MyCMDT --sobjectname SourceCustomSetting__c --typeoutputdir 'path/to/my/cmdt/directory'
        /// Generate a custom metadata type from an sObject in the default target org; put the resulting record metadata file(s) in the specified directory:
        ///     $ sfdx force:cmdt:generate --devname MyCMDT --sobjectname SourceCustomSetting__c --recordsoutputdir 'path/to/my/cmdt/record/directory'
        /// force:cmdt:generate -n <string> -s <string> [-l <string>] [-p <string>] [-v PackageProtected|Protected|Public] [-i] [-d <directory>] [-r <directory>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("generate")]
        public SFDXResponse Generate(CmdtGenerateOptions p_Options)
        {
            return ExecuteCommand<CmdtGenerateOptions>(nameof(Generate), p_Options);
        }

        /// <summary>
        /// create a new record for a given custom metadata type in the current project
        /// </summary>
        /// <remarks>
        /// create a new record for a given custom metadata type in the current project
        /// </remarks>
        /// <example>
        /// 
        /// Create a record metadata file for custom metadata type 'MyCMT' with values specified for two custom fields:
        ///     $ sfdx force:cmdt:record:create --typename MyCMT__mdt --recordname MyRecord My_Custom_Field_1=Foo My_Custom_Field_2=Bar
        /// Create a protected record metadata file for custom metadata type 'MyCMT' with a specific label and values specified for two custom fields:
        ///     $ sfdx force:cmdt:record:create --typename MyCMT__mdt --recordname MyRecord --label "My Record" --protected true My_Custom_Field_1=Foo My_Custom_Field_2=Bar
        /// force:cmdt:record:create [name=value...] -t <string> -n <string> [-l <string>] [-p <string>] [-i <directory>] [-d <directory>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("record:create")]
        public SFDXResponse RecordCreate(CmdtRecordCreateOptions p_Options)
        {
            return ExecuteCommand<CmdtRecordCreateOptions>(nameof(RecordCreate), p_Options);
        }

        /// <summary>
        /// create new custom metadata type records from a CSV file
        /// </summary>
        /// <remarks>
        /// create new custom metadata type records from a CSV file
        /// </remarks>
        /// <example>
        /// 
        /// Create record metadata files for type 'My_CMDT_Name' (from your local project) based on values in a CSV file, using 'Name' as the column that specifies the record name:
        ///     $ sfdx force:cmdt:record:insert --filepath path/to/my.csv --typename My_CMDT_Name
        /// Create record metadata files for type 'My_CMDT_Name' (from the specified directory) based on values in a CSV file, using 'PrimaryKey' as the column that specifies the record name:
        ///     $ sfdx force:cmdt:record:insert --filepath path/to/my.csv --typename My_CMDT_Name --inputdir "path/to/my/cmdt/directory" --namecolumn "PrimaryKey"
        /// force:cmdt:record:insert -f <string> -t <string> [-i <directory>] [-d <directory>] [-n <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("record:insert")]
        public SFDXResponse RecordInsert(CmdtRecordInsertOptions p_Options)
        {
            return ExecuteCommand<CmdtRecordInsertOptions>(nameof(RecordInsert), p_Options);
        }
    }
}

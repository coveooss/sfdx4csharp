// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method bulkDelete of class Data.
    /// </summary>
    public class DataBulkDeleteOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The sObject type of the records you’re deleting
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

        /// <summary>
        /// [Required] The path to the CSV file containing the ids of the records to delete
        /// </summary>
        [SwitchName("--csvfile")]
        public string csvfile { get; set; }

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
        /// [Required] The number of minutes to wait for the command to complete before displaying the results
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }
    }

    /// <summary>
    /// Options for the method bulkStatus of class Data.
    /// </summary>
    public class DataBulkStatusOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The ID of the job you want to view or of the job whose batch you want to view
        /// </summary>
        [SwitchName("--jobid")]
        public string jobid { get; set; }

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
        /// [Required] The ID of the batch whose status you want to view
        /// </summary>
        [SwitchName("--batchid")]
        public string batchid { get; set; }
    }

    /// <summary>
    /// Options for the method bulkUpsert of class Data.
    /// </summary>
    public class DataBulkUpsertOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The sObject type of the records you want to upsert
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

        /// <summary>
        /// [Required] The path to the CSV file that defines the records to upsert
        /// </summary>
        [SwitchName("--csvfile")]
        public string csvfile { get; set; }

        /// <summary>
        /// [Required] The column name of the external ID
        /// </summary>
        [SwitchName("--externalid")]
        public string externalid { get; set; }

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
        /// [Required] The number of minutes to wait for the command to complete before displaying the results
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }

        /// <summary>
        /// [Optional] Run batches in serial mode
        /// </summary>
        [SwitchName("--serial")]
        public bool? serial { get; set; }
    }

    /// <summary>
    /// Options for the method recordCreate of class Data.
    /// </summary>
    public class DataRecordCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The <fieldName>=<value> pairs you’re creating
        /// </summary>
        [SwitchName("--values")]
        public string values { get; set; }

        /// <summary>
        /// [Required] The type of the record you’re creating
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

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
        /// [Optional] Create the record with tooling api
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }

        /// <summary>
        /// [Optional] Get API performance data
        /// </summary>
        [SwitchName("--perflog")]
        public bool? perflog { get; set; }
    }

    /// <summary>
    /// Options for the method recordDelete of class Data.
    /// </summary>
    public class DataRecordDeleteOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The type of the record you’re deleting
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

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
        /// [Required] The ID of the record you’re deleting
        /// </summary>
        [SwitchName("--sobjectid")]
        public string sobjectid { get; set; }

        /// <summary>
        /// [Required] A list of <fieldName>=<value> pairs to search for
        /// </summary>
        [SwitchName("--where")]
        public string where { get; set; }

        /// <summary>
        /// [Optional] Delete the record with Tooling API
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }

        /// <summary>
        /// [Optional] Get API performance data
        /// </summary>
        [SwitchName("--perflog")]
        public bool? perflog { get; set; }
    }

    /// <summary>
    /// Options for the method recordGet of class Data.
    /// </summary>
    public class DataRecordGetOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The type of the record you’re retrieving
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

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
        /// [Required] The ID of the record you’re retrieving
        /// </summary>
        [SwitchName("--sobjectid")]
        public string sobjectid { get; set; }

        /// <summary>
        /// [Required] A list of <fieldName>=<value> pairs to search for
        /// </summary>
        [SwitchName("--where")]
        public string where { get; set; }

        /// <summary>
        /// [Optional] Retrieve the record with Tooling API
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }

        /// <summary>
        /// [Optional] Get API performance data
        /// </summary>
        [SwitchName("--perflog")]
        public bool? perflog { get; set; }
    }

    /// <summary>
    /// Options for the method recordUpdate of class Data.
    /// </summary>
    public class DataRecordUpdateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The <fieldName>=<value> pairs you’re updating
        /// </summary>
        [SwitchName("--values")]
        public string values { get; set; }

        /// <summary>
        /// [Required] The sObject type of the record you’re updating
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

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
        /// [Required] The ID of the record you’re updating
        /// </summary>
        [SwitchName("--sobjectid")]
        public string sobjectid { get; set; }

        /// <summary>
        /// [Required] A list of <fieldName>=<value> pairs to search for
        /// </summary>
        [SwitchName("--where")]
        public string where { get; set; }

        /// <summary>
        /// [Optional] Update the record with Tooling API
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }

        /// <summary>
        /// [Optional] Get API performance data
        /// </summary>
        [SwitchName("--perflog")]
        public bool? perflog { get; set; }
    }

    /// <summary>
    /// Options for the method soqlQuery of class Data.
    /// </summary>
    public class DataSoqlQueryOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] SOQL query to execute
        /// </summary>
        [SwitchName("--query")]
        public string query { get; set; }

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
        /// [Optional] Execute query with Tooling API
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }

        /// <summary>
        /// [Required] Result format emitted to stdout; --json flag overrides this parameter
        /// </summary>
        [SwitchName("--resultformat")]
        public string resultformat { get; set; }

        /// <summary>
        /// [Optional] Get API performance data
        /// </summary>
        [SwitchName("--perflog")]
        public bool? perflog { get; set; }
    }

    /// <summary>
    /// Options for the method treeExport of class Data.
    /// </summary>
    public class DataTreeExportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] Soql query, or filepath of file containing a soql query, to retrieve records
        /// </summary>
        [SwitchName("--query")]
        public string query { get; set; }

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
        /// [Optional] Generate mulitple sobject tree files and a plan definition file for aggregated import
        /// </summary>
        [SwitchName("--plan")]
        public bool? plan { get; set; }

        /// <summary>
        /// [Required] Prefix of generated files
        /// </summary>
        [SwitchName("--prefix")]
        public string prefix { get; set; }

        /// <summary>
        /// [Required] Directory to store files'
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }
    }

    /// <summary>
    /// Options for the method treeImport of class Data.
    /// </summary>
    public class DataTreeImportOptions : SFDXOptions
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
        /// [Required] Comma-delimited, ordered paths of json files containing collection of record trees to insert
        /// </summary>
        [SwitchName("--sobjecttreefiles")]
        public string sobjecttreefiles { get; set; }

        /// <summary>
        /// [Required] Path to plan to insert multiple data files that have master-detail relationships
        /// </summary>
        [SwitchName("--plan")]
        public string plan { get; set; }

        /// <summary>
        /// [Required] If data file extension is not .json, provide content type (applies to all files)
        /// </summary>
        [SwitchName("--contenttype")]
        public string contenttype { get; set; }

        /// <summary>
        /// [Optional] Display schema information for the --plan configuration file to stdout; if you use this option, all other options except --json are ignored
        /// </summary>
        [SwitchName("--confighelp")]
        public bool? confighelp { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    [CommandClass("force:data")]
    public class Data : SFDXCommand
    {
        /// Constructor.
        public Data(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// bulk delete records from a csv file
        /// The file must be a CSV file with only one column: "Id".
        /// One job can contain many batches, depending on the length of the CSV file.
        /// Returns a job ID and a batch ID. Use these IDs to check job status with data:bulk:status.
        /// 
        /// 
        /// </summary>
        /// <remarks>
        /// bulk delete records from a csv file
        /// The file must be a CSV file with only one column: "Id".
        /// One job can contain many batches, depending on the length of the CSV file.
        /// Returns a job ID and a batch ID. Use these IDs to check job status with data:bulk:status.
        /// 
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:data:bulk:delete -s Account -f ./path/to/file.csv
        /// sfdx force:data:bulk:delete -s MyObject__c -f ./path/to/file.csv
        /// force:data:bulk:delete -f <filepath> -s <string> [-w <minutes>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("bulk:delete")]
        public SFDXResponse BulkDelete(DataBulkDeleteOptions p_Options)
        {
            return ExecuteCommand<DataBulkDeleteOptions>(nameof(BulkDelete), p_Options);
        }

        /// <summary>
        /// view the status of a bulk data load job or batch
        /// Run this command using the job ID or batch ID returned from the force:data:bulk:delete or force:data:bulk:upsert commands.
        /// </summary>
        /// <remarks>
        /// view the status of a bulk data load job or batch
        /// Run this command using the job ID or batch ID returned from the force:data:bulk:delete or force:data:bulk:upsert commands.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:data:bulk:status -i 750xx000000005sAAA
        /// sfdx force:data:bulk:status -i 750xx000000005sAAA -b 751xx000000005nAAA
        /// force:data:bulk:status -i <string> [-b <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("bulk:status")]
        public SFDXResponse BulkStatus(DataBulkStatusOptions p_Options)
        {
            return ExecuteCommand<DataBulkStatusOptions>(nameof(BulkStatus), p_Options);
        }

        /// <summary>
        /// bulk upsert records from a CSV file
        /// Inserts or updates records from a CSV file.
        /// 
        /// One job can contain many batches, depending on the length of the CSV file.
        /// Returns a job ID and a batch ID. Use these IDs to check job status with data:bulk:status.
        /// 
        /// For information about formatting your CSV file, see "Prepare CSV Files" in the Bulk API Developer Guide. 
        /// 
        /// By default, the job runs the batches in parallel. Specify --serial to run them serially.
        /// </summary>
        /// <remarks>
        /// bulk upsert records from a CSV file
        /// Inserts or updates records from a CSV file.
        /// 
        /// One job can contain many batches, depending on the length of the CSV file.
        /// Returns a job ID and a batch ID. Use these IDs to check job status with data:bulk:status.
        /// 
        /// For information about formatting your CSV file, see "Prepare CSV Files" in the Bulk API Developer Guide. 
        /// 
        /// By default, the job runs the batches in parallel. Specify --serial to run them serially.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:data:bulk:upsert -s MyObject__c -f ./path/to/file.csv -i MyField__c
        /// sfdx force:data:bulk:upsert -s MyObject__c -f ./path/to/file.csv -i Id -w 2
        /// force:data:bulk:upsert -i <string> -f <filepath> -s <string> [-w <minutes>] [-r] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("bulk:upsert")]
        public SFDXResponse BulkUpsert(DataBulkUpsertOptions p_Options)
        {
            return ExecuteCommand<DataBulkUpsertOptions>(nameof(BulkUpsert), p_Options);
        }

        /// <summary>
        /// creates and inserts a record
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// </summary>
        /// <remarks>
        /// creates and inserts a record
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:data:record:create -s Account -v "Name=Acme"
        /// sfdx force:data:record:create -s Account -v "Name='Universal Containers'"
        /// sfdx force:data:record:create -s Account -v "Name='Universal Containers' Website=www.example.com"
        /// sfdx force:data:record:create -t -s TraceFlag -v "DebugLevelId=7dl170000008U36AAE StartDate=2017-12-01T00:26:04.000+0000 ExpirationDate=2017-12-01T00:56:04.000+0000 LogType=CLASS_TRACING TracedEntityId=01p17000000R6bLAAS"
        /// sfdx force:data:record:create -s Account -v "Name=Acme" --perflog --json
        /// force:data:record:create -s <string> -v <string> [-t] [--perflog --json] [-u <string>] [--apiversion <string>] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("record:create")]
        public SFDXResponse RecordCreate(DataRecordCreateOptions p_Options)
        {
            return ExecuteCommand<DataRecordCreateOptions>(nameof(RecordCreate), p_Options);
        }

        /// <summary>
        /// deletes a single record
        /// Specify an sObject type and either an ID or a list of <fieldName>=<value> pairs.
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// </summary>
        /// <remarks>
        /// deletes a single record
        /// Specify an sObject type and either an ID or a list of <fieldName>=<value> pairs.
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:data:record:delete -s Account -i 001D000000Kv3dl
        /// sfdx force:data:record:delete -s Account -w "Name=Acme"
        /// sfdx force:data:record:delete -s Account -w "Name='Universal Containers'"
        /// sfdx force:data:record:delete -s Account -w "Name='Universal Containers' Phone='(123) 456-7890'"
        /// sfdx force:data:record:delete -t -s TraceFlag -i 7tf170000009cU6AAI --perflog --json
        /// force:data:record:delete -s <string> [-i <id> | -w <string>] [-t] [--perflog --json] [-u <string>] [--apiversion <string>] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("record:delete")]
        public SFDXResponse RecordDelete(DataRecordDeleteOptions p_Options)
        {
            return ExecuteCommand<DataRecordDeleteOptions>(nameof(RecordDelete), p_Options);
        }

        /// <summary>
        /// displays a single record
        /// Specify an sObject type and either an ID or a list of <fieldName>=<value> pairs.
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// </summary>
        /// <remarks>
        /// displays a single record
        /// Specify an sObject type and either an ID or a list of <fieldName>=<value> pairs.
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:data:record:get -s Account -i 001D000000Kv3dl
        /// sfdx force:data:record:get -s Account -w "Name=Acme"
        /// sfdx force:data:record:get -s Account -w "Name='Universal Containers'"
        /// sfdx force:data:record:get -s Account -w "Name='Universal Containers' Phone='(123) 456-7890'"
        /// sfdx force:data:record:get -t -s TraceFlag -i 7tf170000009cUBAAY --perflog --json
        /// force:data:record:get -s <string> [-i <id> | -w <string>] [-t] [--perflog --json] [-u <string>] [--apiversion <string>] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("record:get")]
        public SFDXResponse RecordGet(DataRecordGetOptions p_Options)
        {
            return ExecuteCommand<DataRecordGetOptions>(nameof(RecordGet), p_Options);
        }

        /// <summary>
        /// updates a single record
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// </summary>
        /// <remarks>
        /// updates a single record
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:data:record:update -s Account -i 001D000000Kv3dl -v "Name=NewAcme"
        /// sfdx force:data:record:update -s Account -w "Name='Old Acme'" -v "Name='New Acme'"
        /// sfdx force:data:record:update -s Account -i 001D000000Kv3dl -v "Name='Acme III' Website=www.example.com"
        /// sfdx force:data:record:update -t -s TraceFlag -i 7tf170000009cUBAAY -v "ExpirationDate=2017-12-01T00:58:04.000+0000"
        /// sfdx force:data:record:update -s Account -i 001D000000Kv3dl -v "Name=NewAcme" --perflog --json
        /// force:data:record:update -s <string> -v <string> [-i <id> | -w <string>] [-t] [--perflog --json] [-u <string>] [--apiversion <string>] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("record:update")]
        public SFDXResponse RecordUpdate(DataRecordUpdateOptions p_Options)
        {
            return ExecuteCommand<DataRecordUpdateOptions>(nameof(RecordUpdate), p_Options);
        }

        /// <summary>
        /// execute a SOQL query
        /// When you execute this command in a project, it executes the query against the data in your default scratch org.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// 
        /// 
        /// </summary>
        /// <remarks>
        /// execute a SOQL query
        /// When you execute this command in a project, it executes the query against the data in your default scratch org.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// 
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:data:soql:query -q "SELECT Id, Name, Account.Name FROM Contact"
        /// sfdx force:data:soql:query -q "SELECT Id, Name FROM Account WHERE ShippingState IN ('CA', 'NY')"
        /// sfdx force:data:soql:query -q "SELECT Id, Name FROM Account WHERE ShippingState IN ('CA', 'NY')" --perflog --json
        /// sfdx force:data:soql:query -q "SELECT Name FROM ApexTrigger" -t
        /// force:data:soql:query -q <string> [-t] [-r human|csv|json] [--perflog --json] [-u <string>] [--apiversion <string>] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("soql:query")]
        public SFDXResponse SoqlQuery(DataSoqlQueryOptions p_Options)
        {
            return ExecuteCommand<DataSoqlQueryOptions>(nameof(SoqlQuery), p_Options);
        }

        /// <summary>
        /// export data from an org
        /// Exports data from an org into sObject tree format for use with the force:data:tree:import command.
        /// The query for export can return a maximum of 2,000 records. For more information, see the REST API Developer Guide: https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm
        /// </summary>
        /// <remarks>
        /// export data from an org
        /// Exports data from an org into sObject tree format for use with the force:data:tree:import command.
        /// The query for export can return a maximum of 2,000 records. For more information, see the REST API Developer Guide: https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:data:tree:export -q "SELECT Id, Name, (SELECT Name, Address__c FROM Properties__r) FROM Broker__c"
        /// sfdx force:data:tree:export -q <path to file containing soql query> -x export-demo -d /tmp/sfdx-out -p
        /// force:data:tree:export -q <string> [-p] [-x <string>] [-d <directory>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("tree:export")]
        public SFDXResponse TreeExport(DataTreeExportOptions p_Options)
        {
            return ExecuteCommand<DataTreeExportOptions>(nameof(TreeExport), p_Options);
        }

        /// <summary>
        /// import data into an org
        /// Imports data into an org using the SObject Tree Save API.  This data can include master-detail relationships.
        /// To generate JSON files for use with force:data:tree:import, run "sfdx force:data:tree:export".
        /// The SObject Tree API supports requests that contain up to 200 records. For more information, see the REST API Developer Guide: https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm
        /// </summary>
        /// <remarks>
        /// import data into an org
        /// Imports data into an org using the SObject Tree Save API.  This data can include master-detail relationships.
        /// To generate JSON files for use with force:data:tree:import, run "sfdx force:data:tree:export".
        /// The SObject Tree API supports requests that contain up to 200 records. For more information, see the REST API Developer Guide: https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:data:tree:import -f Contact.json,Account.json -u me@my.org
        /// sfdx force:data:tree:import -p Account-Contact-plan.json -u me@my.org
        /// force:data:tree:import [-f <array> | -p <filepath>] [--confighelp] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("tree:import")]
        public SFDXResponse TreeImport(DataTreeImportOptions p_Options)
        {
            return ExecuteCommand<DataTreeImportOptions>(nameof(TreeImport), p_Options);
        }
    }
}

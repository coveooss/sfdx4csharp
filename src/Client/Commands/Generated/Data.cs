// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method CreateRecord of class Data.
    /// </summary>
    public class DataCreateRecordOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for values
        /// </summary>
        [SwitchName("--values")]
        public string Values { get; set; }

        /// <summary>
        /// [Required] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }

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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for use-tooling-api
        /// </summary>
        [SwitchName("--use-tooling-api")]
        public bool? UseToolingApi { get; set; }

        /// <summary>
        /// [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json.
        /// </summary>
        [SwitchName("--perflog")]
        public bool? Perflog { get; set; }
    }

    /// <summary>
    /// Options for the method DeleteBulk of class Data.
    /// </summary>
    public class DataDeleteBulkOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }

        /// <summary>
        /// [Required] No description for file
        /// </summary>
        [SwitchName("--file")]
        public string File { get; set; }

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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for wait
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] No description for async
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method DeleteRecord of class Data.
    /// </summary>
    public class DataDeleteRecordOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }

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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for record-id
        /// </summary>
        [SwitchName("--record-id")]
        public string RecordId { get; set; }

        /// <summary>
        /// [Optional] No description for where
        /// </summary>
        [SwitchName("--where")]
        public string Where { get; set; }

        /// <summary>
        /// [Optional] No description for use-tooling-api
        /// </summary>
        [SwitchName("--use-tooling-api")]
        public bool? UseToolingApi { get; set; }

        /// <summary>
        /// [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json.
        /// </summary>
        [SwitchName("--perflog")]
        public bool? Perflog { get; set; }
    }

    /// <summary>
    /// Options for the method DeleteResume of class Data.
    /// </summary>
    public class DataDeleteResumeOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] No description for job-id
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] No description for use-most-recent
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }

        /// <summary>
        /// [Optional] No description for wait
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method ExportBetaTree of class Data.
    /// </summary>
    public class DataExportBetaTreeOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for query
        /// </summary>
        [SwitchName("--query")]
        public string Query { get; set; }

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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for plan
        /// </summary>
        [SwitchName("--plan")]
        public bool? Plan { get; set; }

        /// <summary>
        /// [Optional] No description for prefix
        /// </summary>
        [SwitchName("--prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// [Optional] No description for output-dir
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }
    }

    /// <summary>
    /// Options for the method ExportTree of class Data.
    /// </summary>
    public class DataExportTreeOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for query
        /// </summary>
        [SwitchName("--query")]
        public string Query { get; set; }

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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for plan
        /// </summary>
        [SwitchName("--plan")]
        public bool? Plan { get; set; }

        /// <summary>
        /// [Optional] No description for prefix
        /// </summary>
        [SwitchName("--prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// [Optional] No description for output-dir
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }
    }

    /// <summary>
    /// Options for the method GetRecord of class Data.
    /// </summary>
    public class DataGetRecordOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }

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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for record-id
        /// </summary>
        [SwitchName("--record-id")]
        public string RecordId { get; set; }

        /// <summary>
        /// [Optional] No description for where
        /// </summary>
        [SwitchName("--where")]
        public string Where { get; set; }

        /// <summary>
        /// [Optional] No description for use-tooling-api
        /// </summary>
        [SwitchName("--use-tooling-api")]
        public bool? UseToolingApi { get; set; }

        /// <summary>
        /// [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json.
        /// </summary>
        [SwitchName("--perflog")]
        public bool? Perflog { get; set; }
    }

    /// <summary>
    /// Options for the method ImportBetaTree of class Data.
    /// </summary>
    public class DataImportBetaTreeOptions : SfOptions
    {
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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for files
        /// </summary>
        [SwitchName("--files")]
        public string Files { get; set; }

        /// <summary>
        /// [Optional] No description for plan
        /// </summary>
        [SwitchName("--plan")]
        public string Plan { get; set; }
    }

    /// <summary>
    /// Options for the method ImportTree of class Data.
    /// </summary>
    public class DataImportTreeOptions : SfOptions
    {
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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for files
        /// </summary>
        [SwitchName("--files")]
        public string Files { get; set; }

        /// <summary>
        /// [Optional] No description for plan
        /// </summary>
        [SwitchName("--plan")]
        public string Plan { get; set; }

        /// <summary>
        /// [Optional] No description for content-type
        /// </summary>
        [SwitchName("--content-type")]
        public string ContentType { get; set; }

        /// <summary>
        /// [Optional] No description for config-help
        /// </summary>
        [SwitchName("--config-help")]
        public bool? ConfigHelp { get; set; }
    }

    /// <summary>
    /// Options for the method Query of class Data.
    /// </summary>
    public class DataQueryOptions : SfOptions
    {
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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for query
        /// </summary>
        [SwitchName("--query")]
        public string Query { get; set; }

        /// <summary>
        /// [Optional] No description for file
        /// </summary>
        [SwitchName("--file")]
        public string File { get; set; }

        /// <summary>
        /// [Optional] No description for use-tooling-api
        /// </summary>
        [SwitchName("--use-tooling-api")]
        public bool? UseToolingApi { get; set; }

        /// <summary>
        /// [Optional] No description for bulk
        /// </summary>
        [SwitchName("--bulk")]
        public bool? Bulk { get; set; }

        /// <summary>
        /// [Optional] No description for wait
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] No description for async
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] No description for all-rows
        /// </summary>
        [SwitchName("--all-rows")]
        public bool? AllRows { get; set; }

        /// <summary>
        /// [Optional] No description for result-format
        /// </summary>
        [SwitchName("--result-format")]
        public string ResultFormat { get; set; }

        /// <summary>
        /// [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json.
        /// </summary>
        [SwitchName("--perflog")]
        public bool? Perflog { get; set; }
    }

    /// <summary>
    /// Options for the method QueryResume of class Data.
    /// </summary>
    public class DataQueryResumeOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for result-format
        /// </summary>
        [SwitchName("--result-format")]
        public string ResultFormat { get; set; }

        /// <summary>
        /// [Optional] No description for bulk-query-id
        /// </summary>
        [SwitchName("--bulk-query-id")]
        public string BulkQueryId { get; set; }

        /// <summary>
        /// [Optional] No description for use-most-recent
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }
    }

    /// <summary>
    /// Options for the method UpdateRecord of class Data.
    /// </summary>
    public class DataUpdateRecordOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for values
        /// </summary>
        [SwitchName("--values")]
        public string Values { get; set; }

        /// <summary>
        /// [Required] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }

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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for record-id
        /// </summary>
        [SwitchName("--record-id")]
        public string RecordId { get; set; }

        /// <summary>
        /// [Optional] No description for where
        /// </summary>
        [SwitchName("--where")]
        public string Where { get; set; }

        /// <summary>
        /// [Optional] No description for use-tooling-api
        /// </summary>
        [SwitchName("--use-tooling-api")]
        public bool? UseToolingApi { get; set; }

        /// <summary>
        /// [Optional] No description for perflog
        /// </summary>
        [SwitchName("--perflog")]
        public bool? Perflog { get; set; }
    }

    /// <summary>
    /// Options for the method UpsertBulk of class Data.
    /// </summary>
    public class DataUpsertBulkOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for external-id
        /// </summary>
        [SwitchName("--external-id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// [Required] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }

        /// <summary>
        /// [Required] No description for file
        /// </summary>
        [SwitchName("--file")]
        public string File { get; set; }

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
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for wait
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] No description for async
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method UpsertResume of class Data.
    /// </summary>
    public class DataUpsertResumeOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] No description for job-id
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] No description for use-most-recent
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }

        /// <summary>
        /// [Optional] No description for wait
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    [CommandClass("data")]
    public class Data : SfCommand
    {
        /// Constructor.
        public Data(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Create and insert a record into a Salesforce or Tooling API object.
        /// </summary>
        /// <remarks>
        /// You must specify a value for all required fields of the object.
        /// 
        /// When specifying fields, use the format [fieldName]=[value]. Enclose all field-value pairs in one set of double quotation marks, delimited by spaces. Enclose values that contain spaces in single quotes.
        /// 
        /// This command inserts a record into Salesforce objects by default. Use the --use-tooling-api flag to insert into a Tooling API object.
        /// </remarks>
        /// <example>
        /// Insert a record into the Account object of your default org; only the required Name field has a value:
        /// $ sf create record --sobject Account --values "Name=Acme"
        /// Insert an Account record with values for two fields, one value contains a space; the command uses the org with alias "my-scratch":
        /// $ sf create record --sobject Account --values "Name='Universal Containers' Website=www.example.com" --target-org my-scratch
        /// Insert a record into the Tooling API object TraceFlag:
        /// $ sf create record --use-tooling-api --sobject TraceFlag --values "DebugLevelId=7dl170000008U36AAE StartDate=2022-12-15T00:26:04.000+0000 ExpirationDate=2022-12-15T00:56:04.000+0000 LogType=CLASS_TRACING TracedEntityId=01p17000000R6bLAAS"
        /// </example>
        [Command("create record")]
        public SfResponse CreateRecord(DataCreateRecordOptions options)
        {
            return ExecuteCommand(nameof(CreateRecord), options);
        }

        /// <summary>
        /// Bulk delete records from an org using a CSV file. Uses Bulk API 2.0.
        /// </summary>
        /// <remarks>
        /// The CSV file must have only one column ("Id") and then the list of record IDs you want to delete, one ID per line.
        /// 
        /// When you execute this command, it starts a job, displays the ID, and then immediately returns control of the terminal to you by default. If you prefer to wait, set the --wait flag to the number of minutes; if it times out, the command outputs the IDs. Use the job ID to check the status of the job with the "$ sf data delete resume" command.
        /// </remarks>
        /// <example>
        /// Bulk delete Account records from your default org using the list of IDs in the "files/delete.csv" file:
        /// $ sf delete bulk --sobject Account --file files/delete.csv
        /// Bulk delete records from a custom object in an org with alias my-scratch and wait 5 minutes for the command to complete:
        /// $ sf delete bulk --sobject MyObject__c --file files/delete.csv --wait 5 --target-org my-scratch
        /// </example>
        [Command("delete bulk")]
        public SfResponse DeleteBulk(DataDeleteBulkOptions options)
        {
            return ExecuteCommand(nameof(DeleteBulk), options);
        }

        /// <summary>
        /// Deletes a single record from a Salesforce or Tooling API object.
        /// </summary>
        /// <remarks>
        /// Specify the record you want to delete with either its ID or with a list of field-value pairs that identify the record. If your list of fields identifies more than one record, the delete fails; the error displays how many records were found.
        /// 
        /// When specifying field-value pairs, use the format [fieldName]=[value]. Enclose all field-value pairs in one set of double quotation marks, delimited by spaces. Enclose values that contain spaces in single quotes.
        /// 
        /// This command deletes a record from Salesforce objects by default. Use the --use-tooling-api flag to delete from a Tooling API object.
        /// </remarks>
        /// <example>
        /// Delete a record from Account with the specified (truncated) ID:
        /// $ sf delete record --sobject Account --record-id 00180XX
        /// Delete a record from Account whose name equals "Acme":
        /// $ sf delete record --sobject Account --where "Name=Acme"
        /// Delete a record from Account identified with two field values, one that contains a space; the command uses the org with alias "my-scratch":
        /// $ sf delete record --sobject Account --where "Name='Universal Containers' Phone='(123) 456-7890'" --target-org myscratch
        /// Delete a record from the Tooling API object TraceFlag with the specified (truncated) ID:
        /// $ sf delete record --use-tooling-api --sobject TraceFlag --record-id 7tf8c
        /// </example>
        [Command("delete record")]
        public SfResponse DeleteRecord(DataDeleteRecordOptions options)
        {
            return ExecuteCommand(nameof(DeleteRecord), options);
        }

        /// <summary>
        /// Resume a bulk delete job that you previously started. Uses Bulk API 2.0.
        /// </summary>
        /// <remarks>
        /// The command uses the job ID returned by the "$ sf data delete bulk" command or the most recently-run bulk delete job.
        /// </remarks>
        /// <example>
        /// Resume a bulk delete job from your default org using an ID:
        /// $ sf delete resume --job-id 750xx000000005sAAA
        /// Resume the most recently run bulk delete job for an org with alias my-scratch:
        /// $ sf delete resume --use-most-recent --target-org my-scratch
        /// </example>
        [Command("delete resume")]
        public SfResponse DeleteResume(DataDeleteResumeOptions options = null)
        {
            return ExecuteCommand(nameof(DeleteResume), options);
        }

        /// <summary>
        /// Export data from an org into one or more JSON files.
        /// </summary>
        /// <remarks>
        /// Specify a SOQL query, either directly at the command line or read from a file, to retrieve the data you want to export. The exported data is written to JSON files in sObject tree format, which is a collection of nested, parent-child records with a single root record. Use these JSON files to import data into an org with the "$ sf data import tree" command.
        /// 
        /// If your SOQL query references multiple objects, the command generates a single JSON file by default. You can specify the --plan flag to generate separate JSON files for each object and a plan definition file that aggregates them. You then specify just this plan definition file when you import the data into an org.
        /// 
        /// The SOQL query can return a maximum of 2,000 records. For more information, see the REST API Developer Guide. (https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm).
        /// </remarks>
        /// <example>
        /// Export records retrieved with the specified SOQL query into a single JSON file in the current directory; the command uses your default org:
        /// $ sf export beta tree --query "SELECT Id, Name, (SELECT Name, Address__c FROM Properties__r) FROM Broker__c"
        /// Export data using a SOQL query in the "query.txt" file and generate JSON files for each object and a plan that aggregates them:
        /// $ sf export beta tree --query query.txt --plan
        /// Prepend "export-demo" before each generated file and generate the files in the "export-out" directory; run the command on the org with alias "my-scratch":
        /// $ sf export beta tree --query query.txt --plan --prefix export-demo --output-dir export-out --target-org my-scratch
        /// </example>
        [Command("export beta tree")]
        public SfResponse ExportBetaTree(DataExportBetaTreeOptions options)
        {
            return ExecuteCommand(nameof(ExportBetaTree), options);
        }

        /// <summary>
        /// Export data from an org into one or more JSON files.
        /// </summary>
        /// <remarks>
        /// Specify a SOQL query, either directly at the command line or read from a file, to retrieve the data you want to export. The exported data is written to JSON files in sObject tree format, which is a collection of nested, parent-child records with a single root record. Use these JSON files to import data into an org with the "$ sf data import tree" command.
        /// 
        /// If your SOQL query references multiple objects, the command generates a single JSON file by default. You can specify the --plan flag to generate separate JSON files for each object and a plan definition file that aggregates them. You then specify just this plan definition file when you import the data into an org.
        /// 
        /// The SOQL query can return a maximum of 2,000 records. For more information, see the REST API Developer Guide. (https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm).
        /// </remarks>
        /// <example>
        /// Export records retrieved with the specified SOQL query into a single JSON file in the current directory; the command uses your default org:
        /// $ sf export tree --query "SELECT Id, Name, (SELECT Name, Address__c FROM Properties__r) FROM Broker__c"
        /// Export data using a SOQL query in the "query.txt" file and generate JSON files for each object and a plan that aggregates them:
        /// $ sf export tree --query query.txt --plan
        /// Prepend "export-demo" before each generated file and generate the files in the "export-out" directory; run the command on the org with alias "my-scratch":
        /// $ sf export tree --query query.txt --plan --prefix export-demo --output-dir export-out --target-org my-scratch
        /// </example>
        [Command("export tree")]
        public SfResponse ExportTree(DataExportTreeOptions options)
        {
            return ExecuteCommand(nameof(ExportTree), options);
        }

        /// <summary>
        /// Retrieve and display a single record of a Salesforce or Tooling API object.
        /// </summary>
        /// <remarks>
        /// Specify the record you want to retrieve with either its ID or with a list of field-value pairs that identify the record. If your list of fields identifies more than one record, the command fails; the error displays how many records were found.
        /// 
        /// When specifying field-value pairs, use the format [fieldName]=[value]. Enclose all field-value pairs in one set of double quotation marks, delimited by spaces. Enclose values that contain spaces in single quotes.
        /// 
        /// The command displays all the record's fields and their values, one field per terminal line. Fields with no values are displayed as "null".
        /// 
        /// This command retrieves a record from Salesforce objects by default. Use the --use-tooling-api flag to retrieve from a Tooling API object.
        /// </remarks>
        /// <example>
        /// Retrieve and display a record from Account with the specified (truncated) ID:
        /// $ sf get record --sobject Account --record-id 00180XX
        /// Retrieve a record from Account whose name equals "Acme":
        /// $ sf get record --sobject Account --where "Name=Acme"
        /// Retrieve a record from Account identified with two field values, one that contains a space; the command uses the org with alias "my-scratch":
        /// $ sf get record --sobject Account --where "Name='Universal Containers' Phone='(123) 456-7890'" --target-org myscratch
        /// Retrieve a record from the Tooling API object TraceFlag with the specified (truncated) ID:
        /// $ sf get record --use-tooling-api --sobject TraceFlag --record-id 7tf8c
        /// </example>
        [Command("get record")]
        public SfResponse GetRecord(DataGetRecordOptions options)
        {
            return ExecuteCommand(nameof(GetRecord), options);
        }

        /// <summary>
        /// Import data from one or more JSON files into an org.
        /// </summary>
        /// <remarks>
        /// The JSON files that contain the data are in sObject tree format, which is a collection of nested, parent-child records with a single root record. Use the "$ sf data export tree" command to generate these JSON files.
        /// 
        /// If you used the --plan flag when exporting the data to generate a plan definition file, use the --plan flag to reference the file when you import. If you're not using a plan, use the --files flag to list the files. If you specify multiple JSON files that depend on each other in a parent-child relationship, be sure you list them in the correct order.
        /// </remarks>
        /// <example>
        /// Import the records contained in two JSON files into the org with alias "my-scratch":
        /// $ sf import beta tree --files Contact.json,Account.json --target-org my-scratch
        /// Import records using a plan definition file into your default org:
        /// $ sf import beta tree --plan Account-Contact-plan.json
        /// </example>
        [Command("import beta tree")]
        public SfResponse ImportBetaTree(DataImportBetaTreeOptions options)
        {
            return ExecuteCommand(nameof(ImportBetaTree), options);
        }

        /// <summary>
        /// Import data from one or more JSON files into an org.
        /// </summary>
        /// <remarks>
        /// The JSON files that contain the data are in sObject tree format, which is a collection of nested, parent-child records with a single root record. Use the "$ sf data export tree" command to generate these JSON files.
        /// 
        /// If you used the --plan flag when exporting the data to generate a plan definition file, use the --plan flag to reference the file when you import. If you're not using a plan, use the --files flag to list the files. If you specify multiple JSON files that depend on each other in a parent-child relationship, be sure you list them in the correct order.
        /// 
        /// The sObject Tree API supports requests that contain up to 200 records. For more information, see the REST API Developer Guide. (https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm)
        /// </remarks>
        /// <example>
        /// Import the records contained in two JSON files into the org with alias "my-scratch":
        /// $ sf import tree --files Contact.json,Account.json --target-org my-scratch
        /// Import records using a plan definition file into your default org:
        /// $ sf import tree --plan Account-Contact-plan.json
        /// </example>
        [Command("import tree")]
        public SfResponse ImportTree(DataImportTreeOptions options)
        {
            return ExecuteCommand(nameof(ImportTree), options);
        }

        /// <summary>
        /// Execute a SOQL query.
        /// </summary>
        /// <remarks>
        /// Specify the SOQL query at the command line with the --query flag or read the query from a file with the --file flag.
        /// 
        /// If your query returns more than 10,000 records, specify the --bulk flag. The command then runs the query using Bulk API 2.0, which has higher limits than the default API used by the command.
        /// 
        /// When using --bulk, the command waits 3 minutes by default for the query to complete. Use the --wait parameter to specify a different number of minutes to wait, or set --wait to 0 to immediately return control to the terminal. If you set --wait to 0, or you use the --async flag, or the command simply times out, the command displays an ID. Pass this ID to the the "data query resume" command using the --bulk-query-id flag to get the results; pass the ID to the "data resume" command to get the job status.
        /// </remarks>
        /// <example>
        /// Specify a SOQL query at the command line; the command uses your default org:
        /// $ sf query --query "SELECT Id, Name, Account.Name FROM Contact"
        /// Read the SOQL query from a file called "query.txt"; the command uses the org with alias "my-scratch":
        /// $ sf query --file query.txt --target-org my-scratch
        /// Use Tooling API to run a query on the ApexTrigger Tooling API object:
        /// $ sf query --query "SELECT Name FROM ApexTrigger" --use-tooling-api
        /// Use Bulk API 2.0 to run a query that returns many rows, and return control to the terminal immediately:
        /// $ sf query --query "SELECT Id FROM Contact" --bulk --wait 0
        /// </example>
        [Command("query")]
        public SfResponse Query(DataQueryOptions options)
        {
            return ExecuteCommand(nameof(Query), options);
        }

        /// <summary>
        /// View the status of a bulk query.
        /// </summary>
        /// <remarks>
        /// Run this command using the job ID returned from the "$ sf data query --bulk" command.
        /// </remarks>
        /// <example>
        /// View the status of a bulk query with the specified ID:
        /// $ sf query resume --bulk-query-id 7500x000005BdFzXXX
        /// </example>
        [Command("query resume")]
        public SfResponse QueryResume(DataQueryResumeOptions options = null)
        {
            return ExecuteCommand(nameof(QueryResume), options);
        }

        /// <summary>
        /// Updates a single record of a Salesforce or Tooling API object.
        /// </summary>
        /// <remarks>
        /// Specify the record you want to update with either its ID or with a list of field-value pairs that identify the record. If your list of fields identifies more than one record, the update fails; the error displays how many records were found.
        /// 
        /// When using field-value pairs for both identifying the record and specifiyng the new field values, use the format [fieldName]=[value]. Enclose all field-value pairs in one set of double quotation marks, delimited by spaces. Enclose values that contain spaces in single quotes.
        /// 
        /// This command updates a record in Salesforce objects by default. Use the --use-tooling-api flag to update a Tooling API object.
        /// </remarks>
        /// <example>
        /// Update the Name field of an Account record with the specified (truncated) ID:
        /// $ sf update record --sobject Account --record-id 001D0 --values "Name=NewAcme"
        /// Update the Name field of an Account record whose current name is 'Old Acme':
        /// $ sf update record --sobject Account --where "Name='Old Acme'" --values "Name='New Acme'"
        /// Update the Name and Website fields of an Account record with the specified (truncated) ID:
        /// $ sf update record --sobject Account --record-id 001D0 --values "Name='Acme III' Website=www.example.com"
        /// Update the ExpirationDate field of a record of the Tooling API object TraceFlag using the specified (truncated) ID:
        /// $ sf update record -t --sobject TraceFlag --record-id 7tf170000009cUBAAY --values "ExpirationDate=2017-12-01T00:58:04.000+0000"
        /// </example>
        [Command("update record")]
        public SfResponse UpdateRecord(DataUpdateRecordOptions options)
        {
            return ExecuteCommand(nameof(UpdateRecord), options);
        }

        /// <summary>
        /// Bulk upsert records to an org from a CSV file. Uses Bulk API 2.0.
        /// </summary>
        /// <remarks>
        /// An upsert refers to inserting a record into a Salesforce object if the record doesn't already exist, or updating it if it does exist.
        /// 
        /// When you execute this command, it starts a job, displays the ID, and then immediately returns control of the terminal to you by default. If you prefer to wait, set the --wait flag to the number of minutes; if it times out, the command outputs the IDs. Use the job and batch IDs to check the status of the job with the "$ sf data upsert resume" command.
        /// 
        /// See "Prepare CSV Files" in the Bulk API Developer Guide for details on formatting your CSV file. (https://developer.salesforce.com/docs/atlas.en-us.api_asynch.meta/api_asynch/datafiles_prepare_csv.htm)
        /// </remarks>
        /// <example>
        /// Bulk upsert records to the Contact object in your default org:
        /// $ sf upsert bulk --sobject Contact --file files/contacts.csv --external-id Id
        /// Bulk upsert records to a custom object in an org with alias my-scratch and wait 5 minutes for the command to complete:
        /// $ sf upsert bulk --sobject MyObject__c --file files/file.csv --external-id MyField__c --wait 5 --target-org my-scratch
        /// </example>
        [Command("upsert bulk")]
        public SfResponse UpsertBulk(DataUpsertBulkOptions options)
        {
            return ExecuteCommand(nameof(UpsertBulk), options);
        }

        /// <summary>
        /// Resume a bulk upsert job that you previously started. Uses Bulk API 2.0.
        /// </summary>
        /// <remarks>
        /// The command uses the job ID returned from the "$ sf data upsert bulk" command or the most recently-run bulk upsert job.
        /// </remarks>
        /// <example>
        /// Resume a bulk upsert job from your default org using an ID:
        /// $ sf upsert resume --job-id 750xx000000005sAAA
        /// Resume the most recently run bulk upsert job for an org with alias my-scratch:
        /// $ sf upsert resume --use-most-recent --target-org my-scratch
        /// </example>
        [Command("upsert resume")]
        public SfResponse UpsertResume(DataUpsertResumeOptions options = null)
        {
            return ExecuteCommand(nameof(UpsertResume), options);
        }
    }
}

// Generated on November 19th 2018, 12:30:00 pm using sfdx-cli/6.40.0-384e0c6cf2 (windows-x64) node-v8.9.4. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

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
        /// [Required] The sObject type of the records you’re deleting.
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

        /// <summary>
        /// [Required] The path to the CSV file that contains the IDs of the records to delete.
        /// </summary>
        [SwitchName("--csvfile")]
        public string csvfile { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] The number of minutes to wait for the command to complete before displaying the results.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }
    }

    /// <summary>
    /// Options for the method bulkStatus of class Data.
    /// </summary>
    public class DataBulkStatusOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The ID of the job you want to view or of the job whose batch you want to view.
        /// </summary>
        [SwitchName("--jobid")]
        public string jobid { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] The ID of the batch whose status you want to view.
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
        /// [Required] The sObject type of the records you want to upsert.
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

        /// <summary>
        /// [Required] The path to the CSV file that defines the records to upsert.
        /// </summary>
        [SwitchName("--csvfile")]
        public string csvfile { get; set; }

        /// <summary>
        /// [Required] The column name of the external ID.
        /// </summary>
        [SwitchName("--externalid")]
        public string externalid { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] The number of minutes to wait for the command to complete before displaying the results.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }
    }

    /// <summary>
    /// Options for the method recordCreate of class Data.
    /// </summary>
    public class DataRecordCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The sObject type of the record you’re creating.
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

        /// <summary>
        /// [Required] The <fieldName>=<value> pairs you’re creating.
        /// </summary>
        [SwitchName("--values")]
        public string values { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json
        /// </summary>
        [SwitchName("--perflog")]
        public bool? perflog { get; set; }

        /// <summary>
        /// [Optional] Create the record using Tooling API.
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }
    }

    /// <summary>
    /// Options for the method recordDelete of class Data.
    /// </summary>
    public class DataRecordDeleteOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The sObject type of the record you’re deleting.
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json
        /// </summary>
        [SwitchName("--perflog")]
        public bool? perflog { get; set; }

        /// <summary>
        /// [Optional] Delete the record using Tooling API.
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }

        /// <summary>
        /// [Required] A list of <fieldName>=<value> pairs to search for.
        /// </summary>
        [SwitchName("--where")]
        public string where { get; set; }

        /// <summary>
        /// [Required] The ID of the record you’re deleting.
        /// </summary>
        [SwitchName("--sobjectid")]
        public string sobjectid { get; set; }
    }

    /// <summary>
    /// Options for the method recordGet of class Data.
    /// </summary>
    public class DataRecordGetOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The sObject type of the record you’re retrieving.
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json
        /// </summary>
        [SwitchName("--perflog")]
        public bool? perflog { get; set; }

        /// <summary>
        /// [Optional] Retrieve the record using Tooling API.
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }

        /// <summary>
        /// [Required] A list of <fieldName>=<value> pairs to search for.
        /// </summary>
        [SwitchName("--where")]
        public string where { get; set; }

        /// <summary>
        /// [Required] The ID of the record you’re retrieving.
        /// </summary>
        [SwitchName("--sobjectid")]
        public string sobjectid { get; set; }
    }

    /// <summary>
    /// Options for the method recordUpdate of class Data.
    /// </summary>
    public class DataRecordUpdateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The sObject type of the record you’re updating.
        /// </summary>
        [SwitchName("--sobjecttype")]
        public string sobjecttype { get; set; }

        /// <summary>
        /// [Required] The <fieldName>=<value> pairs you’re updating.
        /// </summary>
        [SwitchName("--values")]
        public string values { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json
        /// </summary>
        [SwitchName("--perflog")]
        public bool? perflog { get; set; }

        /// <summary>
        /// [Optional] Update the record using Tooling API.
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }

        /// <summary>
        /// [Required] A list of <fieldName>=<value> pairs to search for.
        /// </summary>
        [SwitchName("--where")]
        public string where { get; set; }

        /// <summary>
        /// [Required] The ID of the record you’re updating.
        /// </summary>
        [SwitchName("--sobjectid")]
        public string sobjectid { get; set; }
    }

    /// <summary>
    /// Options for the method soqlQuery of class Data.
    /// </summary>
    public class DataSoqlQueryOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] SOQL query to execute.
        /// </summary>
        [SwitchName("--query")]
        public string query { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json
        /// </summary>
        [SwitchName("--perflog")]
        public bool? perflog { get; set; }

        /// <summary>
        /// [Required] Format to use when displaying query results. If you also specify the --json flag, --json overrides this parameter.
        /// </summary>
        [SwitchName("--resultformat")]
        public string resultformat { get; set; }

        /// <summary>
        /// [Optional] Execute the query using Tooling API.
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }
    }

    /// <summary>
    /// Options for the method treeExport of class Data.
    /// </summary>
    public class DataTreeExportOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] A SOQL query statement or the path of a file containing a SOQL query statement to retrieve the records to export.
        /// </summary>
        [SwitchName("--query")]
        public string query { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Directory to store generated files.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] Prefix of generated files.
        /// </summary>
        [SwitchName("--prefix")]
        public string prefix { get; set; }

        /// <summary>
        /// [Optional] Generates multiple sObject tree files and a plan definition file for aggregated import.
        /// </summary>
        [SwitchName("--plan")]
        public bool? plan { get; set; }
    }

    /// <summary>
    /// Options for the method treeImport of class Data.
    /// </summary>
    public class DataTreeImportOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] Displays the schema information for the configuration file. If you use this option, all other options, except --json, are ignored.
        /// </summary>
        [SwitchName("--confighelp")]
        public bool? confighelp { get; set; }

        /// <summary>
        /// [Required] If the data file extension is not .json, provide the content type (applies to all files).
        /// </summary>
        [SwitchName("--contenttype")]
        public string contenttype { get; set; }

        /// <summary>
        /// [Required] Path to plan to insert multiple data files that have master-detail relationships. Either --sobjecttreefiles or --plan is required.
        /// </summary>
        [SwitchName("--plan")]
        public string plan { get; set; }

        /// <summary>
        /// [Required] Comma-delimited, ordered paths of JSON files containing a collection of record trees to insert. Either --sobjecttreefiles or --plan is required.
        /// </summary>
        [SwitchName("--sobjecttreefiles")]
        public string sobjecttreefiles { get; set; }
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
        /// </summary>
        /// <remarks>
        /// Deletes a batch of records listed in a CSV file.
        /// </remarks>
        /// <example>
        /// The file must be a CSV file with only one column: "Id".
        /// One job can contain many batches, depending on the length of the CSV file.
        /// Returns a job ID and a batch ID. Use these IDs to check job status with data:bulk:status.
        /// 
        /// Examples:
        ///    $ sfdx force:data:bulk:delete -s Account -f ./path/to/file.csv
        ///    $ sfdx force:data:bulk:delete -s MyObject__c -f ./path/to/file.csv
        /// force:data:bulk:delete -s <string> -f <filepath> [-w <minutes>] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("bulk:delete")]
        public SFDXResponse BulkDelete(DataBulkDeleteOptions p_Options)
        {
            return ExecuteCommand<DataBulkDeleteOptions>(nameof(BulkDelete), p_Options);
        }

        /// <summary>
        /// view the status of a bulk data load job or batch
        /// </summary>
        /// <remarks>
        /// Polls the Bulk API for job status or batch status.
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:data:bulk:status -i 750xx000000005sAAA
        ///    $ sfdx force:data:bulk:status -i 750xx000000005sAAA -b 751xx000000005nAAA
        /// force:data:bulk:status -i <id> [-b <id>] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("bulk:status")]
        public SFDXResponse BulkStatus(DataBulkStatusOptions p_Options)
        {
            return ExecuteCommand<DataBulkStatusOptions>(nameof(BulkStatus), p_Options);
        }

        /// <summary>
        /// bulk upsert records from a CSV file
        /// </summary>
        /// <remarks>
        /// Creates a job and one or more batches for inserting new rows and updating existing rows by accessing the Bulk API.
        /// </remarks>
        /// <example>
        /// Inserts or updates records from a CSV file. 
        /// One job can contain many batches, depending on the length of the CSV file.
        /// Returns a job ID and a batch ID. Use these IDs to check job status with data:bulk:status.
        /// 
        /// For information about formatting your CSV file, see "Prepare CSV Files" in the Bulk API Developer Guide.
        /// 
        /// Examples:
        ///    $ sfdx force:data:bulk:upsert -s MyObject__c -f ./path/to/file.csv -i MyField__c
        ///    $ sfdx force:data:bulk:upsert -s MyObject__c -f ./path/to/file.csv -i Id -w 2
        /// force:data:bulk:upsert -s <string> -f <filepath> -i <id> [-w <minutes>] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("bulk:upsert")]
        public SFDXResponse BulkUpsert(DataBulkUpsertOptions p_Options)
        {
            return ExecuteCommand<DataBulkUpsertOptions>(nameof(BulkUpsert), p_Options);
        }

        /// <summary>
        /// create a record
        /// </summary>
        /// <remarks>
        /// Creates and inserts a record.
        /// </remarks>
        /// <example>
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// 
        /// Examples:
        ///    $ sfdx force:data:record:create -s Account -v "Name=Acme"
        ///    $ sfdx force:data:record:create -s Account -v "Name='Universal Containers'"
        ///    $ sfdx force:data:record:create -s Account -v "Name='Universal Containers' Website=www.example.com"
        ///    $ sfdx force:data:record:create -t -s TraceFlag -v "DebugLevelId=7dl170000008U36AAE StartDate=2017-12-01T00:26:04.000+0000 ExpirationDate=2017-12-01T00:56:04.000+0000 LogType=CLASS_TRACING TracedEntityId=01p17000000R6bLAAS"
        ///    $ sfdx force:data:record:create -s Account -v "Name=Acme" --perflog --json
        /// force:data:record:create -s <string> -v <string> [-t] [--perflog] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("record:create")]
        public SFDXResponse RecordCreate(DataRecordCreateOptions p_Options)
        {
            return ExecuteCommand<DataRecordCreateOptions>(nameof(RecordCreate), p_Options);
        }

        /// <summary>
        /// delete a record
        /// </summary>
        /// <remarks>
        /// Deletes a single record.
        /// </remarks>
        /// <example>
        /// Specify an sObject type and either an ID or a list of <fieldName>=<value> pairs.
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// 
        /// Examples:
        ///    $ sfdx force:data:record:delete -s Account -i 001D000000Kv3dl
        ///    $ sfdx force:data:record:delete -s Account -w "Name=Acme"
        ///    $ sfdx force:data:record:delete -s Account -w "Name='Universal Containers'"
        ///    $ sfdx force:data:record:delete -s Account -w "Name='Universal Containers' Phone='(123) 456-7890'"
        ///    $ sfdx force:data:record:delete -t -s TraceFlag -i 7tf170000009cU6AAI --perflog --json
        /// force:data:record:delete -s <string> [-i <id>] [-w <string>] [-t] [--perflog] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("record:delete")]
        public SFDXResponse RecordDelete(DataRecordDeleteOptions p_Options)
        {
            return ExecuteCommand<DataRecordDeleteOptions>(nameof(RecordDelete), p_Options);
        }

        /// <summary>
        /// view a record
        /// </summary>
        /// <remarks>
        /// Displays a single record.
        /// </remarks>
        /// <example>
        /// Specify an sObject type and either an ID or a list of <fieldName>=<value> pairs.
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// 
        /// Examples:
        ///    $ sfdx force:data:record:get -s Account -i 001D000000Kv3dl
        ///    $ sfdx force:data:record:get -s Account -w "Name=Acme"
        ///    $ sfdx force:data:record:get -s Account -w "Name='Universal Containers'"
        ///    $ sfdx force:data:record:get -s Account -w "Name='Universal Containers' Phone='(123) 456-7890'"
        ///    $ sfdx force:data:record:get -t -s TraceFlag -i 7tf170000009cUBAAY --perflog --json
        /// force:data:record:get -s <string> [-i <id>] [-w <string>] [-t] [--perflog] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("record:get")]
        public SFDXResponse RecordGet(DataRecordGetOptions p_Options)
        {
            return ExecuteCommand<DataRecordGetOptions>(nameof(RecordGet), p_Options);
        }

        /// <summary>
        /// update a record
        /// </summary>
        /// <remarks>
        /// Updates a single record.
        /// </remarks>
        /// <example>
        /// The format of a field-value pair is <fieldName>=<value>.
        /// Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
        /// Enclose values that contain spaces in single quotes.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// 
        /// Examples:
        ///    $ sfdx force:data:record:update -s Account -i 001D000000Kv3dl -v "Name=NewAcme"
        ///    $ sfdx force:data:record:update -s Account -w "Name='Old Acme'" -v "Name='New Acme'"
        ///    $ sfdx force:data:record:update -s Account -i 001D000000Kv3dl -v "Name='Acme III' Website=www.example.com"
        ///    $ sfdx force:data:record:update -t -s TraceFlag -i 7tf170000009cUBAAY -v "ExpirationDate=2017-12-01T00:58:04.000+0000"
        ///    $ sfdx force:data:record:update -s Account -i 001D000000Kv3dl -v "Name=NewAcme" --perflog --json
        /// force:data:record:update -s <string> -v <string> [-i <id>] [-w <string>] [-t] [--perflog] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("record:update")]
        public SFDXResponse RecordUpdate(DataRecordUpdateOptions p_Options)
        {
            return ExecuteCommand<DataRecordUpdateOptions>(nameof(RecordUpdate), p_Options);
        }

        /// <summary>
        /// execute a SOQL query
        /// </summary>
        /// <remarks>
        /// Executes a SOQL query.
        /// </remarks>
        /// <example>
        /// When you execute this command in a project, it executes the query against the data in your default scratch org.
        /// 
        /// To get data on API performance metrics, specify both --perflog and --json.
        /// 
        /// Examples:
        ///    $ sfdx force:data:soql:query -q "SELECT Id, Name, Account.Name FROM Contact"
        ///    $ sfdx force:data:soql:query -q "SELECT Id, Name FROM Account WHERE ShippingState IN ('CA', 'NY')"
        ///    $ sfdx force:data:soql:query -q "SELECT Name FROM ApexTrigger" -t
        ///    $ sfdx force:data:soql:query -q "SELECT Name FROM ApexTrigger" --perflog --json
        /// force:data:soql:query -q <string> [-t] [-r <string>] [--perflog] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("soql:query")]
        public SFDXResponse SoqlQuery(DataSoqlQueryOptions p_Options)
        {
            return ExecuteCommand<DataSoqlQueryOptions>(nameof(SoqlQuery), p_Options);
        }

        /// <summary>
        /// export data from an org into sObject tree format for force:data:tree:import consumption
        /// </summary>
        /// <remarks>
        /// Exports data from an org into sObject tree format for force:data:tree:import consumption.
        /// </remarks>
        /// <example>
        /// Generates JSON files for use with the force:data:tree:import command.
        /// 
        /// Examples:
        ///    $ sfdx force:data:tree:export -q "SELECT Id, Name, (SELECT Name, Address__c FROM Properties__r) FROM Broker__c"
        ///    $ sfdx force:data:tree:export -q <path to file containing soql query> -x export-demo -d /tmp/sfdx-out -p
        /// 
        /// For more information and examples, run "sfdx force:data:tree:import -h".
        /// 
        /// The query for export can return a maximum of 2,000 records. For more information, see the REST API Developer Guide: https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm
        /// force:data:tree:export -q <string> [-p] [-x <string>] [-d <directory>] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("tree:export")]
        public SFDXResponse TreeExport(DataTreeExportOptions p_Options)
        {
            return ExecuteCommand<DataTreeExportOptions>(nameof(TreeExport), p_Options);
        }

        /// <summary>
        /// import data into an org using SObject Tree Save API
        /// </summary>
        /// <remarks>
        /// Imports data into an org using the SObject Tree Save API. This data can include master-detail relationships.
        /// </remarks>
        /// <example>
        /// To generate JSON files for use with force:data:tree:import, run "sfdx force:data:tree:export".
        /// 
        /// Examples:
        /// To import records as individual files, first run the export commands:
        ///    $ sfdx force:data:tree:export -q "SELECT Id, Name FROM Account"
        ///    $ sfdx force:data:tree:export -q "SELECT Id, LastName, FirstName FROM Contact"
        /// Then run the import command:
        ///    $ sfdx force:data:tree:import -f Contact.json,Account.json -u me@my.org
        /// 
        /// To import multiple data files as part of a plan, first run the export command with the -p | --plan flag:
        ///    $ sfdx force:data:tree:export -p -q "SELECT Id, Name, (SELECT Id, LastName, FirstName FROM Contacts) FROM Account"
        /// Then run the import command, supplying a filepath value for the -p | --plan parameter:
        ///    $ sfdx force:data:tree:import -p Account-Contact-plan.json -u me@my.org
        /// 
        /// The SObject Tree API supports requests that contain up to 200 records. For more information, see the REST API Developer Guide: https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm
        /// force:data:tree:import (-f <filepath>... | -p <filepath>) [-c <string>] [--confighelp] [-u <string>] [--json] [--loglevel <string>]
        /// </example>
        [Command("tree:import")]
        public SFDXResponse TreeImport(DataTreeImportOptions p_Options)
        {
            return ExecuteCommand<DataTreeImportOptions>(nameof(TreeImport), p_Options);
        }
    }
}

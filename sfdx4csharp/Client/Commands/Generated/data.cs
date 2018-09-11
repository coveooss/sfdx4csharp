// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method bulkDelete of class Data.
 *
 * IDataBulkDelete
 */
public class DataBulkDeleteOptions : SFDXOptions {

  /**
   * [Required] The sObject type of the records you’re deleting.
   * @type {string}
   * @memberof DataBulkDeleteOptions
   */
  [SwitchName("--sobjecttype")]
  public string sobjecttype  {get; set;}

  /**
   * [Required] The path to the CSV file that contains the IDs of the records to delete.
   * @type {string}
   * @memberof DataBulkDeleteOptions
   */
  [SwitchName("--csvfile")]
  public string csvfile  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DataBulkDeleteOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DataBulkDeleteOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof DataBulkDeleteOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] The number of minutes to wait for the command to complete before displaying the results.
   * @type {string}
   * @memberof DataBulkDeleteOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}
}

/**
 * Options for the method bulkStatus of class Data.
 *
 * IDataBulkStatus
 */
public class DataBulkStatusOptions : SFDXOptions {

  /**
   * [Required] The ID of the job you want to view or of the job whose batch you want to view.
   * @type {string}
   * @memberof DataBulkStatusOptions
   */
  [SwitchName("--jobid")]
  public string jobid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DataBulkStatusOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DataBulkStatusOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof DataBulkStatusOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] The ID of the batch whose status you want to view.
   * @type {string}
   * @memberof DataBulkStatusOptions
   */
  [SwitchName("--batchid")]
  public string batchid  {get; set;}
}

/**
 * Options for the method bulkUpsert of class Data.
 *
 * IDataBulkUpsert
 */
public class DataBulkUpsertOptions : SFDXOptions {

  /**
   * [Required] The sObject type of the records you want to upsert.
   * @type {string}
   * @memberof DataBulkUpsertOptions
   */
  [SwitchName("--sobjecttype")]
  public string sobjecttype  {get; set;}

  /**
   * [Required] The path to the CSV file that defines the records to upsert.
   * @type {string}
   * @memberof DataBulkUpsertOptions
   */
  [SwitchName("--csvfile")]
  public string csvfile  {get; set;}

  /**
   * [Required] The column name of the external ID.
   * @type {string}
   * @memberof DataBulkUpsertOptions
   */
  [SwitchName("--externalid")]
  public string externalid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DataBulkUpsertOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DataBulkUpsertOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof DataBulkUpsertOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] The number of minutes to wait for the command to complete before displaying the results.
   * @type {string}
   * @memberof DataBulkUpsertOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}
}

/**
 * Options for the method recordCreate of class Data.
 *
 * IDataRecordCreate
 */
public class DataRecordCreateOptions : SFDXOptions {

  /**
   * [Required] The sObject type of the record you’re creating.
   * @type {string}
   * @memberof DataRecordCreateOptions
   */
  [SwitchName("--sobjecttype")]
  public string sobjecttype  {get; set;}

  /**
   * [Required] The <fieldName>=<value> pairs you’re creating.
   * @type {string}
   * @memberof DataRecordCreateOptions
   */
  [SwitchName("--values")]
  public string values  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DataRecordCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DataRecordCreateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof DataRecordCreateOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json
   * @type {bool}
   * @memberof DataRecordCreateOptions
   */
  [SwitchName("--perflog")]
  public bool? perflog  {get; set;}

  /**
   * [Optional] Create the record using Tooling API.
   * @type {bool}
   * @memberof DataRecordCreateOptions
   */
  [SwitchName("--usetoolingapi")]
  public bool? usetoolingapi  {get; set;}
}

/**
 * Options for the method recordDelete of class Data.
 *
 * IDataRecordDelete
 */
public class DataRecordDeleteOptions : SFDXOptions {

  /**
   * [Required] The sObject type of the record you’re deleting.
   * @type {string}
   * @memberof DataRecordDeleteOptions
   */
  [SwitchName("--sobjecttype")]
  public string sobjecttype  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DataRecordDeleteOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DataRecordDeleteOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof DataRecordDeleteOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json
   * @type {bool}
   * @memberof DataRecordDeleteOptions
   */
  [SwitchName("--perflog")]
  public bool? perflog  {get; set;}

  /**
   * [Optional] Delete the record using Tooling API.
   * @type {bool}
   * @memberof DataRecordDeleteOptions
   */
  [SwitchName("--usetoolingapi")]
  public bool? usetoolingapi  {get; set;}

  /**
   * [Required] A list of <fieldName>=<value> pairs to search for.
   * @type {string}
   * @memberof DataRecordDeleteOptions
   */
  [SwitchName("--where")]
  public string where  {get; set;}

  /**
   * [Required] The ID of the record you’re deleting.
   * @type {string}
   * @memberof DataRecordDeleteOptions
   */
  [SwitchName("--sobjectid")]
  public string sobjectid  {get; set;}
}

/**
 * Options for the method recordGet of class Data.
 *
 * IDataRecordGet
 */
public class DataRecordGetOptions : SFDXOptions {

  /**
   * [Required] The sObject type of the record you’re retrieving.
   * @type {string}
   * @memberof DataRecordGetOptions
   */
  [SwitchName("--sobjecttype")]
  public string sobjecttype  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DataRecordGetOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DataRecordGetOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof DataRecordGetOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json
   * @type {bool}
   * @memberof DataRecordGetOptions
   */
  [SwitchName("--perflog")]
  public bool? perflog  {get; set;}

  /**
   * [Optional] Retrieve the record using Tooling API.
   * @type {bool}
   * @memberof DataRecordGetOptions
   */
  [SwitchName("--usetoolingapi")]
  public bool? usetoolingapi  {get; set;}

  /**
   * [Required] A list of <fieldName>=<value> pairs to search for.
   * @type {string}
   * @memberof DataRecordGetOptions
   */
  [SwitchName("--where")]
  public string where  {get; set;}

  /**
   * [Required] The ID of the record you’re retrieving.
   * @type {string}
   * @memberof DataRecordGetOptions
   */
  [SwitchName("--sobjectid")]
  public string sobjectid  {get; set;}
}

/**
 * Options for the method recordUpdate of class Data.
 *
 * IDataRecordUpdate
 */
public class DataRecordUpdateOptions : SFDXOptions {

  /**
   * [Required] The sObject type of the record you’re updating.
   * @type {string}
   * @memberof DataRecordUpdateOptions
   */
  [SwitchName("--sobjecttype")]
  public string sobjecttype  {get; set;}

  /**
   * [Required] The <fieldName>=<value> pairs you’re updating.
   * @type {string}
   * @memberof DataRecordUpdateOptions
   */
  [SwitchName("--values")]
  public string values  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DataRecordUpdateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DataRecordUpdateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof DataRecordUpdateOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json
   * @type {bool}
   * @memberof DataRecordUpdateOptions
   */
  [SwitchName("--perflog")]
  public bool? perflog  {get; set;}

  /**
   * [Optional] Update the record using Tooling API.
   * @type {bool}
   * @memberof DataRecordUpdateOptions
   */
  [SwitchName("--usetoolingapi")]
  public bool? usetoolingapi  {get; set;}

  /**
   * [Required] A list of <fieldName>=<value> pairs to search for.
   * @type {string}
   * @memberof DataRecordUpdateOptions
   */
  [SwitchName("--where")]
  public string where  {get; set;}

  /**
   * [Required] The ID of the record you’re updating.
   * @type {string}
   * @memberof DataRecordUpdateOptions
   */
  [SwitchName("--sobjectid")]
  public string sobjectid  {get; set;}
}

/**
 * Options for the method soqlQuery of class Data.
 *
 * IDataSoqlQuery
 */
public class DataSoqlQueryOptions : SFDXOptions {

  /**
   * [Required] SOQL query to execute.
   * @type {string}
   * @memberof DataSoqlQueryOptions
   */
  [SwitchName("--query")]
  public string query  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DataSoqlQueryOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DataSoqlQueryOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof DataSoqlQueryOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Gets data on API performance metrics from the server. The data is stored in $HOME/.sfdx/apiPerformanceLog.json
   * @type {bool}
   * @memberof DataSoqlQueryOptions
   */
  [SwitchName("--perflog")]
  public bool? perflog  {get; set;}

  /**
   * [Required] Format to use when displaying query results. If you also specify the --json flag, --json overrides this parameter.
   * @type {string}
   * @memberof DataSoqlQueryOptions
   */
  [SwitchName("--resultformat")]
  public string resultformat  {get; set;}

  /**
   * [Optional] Execute the query using Tooling API.
   * @type {bool}
   * @memberof DataSoqlQueryOptions
   */
  [SwitchName("--usetoolingapi")]
  public bool? usetoolingapi  {get; set;}
}

/**
 * Options for the method treeExport of class Data.
 *
 * IDataTreeExport
 */
public class DataTreeExportOptions : SFDXOptions {

  /**
   * [Required] A SOQL query statement or the path of a file containing a SOQL query statement to retrieve the records to export.
   * @type {string}
   * @memberof DataTreeExportOptions
   */
  [SwitchName("--query")]
  public string query  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DataTreeExportOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DataTreeExportOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof DataTreeExportOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Directory to store generated files.
   * @type {string}
   * @memberof DataTreeExportOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}

  /**
   * [Required] Prefix of generated files.
   * @type {string}
   * @memberof DataTreeExportOptions
   */
  [SwitchName("--prefix")]
  public string prefix  {get; set;}

  /**
   * [Optional] Generates multiple sObject tree files and a plan definition file for aggregated import.
   * @type {bool}
   * @memberof DataTreeExportOptions
   */
  [SwitchName("--plan")]
  public bool? plan  {get; set;}
}

/**
 * Options for the method treeImport of class Data.
 *
 * IDataTreeImport
 */
public class DataTreeImportOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DataTreeImportOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DataTreeImportOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof DataTreeImportOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Displays the schema information for the configuration file. If you use this option, all other options, except --json, are ignored.
   * @type {bool}
   * @memberof DataTreeImportOptions
   */
  [SwitchName("--confighelp")]
  public bool? confighelp  {get; set;}

  /**
   * [Required] If the data file extension is not .json, provide the content type (applies to all files).
   * @type {string}
   * @memberof DataTreeImportOptions
   */
  [SwitchName("--contenttype")]
  public string contenttype  {get; set;}

  /**
   * [Required] Path to plan to insert multiple data files that have master-detail relationships. Either --sobjecttreefiles or --plan is required.
   * @type {string}
   * @memberof DataTreeImportOptions
   */
  [SwitchName("--plan")]
  public string plan  {get; set;}

  /**
   * [Required] Comma-delimited, ordered paths of JSON files containing a collection of record trees to insert. Either --sobjecttreefiles or --plan is required.
   * @type {string}
   * @memberof DataTreeImportOptions
   */
  [SwitchName("--sobjecttreefiles")]
  public string sobjecttreefiles  {get; set;}
}


/**
 * Data
 *
 * @class Data
 */
[CommandClass("force:data")]
public class Data : SFDXCommand {
        /// <inheritDoc />
    public Data(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * bulk delete records from a csv file
   * @returns {(Promise<Object | void>)}
   * @memberof Data
   * @description Deletes a batch of records listed in a CSV file.
   * @example The file must be a CSV file with only one column: "Id".
   * One job can contain many batches, depending on the length of the CSV file.
   * Returns a job ID and a batch ID. Use these IDs to check job status with data:bulk:status.
   * 
   * Examples:
   *    $ sfdx force:data:bulk:delete -s Account -f ./path/to/file.csv
   *    $ sfdx force:data:bulk:delete -s MyObject__c -f ./path/to/file.csv
   * force:data:bulk:delete -s <string> -f <filepath> [-w <minutes>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("bulk:delete")]
    public JToken bulkDelete(DataBulkDeleteOptions p_Options) {
      return ExecuteCommand<DataBulkDeleteOptions, JToken>(nameof(bulkDelete), p_Options);      
    }
  
  /**
   * view the status of a bulk data load job or batch
   * @returns {(Promise<Object | void>)}
   * @memberof Data
   * @description Polls the Bulk API for job status or batch status.
   * @example Examples:
   *    $ sfdx force:data:bulk:status -i 750xx000000005sAAA
   *    $ sfdx force:data:bulk:status -i 750xx000000005sAAA -b 751xx000000005nAAA
   * force:data:bulk:status -i <id> [-b <id>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("bulk:status")]
    public JToken bulkStatus(DataBulkStatusOptions p_Options) {
      return ExecuteCommand<DataBulkStatusOptions, JToken>(nameof(bulkStatus), p_Options);      
    }
  
  /**
   * bulk upsert records from a CSV file
   * @returns {(Promise<Object | void>)}
   * @memberof Data
   * @description Creates a job and one or more batches for inserting new rows and updating existing rows by accessing the Bulk API.
   * @example Inserts or updates records from a CSV file. 
   * One job can contain many batches, depending on the length of the CSV file.
   * Returns a job ID and a batch ID. Use these IDs to check job status with data:bulk:status.
   * 
   * For information about formatting your CSV file, see "Prepare CSV Files" in the Bulk API Developer Guide.
   * 
   * Examples:
   *    $ sfdx force:data:bulk:upsert -s MyObject__c -f ./path/to/file.csv -i MyField__c
   *    $ sfdx force:data:bulk:upsert -s MyObject__c -f ./path/to/file.csv -i Id -w 2
   * force:data:bulk:upsert -s <string> -f <filepath> -i <id> [-w <minutes>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("bulk:upsert")]
    public JToken bulkUpsert(DataBulkUpsertOptions p_Options) {
      return ExecuteCommand<DataBulkUpsertOptions, JToken>(nameof(bulkUpsert), p_Options);      
    }
  
  /**
   * create a record
   * @returns {(Promise<Object | void>)}
   * @memberof Data
   * @description Creates and inserts a record.
   * @example The format of a field-value pair is <fieldName>=<value>.
   * Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
   * Enclose values that contain spaces in single quotes.
   * 
   * To get data on API performance metrics, specify both --perflog and --json.
   * 
   * Examples:
   *    $ sfdx force:data:record:create -s Account -v "Name=Acme"
   *    $ sfdx force:data:record:create -s Account -v "Name='Universal Containers'"
   *    $ sfdx force:data:record:create -s Account -v "Name='Universal Containers' Website=www.example.com"
   *    $ sfdx force:data:record:create -t -s TraceFlag -v "DebugLevelId=7dl170000008U36AAE StartDate=2017-12-01T00:26:04.000+0000 ExpirationDate=2017-12-01T00:56:04.000+0000 LogType=CLASS_TRACING TracedEntityId=01p17000000R6bLAAS"
   *    $ sfdx force:data:record:create -s Account -v "Name=Acme" --perflog --json
   * force:data:record:create -s <string> -v <string> [-t] [--perflog] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("record:create")]
    public JToken recordCreate(DataRecordCreateOptions p_Options) {
      return ExecuteCommand<DataRecordCreateOptions, JToken>(nameof(recordCreate), p_Options);      
    }
  
  /**
   * delete a record
   * @returns {(Promise<Object | void>)}
   * @memberof Data
   * @description Deletes a single record.
   * @example Specify an sObject type and either an ID or a list of <fieldName>=<value> pairs.
   * The format of a field-value pair is <fieldName>=<value>.
   * Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
   * Enclose values that contain spaces in single quotes.
   * 
   * To get data on API performance metrics, specify both --perflog and --json.
   * 
   * Examples:
   *    $ sfdx force:data:record:delete -s Account -i 001D000000Kv3dl
   *    $ sfdx force:data:record:delete -s Account -w "Name=Acme"
   *    $ sfdx force:data:record:delete -s Account -w "Name='Universal Containers'"
   *    $ sfdx force:data:record:delete -s Account -w "Name='Universal Containers' Phone='(123) 456-7890'"
   *    $ sfdx force:data:record:delete -t -s TraceFlag -i 7tf170000009cU6AAI --perflog --json
   * force:data:record:delete -s <string> [-i <id>] [-w <string>] [-t] [--perflog] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("record:delete")]
    public JToken recordDelete(DataRecordDeleteOptions p_Options) {
      return ExecuteCommand<DataRecordDeleteOptions, JToken>(nameof(recordDelete), p_Options);      
    }
  
  /**
   * view a record
   * @returns {(Promise<Object | void>)}
   * @memberof Data
   * @description Displays a single record.
   * @example Specify an sObject type and either an ID or a list of <fieldName>=<value> pairs.
   * The format of a field-value pair is <fieldName>=<value>.
   * Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
   * Enclose values that contain spaces in single quotes.
   * 
   * To get data on API performance metrics, specify both --perflog and --json.
   * 
   * Examples:
   *    $ sfdx force:data:record:get -s Account -i 001D000000Kv3dl
   *    $ sfdx force:data:record:get -s Account -w "Name=Acme"
   *    $ sfdx force:data:record:get -s Account -w "Name='Universal Containers'"
   *    $ sfdx force:data:record:get -s Account -w "Name='Universal Containers' Phone='(123) 456-7890'"
   *    $ sfdx force:data:record:get -t -s TraceFlag -i 7tf170000009cUBAAY --perflog --json
   * force:data:record:get -s <string> [-i <id>] [-w <string>] [-t] [--perflog] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("record:get")]
    public JToken recordGet(DataRecordGetOptions p_Options) {
      return ExecuteCommand<DataRecordGetOptions, JToken>(nameof(recordGet), p_Options);      
    }
  
  /**
   * update a record
   * @returns {(Promise<Object | void>)}
   * @memberof Data
   * @description Updates a single record.
   * @example The format of a field-value pair is <fieldName>=<value>.
   * Enclose all field-value pairs in one set of double quotation marks, delimited by spaces.
   * Enclose values that contain spaces in single quotes.
   * 
   * To get data on API performance metrics, specify both --perflog and --json.
   * 
   * Examples:
   *    $ sfdx force:data:record:update -s Account -i 001D000000Kv3dl -v "Name=NewAcme"
   *    $ sfdx force:data:record:update -s Account -w "Name='Old Acme'" -v "Name='New Acme'"
   *    $ sfdx force:data:record:update -s Account -i 001D000000Kv3dl -v "Name='Acme III' Website=www.example.com"
   *    $ sfdx force:data:record:update -t -s TraceFlag -i 7tf170000009cUBAAY -v "ExpirationDate=2017-12-01T00:58:04.000+0000"
   *    $ sfdx force:data:record:update -s Account -i 001D000000Kv3dl -v "Name=NewAcme" --perflog --json
   * force:data:record:update -s <string> -v <string> [-i <id>] [-w <string>] [-t] [--perflog] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("record:update")]
    public JToken recordUpdate(DataRecordUpdateOptions p_Options) {
      return ExecuteCommand<DataRecordUpdateOptions, JToken>(nameof(recordUpdate), p_Options);      
    }
  
  /**
   * execute a SOQL query
   * @returns {(Promise<Object | void>)}
   * @memberof Data
   * @description Executes a SOQL query.
   * @example When you execute this command in a project, it executes the query against the data in your default scratch org.
   * 
   * To get data on API performance metrics, specify both --perflog and --json.
   * 
   * Examples:
   *    $ sfdx force:data:soql:query -q "SELECT Id, Name, Account.Name FROM Contact"
   *    $ sfdx force:data:soql:query -q "SELECT Id, Name FROM Account WHERE ShippingState IN ('CA', 'NY')"
   *    $ sfdx force:data:soql:query -q "SELECT Name FROM ApexTrigger" -t
   *    $ sfdx force:data:soql:query -q "SELECT Name FROM ApexTrigger" --perflog --json
   * force:data:soql:query -q <string> [-t] [-r <string>] [--perflog] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("soql:query")]
    public JToken soqlQuery(DataSoqlQueryOptions p_Options) {
      return ExecuteCommand<DataSoqlQueryOptions, JToken>(nameof(soqlQuery), p_Options);      
    }
  
  /**
   * export data from an org into sObject tree format for force:data:tree:import consumption
   * @returns {(Promise<Object | void>)}
   * @memberof Data
   * @description Exports data from an org into sObject tree format for force:data:tree:import consumption.
   * @example Generates JSON files for use with the force:data:tree:import command.
   * 
   * Examples:
   *    $ sfdx force:data:tree:export -q "SELECT Id, Name, (SELECT Name, Address__c FROM Properties__r) FROM Broker__c"
   *    $ sfdx force:data:tree:export -q <path to file containing soql query> -x export-demo -d /tmp/sfdx-out -p
   * 
   * For more information and examples, run "sfdx force:data:tree:import -h".
   * 
   * The query for export can return a maximum of 2,000 records. For more information, see the REST API Developer Guide: https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm
   * force:data:tree:export -q <string> [-p] [-x <string>] [-d <directory>] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("tree:export")]
    public JToken treeExport(DataTreeExportOptions p_Options) {
      return ExecuteCommand<DataTreeExportOptions, JToken>(nameof(treeExport), p_Options);      
    }
  
  /**
   * import data into an org using SObject Tree Save API
   * @returns {(Promise<Object | void>)}
   * @memberof Data
   * @description Imports data into an org using the SObject Tree Save API. This data can include master-detail relationships.
   * @example To generate JSON files for use with force:data:tree:import, run "sfdx force:data:tree:export".
   * 
   * Examples:
   * To import records as individual files, first run the export commands:
   *    $ sfdx force:data:tree:export -q "SELECT Id, Name FROM Account"
   *    $ sfdx force:data:tree:export -q "SELECT Id, LastName, FirstName FROM Contact"
   * Then run the import command:
   *    $ sfdx force:data:tree:import -f Contact.json,Account.json -u me@my.org
   * 
   * To import multiple data files as part of a plan, first run the export command with the -p | --plan flag:
   *    $ sfdx force:data:tree:export -p -q "SELECT Id, Name, (SELECT Id, LastName, FirstName FROM Contacts) FROM Account"
   * Then run the import command, supplying a filepath value for the -p | --plan parameter:
   *    $ sfdx force:data:tree:import -p Account-Contact-plan.json -u me@my.org
   * 
   * The SObject Tree API supports requests that contain up to 200 records. For more information, see the REST API Developer Guide: https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_composite_sobject_tree.htm
   * force:data:tree:import (-f <filepath>... | -p <filepath>) [-c <string>] [--confighelp] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("tree:import")]
    public JToken treeImport(DataTreeImportOptions p_Options) {
      return ExecuteCommand<DataTreeImportOptions, JToken>(nameof(treeImport), p_Options);      
    }
  
}

// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method BulkDelete of class ForceData.
    /// </summary>
    public class ForceDataBulkDeleteOptions : SfOptions
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
    }

    /// <summary>
    /// Options for the method BulkStatus of class ForceData.
    /// </summary>
    public class ForceDataBulkStatusOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for job-id
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

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
        /// [Optional] No description for batch-id
        /// </summary>
        [SwitchName("--batch-id")]
        public string BatchId { get; set; }
    }

    /// <summary>
    /// Options for the method BulkUpsert of class ForceData.
    /// </summary>
    public class ForceDataBulkUpsertOptions : SfOptions
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
        /// [Required] No description for external-id
        /// </summary>
        [SwitchName("--external-id")]
        public string ExternalId { get; set; }

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
        /// [Optional] No description for serial
        /// </summary>
        [SwitchName("--serial")]
        public bool? Serial { get; set; }
    }

    /// <summary>
    /// ForceData
    /// </summary>
    [CommandClass("force data")]
    public class ForceData : SfCommand
    {
        /// Constructor.
        public ForceData(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Bulk delete records from an org using a CSV file. Uses Bulk API 1.0.
        /// </summary>
        /// <remarks>
        /// The CSV file must have only one column ("Id") and then the list of record IDs you want to delete, one ID per line.
        /// 
        /// When you execute this command, it starts a job and one or more batches, displays their IDs, and then immediately returns control of the terminal to you by default. If you prefer to wait, set the --wait flag to the number of minutes; if it times out, the command outputs the IDs. Use the job and batch IDs to check the status of the job with the "$ sf force data bulk status" command. A single job can contain many batches, depending on the length of the CSV file.
        /// </remarks>
        /// <example>
        /// Bulk delete Account records from your default org using the list of IDs in the "files/delete.csv" file:
        /// $ sf bulk delete --sobject Account --file files/delete.csv
        /// Bulk delete records from a custom object in an org with alias my-scratch and wait 5 minutes for the command to complete:
        /// $ sf bulk delete --sobject MyObject__c --file files/delete.csv --wait 5 --target-org my-scratch
        /// </example>
        [Command("bulk delete")]
        public SfResponse BulkDelete(ForceDataBulkDeleteOptions options)
        {
            return ExecuteCommand(nameof(BulkDelete), options);
        }

        /// <summary>
        /// View the status of a bulk data load job or batch. Uses Bulk API 1.0.
        /// </summary>
        /// <remarks>
        /// Run this command using the job ID or batch ID returned from the "$ sf force data bulk delete" or "$ sf force data bulk upsert" commands.
        /// </remarks>
        /// <example>
        /// View the status of a bulk load job in your default org:
        /// $ sf bulk status --job-id 750xx000000005sAAA
        /// View the status of a bulk load job and a specific batches in an org with alias my-scratch:
        /// $ sf bulk status --job-id 750xx000000005sAAA --batch-id 751xx000000005nAAA --target-org my-scratch
        /// </example>
        [Command("bulk status")]
        public SfResponse BulkStatus(ForceDataBulkStatusOptions options)
        {
            return ExecuteCommand(nameof(BulkStatus), options);
        }

        /// <summary>
        /// Bulk upsert records to an org from a CSV file. Uses Bulk API 1.0.
        /// </summary>
        /// <remarks>
        /// An upsert refers to inserting a record into a Salesforce object if the record doesn't already exist, or updating it if it does exist.
        /// 
        /// When you execute this command, it starts a job and one or more batches, displays their IDs, and then immediately returns control of the terminal to you by default. If you prefer to wait, set the --wait flag to the number of minutes; if it times out, the command outputs the IDs. Use the job and batch IDs to check the status of the job with the "$ sf force data bulk status" command. A single job can contain many batches, depending on the length of the CSV file.
        /// 
        /// See "Prepare CSV Files" in the Bulk API Developer Guide for details on formatting your CSV file. (https://developer.salesforce.com/docs/atlas.en-us.api_asynch.meta/api_asynch/datafiles_csv_preparing.htm)
        /// 
        /// By default, the job runs the batches in parallel, which we recommend. You can run jobs serially by specifying the --serial flag. But don't process data in serial mode unless you know this would otherwise result in lock timeouts and you can't reorganize your batches to avoid the locks.
        /// </remarks>
        /// <example>
        /// Bulk upsert records to the Contact object in your default org:
        /// $ sf --sobject Contact --file files/contacts.csv --external-id Id
        /// Bulk upsert records to a custom object in an org with alias my-scratch and wait 5 minutes for the command to complete:
        /// $ sf bulk upsert --sobject MyObject__c --file files/file.csv --external-id MyField__c --wait 5 --target-org my-scratch
        /// </example>
        [Command("bulk upsert")]
        public SfResponse BulkUpsert(ForceDataBulkUpsertOptions options)
        {
            return ExecuteCommand(nameof(BulkUpsert), options);
        }
    }
}

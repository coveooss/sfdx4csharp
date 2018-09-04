// Copyright (c) 2005-2018, Coveo Solutions Inc.

using sfdx4csharpClient.Commands.Options;
using sfdx4csharpClient.Commands.Response;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Commands
{
    /// <summary>
    /// Use the data commands to manipulate records in your org.
    /// </summary>
    /// <remarks>
    /// source:
    /// https://developer.salesforce.com/docs/atlas.en-us.sfdx_cli_reference.meta/sfdx_cli_reference/cli_reference_force_data.htm#cli_reference_force_data
    /// </remarks>
    [CommandClass("force:data")]
    public class DataCommand : SFDXCommand
    {
        /// <inheritDoc />
        public DataCommand(CommandExecutioner p_CommandExecutioner)
            : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// Executes an SOQL query.
        /// </summary>
        /// <returns><see cref="DataSoqlQueryResult" /></returns>
        [Command("soql:query")]
        public DataSoqlQueryResult SoqlQuery(DataSoqlQueryOptions p_Options)
        {
            return ExecuteCommand<DataSoqlQueryOptions, DataSoqlQueryResult>(nameof(SoqlQuery), p_Options);
        }

        /// <summary>
        /// Deletes a record.
        /// </summary>
        [Command("record:delete")]
        public DataRecordDeleteResult RecordDelete(DataRecordDeleteOptions p_Options)
        {
            return ExecuteCommand<DataRecordDeleteOptions, DataRecordDeleteResult>(nameof(RecordDelete), p_Options);
        }
    }
}

// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method apiDisplay of class Limits.
    /// </summary>
    public class LimitsApiDisplayOptions : SFDXOptions
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
    }

    /// <summary>
    /// Options for the method recordcountsDisplay of class Limits.
    /// </summary>
    public class LimitsRecordcountsDisplayOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of API names of standard or custom objects for which to display record counts
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
    }

    /// <summary>
    /// Limits
    /// </summary>
    [CommandClass("force:limits")]
    public class Limits : SFDXCommand
    {
        /// Constructor.
        public Limits(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// display current org’s limits
        /// When you execute this command in a project, it provides limit information for your default scratch org.
        /// </summary>
        /// <remarks>
        /// display current org’s limits
        /// When you execute this command in a project, it provides limit information for your default scratch org.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:limits:api:display
        /// sfdx force:limits:api:display -u me@my.org
        /// force:limits:api:display [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("api:display")]
        public SFDXResponse ApiDisplay(LimitsApiDisplayOptions p_Options)
        {
            return ExecuteCommand<LimitsApiDisplayOptions>(nameof(ApiDisplay), p_Options);
        }

        /// <summary>
        /// display record counts for the specified standard and custom objects
        /// Use this command to get an approximate count of the records in standard or custom objects in your org. These record counts are the same as the counts listed in the Storage Usage page in Setup. The record counts are approximate because they're calculated asynchronously and your org’s storage usage isn’t updated immediately.
        /// </summary>
        /// <remarks>
        /// display record counts for the specified standard and custom objects
        /// Use this command to get an approximate count of the records in standard or custom objects in your org. These record counts are the same as the counts listed in the Storage Usage page in Setup. The record counts are approximate because they're calculated asynchronously and your org’s storage usage isn’t updated immediately.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:limits:recordcounts:display -s Account,Contact,Lead,Opportunity
        /// sfdx force:limits:recordcounts:display -s Account,Contact -u me@my.org
        /// force:limits:recordcounts:display -s <array> [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("recordcounts:display")]
        public SFDXResponse RecordcountsDisplay(LimitsRecordcountsDisplayOptions p_Options)
        {
            return ExecuteCommand<LimitsRecordcountsDisplayOptions>(nameof(RecordcountsDisplay), p_Options);
        }
    }
}

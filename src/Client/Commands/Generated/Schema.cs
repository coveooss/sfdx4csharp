// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method sobjectDescribe of class Schema.
    /// </summary>
    public class SchemaSobjectDescribeOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The API name of the object to describe
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
        /// [Optional] Execute with Tooling API
        /// </summary>
        [SwitchName("--usetoolingapi")]
        public bool? usetoolingapi { get; set; }
    }

    /// <summary>
    /// Options for the method sobjectList of class Schema.
    /// </summary>
    public class SchemaSobjectListOptions : SFDXOptions
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
        /// [Required] The type of objects to list (all|custom|standard)
        /// </summary>
        [SwitchName("--sobjecttypecategory")]
        public string sobjecttypecategory { get; set; }
    }

    /// <summary>
    /// Schema
    /// </summary>
    [CommandClass("force:schema")]
    public class Schema : SFDXCommand
    {
        /// Constructor.
        public Schema(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// displays the metadata for a standard or custom object
        /// </summary>
        /// <remarks>
        /// displays the metadata for a standard or custom object
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:schema:sobject:describe -s Account
        /// sfdx force:schema:sobject:describe -s MyObject__c
        /// sfdx force:schema:sobject:describe -s ApexClass -t
        /// force:schema:sobject:describe -s <string> [-t] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("sobject:describe")]
        public SFDXResponse SobjectDescribe(SchemaSobjectDescribeOptions p_Options)
        {
            return ExecuteCommand<SchemaSobjectDescribeOptions>(nameof(SobjectDescribe), p_Options);
        }

        /// <summary>
        /// list all objects of a specified category
        /// </summary>
        /// <remarks>
        /// list all objects of a specified category
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:schema:sobject:list -c all
        /// sfdx force:schema:sobject:list -c custom
        /// sfdx force:schema:sobject:list -c standard
        /// force:schema:sobject:list [-c <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("sobject:list")]
        public SFDXResponse SobjectList(SchemaSobjectListOptions p_Options)
        {
            return ExecuteCommand<SchemaSobjectListOptions>(nameof(SobjectList), p_Options);
        }
    }
}

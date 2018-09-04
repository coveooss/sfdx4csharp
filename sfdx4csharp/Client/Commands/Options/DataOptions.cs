// Copyright (c) 2005-2018, Coveo Solutions Inc.

using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Commands.Options
{
    /// <summary>
    /// Options for the method SoqlQuery of class Data.
    /// </summary>
    public class DataSoqlQueryOptions : SFDXOptions
    {
        [SwitchName("--query")]
        public string Query { get; set; }

        [SwitchName("--targetusername")]
        public string TargetUsername { get; set; }

        [SwitchName("--usetoolingapi")]
        public bool? UseToolingApi { get; set; }
    }

    /// <summary>
    /// Options for the method RecordDelete of class Data.
    /// </summary>
    public class DataRecordDeleteOptions : SFDXOptions
    {
        [SwitchName("--sobjecttype")]
        public string ObjectType { get; set; }

        [SwitchName("--sobjectid")]
        public string ObjectId { get; set; }

        [SwitchName("--where")]
        public string Where { get; set; }

        [SwitchName("--usetoolingapi")]
        public bool? UseToolingApi { get; set; }

        [SwitchName("--perflog")]
        public bool? PerfLog { get; set; }

        [SwitchName("--targetusername")]
        public string TargetUsername { get; set; }
    }
}

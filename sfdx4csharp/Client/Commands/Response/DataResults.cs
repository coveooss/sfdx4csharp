// Copyright (c) 2005-2018, Coveo Solutions Inc.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace sfdx4csharpClient.Commands.Response
{
    /// <summary>
    /// Response result for the method SoqlQuery of class Data.
    /// </summary>
    public class DataSoqlQueryResult
    {
        [JsonProperty("done")]
        public bool Done { get; set; }

        [JsonProperty("records")]
        public Dictionary<string, object>[] Records { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class DataRecordDeleteResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }
    }
}

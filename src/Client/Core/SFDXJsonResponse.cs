// Copyright (c) 2005-2020, Coveo Solutions Inc.

using Newtonsoft.Json.Linq;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI Json Response's wrapper
    /// </summary>
    public class SFDXJsonResponse
    {
        /// <summary>
        /// Deserialized from cli output. Represents the parsed output of the executed command.
        /// </summary>
        public JToken Result { get; set; }

        /// <summary>
        /// Deserialized from cli output. Represents the status code from the executed command.
        /// </summary>
        public int Status { get; set; }
    }
}
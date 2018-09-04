// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI Response's wrapper
    /// </summary>
    /// <typeparam name="T">Response result type</typeparam>
    public class SFDXResponse<T>
    {
        [JsonProperty("result")]
        public T Result { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }
}

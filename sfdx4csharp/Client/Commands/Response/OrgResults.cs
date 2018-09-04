// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json;

namespace sfdx4csharpClient.Commands.Response
{
    /// <summary>
    /// Response result for the method Create of class Org.
    /// </summary>
    public class OrgCreateResult
    {
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    /// <summary>
    /// Response result for the method Display of class Org.
    /// </summary>
    public class OrgDisplayResult
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("connectedStatus")]
        public string ConnectedStatus { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("devHubId")]
        public string DevHubId { get; set; }

        [JsonProperty("edition")]
        public string Edition { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("instanceUrl")]
        public string InstanceUrl { get; set; }

        [JsonProperty("orgName")]
        public string OrgName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    /// <summary>
    /// Response result for the method Open of class Org.
    /// </summary>
    public class OrgOpenResult
    {
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}

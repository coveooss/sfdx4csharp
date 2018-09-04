// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json;

namespace sfdx4csharpClient.Commands.Response
{
    /// <summary>
    /// Response result for the method JwtGrant of class Auth.
    /// </summary>
    public class AuthJwtGrantResult
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("instanceUrl")]
        public string InstanceUrl { get; set; }

        [JsonProperty("loginUrl")]
        public string LoginUrl { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        [JsonProperty("privateKey")]
        public string PrivateKey { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}

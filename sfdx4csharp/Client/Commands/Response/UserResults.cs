// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json;

namespace sfdx4csharpClient.Commands.Response
{
    /// <summary>
    /// Response result for the method PasswordGenerate of class User.
    /// </summary>
    public class UserPasswordGenerateResult
    {
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}

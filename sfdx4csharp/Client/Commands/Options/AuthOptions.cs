// Copyright (c) 2005-2018, Coveo Solutions Inc.

using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Commands.Options
{
    /// <summary>
    /// Options for the method JwtGrant of class Auth.
    /// </summary>
    public class AuthJwtGrantOptions : SFDXOptions
    {
        [SwitchName("--username")]
        public string Username { get; set; }

        [SwitchName("--jwtkeyfile")]
        public string JwtKeyFilePath { get; set; }

        [SwitchName("--clientid")]
        public string ClientId { get; set; }

        [SwitchName("--setalias")]
        public bool? SetAlias { get; set; }

        [SwitchName("--setdefaultusername")]
        public bool? SetDefaultUsername { get; set; }

        [SwitchName("--setdefaultdevhubusername")]
        public bool? SetDefaultDevHubUsername { get; set; }

        [SwitchName("--instanceurl")]
        public string InstanceUrl { get; set; }
    }
}

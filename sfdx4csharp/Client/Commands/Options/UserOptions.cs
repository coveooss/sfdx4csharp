// Copyright (c) 2005-2018, Coveo Solutions Inc.

using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Commands.Options
{
    /// <summary>
    /// Options for the method PasswordGenerate of class User.
    /// </summary>
    public class UserPasswordGenerateOptions : SFDXOptions
    {
        [SwitchName("--targetdevhubusername")]
        public string TargetDevHubUsername { get; set; }

        [SwitchName("--targetusername")]
        public string TargetUsername { get; set; }

        [SwitchName("--onbehalfof")]
        public string OnBehalfOf { get; set; }
    }
}

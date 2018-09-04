// Copyright (c) 2005-2018, Coveo Solutions Inc.

using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Commands.Options
{
    /// <summary>
    /// Options for the method Create of class Org.
    /// </summary>
    public class OrgCreateOptions : SFDXOptions
    {
        [SwitchName("")]
        public string Expression { get; set; }

        [SwitchName("--env")]
        public string Env { get; set; }

        [SwitchName("--wait")]
        public string Wait { get; set; }

        [SwitchName("--definitionfile")]
        public string DefinitionFilePath { get; set; }

        [SwitchName("--nonamespace")]
        public bool? NoNamespace { get; set; }

        [SwitchName("--targetdevhubusername")]
        public string TargetDevHubUsername { get; set; }

        [SwitchName("--durationdays")]
        public string DurationDays { get; set; }

        [SwitchName("--noancestors")]
        public bool? NoAncestors { get; set; }

        [SwitchName("--definitionjson")]
        public string DefinitionJson { get; set; }

        [SwitchName("--setalias")]
        public string SetAlias { get; set; }

        [SwitchName("--setdefaultusername")]
        public bool? SetDefaultUsername { get; set; }

        [SwitchName("--clientid")]
        public string ClientId { get; set; }
    }

    /// <summary>
    /// Options for the method Display of class Org.
    /// </summary>
    public class OrgDisplayOptions : SFDXOptions
    {
        [SwitchName("--targetusername")]
        public string TargetUsername { get; set; }

        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method Open of class Org.
    /// </summary>
    public class OrgOpenOptions : SFDXOptions
    {
        [SwitchName("--targetusername")]
        public string TargetUsername { get; set; }

        [SwitchName("--urlonly")]
        public bool? Urlonly { get; set; }

        [SwitchName("--path")]
        public string Path { get; set; }
    }
}

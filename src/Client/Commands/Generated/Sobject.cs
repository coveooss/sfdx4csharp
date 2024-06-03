// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Describe of class Sobject.
    /// </summary>
    public class SobjectDescribeOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for use-tooling-api
        /// </summary>
        [SwitchName("--use-tooling-api")]
        public bool? UseToolingApi { get; set; }
    }

    /// <summary>
    /// Options for the method List of class Sobject.
    /// </summary>
    public class SobjectListOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }
    }

    /// <summary>
    /// Sobject
    /// </summary>
    [CommandClass("sobject")]
    public class Sobject : SfCommand
    {
        /// Constructor.
        public Sobject(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Display the metadata for a standard or custom object or a Tooling API object.
        /// </summary>
        /// <remarks>
        /// The metadata is displayed in JSON format. See this topic for a description of each property: https://developer.salesforce.com/docs/atlas.en-us.api.meta/api/sforce_api_calls_describesobjects_describesobjectresult.htm.
        /// 
        /// This command displays metadata for Salesforce objects by default. Use the --use-tooling-api flag to view metadata for a Tooling API object.
        /// </remarks>
        /// <example>
        /// Display the metadata of the "Account" standard object in your default org:
        /// $ sf describe --sobject Account
        /// Display the metadata of the "MyObject__c" custom object in the org with alias "my-scratch-org":
        /// $ sf describe --sobject MyObject__c --target-org my-scratch-org
        /// Display the metadata of the ApexCodeCoverage Tooling API object in your default org:
        /// $ sf describe --sobject ApexCodeCoverage --use-tooling-api
        /// </example>
        [Command("describe")]
        public SfResponse Describe(SobjectDescribeOptions options)
        {
            return ExecuteCommand(nameof(Describe), options);
        }

        /// <summary>
        /// List all Salesforce objects of a specified category.
        /// </summary>
        /// <remarks>
        /// You can list the standard objects, custom objects, or all. The lists include only Salesforce objects, not Tooling API objects.
        /// </remarks>
        /// <example>
        /// List all objects in your default org:
        /// $ sf list --sobject all
        /// List only custom objects in the org with alias "my-scratch-org":
        /// $ sf list --sobject custom --target-org my-scratch-org
        /// </example>
        [Command("list")]
        public SfResponse List(SobjectListOptions options)
        {
            return ExecuteCommand(nameof(List), options);
        }
    }
}

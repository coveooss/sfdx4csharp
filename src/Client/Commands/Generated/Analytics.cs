// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method GenerateTemplate of class Analytics.
    /// </summary>
    public class AnalyticsGenerateTemplateOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

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
    }

    /// <summary>
    /// Analytics
    /// </summary>
    [CommandClass("analytics")]
    public class Analytics : SfCommand
    {
        /// Constructor.
        public Analytics(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Generate a simple Analytics template.
        /// </summary>
        /// <remarks>
        /// The metadata files associated with the Analytics template must be contained in a parent directory called "waveTemplates" in your package directory. Either run this command from an existing directory of this name, or use the --output-dir flag to generate one or point to an existing one.
        /// </remarks>
        /// <example>
        /// Generate the metadata files for a simple Analytics template file called myTemplate in the force-app/main/default/waveTemplates directory:
        /// $ sf generate template --name myTemplate --output-dir force-app/main/default/waveTemplates
        /// </example>
        [Command("generate template")]
        public SfResponse GenerateTemplate(AnalyticsGenerateTemplateOptions options)
        {
            return ExecuteCommand(nameof(GenerateTemplate), options);
        }
    }
}

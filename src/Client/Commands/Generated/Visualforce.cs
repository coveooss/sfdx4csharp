// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method GenerateComponent of class Visualforce.
    /// </summary>
    public class VisualforceGenerateComponentOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for label
        /// </summary>
        [SwitchName("--label")]
        public string Label { get; set; }

        /// <summary>
        /// [Required] The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string Template { get; set; }

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
    /// Options for the method GeneratePage of class Visualforce.
    /// </summary>
    public class VisualforceGeneratePageOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for label
        /// </summary>
        [SwitchName("--label")]
        public string Label { get; set; }

        /// <summary>
        /// [Required] The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string Template { get; set; }

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
    /// Visualforce
    /// </summary>
    [CommandClass("visualforce")]
    public class Visualforce : SfCommand
    {
        /// Constructor.
        public Visualforce(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Generate a Visualforce Component.
        /// </summary>
        /// <remarks>
        /// The command generates the .Component file and associated metadata file in the specified directory or the current working directory by default.
        /// </remarks>
        /// <example>
        /// Generate the metadata files for a Visualforce component in the current directory:
        /// $ sf generate component --name mycomponent --label mylabel
        /// Similar to previous example, but generate the files in the directory "force-app/main/default/components":
        /// $ sf generate component --name mycomponent --label mylabel --output-dir components
        /// </example>
        [Command("generate component")]
        public SfResponse GenerateComponent(VisualforceGenerateComponentOptions options)
        {
            return ExecuteCommand(nameof(GenerateComponent), options);
        }

        /// <summary>
        /// Generate a Visualforce Page.
        /// </summary>
        /// <remarks>
        /// The command generates the .Page file and associated metadata file in the specified directory or the current working directory by default.
        /// </remarks>
        /// <example>
        /// Generate the metadata files for a Visualforce page in the current directory:
        /// $ sf generate page --name mypage --label mylabel
        /// Similar to previous example, but generate the files in the directory "force-app/main/default/pages":
        /// $ sf generate page --name mypage --label mylabel --output-dir pages
        /// </example>
        [Command("generate page")]
        public SfResponse GeneratePage(VisualforceGeneratePageOptions options)
        {
            return ExecuteCommand(nameof(GeneratePage), options);
        }
    }
}

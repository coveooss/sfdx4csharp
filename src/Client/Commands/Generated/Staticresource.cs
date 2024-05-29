// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Generate of class StaticResource.
    /// </summary>
    public class StaticResourceGenerateOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] This name can contain only underscores and alphanumeric characters, and must be unique in your org. It must begin with a letter, not include spaces, not end with an underscore, and not contain two consecutive underscores.
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Required] Must be a valid MIME type such as application/json, application/javascript, application/zip, text/plain, text/css, etc.
        /// </summary>
        [SwitchName("--type")]
        public string Type { get; set; }

        /// <summary>
        /// [Required] The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Required] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// StaticResource
    /// </summary>
    [CommandClass("static-resource")]
    public class StaticResource : SfdxCommand
    {
        /// Constructor.
        public StaticResource(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Generates the metadata resource file in the specified directory or the current working directory. Static resource files must be contained in a parent directory called "staticresources" in your package directory. Either run this command from an existing directory of this name, or use the --output-dir flag to create one or point to an existing one.
        /// </summary>
        /// <remarks>
        /// Generates the metadata resource file in the specified directory or the current working directory. Static resource files must be contained in a parent directory called "staticresources" in your package directory. Either run this command from an existing directory of this name, or use the --output-dir flag to create one or point to an existing one.
        /// </remarks>
        /// <example>
        /// 
        /// Generate the metadata file for a static resource called MyResource in the current directory:
        /// <%= config.bin %> <%= command.id %> --name MyResource
        /// Similar to previous example, but specifies a MIME type of application/json:
        /// <%= config.bin %> <%= command.id %> --name MyResource --type application/json
        /// Generate the resource file in the "force-app/main/default/staticresources" directory:
        /// <%= config.bin %> <%= command.id %> --name MyResource --output-dir force-app/main/default/staticresources
        /// </example>
        [Command("generate")]
        public SfdxResponse Generate(StaticResourceGenerateOptions options)
        {
            return ExecuteCommand(nameof(Generate), options);
        }
    }
}

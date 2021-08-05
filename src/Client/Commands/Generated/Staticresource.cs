// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method create of class Staticresource.
    /// </summary>
    public class StaticresourceCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The name of the new static resource. This name can contain only underscores and alphanumeric characters, and must be unique in your org. It must begin with a letter, not include spaces, not end with an underscore, and not contain two consecutive underscores.
        /// </summary>
        [SwitchName("--resourcename")]
        public string resourcename { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The content type of the generated static resource. This must be a valid MIME type such as application/json, application/javascript, application/zip, text/plain, text/css, etc.
        /// </summary>
        [SwitchName("--contenttype")]
        public string contenttype { get; set; }

        /// <summary>
        /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Staticresource
    /// </summary>
    [CommandClass("force:staticresource")]
    public class Staticresource : SFDXCommand
    {
        /// Constructor.
        public Staticresource(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// create a static resource
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </summary>
        /// <remarks>
        /// create a static resource
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:staticresource:create -n MyResource
        ///    $ sfdx force:staticresource:create -n MyResource --contenttype application/json
        ///    $ sfdx force:staticresource:create -n MyResource -d staticresources
        /// 
        /// $ sfdx force:staticresource:create -n MyResource
        /// $ sfdx force:staticresource:create -n MyResource --contenttype application/json
        /// $ sfdx force:staticresource:create -n MyResource -d staticresources
        /// force:staticresource:create -n <string> [--contenttype <string>] [-d <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("create")]
        public SFDXResponse Create(StaticresourceCreateOptions p_Options)
        {
            return ExecuteCommand<StaticresourceCreateOptions>(nameof(Create), p_Options);
        }
    }
}

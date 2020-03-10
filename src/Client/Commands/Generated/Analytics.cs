// Generated on Tue Mar 10 2020 using sfdx-cli/7.43.1 win32-x64 node-v12.16.1. DO NOT MODIFY
// Copyright (c) 2005-2020, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method templateCreate of class Analytics.
    /// </summary>
    public class AnalyticsTemplateCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The name of the Analytics template.
        /// </summary>
        [SwitchName("--templatename")]
        public string templatename { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Analytics
    /// </summary>
    [CommandClass("force:analytics")]
    public class Analytics : SFDXCommand
    {
        /// Constructor.
        public Analytics(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// add an Analytics template to your workspace
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a simple Analytics template in the specified directory. If you don’t explicitly set the API version, it defaults to the current API version. The associated metadata files are created.
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:analytics:template:create -n myTemplate -d outputdir
        /// 
        /// force:analytics:template:create -n <string> [-d <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("template:create")]
        public SFDXResponse TemplateCreate(AnalyticsTemplateCreateOptions p_Options)
        {
            return ExecuteCommand<AnalyticsTemplateCreateOptions>(nameof(TemplateCreate), p_Options);
        }
    }
}

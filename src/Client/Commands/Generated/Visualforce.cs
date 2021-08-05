// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method componentCreate of class Visualforce.
    /// </summary>
    public class VisualforceComponentCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The label saved in the metadata for the Visualforce component.
        /// </summary>
        [SwitchName("--label")]
        public string label { get; set; }

        /// <summary>
        /// [Required] The Visualforce component name. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--componentname")]
        public string componentname { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string template { get; set; }

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
    /// Options for the method pageCreate of class Visualforce.
    /// </summary>
    public class VisualforcePageCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The label saved in the metadata for the Visualforce page.
        /// </summary>
        [SwitchName("--label")]
        public string label { get; set; }

        /// <summary>
        /// [Required] The Visualforce page name. The name can be up to 40 characters and must start with a letter.
        /// </summary>
        [SwitchName("--pagename")]
        public string pagename { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string template { get; set; }

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
    /// Visualforce
    /// </summary>
    [CommandClass("force:visualforce")]
    public class Visualforce : SFDXCommand
    {
        /// Constructor.
        public Visualforce(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// create a Visualforce component
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </summary>
        /// <remarks>
        /// create a Visualforce component
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:visualforce:component:create -n mycomponent -l mylabel
        ///    $ sfdx force:visualforce:component:create -n mycomponent -l mylabel -d components
        /// 
        /// $ sfdx force:visualforce:component:create -n mycomponent -l mylabel
        /// $ sfdx force:visualforce:component:create -n mycomponent -l mylabel -d components
        /// force:visualforce:component:create -n <string> -l <string> [-t <string>] [-d <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("component:create")]
        public SFDXResponse ComponentCreate(VisualforceComponentCreateOptions p_Options)
        {
            return ExecuteCommand<VisualforceComponentCreateOptions>(nameof(ComponentCreate), p_Options);
        }

        /// <summary>
        /// create a Visualforce page
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </summary>
        /// <remarks>
        /// create a Visualforce page
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:visualforce:page:create -n mypage -l mylabel
        ///    $ sfdx force:visualforce:page:create -n mypage -l mylabel -d pages
        /// 
        /// $ sfdx force:visualforce:page:create -n mypage -l mylabel
        /// $ sfdx force:visualforce:page:create -n mypage -l mylabel -d pages
        /// force:visualforce:page:create -n <string> -l <string> [-t <string>] [-d <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("page:create")]
        public SFDXResponse PageCreate(VisualforcePageCreateOptions p_Options)
        {
            return ExecuteCommand<VisualforcePageCreateOptions>(nameof(PageCreate), p_Options);
        }
    }
}

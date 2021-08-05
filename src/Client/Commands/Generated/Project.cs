// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method create of class Project.
    /// </summary>
    public class ProjectCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The name for the new project. Any valid folder name is accepted.
        /// </summary>
        [SwitchName("--projectname")]
        public string projectname { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The template to use to create the project. Supplied parameter values or default values are filled into a copy of the template.
        /// </summary>
        [SwitchName("--template")]
        public string template { get; set; }

        /// <summary>
        /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] The namespace associated with this project and any connected scratch orgs.
        /// </summary>
        [SwitchName("--namespace")]
        public string @namespace { get; set; }

        /// <summary>
        /// [Required] The default package directory name. Metadata items such as classes and Lightning bundles are placed inside this folder.
        /// </summary>
        [SwitchName("--defaultpackagedir")]
        public string defaultpackagedir { get; set; }

        /// <summary>
        /// [Optional] Generates a default manifest (package.xml) for fetching Apex, Visualforce, Lightning components, and static resources.
        /// </summary>
        [SwitchName("--manifest")]
        public bool? manifest { get; set; }

        /// <summary>
        /// [Required] The login URL for the Salesforce instance being used. Normally defaults to https://login.salesforce.com.
        /// </summary>
        [SwitchName("--loginurl")]
        public string loginurl { get; set; }
    }

    /// <summary>
    /// Project
    /// </summary>
    [CommandClass("force:project")]
    public class Project : SFDXCommand
    {
        /// Constructor.
        public Project(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// create a Salesforce DX project
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </summary>
        /// <remarks>
        /// create a Salesforce DX project
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// </remarks>
        /// <example>
        /// If not supplied, the apiversion, template, and outputdir use default values.
        /// The outputdir can be an absolute path or relative to the current working directory.
        /// 
        /// Examples:
        ///    $ sfdx force:project:create --projectname mywork
        ///    $ sfdx force:project:create --projectname mywork --defaultpackagedir myapp
        ///    $ sfdx force:project:create --projectname mywork --defaultpackagedir myapp --manifest
        ///    $ sfdx force:project:create --projectname mywork --template empty
        /// 
        /// $ sfdx force:project:create --projectname mywork
        /// $ sfdx force:project:create --projectname mywork --defaultpackagedir myapp
        /// $ sfdx force:project:create --projectname mywork --defaultpackagedir myapp --manifest
        /// $ sfdx force:project:create --projectname mywork --template empty
        /// force:project:create -n <string> [-t <string>] [-d <string>] [-s <string>] [-p <string>] [-x] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("create")]
        public SFDXResponse Create(ProjectCreateOptions p_Options)
        {
            return ExecuteCommand<ProjectCreateOptions>(nameof(Create), p_Options);
        }
    }
}

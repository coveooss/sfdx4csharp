// Generated on March 9th 2020 using sfdx-cli/7.43.1 win32-x64 node-v8.15.0. DO NOT MODIFY
// Copyright (c) 2005-2020, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method apiDisplay of class Limits.
    /// </summary>
    public class LimitsApiDisplayOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Limits
    /// </summary>
    [CommandClass("force:limits")]
    public class Limits : SFDXCommand
    {
        /// Constructor.
        public Limits(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// display current org’s limits
        /// </summary>
        /// <remarks>
        /// Displays remaining and maximum calls and events for your org.
        /// </remarks>
        /// <example>
        /// When you execute this command in a project, it provides limit information for your default scratch org.
        /// 
        /// Examples:
        ///    $ sfdx force:limits:api:display
        ///    $ sfdx force:limits:api:display -u me@my.org
        /// force:limits:api:display [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("api:display")]
        public SFDXResponse ApiDisplay(LimitsApiDisplayOptions p_Options)
        {
            return ExecuteCommand<LimitsApiDisplayOptions>(nameof(ApiDisplay), p_Options);
        }
    }
}

// Copyright (c) 2005-2018, Coveo Solutions Inc.

using sfdx4csharpClient.Commands.Options;
using sfdx4csharpClient.Commands.Response;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Commands
{
    /// <summary>
    /// Use the org commands to manage the orgs you use with Salesforce DX. Create and delete scratch orgs,
    /// list your created and authorized orgs, and open orgs in your browser.
    /// </summary>
    /// <remarks>
    /// source:
    /// https://developer.salesforce.com/docs/atlas.en-us.sfdx_cli_reference.meta/sfdx_cli_reference/cli_reference_force_org.htm#cli_reference_force_org
    /// </remarks>
    [CommandClass("force:org")]
    public class OrgCommand : SFDXCommand
    {
        /// <inheritDoc />
        public OrgCommand(CommandExecutioner p_CommandExecutioner)
            : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// Creates a scratch org using values specified in a configuration file or key=value pairs that you specify on the command
        /// line. Values specified on the command line override values in the configuration file.
        /// </summary>
        /// <returns><see cref="OrgCreateResult" /></returns>
        [Command("create")]
        public OrgCreateResult Create(OrgCreateOptions p_Options)
        {
            return ExecuteCommand<OrgCreateOptions, OrgCreateResult>(nameof(Create), p_Options);
        }

        /// <summary>
        /// Gets the description for the current or target org.
        /// </summary>
        /// <returns><see cref="OrgDisplayResult" /></returns>
        [Command("display")]
        public OrgDisplayResult Display(OrgDisplayOptions p_Options)
        {
            return ExecuteCommand<OrgDisplayOptions, OrgDisplayResult>(nameof(Display), p_Options);
        }

        /// <summary>
        /// Opens an org in your browser.
        /// </summary>
        /// <returns><see cref="OrgOpenResult" /></returns>
        [Command("open")]
        public OrgOpenResult Open(OrgOpenOptions p_Options)
        {
            return ExecuteCommand<OrgOpenOptions, OrgOpenResult>(nameof(Open), p_Options);
        }
    }
}
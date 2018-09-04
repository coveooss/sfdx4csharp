// Copyright (c) 2005-2018, Coveo Solutions Inc.

using sfdx4csharpClient.Commands.Options;
using sfdx4csharpClient.Commands.Response;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Commands
{
    /// <summary>
    /// Use the auth commands to authorize a Salesforce org for use with the Salesforce CLI.
    /// </summary>
    /// <remarks>
    /// source:
    /// https://developer.salesforce.com/docs/atlas.en-us.sfdx_cli_reference.meta/sfdx_cli_reference/cli_reference_force_auth.htm#cli_reference_force_auth
    /// </remarks>
    [CommandClass("force:auth")]
    public class AuthCommand : SFDXCommand
    {
        /// <inheritDoc />
        public AuthCommand(CommandExecutioner p_CommandExecutioner)
            : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// Authorizes a Salesforce org using the JWT flow.
        /// </summary>
        /// <returns><see cref="AuthJwtGrantResult" /></returns>
        [Command("jwt:grant")]
        public AuthJwtGrantResult JwtGrant(AuthJwtGrantOptions p_Options)
        {
            return ExecuteCommand<AuthJwtGrantOptions, AuthJwtGrantResult>(nameof(JwtGrant), p_Options);
        }
    }
}
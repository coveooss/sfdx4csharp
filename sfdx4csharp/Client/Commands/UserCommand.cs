// Copyright (c) 2005-2018, Coveo Solutions Inc.

using sfdx4csharpClient.Commands.Options;
using sfdx4csharpClient.Commands.Response;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Commands
{
    /// <summary>
    /// Use the user commands to perform user-related admin tasks.
    /// </summary>
    /// <remarks>
    /// source:
    /// https://developer.salesforce.com/docs/atlas.en-us.sfdx_cli_reference.meta/sfdx_cli_reference/cli_reference_force_user.htm#cli_reference_force_user
    /// </remarks>
    [CommandClass("force:user")]
    public class UserCommand : SFDXCommand
    {
        /// <inheritDoc />
        public UserCommand(CommandExecutioner p_CommandExecutioner)
            : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// Generate a password for scratch org users.
        /// </summary>
        /// <returns><see cref="UserPasswordGenerateResult" /></returns>
        [Command("password:generate")]
        public UserPasswordGenerateResult PasswordGenerate(UserPasswordGenerateOptions p_Options)
        {
            return ExecuteCommand<UserPasswordGenerateOptions, UserPasswordGenerateResult>(nameof(PasswordGenerate), p_Options);
        }
    }
}
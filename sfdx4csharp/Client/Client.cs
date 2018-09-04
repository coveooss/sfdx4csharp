// Copyright (c) 2005-2018, Coveo Solutions Inc.

using System.Diagnostics;
using System.IO;
using sfdx4csharpClient.Commands;
using sfdx4csharpClient.Core;

namespace sfdx4csharpClient
{
    /// <summary>
    /// A client using the Salesforce Developer Experience (SFDX) command-line interface.
    /// </summary>
    /// <remarks>
    /// In order to use this client, you need to install the sfdxcli on your machine.
    /// How to: https://developer.salesforce.com/docs/atlas.en-us.sfdx_setup.meta/sfdx_setup/sfdx_setup_intro.htm
    /// </remarks>
    public class SFDXClient
    {
        /// <summary>
        /// Encapsulate the Auth commands in the force namespace.
        /// </summary>
        public AuthCommand AuthCommand { get; }

        /// <summary>
        /// Encapsulate the Data commands in the force namespace.
        /// </summary>
        public DataCommand DataCommand { get; }

        /// <summary>
        /// Encapsulate the OrgCommand commands in the force namespace.
        /// </summary>
        public OrgCommand OrgCommand { get; }

        /// <summary>
        /// Encapsulate the User commands in the force namespace.
        /// </summary>
        public UserCommand UserCommand { get; }

        private CommandExecutioner CommandExecutioner { get; }

        /// <summary>
        /// Initialize the modules that encapsulate the commands in the force namespace.
        /// </summary>
        /// <param name="p_Path">File path to the SFDC CLI executable</param>
        public SFDXClient(string p_Path)
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Path));
            Debug.Assert(File.Exists(p_Path));

            CommandExecutioner = new CommandExecutioner(new CommandRunner(p_Path));
            AuthCommand = new AuthCommand(CommandExecutioner);
            DataCommand = new DataCommand(CommandExecutioner);
            OrgCommand = new OrgCommand(CommandExecutioner);
            UserCommand = new UserCommand(CommandExecutioner);
        }
    }
}

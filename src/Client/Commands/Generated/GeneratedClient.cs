// Generated on November 19th 2018, 12:30:00 pm using sfdx-cli/6.40.0-384e0c6cf2 (windows-x64) node-v8.9.4. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using System.Diagnostics;
using System.IO;
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
    public class GeneratedSFDXClient
    {
        public Limits Limits { get; }
        public Lightning Lightning { get; }
        public Data Data { get; }
        public Apex Apex { get; }
        public Doc Doc { get; }
        public Visualforce Visualforce { get; }
        public Mdapi Mdapi { get; }
        public Source Source { get; }
        public Org Org { get; }
        public Package Package { get; }
        public User User { get; }
        public Project Project { get; }
        public Config Config { get; }
        public Auth Auth { get; }
        public Alias Alias { get; }
        public Schema Schema { get; }
        public Package1 Package1 { get; }

        private readonly CommandRunner m_CmdRunner;

        /// <summary>
        /// Initialize the modules that encapsulate the commands in the force namespace.
        /// </summary>
        /// <param name="p_Path">File path to the SFDC CLI executable.</param>
        /// <param name="p_WorkingFolder">The working folder where to run SFDX commands.</param>
        public GeneratedSFDXClient(string p_Path,
            string p_WorkingFolder = "")
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Path));
            Debug.Assert(File.Exists(p_Path));
            Debug.Assert(string.IsNullOrEmpty(p_WorkingFolder) || Directory.Exists(p_WorkingFolder));

            m_CmdRunner = new CommandRunner(p_Path, p_WorkingFolder);
            CommandExecutioner executioner = new CommandExecutioner(m_CmdRunner);
            this.Limits = new Limits(executioner);
            this.Lightning = new Lightning(executioner);
            this.Data = new Data(executioner);
            this.Apex = new Apex(executioner);
            this.Doc = new Doc(executioner);
            this.Visualforce = new Visualforce(executioner);
            this.Mdapi = new Mdapi(executioner);
            this.Source = new Source(executioner);
            this.Org = new Org(executioner);
            this.Package = new Package(executioner);
            this.User = new User(executioner);
            this.Project = new Project(executioner);
            this.Config = new Config(executioner);
            this.Auth = new Auth(executioner);
            this.Alias = new Alias(executioner);
            this.Schema = new Schema(executioner);
            this.Package1 = new Package1(executioner);
        }

        /// <summary>
        /// Changes the working folder of the SFDX client.
        /// </summary>
        /// <param name="p_WorkingFolder">The new working folder where to run SFDX commands.</param>
        public void ChangeWorkingFolder(string p_FolderPath)
        {
            Debug.Assert(!string.IsNullOrEmpty(p_FolderPath));
            Debug.Assert(Directory.Exists(p_FolderPath));
            m_CmdRunner.WorkingFolder = p_FolderPath;
        }
    }
}

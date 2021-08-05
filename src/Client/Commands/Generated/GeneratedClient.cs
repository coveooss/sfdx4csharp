// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

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
        public Alias Alias { get; }
        public Auth Auth { get; }
        public Config Config { get; }
        public Analytics Analytics { get; }
        public Apex Apex { get; }
        public Cmdt Cmdt { get; }
        public Community Community { get; }
        public Data Data { get; }
        public Lightning Lightning { get; }
        public Limits Limits { get; }
        public Mdapi Mdapi { get; }
        public Org Org { get; }
        public Package1 Package1 { get; }
        public Package Package { get; }
        public Project Project { get; }
        public Schema Schema { get; }
        public Source Source { get; }
        public Staticresource Staticresource { get; }
        public User User { get; }
        public Visualforce Visualforce { get; }
        public Plugins Plugins { get; }

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
            this.Alias = new Alias(executioner);
            this.Auth = new Auth(executioner);
            this.Config = new Config(executioner);
            this.Analytics = new Analytics(executioner);
            this.Apex = new Apex(executioner);
            this.Cmdt = new Cmdt(executioner);
            this.Community = new Community(executioner);
            this.Data = new Data(executioner);
            this.Lightning = new Lightning(executioner);
            this.Limits = new Limits(executioner);
            this.Mdapi = new Mdapi(executioner);
            this.Org = new Org(executioner);
            this.Package1 = new Package1(executioner);
            this.Package = new Package(executioner);
            this.Project = new Project(executioner);
            this.Schema = new Schema(executioner);
            this.Source = new Source(executioner);
            this.Staticresource = new Staticresource(executioner);
            this.User = new User(executioner);
            this.Visualforce = new Visualforce(executioner);
            this.Plugins = new Plugins(executioner);
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
		
        /// <summary>
        /// Changes the home folder of the SFDX client. 
        /// This is the directory where it looks for the .sfdx folder
        /// </summary>
        /// <param name="p_HomeFolderPath">The new home folder where the .sfdx folder is located, or null/empty to revert back to the default.</param>
        /// <remarks>Only works on Windows.</remarks>
        public void ChangeHomeFolder(string p_HomeFolderPath)
        {
            Debug.Assert(string.IsNullOrEmpty(p_HomeFolderPath) || Directory.Exists(p_HomeFolderPath));
            m_CmdRunner.HomeFolder = p_HomeFolderPath;
        }
    }
}

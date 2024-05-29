// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using System.Diagnostics;
using System.IO;
using sfdx4csharpClient.Core;

namespace sfdx4csharpClient
{
    /// <summary>
    /// A client using the Salesforce command-line interface (Salesforce CLI).
    /// </summary>
    /// <remarks>
    /// In order to use this client, you need to install the Salesforce CLI on your machine.
    /// How to: https://developer.salesforce.com/docs/atlas.en-us.sfdx_setup.meta/sfdx_setup/sfdx_setup_install_cli.htm
    /// </remarks>
    public class GeneratedSfdxClient
    {
        public Alias Alias { get; }
        public Analytics Analytics { get; }
        public Apex Apex { get; }
        public Cmdt Cmdt { get; }
        public Community Community { get; }
        public Config Config { get; }
        public Data Data { get; }
        public Deploy Deploy { get; }
        public Dev Dev { get; }
        public Env Env { get; }
        public ForceData ForceData { get; }
        public ForceLightning ForceLightning { get; }
        public Generate Generate { get; }
        public Info Info { get; }
        public Lightning Lightning { get; }
        public Login Login { get; }
        public Logout Logout { get; }
        public Org Org { get; }
        public Package1 Package1 { get; }
        public Package Package { get; }
        public Plugins Plugins { get; }
        public Project Project { get; }
        public Run Run { get; }
        public Scanner Scanner { get; }
        public Schema Schema { get; }
        public Sobject Sobject { get; }
        public StaticResource StaticResource { get; }
        public Visualforce Visualforce { get; }
        public Whoami Whoami { get; }

        private readonly CommandRunner _cmdRunner;

        /// <summary>
        /// Initialize the modules that encapsulate the commands in the force namespace.
        /// </summary>
        /// <param name="path">File path to the SFDC CLI executable.</param>
        /// <param name="workingFolder">The working folder where to run sfdx commands.</param>
        public GeneratedSfdxClient(string path,
            string workingFolder = "")
        {
            Debug.Assert(!string.IsNullOrEmpty(path));
            Debug.Assert(File.Exists(path));
            Debug.Assert(string.IsNullOrEmpty(workingFolder) || Directory.Exists(workingFolder));

            _cmdRunner = new CommandRunner(path, workingFolder);
            CommandExecutioner executioner = new CommandExecutioner(_cmdRunner);
            this.Alias = new Alias(executioner);
            this.Analytics = new Analytics(executioner);
            this.Apex = new Apex(executioner);
            this.Cmdt = new Cmdt(executioner);
            this.Community = new Community(executioner);
            this.Config = new Config(executioner);
            this.Data = new Data(executioner);
            this.Deploy = new Deploy(executioner);
            this.Dev = new Dev(executioner);
            this.Env = new Env(executioner);
            this.ForceData = new ForceData(executioner);
            this.ForceLightning = new ForceLightning(executioner);
            this.Generate = new Generate(executioner);
            this.Info = new Info(executioner);
            this.Lightning = new Lightning(executioner);
            this.Login = new Login(executioner);
            this.Logout = new Logout(executioner);
            this.Org = new Org(executioner);
            this.Package1 = new Package1(executioner);
            this.Package = new Package(executioner);
            this.Plugins = new Plugins(executioner);
            this.Project = new Project(executioner);
            this.Run = new Run(executioner);
            this.Scanner = new Scanner(executioner);
            this.Schema = new Schema(executioner);
            this.Sobject = new Sobject(executioner);
            this.StaticResource = new StaticResource(executioner);
            this.Visualforce = new Visualforce(executioner);
            this.Whoami = new Whoami(executioner);
        }

        /// <summary>
        /// Changes the working folder of the sfdx client.
        /// </summary>
        /// <param name="folderPath">The new working folder path where to run sfdx commands.</param>
        public void ChangeWorkingFolder(string folderPath)
        {
            Debug.Assert(!string.IsNullOrEmpty(folderPath));
            Debug.Assert(Directory.Exists(folderPath));
            _cmdRunner.WorkingFolder = folderPath;
        }
		
        /// <summary>
        /// Changes the home folder of the sfdx client. 
        /// This is the directory where it looks for the .sfdx folder
        /// </summary>
        /// <param name="homeFolderPath">The new home folder where the .sfdx folder is located, or null/empty to revert back to the default.</param>
        /// <remarks>Only works on Windows.</remarks>
        public void ChangeHomeFolder(string homeFolderPath)
        {
            Debug.Assert(string.IsNullOrEmpty(homeFolderPath) || Directory.Exists(homeFolderPath));
            _cmdRunner.HomeFolder = homeFolderPath;
        }
    }
}

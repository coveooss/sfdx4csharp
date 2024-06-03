// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

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
    public class GeneratedSfClient
    {
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Alias' topic.
        /// </summary>
        public Alias Alias { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Analytics' topic.
        /// </summary>
        public Analytics Analytics { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Apex' topic.
        /// </summary>
        public Apex Apex { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Autocomplete' topic.
        /// </summary>
        public Autocomplete Autocomplete { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Cmdt' topic.
        /// </summary>
        public Cmdt Cmdt { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Commands' topic.
        /// </summary>
        public Commands Commands { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Community' topic.
        /// </summary>
        public Community Community { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Config' topic.
        /// </summary>
        public Config Config { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Data' topic.
        /// </summary>
        public Data Data { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Deploy' topic.
        /// </summary>
        public Deploy Deploy { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Dev' topic.
        /// </summary>
        public Dev Dev { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Doctor' topic.
        /// </summary>
        public Doctor Doctor { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Env' topic.
        /// </summary>
        public Env Env { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'ForceData' topic.
        /// </summary>
        public ForceData ForceData { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'ForceLightning' topic.
        /// </summary>
        public ForceLightning ForceLightning { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Generate' topic.
        /// </summary>
        public Generate Generate { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Help' topic.
        /// </summary>
        public Help Help { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Info' topic.
        /// </summary>
        public Info Info { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Lightning' topic.
        /// </summary>
        public Lightning Lightning { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Login' topic.
        /// </summary>
        public Login Login { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Logout' topic.
        /// </summary>
        public Logout Logout { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Org' topic.
        /// </summary>
        public Org Org { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Package1' topic.
        /// </summary>
        public Package1 Package1 { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Package' topic.
        /// </summary>
        public Package Package { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Plugins' topic.
        /// </summary>
        public Plugins Plugins { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Project' topic.
        /// </summary>
        public Project Project { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Run' topic.
        /// </summary>
        public Run Run { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Scanner' topic.
        /// </summary>
        public Scanner Scanner { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Schema' topic.
        /// </summary>
        public Schema Schema { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Search' topic.
        /// </summary>
        public Search Search { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Sobject' topic.
        /// </summary>
        public Sobject Sobject { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'StaticResource' topic.
        /// </summary>
        public StaticResource StaticResource { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Update' topic.
        /// </summary>
        public Update Update { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Version' topic.
        /// </summary>
        public Version Version { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Visualforce' topic.
        /// </summary>
        public Visualforce Visualforce { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Which' topic.
        /// </summary>
        public Which Which { get; }
        /// <summary>
        /// Regroups all Salesforce CLI calls under the 'Whoami' topic.
        /// </summary>
        public Whoami Whoami { get; }

        private readonly CommandRunner _cmdRunner;

        /// <summary>
        /// Initialize the modules that encapsulate the commands in the force namespace.
        /// </summary>
        /// <param name="path">File path to the SFDC CLI executable.</param>
        /// <param name="workingFolder">The working folder where to run sf commands.</param>
        public GeneratedSfClient(string path,
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
            this.Autocomplete = new Autocomplete(executioner);
            this.Cmdt = new Cmdt(executioner);
            this.Commands = new Commands(executioner);
            this.Community = new Community(executioner);
            this.Config = new Config(executioner);
            this.Data = new Data(executioner);
            this.Deploy = new Deploy(executioner);
            this.Dev = new Dev(executioner);
            this.Doctor = new Doctor(executioner);
            this.Env = new Env(executioner);
            this.ForceData = new ForceData(executioner);
            this.ForceLightning = new ForceLightning(executioner);
            this.Generate = new Generate(executioner);
            this.Help = new Help(executioner);
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
            this.Search = new Search(executioner);
            this.Sobject = new Sobject(executioner);
            this.StaticResource = new StaticResource(executioner);
            this.Update = new Update(executioner);
            this.Version = new Version(executioner);
            this.Visualforce = new Visualforce(executioner);
            this.Which = new Which(executioner);
            this.Whoami = new Whoami(executioner);
        }

        /// <summary>
        /// Changes the working folder of the sf client.
        /// </summary>
        /// <param name="folderPath">The new working folder path where to run sf commands.</param>
        public void ChangeWorkingFolder(string folderPath)
        {
            Debug.Assert(!string.IsNullOrEmpty(folderPath));
            Debug.Assert(Directory.Exists(folderPath));
            _cmdRunner.WorkingFolder = folderPath;
        }
		
        /// <summary>
        /// Changes the home folder of the sf client. 
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

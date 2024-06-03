using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using sfdx4csharpClient;
using sfdx4csharpClient.Core;

namespace sfdx4csharp
{
    /// <summary>
    /// This is only used as simple tests and examples of usages of the SfClient class.
    /// </summary>
    public class Program
    {
        private const string SFDX_PATH_ENV_KEY = "SF_PATH";

        static void Main()
        {
            Console.WriteLine("Verifying sfdx version.");
            var cliPath = Environment.GetEnvironmentVariable(SFDX_PATH_ENV_KEY);
            Debug.Assert(cliPath != null);

            var runner = new CommandRunner(cliPath);
            var version = runner.RunCommand("--version").RawOutput;
            Console.WriteLine($"Using SFDX version: {version}");

            var client = new SfClient(cliPath);
            var projectFolder = "C:\\TmpSfdxProject";
            if (Directory.Exists(projectFolder)) {
                Directory.Delete(projectFolder, true);
            }

            Directory.CreateDirectory(projectFolder);
            client.ChangeWorkingFolder(projectFolder);

            var result = client.Org.DisplayUser(new OrgDisplayUserOptions
            {
                TargetOrg = "Bob"
            });

            Console.WriteLine("Listing the existing orgs.");
            client.Org.List(new OrgListOptions { All = true});

            Console.WriteLine("Creating test project.");
            client.Project.Generate(new ProjectGenerateOptions { Name = "Test" });
            client.ChangeWorkingFolder(Path.Combine(projectFolder, "Test"));

            Console.WriteLine("Creating a scratch org.");
            client.Org.CreateScratch(new OrgCreateScratchOptions
            {
                DefinitionFile = "config\\project-scratch-def.json",
                Alias = "Toto",
                Wait = 5
            });

            Console.WriteLine("Project status:");
            var response = client.Project.RetrievePreview(new ProjectRetrievePreviewOptions
            {
                TargetOrg = "Toto"
            });

            Console.WriteLine(JsonConvert.SerializeObject(response));

            client.Org.DeleteScratch(new OrgDeleteScratchOptions {
                NoPrompt = true,
                TargetOrg = "Toto"
            });

            Console.WriteLine("Dummy run done!");
        }
    }
}
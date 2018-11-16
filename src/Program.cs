    // Copyright (c) 2005-2018, Coveo Solutions Inc.

    using System;
    using System.Diagnostics;
    using System.IO;
    using sfdx4csharpClient;
    using sfdx4csharpClient.Core;

    namespace sfdx4csharp
    {
        class Program
        {
            const string SFDX_PATH_ENV_KEY = "SFDX_PATH";
            static void Main(string[] args)
            {            
                Console.WriteLine("Verifying sfdx version.");
                var cliPath = Environment.GetEnvironmentVariable(SFDX_PATH_ENV_KEY);
                Debug.Assert(cliPath != null);

                CommandRunner runner = new CommandRunner(cliPath);
                string version = runner.RunCommand("--version");
                Console.WriteLine($"Using SFDX version: {version}");

                Console.WriteLine("Simple debug test using api:display command.");
                var client = new SFDXClient(cliPath);
                var response = client.Doc.CommandsDisplay(new DocCommandsDisplayOptions {
                    json = true
                });

                string commandNamespace = response.First["command"].ToString();
                Debug.Assert(commandNamespace.Equals("api:display"));
                
                string projectFolder = "C:\\TmpSfdxProject";
                if (Directory.Exists(projectFolder)) {
                    Directory.Delete(projectFolder, true);
                }
                
                Directory.CreateDirectory(projectFolder);
                client.ChangeWorkingFolder(projectFolder);
                client.Project.Create(new ProjectCreateOptions { projectname = "Test" });

                client.ChangeWorkingFolder(Path.Combine(projectFolder, "Test"));
                Console.WriteLine("Creating test project.");
                Console.WriteLine(client.Project.Create(new ProjectCreateOptions {
                    projectname = "test"
                }));

                Console.WriteLine("Creating a scratch org.");
                Console.WriteLine(client.Org.Create(new OrgCreateOptions {
                    definitionfile = "config\\project-scratch-def.json",
                    setalias = "Toto",
                    wait = 5
                }));

                Console.WriteLine("Project status:");
                Console.WriteLine(client.Source.Status(new SourceStatusOptions {
                    targetusername = "Toto"
                }));

                client.Org.Delete(new OrgDeleteOptions {
                    noprompt = true,
                    targetusername = "Toto"
                });

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }

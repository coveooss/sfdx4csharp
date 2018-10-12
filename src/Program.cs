// Copyright (c) 2005-2018, Coveo Solutions Inc.

using System;
using System.Diagnostics;
using Newtonsoft.Json;
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
            var response = client.Doc.CommandsDisplay(new DocCommandsDisplayOptions{
                json = true
            });
            string commandNamespace = response.First["command"].ToString();
            Debug.Assert(commandNamespace.Equals("api:display"));            
        }
    }
}

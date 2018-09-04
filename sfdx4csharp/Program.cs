using System;
using System.Diagnostics;
using Newtonsoft.Json;
using sfdx4csharpClient;

namespace sfdx4csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verifying sfdx version.");
            var client = new SFDXClient("/usr/local/bin/sfdx");
            var response = client.AuthCommand.JwtGrant(new sfdx4csharpClient.Commands.Options.AuthJwtGrantOptions() {

            });

            Console.WriteLine("test:"+ response.AccessToken);
              

        }
    }
}

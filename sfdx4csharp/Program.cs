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
            {
                var response = client.auth.jwtGrant(new AuthJwtGrantOptions {
                    username = "rdaccess@coveo.com",
                    instanceurl = "https://login.salesforce.com",
                    clientid = "3MVG99OxTyEMCQ3jzMsXigXWi8U5eV.e7V8LqZXTVhSFWeIvQ_CXgDyNS_alUlp6PZZ02elvXfc_zD2FvO5r4",
                    jwtkeyfile = "/Users/maveilleux/Repositories/SalesforceIntegrationV2/2/env/.sfdxjwtkey"
                });
                

                Console.WriteLine("accessToken:"+ response["accessToken"].ToString());
            }

            {
                var response = client.org.list();
                Console.WriteLine("orgs:"+ response.ToString());

            }


        }
    }
}

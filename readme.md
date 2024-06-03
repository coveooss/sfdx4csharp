[![Build status](https://ci.appveyor.com/api/projects/status/f7gkamlhy3k6r2jy/branch/master?svg=true)](https://ci.appveyor.com/project/Website/sfdx4csharp/branch/master)

# sfdx4csharp
Coveo C# Salesforce CLI wrapper. Allow to call the Salesforce CLI using C#.

## Requirements
* Salesforce CLI: https://developer.salesforce.com/docs/atlas.en-us.sfdx_setup.meta/sfdx_setup/sfdx_setup_install_cli.htm

## How to use
This lib is compiled and deployed to nuget. So you can just add it as a dependency to you your C# project and it should work.
https://www.nuget.org/packages/sfdx4csharp

## Code examples
You can see additional examples in the `Program.cs` file.

```c#
// Creating a client to call the Salesforce CLI installed using the npm method:
// npm install @salesforce/cli --global
var client = new SfClient("C:\\Program Files\\nodejs\\sf.cmd");

// Creats a Salesforce scratch organization. This following will execute:
// $ sf org create scratch --definition-file "config\project-scratch-def.json" --alias "MyOrg" -- wait 5
client.Org.CreateScratch(new OrgCreateScratchOptions
{
    DefinitionFile = "config\\project-scratch-def.json",
    Alias = "MyOrg",
    Wait = 5
});

// Fetches the created organization information. This following will execute:
// $ sf org display "MyOrg"
client.Org.Display(new OrgDisplayOptions
{
    TargetOrg = "MyOrg"
});

// Executes an SOQL query to retrieve all Salesforce Case ids from the scratch organizaiton. This following will execute:
// $ sf data query --query "Select id from Case" --target-org "MyOrg"
client.Data.Query(new DataQueryOptions
{
    Query = "Select id from Case",
    TargetOrg = "MyOrg"
});
```

## Typescipt code generator
This repostory includes a typescript application to generate c# classes from the Salesforce CLI command documentation.

To run it (from the root of the repository):
* have a working node JS enviroment.
* `npm install`: Installs the dependencies.
* `npm run generate`: Loads documentation from the Salesforce CLI and then generates the c# classes.

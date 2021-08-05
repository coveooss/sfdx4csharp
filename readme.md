[![Build status](https://ci.appveyor.com/api/projects/status/f7gkamlhy3k6r2jy/branch/master?svg=true)](https://ci.appveyor.com/project/Website/sfdx4csharp/branch/master)

# sfdx4csharp
Coveo Salesforce DX C# wrapper.

## Important NPM tasks
* `npm install`: Installs the dependencies.
* `npm run generate`: Loads documentation from sfdx-cli and then generates the wrapper classes.

## Basic usage

```c#
var client = new SFDXClient("{{path to sfdx-cli}}");

var response1 = client.Auth.JwtGrant(new AuthJwtGrantOptions {
    username = "{{devhub username}}",
    instanceurl = "{{instanceurl}}",
    clientid = "{{clientid}}",
    jwtkeyfile = "{{jwtkeyfile path}}"
});                
Console.WriteLine("accessToken:"+ response1["accessToken"].ToString());

var response2 = client.Org.List();
Console.WriteLine("orgs:"+ response2.ToString());
```

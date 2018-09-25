# sfdx4csharp
Coveo Salesforce DX C# wrapper.

## Important Npm Tasks

* `npm run run-generator`: Generates the wrapper classes.
* `npm run generate`: Loads documentation from sfdx and then generates the wrapper classes.

## Basic Usage

```c#
var client = new SFDXClient("/usr/local/bin/sfdx");

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


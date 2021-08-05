// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method accesstokenStore of class Auth.
    /// </summary>
    public class AuthAccesstokenStoreOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The login URL of the instance the org lives on
        /// </summary>
        [SwitchName("--instanceurl")]
        public string instanceurl { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Optional] Set the authenticated org as the default dev hub org for scratch org creation
        /// </summary>
        [SwitchName("--setdefaultdevhubusername")]
        public bool? setdefaultdevhubusername { get; set; }

        /// <summary>
        /// [Optional] Set the authenticated org as the default username that all commands run against
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] Set an alias for the authenticated org
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for confirmation
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Options for the method deviceLogin of class Auth.
    /// </summary>
    public class AuthDeviceLoginOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] OAuth client ID (sometimes called the consumer key)
        /// </summary>
        [SwitchName("--clientid")]
        public string clientid { get; set; }

        /// <summary>
        /// [Required] The login URL of the instance the org lives on
        /// </summary>
        [SwitchName("--instanceurl")]
        public string instanceurl { get; set; }

        /// <summary>
        /// [Optional] Set the authenticated org as the default dev hub org for scratch org creation
        /// </summary>
        [SwitchName("--setdefaultdevhubusername")]
        public bool? setdefaultdevhubusername { get; set; }

        /// <summary>
        /// [Optional] Set the authenticated org as the default username that all commands run against
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] Set an alias for the authenticated org
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Optional] Disable masking of user input (for use with problematic terminals)
        /// </summary>
        [SwitchName("--disablemasking")]
        public bool? disablemasking { get; set; }
    }

    /// <summary>
    /// Options for the method jwtGrant of class Auth.
    /// </summary>
    public class AuthJwtGrantOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] OAuth client ID (sometimes called the consumer key)
        /// </summary>
        [SwitchName("--clientid")]
        public string clientid { get; set; }

        /// <summary>
        /// [Required] Path to a file containing the private key
        /// </summary>
        [SwitchName("--jwtkeyfile")]
        public string jwtkeyfile { get; set; }

        /// <summary>
        /// [Required] Authentication username
        /// </summary>
        [SwitchName("--username")]
        public string username { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The login URL of the instance the org lives on
        /// </summary>
        [SwitchName("--instanceurl")]
        public string instanceurl { get; set; }

        /// <summary>
        /// [Optional] Set the authenticated org as the default dev hub org for scratch org creation
        /// </summary>
        [SwitchName("--setdefaultdevhubusername")]
        public bool? setdefaultdevhubusername { get; set; }

        /// <summary>
        /// [Optional] Set the authenticated org as the default username that all commands run against
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] Set an alias for the authenticated org
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for auth confirmation in demo mode
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Options for the method list of class Auth.
    /// </summary>
    public class AuthListOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method logout of class Auth.
    /// </summary>
    public class AuthLogoutOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Includes all authenticated orgs: for example, Dev Hubs, sandboxes, DE orgs, and expired, deleted, and unknown-status scratch orgs.
        /// </summary>
        [SwitchName("--all")]
        public bool? all { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for confirmation
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Options for the method sfdxurlStore of class Auth.
    /// </summary>
    public class AuthSfdxurlStoreOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] Path to a file containing the sfdx url
        /// </summary>
        [SwitchName("--sfdxurlfile")]
        public string sfdxurlfile { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Optional] Set the authenticated org as the default dev hub org for scratch org creation
        /// </summary>
        [SwitchName("--setdefaultdevhubusername")]
        public bool? setdefaultdevhubusername { get; set; }

        /// <summary>
        /// [Optional] Set the authenticated org as the default username that all commands run against
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] Set an alias for the authenticated org
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for auth confirmation in demo mode
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Options for the method webLogin of class Auth.
    /// </summary>
    public class AuthWebLoginOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] OAuth client ID (sometimes called the consumer key)
        /// </summary>
        [SwitchName("--clientid")]
        public string clientid { get; set; }

        /// <summary>
        /// [Required] The login URL of the instance the org lives on
        /// </summary>
        [SwitchName("--instanceurl")]
        public string instanceurl { get; set; }

        /// <summary>
        /// [Optional] Set the authenticated org as the default dev hub org for scratch org creation
        /// </summary>
        [SwitchName("--setdefaultdevhubusername")]
        public bool? setdefaultdevhubusername { get; set; }

        /// <summary>
        /// [Optional] Set the authenticated org as the default username that all commands run against
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] Set an alias for the authenticated org
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Optional] Disable masking of user input (for use with problematic terminals)
        /// </summary>
        [SwitchName("--disablemasking")]
        public bool? disablemasking { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for auth confirmation in demo mode
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Auth
    /// </summary>
    [CommandClass("auth")]
    public class Auth : SFDXCommand
    {
        /// Constructor.
        public Auth(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// authorize an org using an existing Salesforce access token
        /// By default, the command runs interactively and asks you for the access token. If you previously authorized the org, the command prompts whether you want to overwrite the local file. Specify --noprompt to not be prompted.
        /// To use the command in a CI/CD script, set the SFDX_ACCESS_TOKEN environment variable to the access token. Then run the command with the --noprompt parameter. "<org id>!<accesstoken>"
        /// </summary>
        /// <remarks>
        /// authorize an org using an existing Salesforce access token
        /// By default, the command runs interactively and asks you for the access token. If you previously authorized the org, the command prompts whether you want to overwrite the local file. Specify --noprompt to not be prompted.
        /// To use the command in a CI/CD script, set the SFDX_ACCESS_TOKEN environment variable to the access token. Then run the command with the --noprompt parameter. "<org id>!<accesstoken>"
        /// </remarks>
        /// <example>
        /// 
        /// sfdx auth:accesstoken:store --instanceurl https://mycompany.my.salesforce.com
        /// export SFDX_ACCESS_TOKEN=00Dxx0000000000!xxxxx
        /// sfdx auth:accesstoken:store --instanceurl https://dev-hub.my.salesforce.com --noprompt
        /// auth:accesstoken:store -r <url> [-s] [-s] [-a <string>] [-p] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("accesstoken:store")]
        public SFDXResponse AccesstokenStore(AuthAccesstokenStoreOptions p_Options)
        {
            return ExecuteCommand<AuthAccesstokenStoreOptions>(nameof(AccesstokenStore), p_Options);
        }

        /// <summary>
        /// authorize an org using a device code
        /// </summary>
        /// <remarks>
        /// authorize an org using a device code
        /// </remarks>
        /// <example>
        /// 
        /// sfdx auth:device:login -d -a TestOrg1
        /// sfdx auth:device:login -i <OAuth client id>
        /// sfdx auth:device:login -r https://test.salesforce.com
        /// auth:device:login [-i <string>] [-r <url>] [-d] [-s] [-a <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("device:login")]
        public SFDXResponse DeviceLogin(AuthDeviceLoginOptions p_Options)
        {
            return ExecuteCommand<AuthDeviceLoginOptions>(nameof(DeviceLogin), p_Options);
        }

        /// <summary>
        /// authorize an org using the JWT flow
        /// Use a certificate associated with your private key that has been uploaded to a personal connected app.
        /// If you specify an --instanceurl value, this value overrides the sfdcLoginUrl value in your sfdx-project.json file. To specify a My Domain URL, use the format MyDomainName.my.salesforce.com (not MyDomainName.lightning.force.com). To specify a sandbox, set --instanceurl to https://test.salesforce.com.
        /// </summary>
        /// <remarks>
        /// authorize an org using the JWT flow
        /// Use a certificate associated with your private key that has been uploaded to a personal connected app.
        /// If you specify an --instanceurl value, this value overrides the sfdcLoginUrl value in your sfdx-project.json file. To specify a My Domain URL, use the format MyDomainName.my.salesforce.com (not MyDomainName.lightning.force.com). To specify a sandbox, set --instanceurl to https://test.salesforce.com.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx auth:jwt:grant -u me@my.org -f <path to jwt key file> -i <OAuth client id>
        /// sfdx auth:jwt:grant -u me@my.org -f <path to jwt key file> -i <OAuth client id> -s -a MyDefaultOrg
        /// sfdx auth:jwt:grant -u me@acme.org -f <path to jwt key file> -i <OAuth client id> -r https://acme.my.salesforce.com
        /// auth:jwt:grant -u <string> -f <filepath> -i <string> [-r <url>] [-d] [-s] [-a <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("jwt:grant")]
        public SFDXResponse JwtGrant(AuthJwtGrantOptions p_Options)
        {
            return ExecuteCommand<AuthJwtGrantOptions>(nameof(JwtGrant), p_Options);
        }

        /// <summary>
        /// list auth connection information
        /// </summary>
        /// <remarks>
        /// list auth connection information
        /// </remarks>
        /// <example>
        /// 
        /// auth:list [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("list")]
        public SFDXResponse List(AuthListOptions p_Options)
        {
            return ExecuteCommand<AuthListOptions>(nameof(List), p_Options);
        }

        /// <summary>
        /// log out from authorized orgs
        /// By default, this command logs you out from your default scratch org.
        /// </summary>
        /// <remarks>
        /// log out from authorized orgs
        /// By default, this command logs you out from your default scratch org.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx auth:logout -u me@my.org
        /// sfdx auth:logout -a
        /// sfdx auth:logout -p
        /// auth:logout [-a] [-p] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("logout")]
        public SFDXResponse Logout(AuthLogoutOptions p_Options)
        {
            return ExecuteCommand<AuthLogoutOptions>(nameof(Logout), p_Options);
        }

        /// <summary>
        /// Authorize an org using an SFDX auth URL
        /// Authorize a Salesforce org using an SFDX auth URL stored within a file. The URL must have the format "force://<refreshToken>@<instanceUrl>" or "force://<clientId>:<clientSecret>:<refreshToken>@<instanceUrl>".
        /// You have three options when creating the auth file. The easiest option is to redirect the output of the `sfdx force:org:display --verbose --json` command into a file.
        /// For example, using an org you have already authorized:
        /// 
        ///     $ sfdx force:org:display -u <DevHub> --verbose --json > authFile.json
        ///     $ sfdx auth:sfdxurl:store -f authFile.json
        /// 
        /// The resulting JSON file contains the URL in the sfdxAuthUrl property inside of a results object.
        /// You can also create a JSON file that has a top-level property named sfdxAuthUrl whose value is the auth URL.
        /// Finally, you can create a normal text file that includes just the URL and nothing else.
        /// </summary>
        /// <remarks>
        /// Authorize an org using an SFDX auth URL
        /// Authorize a Salesforce org using an SFDX auth URL stored within a file. The URL must have the format "force://<refreshToken>@<instanceUrl>" or "force://<clientId>:<clientSecret>:<refreshToken>@<instanceUrl>".
        /// You have three options when creating the auth file. The easiest option is to redirect the output of the `sfdx force:org:display --verbose --json` command into a file.
        /// For example, using an org you have already authorized:
        /// 
        ///     $ sfdx force:org:display -u <DevHub> --verbose --json > authFile.json
        ///     $ sfdx auth:sfdxurl:store -f authFile.json
        /// 
        /// The resulting JSON file contains the URL in the sfdxAuthUrl property inside of a results object.
        /// You can also create a JSON file that has a top-level property named sfdxAuthUrl whose value is the auth URL.
        /// Finally, you can create a normal text file that includes just the URL and nothing else.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx auth:sfdxurl:store -f <path to sfdxAuthUrl file>
        /// sfdx auth:sfdxurl:store -f <path to sfdxAuthUrl file> -s -a MyDefaultOrg
        /// auth:sfdxurl:store -f <filepath> [-d] [-s] [-a <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("sfdxurl:store")]
        public SFDXResponse SfdxurlStore(AuthSfdxurlStoreOptions p_Options)
        {
            return ExecuteCommand<AuthSfdxurlStoreOptions>(nameof(SfdxurlStore), p_Options);
        }

        /// <summary>
        /// authorize an org using the web login flow
        /// If you specify an --instanceurl value, this value overrides the sfdcLoginUrl value in your sfdx-project.json file. To specify a My Domain URL, use the format MyDomainName.my.salesforce.com (not MyDomainName.lightning.force.com). To log in to a sandbox, set --instanceurl to https://test.salesforce.com.
        /// </summary>
        /// <remarks>
        /// authorize an org using the web login flow
        /// If you specify an --instanceurl value, this value overrides the sfdcLoginUrl value in your sfdx-project.json file. To specify a My Domain URL, use the format MyDomainName.my.salesforce.com (not MyDomainName.lightning.force.com). To log in to a sandbox, set --instanceurl to https://test.salesforce.com.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx auth:web:login -a TestOrg1
        /// sfdx auth:web:login -i <OAuth client id>
        /// sfdx auth:web:login -r https://test.salesforce.com
        /// auth:web:login [-i <string>] [-r <url>] [-d] [-s] [-a <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("web:login")]
        public SFDXResponse WebLogin(AuthWebLoginOptions p_Options)
        {
            return ExecuteCommand<AuthWebLoginOptions>(nameof(WebLogin), p_Options);
        }
    }
}

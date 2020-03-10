// Generated on Tue Mar 10 2020 using sfdx-cli/7.43.1 win32-x64 node-v12.16.1. DO NOT MODIFY
// Copyright (c) 2005-2020, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method deviceLogin of class Auth.
    /// </summary>
    public class AuthDeviceLoginOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] OAuth client ID (aka consumer key)
        /// </summary>
        [SwitchName("--clientid")]
        public string clientid { get; set; }

        /// <summary>
        /// [Required] login URL of the instance the org is on
        /// </summary>
        [SwitchName("--instanceurl")]
        public string instanceurl { get; set; }

        /// <summary>
        /// [Optional] set the authenticated org as the default Dev Hub org for scratch org creation
        /// </summary>
        [SwitchName("--setdefaultdevhubusername")]
        public bool? setdefaultdevhubusername { get; set; }

        /// <summary>
        /// [Optional] set the authenticated org as the default username that all commands run against
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] set an alias for the authenticated org
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }
    }

    /// <summary>
    /// Options for the method jwtGrant of class Auth.
    /// </summary>
    public class AuthJwtGrantOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] The OAuth client ID (sometimes referred to as the consumer key).
        /// </summary>
        [SwitchName("--clientid")]
        public string clientid { get; set; }

        /// <summary>
        /// [Required] Path to a file containing the private key.
        /// </summary>
        [SwitchName("--jwtkeyfile")]
        public string jwtkeyfile { get; set; }

        /// <summary>
        /// [Required] The authentication username.
        /// </summary>
        [SwitchName("--username")]
        public string username { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The login URL of the Salesforce instance that the org lives on.
        /// </summary>
        [SwitchName("--instanceurl")]
        public string instanceurl { get; set; }

        /// <summary>
        /// [Optional] Sets the authenticated org as the default Dev Hub org for scratch org creation.
        /// </summary>
        [SwitchName("--setdefaultdevhubusername")]
        public bool? setdefaultdevhubusername { get; set; }

        /// <summary>
        /// [Optional] Sets the authenticated org as the default username that all commands run against.
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] Sets an alias for the authenticated org.
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for auth confirmation in demo mode.
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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Includes all authenticated orgs: for example, Dev Hubs, sandboxes, DE orgs, and expired, deleted, and unknown-status scratch orgs.
        /// </summary>
        [SwitchName("--all")]
        public bool? all { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for confirmation.
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
        /// [Required] Path to a file containing the SFDX URL.
        /// </summary>
        [SwitchName("--sfdxurlfile")]
        public string sfdxurlfile { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Optional] Sets the authenticated org as the default Dev Hub org for scratch org creation.
        /// </summary>
        [SwitchName("--setdefaultdevhubusername")]
        public bool? setdefaultdevhubusername { get; set; }

        /// <summary>
        /// [Optional] Sets the authenticated org as the default username that all commands run against.
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] Sets an alias for the authenticated org.
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for auth confirmation in demo mode.
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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] The OAuth client ID (sometimes referred to as the consumer key).
        /// </summary>
        [SwitchName("--clientid")]
        public string clientid { get; set; }

        /// <summary>
        /// [Required] The login URL of the Salesforce instance that the org lives on.
        /// </summary>
        [SwitchName("--instanceurl")]
        public string instanceurl { get; set; }

        /// <summary>
        /// [Optional] Sets the authenticated org as the default Dev Hub org for scratch org creation.
        /// </summary>
        [SwitchName("--setdefaultdevhubusername")]
        public bool? setdefaultdevhubusername { get; set; }

        /// <summary>
        /// [Optional] Sets the authenticated org as the default username that all commands run against.
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] Sets an alias for the authenticated org.
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Optional] Disables masking of user input (for use with problematic terminals).
        /// </summary>
        [SwitchName("--disablemasking")]
        public bool? disablemasking { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for auth confirmation in demo mode.
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Auth
    /// </summary>
    [CommandClass("force:auth")]
    public class Auth : SFDXCommand
    {
        /// Constructor.
        public Auth(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// authorize an org using a device code
        /// </summary>
        /// <remarks>
        /// Authorize an org using a device code. You must open a browser, navigate to the verification URL, and enter the code. Log in, if not already logged in, and you’ll be prompted to allow the device to connect to the org.
        /// </remarks>
        /// <example>
        /// 
        /// force:auth:device:login [-i <string>] [-r <url>] [-d] [-s] [-a <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("device:login")]
        public SFDXResponse DeviceLogin(AuthDeviceLoginOptions p_Options)
        {
            return ExecuteCommand<AuthDeviceLoginOptions>(nameof(DeviceLogin), p_Options);
        }

        /// <summary>
        /// authorize an org using the JWT flow
        /// </summary>
        /// <remarks>
        /// Authorizes a Salesforce org using the JWT flow.
        /// </remarks>
        /// <example>
        /// Authorizes a Salesforce org using a certificate associated with your private key that has been uploaded to a personal connected app.
        /// 
        /// If you specify an --instanceurl value, this value overrides the sfdcLoginUrl value in your sfdx-project.json file. To specify a My Domain URL, use the format <yourdomain>.my.salesforce.com (not <yourdomain>.lightning.force.com).
        /// 
        /// Examples:
        ///    $ sfdx force:auth:jwt:grant -u me@my.org -f <path to jwt key file> -i <OAuth client id>
        ///    $ sfdx force:auth:jwt:grant -u me@my.org -f <path to jwt key file> -i <OAuth client id> -s -a MyDefaultOrg
        ///    $ sfdx force:auth:jwt:grant -u me@acme.org -f <path to jwt key file> -i <OAuth client id> -r https://acme.my.salesforce.com
        /// force:auth:jwt:grant -u <string> -f <filepath> -i <string> [-r <url>] [-d] [-s] [-a <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
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
        /// force:auth:list [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("list")]
        public SFDXResponse List(AuthListOptions p_Options = null)
        {
            return ExecuteCommand<AuthListOptions>(nameof(List), p_Options);
        }

        /// <summary>
        /// log out from authorized orgs
        /// </summary>
        /// <remarks>
        /// Logs you out from one or all of your authorized Salesforce orgs.
        /// </remarks>
        /// <example>
        /// By default, this command logs you out from your default scratch org.
        /// Examples:
        ///    $ sfdx force:auth:logout -u me@my.org
        ///    $ sfdx force:auth:logout -a
        ///    $ sfdx force:auth:logout -p
        /// force:auth:logout [-a] [-p] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("logout")]
        public SFDXResponse Logout(AuthLogoutOptions p_Options)
        {
            return ExecuteCommand<AuthLogoutOptions>(nameof(Logout), p_Options);
        }

        /// <summary>
        /// authorize an org using an SFDX auth URL
        /// </summary>
        /// <remarks>
        /// Authorizes a Salesforce org using an SFDX auth URL.
        /// </remarks>
        /// <example>
        /// Authorize a Salesforce org using an SFDX auth URL stored within a file.
        /// The file must have the format "force://<refreshToken>@<instanceUrl>" or "force://<clientId>:<clientSecret>:<refreshToken>@<instanceUrl>".
        /// The file must contain only the URL or be a JSON file that has a top-level property named sfdxAuthUrl.
        /// 
        /// Examples:
        ///    $ sfdx force:auth:sfdxurl:store -f <path to sfdxAuthUrl file>
        ///    $ sfdx force:auth:sfdxurl:store -f <path to sfdxAuthUrl file> -s -a MyDefaultOrg
        /// force:auth:sfdxurl:store -f <filepath> [-d] [-s] [-a <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("sfdxurl:store")]
        public SFDXResponse SfdxurlStore(AuthSfdxurlStoreOptions p_Options)
        {
            return ExecuteCommand<AuthSfdxurlStoreOptions>(nameof(SfdxurlStore), p_Options);
        }

        /// <summary>
        /// authorize an org using the web login flow
        /// </summary>
        /// <remarks>
        /// Authorizes a Salesforce org by opening a browser so you can log in through salesforce.com.
        /// </remarks>
        /// <example>
        /// To log in to a sandbox, set --instanceurl to https://test.salesforce.com.
        /// 
        /// Examples:
        ///    $ sfdx force:auth:web:login -a TestOrg1
        ///    $ sfdx force:auth:web:login -i <OAuth client id>
        ///    $ sfdx force:auth:web:login -r https://test.salesforce.com
        /// force:auth:web:login [-i <string>] [-r <url>] [-d] [-s] [-a <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("web:login")]
        public SFDXResponse WebLogin(AuthWebLoginOptions p_Options)
        {
            return ExecuteCommand<AuthWebLoginOptions>(nameof(WebLogin), p_Options);
        }
    }
}

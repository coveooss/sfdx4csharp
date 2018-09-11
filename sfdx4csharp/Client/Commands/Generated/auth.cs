// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method jwtGrant of class Auth.
 *
 * IAuthJwtGrant
 */
public class AuthJwtGrantOptions : SFDXOptions {

  /**
   * [Required] The authentication username.
   * @type {string}
   * @memberof AuthJwtGrantOptions
   */
  [SwitchName("--username")]
  public string username  {get; set;}

  /**
   * [Required] Path to a file containing the private key.
   * @type {string}
   * @memberof AuthJwtGrantOptions
   */
  [SwitchName("--jwtkeyfile")]
  public string jwtkeyfile  {get; set;}

  /**
   * [Required] The OAuth client ID (sometimes referred to as the consumer key).
   * @type {string}
   * @memberof AuthJwtGrantOptions
   */
  [SwitchName("--clientid")]
  public string clientid  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof AuthJwtGrantOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof AuthJwtGrantOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Optional] Do not prompt for auth confirmation in demo mode.
   * @type {bool}
   * @memberof AuthJwtGrantOptions
   */
  [SwitchName("--noprompt")]
  public bool? noprompt  {get; set;}

  /**
   * [Required] Sets an alias for the authenticated org.
   * @type {string}
   * @memberof AuthJwtGrantOptions
   */
  [SwitchName("--setalias")]
  public string setalias  {get; set;}

  /**
   * [Optional] Sets the authenticated org as the default username that all commands run against.
   * @type {bool}
   * @memberof AuthJwtGrantOptions
   */
  [SwitchName("--setdefaultusername")]
  public bool? setdefaultusername  {get; set;}

  /**
   * [Optional] Sets the authenticated org as the default Dev Hub org for scratch org creation.
   * @type {bool}
   * @memberof AuthJwtGrantOptions
   */
  [SwitchName("--setdefaultdevhubusername")]
  public bool? setdefaultdevhubusername  {get; set;}

  /**
   * [Required] The login URL of the Salesforce instance that the org lives on.
   * @type {string}
   * @memberof AuthJwtGrantOptions
   */
  [SwitchName("--instanceurl")]
  public string instanceurl  {get; set;}
}

/**
 * Options for the method logout of class Auth.
 *
 * IAuthLogout
 */
public class AuthLogoutOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof AuthLogoutOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof AuthLogoutOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof AuthLogoutOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Do not prompt for confirmation.
   * @type {bool}
   * @memberof AuthLogoutOptions
   */
  [SwitchName("--noprompt")]
  public bool? noprompt  {get; set;}

  /**
   * [Optional] Includes all authenticated orgs: for example, Dev Hubs, sandboxes, DE orgs, and expired, deleted, and unknown-status scratch orgs.
   * @type {bool}
   * @memberof AuthLogoutOptions
   */
  [SwitchName("--all")]
  public bool? all  {get; set;}
}

/**
 * Options for the method sfdxurlStore of class Auth.
 *
 * IAuthSfdxurlStore
 */
public class AuthSfdxurlStoreOptions : SFDXOptions {

  /**
   * [Required] Path to a file containing the SFDX URL.
   * @type {string}
   * @memberof AuthSfdxurlStoreOptions
   */
  [SwitchName("--sfdxurlfile")]
  public string sfdxurlfile  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof AuthSfdxurlStoreOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof AuthSfdxurlStoreOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Optional] Do not prompt for auth confirmation in demo mode.
   * @type {bool}
   * @memberof AuthSfdxurlStoreOptions
   */
  [SwitchName("--noprompt")]
  public bool? noprompt  {get; set;}

  /**
   * [Required] Sets an alias for the authenticated org.
   * @type {string}
   * @memberof AuthSfdxurlStoreOptions
   */
  [SwitchName("--setalias")]
  public string setalias  {get; set;}

  /**
   * [Optional] Sets the authenticated org as the default username that all commands run against.
   * @type {bool}
   * @memberof AuthSfdxurlStoreOptions
   */
  [SwitchName("--setdefaultusername")]
  public bool? setdefaultusername  {get; set;}

  /**
   * [Optional] Sets the authenticated org as the default Dev Hub org for scratch org creation.
   * @type {bool}
   * @memberof AuthSfdxurlStoreOptions
   */
  [SwitchName("--setdefaultdevhubusername")]
  public bool? setdefaultdevhubusername  {get; set;}
}

/**
 * Options for the method webLogin of class Auth.
 *
 * IAuthWebLogin
 */
public class AuthWebLoginOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof AuthWebLoginOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof AuthWebLoginOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Optional] Do not prompt for auth confirmation in demo mode.
   * @type {bool}
   * @memberof AuthWebLoginOptions
   */
  [SwitchName("--noprompt")]
  public bool? noprompt  {get; set;}

  /**
   * [Optional] Disables masking of user input (for use with problematic terminals).
   * @type {bool}
   * @memberof AuthWebLoginOptions
   */
  [SwitchName("--disablemasking")]
  public bool? disablemasking  {get; set;}

  /**
   * [Required] Sets an alias for the authenticated org.
   * @type {string}
   * @memberof AuthWebLoginOptions
   */
  [SwitchName("--setalias")]
  public string setalias  {get; set;}

  /**
   * [Optional] Sets the authenticated org as the default username that all commands run against.
   * @type {bool}
   * @memberof AuthWebLoginOptions
   */
  [SwitchName("--setdefaultusername")]
  public bool? setdefaultusername  {get; set;}

  /**
   * [Optional] Sets the authenticated org as the default Dev Hub org for scratch org creation.
   * @type {bool}
   * @memberof AuthWebLoginOptions
   */
  [SwitchName("--setdefaultdevhubusername")]
  public bool? setdefaultdevhubusername  {get; set;}

  /**
   * [Required] The login URL of the Salesforce instance that the org lives on.
   * @type {string}
   * @memberof AuthWebLoginOptions
   */
  [SwitchName("--instanceurl")]
  public string instanceurl  {get; set;}

  /**
   * [Required] The OAuth client ID (sometimes referred to as the consumer key).
   * @type {string}
   * @memberof AuthWebLoginOptions
   */
  [SwitchName("--clientid")]
  public string clientid  {get; set;}
}


/**
 * Auth
 *
 * @class Auth
 */
[CommandClass("force:auth")]
public class Auth : SFDXCommand {
        /// <inheritDoc />
    public Auth(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * authorize an org using the JWT flow
   * @returns {(Promise<Object | void>)}
   * @memberof Auth
   * @description Authorizes a Salesforce org using the JWT flow.
   * @example Authorizes a Salesforce org using a private key file that has been uploaded to a personal connected app.
   * 
   * If you specify an --instanceurl value, this value overrides the sfdcLoginUrl value in your sfdx-project.json file. To specify a My Domain URL, use the format <yourdomain>.my.salesforce.com (not <yourdomain>.lightning.force.com).
   * 
   * Examples:
   *    $ sfdx force:auth:jwt:grant -u me@my.org -f <path to jwt key file> -i <OAuth client id>
   *    $ sfdx force:auth:jwt:grant -u me@my.org -f <path to jwt key file> -i <OAuth client id> -s -a MyDefaultOrg
   *    $ sfdx force:auth:jwt:grant -u me@acme.org -f <path to jwt key file> -i <OAuth client id> -r https://acme.my.salesforce.com
   * force:auth:jwt:grant -u <string> -f <filepath> -i <string> [-r <url>] [-d] [-s] [-a <string>] [--json] [--loglevel <string>]
   */
   [Command("jwt:grant")]
    public JToken jwtGrant(AuthJwtGrantOptions p_Options) {
      return ExecuteCommand<AuthJwtGrantOptions, JToken>(nameof(jwtGrant), p_Options);      
    }
  
  /**
   * log out from authorized orgs
   * @returns {(Promise<Object | void>)}
   * @memberof Auth
   * @description Logs you out from one or all of your authorized Salesforce orgs.
   * @example By default, this command logs you out from your default scratch org.
   * Examples:
   *    $ sfdx force:auth:logout -u me@my.org
   *    $ sfdx force:auth:logout -a
   *    $ sfdx force:auth:logout -p
   * force:auth:logout [-a] [-p] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("logout")]
    public JToken logout(AuthLogoutOptions p_Options) {
      return ExecuteCommand<AuthLogoutOptions, JToken>(nameof(logout), p_Options);      
    }
  
  /**
   * authorize an org using an SFDX auth URL
   * @returns {(Promise<Object | void>)}
   * @memberof Auth
   * @description Authorizes a Salesforce org using an SFDX auth URL.
   * @example Authorize a Salesforce org using an SFDX auth URL stored within a file.
   * The file must have the format "force://<refreshToken>@<instanceUrl>" or "force://<clientId>:<clientSecret>:<refreshToken>@<instanceUrl>".
   * The file must contain only the URL or be a JSON file that has a top-level property named sfdxAuthUrl.
   * 
   * Examples:
   *    $ sfdx force:auth:sfdxurl:store -f <path to sfdxAuthUrl file>
   *    $ sfdx force:auth:sfdxurl:store -f <path to sfdxAuthUrl file> -s -a MyDefaultOrg
   * force:auth:sfdxurl:store -f <filepath> [-d] [-s] [-a <string>] [--json] [--loglevel <string>]
   */
   [Command("sfdxurl:store")]
    public JToken sfdxurlStore(AuthSfdxurlStoreOptions p_Options) {
      return ExecuteCommand<AuthSfdxurlStoreOptions, JToken>(nameof(sfdxurlStore), p_Options);      
    }
  
  /**
   * authorize an org using the web login flow
   * @returns {(Promise<Object | void>)}
   * @memberof Auth
   * @description Authorizes a Salesforce org by opening a browser so you can log in through salesforce.com.
   * @example To log in to a sandbox, set --instanceurl to https://test.salesforce.com.
   * 
   * Examples:
   *    $ sfdx force:auth:web:login -a TestOrg1
   *    $ sfdx force:auth:web:login -i <OAuth client id>
   *    $ sfdx force:auth:web:login -r https://test.salesforce.com
   * force:auth:web:login [-i <string>] [-r <url>] [-d] [-s] [-a <string>] [--json] [--loglevel <string>]
   */
   [Command("web:login")]
    public JToken webLogin(AuthWebLoginOptions p_Options) {
      return ExecuteCommand<AuthWebLoginOptions, JToken>(nameof(webLogin), p_Options);      
    }
  
}

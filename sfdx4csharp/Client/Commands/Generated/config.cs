// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method get of class Config.
 *
 * IConfigGet
 */
public class ConfigGetOptions : SFDXOptions {

  /**
   * [Required] The key pair expression for the command
   * @type {string}
   * @memberof ConfigGetOptions
   */
  [SwitchName("")]
  public string expression  {get; set;}

  /**
   * [Optional] Emit additional command output to stdout.
   * @type {bool}
   * @memberof ConfigGetOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ConfigGetOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof ConfigGetOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}
}

/**
 * Options for the method list of class Config.
 *
 * IConfigList
 */
public class ConfigListOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ConfigListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof ConfigListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}
}

/**
 * Options for the method set of class Config.
 *
 * IConfigSet
 */
public class ConfigSetOptions : SFDXOptions {

  /**
   * [Required] The key pair expression for the command
   * @type {string}
   * @memberof ConfigSetOptions
   */
  [SwitchName("")]
  public string expression  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof ConfigSetOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof ConfigSetOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Optional] Sets the configuration variables globally, so they can be used from any directory.
   * @type {bool}
   * @memberof ConfigSetOptions
   */
  [SwitchName("--global")]
  public bool? global  {get; set;}
}


/**
 * Config
 *
 * @class Config
 */
[CommandClass("force:config")]
public class Config : SFDXCommand {
        /// <inheritDoc />
    public Config(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * get config var values for given names
   * @returns {(Promise<Object | void>)}
   * @memberof Config
   * @description Gets the Salesforce CLI configuration values for your default scratch org, your default Dev Hub org, your default instance URL, or any combination of the three.
   * @example To see your default scratch org username, include "defaultusername".
   * To see your default Dev Hub, include "defaultdevhubusername".
   * To see your default instance URL, include "instanceUrl".
   * To see the locations where your values are set, include the --verbose flag.
   * 
   * Examples:
   *    $ sfdx force:config:get defaultusername
   *    $ sfdx force:config:get defaultusername defaultdevhubusername instanceUrl
   *    $ sfdx force:config:get defaultusername defaultdevhubusername --verbose
   * force:config:get name=value... [--json] [--loglevel <string>] [--verbose]
   */
   [Command("get")]
    public JToken get(ConfigGetOptions p_Options) {
      return ExecuteCommand<ConfigGetOptions, JToken>(nameof(get), p_Options);      
    }
  
  /**
   * list config vars for the Salesforce CLI
   * @returns {(Promise<Object | void>)}
   * @memberof Config
   * @description Lists the configuration variables for the Salesforce CLI.
   * @example Lists the config variables that the Salesforce CLI uses for various commands and tasks.
   * force:config:list [--json] [--loglevel <string>]
   */
   [Command("list")]
    public JToken list(ConfigListOptions p_Options = null) {
      return ExecuteCommand<ConfigListOptions, JToken>(nameof(list), p_Options);      
    }
  
  /**
   * set config vars for the Salesforce CLI
   * @returns {(Promise<Object | void>)}
   * @memberof Config
   * @description Sets the local and global configuration variables for the Salesforce CLI.
   * @example Sets the configuration variables that the Salesforce CLI uses for various commands and tasks. Local variables apply only to your current project. Global variables apply in any directory.
   * 
   * Examples:
   *    $ sfdx force:config:set defaultusername=me@my.org defaultdevhubusername=me@myhub.org
   *    $ sfdx force:config:set defaultdevhubusername=me@myhub.org -g
   * force:config:set name=value... [-g] [--json] [--loglevel <string>]
   */
   [Command("set")]
    public JToken set(ConfigSetOptions p_Options) {
      return ExecuteCommand<ConfigSetOptions, JToken>(nameof(set), p_Options);      
    }
  
}

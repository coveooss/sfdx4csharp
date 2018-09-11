// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method list of class Alias.
 *
 * IAliasList
 */
public class AliasListOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof AliasListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof AliasListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}
}

/**
 * Options for the method set of class Alias.
 *
 * IAliasSet
 */
public class AliasSetOptions : SFDXOptions {

  /**
   * [Required] The key pair expression for the command
   * @type {string}
   * @memberof AliasSetOptions
   */
  [SwitchName("")]
  public string expression  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof AliasSetOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof AliasSetOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}
}


/**
 * Alias
 *
 * @class Alias
 */
[CommandClass("force:alias")]
public class Alias : SFDXCommand {
        /// <inheritDoc />
    public Alias(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * list username aliases for the Salesforce CLI
   * @returns {(Promise<Object | void>)}
   * @memberof Alias
   * @description Lists the aliases that the Salesforce CLI can use for various commands and tasks.
   * @example Example: 
   *    $ sfdx force:alias:list
   * force:alias:list [--json] [--loglevel <string>]
   */
   [Command("list")]
    public JToken list(AliasListOptions p_Options = null) {
      return ExecuteCommand<AliasListOptions, JToken>(nameof(list), p_Options);      
    }
  
  /**
   * set username aliases for the Salesforce CLI
   * @returns {(Promise<Object | void>)}
   * @memberof Alias
   * @description Sets an alias that the Salesforce CLI can use for various commands and tasks.
   * @example You can associate an alias with only one username at a time. If you’ve set an alias multiple times, the alias points to the most recent username.
   * 
   * To delete an alias, run "sfdx force:alias:set" with no username.
   * 
   * Examples:
   *    $ sfdx force:alias:set DefaultOrg=me@my.org
   *    $ sfdx force:alias:set DefaultOrg=me@my.org DevHubOrg=me@myhub.org
   *    $ sfdx force:alias:set AliasToDelete=
   * force:alias:set name=value... [--json] [--loglevel <string>]
   */
   [Command("set")]
    public JToken set(AliasSetOptions p_Options) {
      return ExecuteCommand<AliasSetOptions, JToken>(nameof(set), p_Options);      
    }
  
}

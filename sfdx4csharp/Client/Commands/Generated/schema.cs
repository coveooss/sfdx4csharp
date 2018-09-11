// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method sobjectDescribe of class Schema.
 *
 * ISchemaSobjectDescribe
 */
public class SchemaSobjectDescribeOptions : SFDXOptions {

  /**
   * [Required] The API name of the object to describe.
   * @type {string}
   * @memberof SchemaSobjectDescribeOptions
   */
  [SwitchName("--sobjecttype")]
  public string sobjecttype  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof SchemaSobjectDescribeOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof SchemaSobjectDescribeOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof SchemaSobjectDescribeOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Execute using Tooling API.
   * @type {bool}
   * @memberof SchemaSobjectDescribeOptions
   */
  [SwitchName("--usetoolingapi")]
  public bool? usetoolingapi  {get; set;}
}

/**
 * Options for the method sobjectList of class Schema.
 *
 * ISchemaSobjectList
 */
public class SchemaSobjectListOptions : SFDXOptions {

  /**
   * [Required] The type of objects to list: all, custom, or standard.
   * @type {string}
   * @memberof SchemaSobjectListOptions
   */
  [SwitchName("--sobjecttypecategory")]
  public string sobjecttypecategory  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof SchemaSobjectListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof SchemaSobjectListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof SchemaSobjectListOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}


/**
 * Schema
 *
 * @class Schema
 */
[CommandClass("force:schema")]
public class Schema : SFDXCommand {
        /// <inheritDoc />
    public Schema(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * describe an object
   * @returns {(Promise<Object | void>)}
   * @memberof Schema
   * @description Displays the metadata for a standard or custom object.
   * @example Examples:
   *    $ sfdx force:schema:sobject:describe -s Account
   *    $ sfdx force:schema:sobject:describe -s MyObject__c
   *    $ sfdx force:schema:sobject:describe -s ApexClass -t
   * force:schema:sobject:describe -s <string> [-t] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("sobject:describe")]
    public JToken sobjectDescribe(SchemaSobjectDescribeOptions p_Options) {
      return ExecuteCommand<SchemaSobjectDescribeOptions, JToken>(nameof(sobjectDescribe), p_Options);      
    }
  
  /**
   * list all objects of a specified category
   * @returns {(Promise<Object | void>)}
   * @memberof Schema
   * @description Lists all objects of a specified sObject category.
   * @example Lists all objects, custom objects, or standard objects in the org.
   * 
   * Examples:
   *    $ sfdx force:schema:sobject:list -c all
   *    $ sfdx force:schema:sobject:list -c custom
   *    $ sfdx force:schema:sobject:list -c standard
   * force:schema:sobject:list -c <string> [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("sobject:list")]
    public JToken sobjectList(SchemaSobjectListOptions p_Options) {
      return ExecuteCommand<SchemaSobjectListOptions, JToken>(nameof(sobjectList), p_Options);      
    }
  
}

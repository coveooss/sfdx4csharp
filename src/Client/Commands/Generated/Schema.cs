// Generated on November 2nd 2018, 11:11:11 am using sfdx-cli/6.38.0-0d66175ccf (windows-x64) node-v8.9.4. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method sobjectDescribe of class Schema.
  /// </summary>
  public class SchemaSobjectDescribeOptions : SFDXOptions {
    /// <summary>
    /// [Required] The API name of the object to describe.
    /// </summary>  
    [SwitchName("--sobjecttype")]
    public string sobjecttype  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Optional] Execute using Tooling API.
    /// </summary>  
    [SwitchName("--usetoolingapi")]
    public bool? usetoolingapi  {get; set;}
  }
  
  /// <summary>
  /// Options for the method sobjectList of class Schema.
  /// </summary>
  public class SchemaSobjectListOptions : SFDXOptions {
    /// <summary>
    /// [Required] The type of objects to list: all, custom, or standard.
    /// </summary>  
    [SwitchName("--sobjecttypecategory")]
    public string sobjecttypecategory  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Optional] Format output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public bool? json  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  }
  

  /// <summary>
  /// Schema
  /// </summary>
  [CommandClass("force:schema")]
  public class Schema : SFDXCommand {

    /// Constructor.
    public Schema(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// describe an object
    /// </summary>
    /// <remarks>
    /// Displays the metadata for a standard or custom object.
    /// </remarks>
    /// <example>  
    /// Examples:
    ///    $ sfdx force:schema:sobject:describe -s Account
    ///    $ sfdx force:schema:sobject:describe -s MyObject__c
    ///    $ sfdx force:schema:sobject:describe -s ApexClass -t
    /// force:schema:sobject:describe -s <string> [-t] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("sobject:describe")]
      public JToken SobjectDescribe(SchemaSobjectDescribeOptions p_Options) {
        return ExecuteCommand<SchemaSobjectDescribeOptions, JToken>(nameof(SobjectDescribe), p_Options);      
      }
    
    /// <summary>
    /// list all objects of a specified category
    /// </summary>
    /// <remarks>
    /// Lists all objects of a specified sObject category.
    /// </remarks>
    /// <example>  
    /// Lists all objects, custom objects, or standard objects in the org.
    /// 
    /// Examples:
    ///    $ sfdx force:schema:sobject:list -c all
    ///    $ sfdx force:schema:sobject:list -c custom
    ///    $ sfdx force:schema:sobject:list -c standard
    /// force:schema:sobject:list -c <string> [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("sobject:list")]
      public JToken SobjectList(SchemaSobjectListOptions p_Options) {
        return ExecuteCommand<SchemaSobjectListOptions, JToken>(nameof(SobjectList), p_Options);      
      }
    
  }
}

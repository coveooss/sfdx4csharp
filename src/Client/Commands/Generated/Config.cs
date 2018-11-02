// Generated on November 2nd 2018, 11:11:11 am using sfdx-cli/6.38.0-0d66175ccf (windows-x64) node-v8.9.4. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method get of class Config.
  /// </summary>
  public class ConfigGetOptions : SFDXOptions {
    /// <summary>
    /// [Required] The key pair expression for the command
    /// </summary>  
    [SwitchName("")]
    public string expression  {get; set;}
  
    /// <summary>
    /// [Optional] Emit additional command output to stdout.
    /// </summary>  
    [SwitchName("--verbose")]
    public bool? verbose  {get; set;}
  
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
  }
  
  /// <summary>
  /// Options for the method list of class Config.
  /// </summary>
  public class ConfigListOptions : SFDXOptions {
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
  }
  
  /// <summary>
  /// Options for the method set of class Config.
  /// </summary>
  public class ConfigSetOptions : SFDXOptions {
    /// <summary>
    /// [Required] The key pair expression for the command
    /// </summary>  
    [SwitchName("")]
    public string expression  {get; set;}
  
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
    /// [Optional] Sets the configuration variables globally, so they can be used from any directory.
    /// </summary>  
    [SwitchName("--global")]
    public bool? global  {get; set;}
  }
  

  /// <summary>
  /// Config
  /// </summary>
  [CommandClass("force:config")]
  public class Config : SFDXCommand {

    /// Constructor.
    public Config(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// get config var values for given names
    /// </summary>
    /// <remarks>
    /// Gets the Salesforce CLI configuration values for your default scratch org, your default Dev Hub org, your default instance URL, or any combination of the three.
    /// </remarks>
    /// <example>  
    /// To see your default scratch org username, include "defaultusername".
    /// To see your default Dev Hub, include "defaultdevhubusername".
    /// To see your default instance URL, include "instanceUrl".
    /// To see the locations where your values are set, include the --verbose flag.
    /// 
    /// Examples:
    ///    $ sfdx force:config:get defaultusername
    ///    $ sfdx force:config:get defaultusername defaultdevhubusername instanceUrl
    ///    $ sfdx force:config:get defaultusername defaultdevhubusername --verbose
    /// force:config:get name=value... [--json] [--loglevel <string>] [--verbose]
    /// </example>
    [Command("get")]
      public JToken Get(ConfigGetOptions p_Options) {
        return ExecuteCommand<ConfigGetOptions, JToken>(nameof(Get), p_Options);      
      }
    
    /// <summary>
    /// list config vars for the Salesforce CLI
    /// </summary>
    /// <remarks>
    /// Lists the configuration variables for the Salesforce CLI.
    /// </remarks>
    /// <example>  
    /// Lists the config variables that the Salesforce CLI uses for various commands and tasks.
    /// force:config:list [--json] [--loglevel <string>]
    /// </example>
    [Command("list")]
      public JToken List(ConfigListOptions p_Options = null) {
        return ExecuteCommand<ConfigListOptions, JToken>(nameof(List), p_Options);      
      }
    
    /// <summary>
    /// set config vars for the Salesforce CLI
    /// </summary>
    /// <remarks>
    /// Sets the local and global configuration variables for the Salesforce CLI.
    /// </remarks>
    /// <example>  
    /// Sets the configuration variables that the Salesforce CLI uses for various commands and tasks. Local variables apply only to your current project. Global variables apply in any directory.
    /// 
    /// Examples:
    ///    $ sfdx force:config:set defaultusername=me@my.org defaultdevhubusername=me@myhub.org
    ///    $ sfdx force:config:set defaultdevhubusername=me@myhub.org -g
    /// force:config:set name=value... [-g] [--json] [--loglevel <string>]
    /// </example>
    [Command("set")]
      public JToken Set(ConfigSetOptions p_Options) {
        return ExecuteCommand<ConfigSetOptions, JToken>(nameof(Set), p_Options);      
      }
    
  }
}

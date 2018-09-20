// Generated on September 19th 2018, 4:53:42 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method list of class Alias.
  /// </summary>
  public class AliasListOptions : SFDXOptions {
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
  /// Options for the method set of class Alias.
  /// </summary>
  public class AliasSetOptions : SFDXOptions {
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
  }
  

  /// <summary>
  /// Alias
  /// </summary>
  [CommandClass("force:alias")]
  public class Alias : SFDXCommand {

    /// Constructor.
    public Alias(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// list username aliases for the Salesforce CLI
    /// </summary>
    /// <remarks>
    /// Lists the aliases that the Salesforce CLI can use for various commands and tasks.
    /// </remarks>
    /// <example>  
    /// Example: 
    ///    $ sfdx force:alias:list
    /// force:alias:list [--json] [--loglevel <string>]
    /// </example>
    [Command("list")]
      public JToken List(AliasListOptions p_Options = null) {
        return ExecuteCommand<AliasListOptions, JToken>(nameof(List), p_Options);      
      }
    
    /// <summary>
    /// set username aliases for the Salesforce CLI
    /// </summary>
    /// <remarks>
    /// Sets an alias that the Salesforce CLI can use for various commands and tasks.
    /// </remarks>
    /// <example>  
    /// You can associate an alias with only one username at a time. If you’ve set an alias multiple times, the alias points to the most recent username.
    /// 
    /// To delete an alias, run "sfdx force:alias:set" with no username.
    /// 
    /// Examples:
    ///    $ sfdx force:alias:set DefaultOrg=me@my.org
    ///    $ sfdx force:alias:set DefaultOrg=me@my.org DevHubOrg=me@myhub.org
    ///    $ sfdx force:alias:set AliasToDelete=
    /// force:alias:set name=value... [--json] [--loglevel <string>]
    /// </example>
    [Command("set")]
      public JToken Set(AliasSetOptions p_Options) {
        return ExecuteCommand<AliasSetOptions, JToken>(nameof(Set), p_Options);      
      }
    
  }
}

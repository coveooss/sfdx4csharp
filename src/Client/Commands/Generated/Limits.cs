// Generated on November 2nd 2018, 11:11:11 am using sfdx-cli/6.38.0-0d66175ccf (windows-x64) node-v8.9.4. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method apiDisplay of class Limits.
  /// </summary>
  public class LimitsApiDisplayOptions : SFDXOptions {
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
  /// Limits
  /// </summary>
  [CommandClass("force:limits")]
  public class Limits : SFDXCommand {

    /// Constructor.
    public Limits(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// display current org’s limits
    /// </summary>
    /// <remarks>
    /// Displays remaining and maximum calls and events for your org.
    /// </remarks>
    /// <example>  
    /// When you execute this command in a project, it provides limit information for your default scratch org.
    /// 
    /// Examples:
    ///    $ sfdx force:limits:api:display
    ///    $ sfdx force:limits:api:display -u me@my.org
    /// force:limits:api:display [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("api:display")]
      public JToken ApiDisplay(LimitsApiDisplayOptions p_Options) {
        return ExecuteCommand<LimitsApiDisplayOptions, JToken>(nameof(ApiDisplay), p_Options);      
      }
    
  }
}

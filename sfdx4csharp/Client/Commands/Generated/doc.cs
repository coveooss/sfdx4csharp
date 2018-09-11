// Generated on September 11th 2018, 5:23:30 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  
  /// <summary>
  /// Options for the method commandsDisplay of class Doc.
  /// </summary>
  public class DocCommandsDisplayOptions : SFDXOptions {
  
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
  /// Options for the method commandsList of class Doc.
  /// </summary>
  public class DocCommandsListOptions : SFDXOptions {
  
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
    /// [Optional] Lists docopt usage strings instead of command names and descriptions.
    /// </summary>  
    [SwitchName("--usage")]
    public bool? usage  {get; set;}
  }
  

  /// <summary>
  /// Doc
  /// </summary>
  [CommandClass("force:doc")]
  public class Doc : SFDXCommand {

    /// Constructor.
    public Doc(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// display help for force commands
    /// </summary>
    /// <remarks>
    /// Displays help for commands in the force namespace.
    /// </remarks>
    /// <example>  
    /// Displays --help output for commands in the force namespace.
    /// To display more details about the commands’ parameters, include the --json flag.
    /// force:doc:commands:display [--json] [--loglevel <string>]
    /// </example>
    [Command("commands:display")]
      public JToken commandsDisplay(DocCommandsDisplayOptions p_Options = null) {
        return ExecuteCommand<DocCommandsDisplayOptions, JToken>(nameof(commandsDisplay), p_Options);      
      }
    
    /// <summary>
    /// list the force commands
    /// </summary>
    /// <remarks>
    /// Lists the commands in the force namespace.
    /// </remarks>
    /// <example>  
    /// Displays a list of commands in the force namespace and their descriptions.
    /// force:doc:commands:list [-u] [--json] [--loglevel <string>]
    /// </example>
    [Command("commands:list")]
      public JToken commandsList(DocCommandsListOptions p_Options = null) {
        return ExecuteCommand<DocCommandsListOptions, JToken>(nameof(commandsList), p_Options);      
      }
    
  }
}

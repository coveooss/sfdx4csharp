// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method commandsDisplay of class Doc.
 *
 * IDocCommandsDisplay
 */
public class DocCommandsDisplayOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DocCommandsDisplayOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DocCommandsDisplayOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}
}

/**
 * Options for the method commandsList of class Doc.
 *
 * IDocCommandsList
 */
public class DocCommandsListOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof DocCommandsListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof DocCommandsListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Optional] Lists docopt usage strings instead of command names and descriptions.
   * @type {bool}
   * @memberof DocCommandsListOptions
   */
  [SwitchName("--usage")]
  public bool? usage  {get; set;}
}


/**
 * Doc
 *
 * @class Doc
 */
[CommandClass("force:doc")]
public class Doc : SFDXCommand {
        /// <inheritDoc />
    public Doc(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * display help for force commands
   * @returns {(Promise<Object | void>)}
   * @memberof Doc
   * @description Displays help for commands in the force namespace.
   * @example Displays --help output for commands in the force namespace.
   * To display more details about the commands’ parameters, include the --json flag.
   * force:doc:commands:display [--json] [--loglevel <string>]
   */
   [Command("commands:display")]
    public JToken commandsDisplay(DocCommandsDisplayOptions p_Options = null) {
      return ExecuteCommand<DocCommandsDisplayOptions, JToken>(nameof(commandsDisplay), p_Options);      
    }
  
  /**
   * list the force commands
   * @returns {(Promise<Object | void>)}
   * @memberof Doc
   * @description Lists the commands in the force namespace.
   * @example Displays a list of commands in the force namespace and their descriptions.
   * force:doc:commands:list [-u] [--json] [--loglevel <string>]
   */
   [Command("commands:list")]
    public JToken commandsList(DocCommandsListOptions p_Options = null) {
      return ExecuteCommand<DocCommandsListOptions, JToken>(nameof(commandsList), p_Options);      
    }
  
}

// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method apiDisplay of class Limits.
 *
 * ILimitsApiDisplay
 */
public class LimitsApiDisplayOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof LimitsApiDisplayOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof LimitsApiDisplayOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof LimitsApiDisplayOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}


/**
 * Limits
 *
 * @class Limits
 */
[CommandClass("force:limits")]
public class Limits : SFDXCommand {
        /// <inheritDoc />
    public Limits(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * display current org’s limits
   * @returns {(Promise<Object | void>)}
   * @memberof Limits
   * @description Displays remaining and maximum calls and events for your org.
   * @example When you execute this command in a project, it provides limit information for your default scratch org.
   * 
   * Examples:
   *    $ sfdx force:limits:api:display
   *    $ sfdx force:limits:api:display -u me@my.org
   * force:limits:api:display [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("api:display")]
    public JToken apiDisplay(LimitsApiDisplayOptions p_Options) {
      return ExecuteCommand<LimitsApiDisplayOptions, JToken>(nameof(apiDisplay), p_Options);      
    }
  
}

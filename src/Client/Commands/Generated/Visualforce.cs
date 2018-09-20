// Generated on September 19th 2018, 4:53:42 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method componentCreate of class Visualforce.
  /// </summary>
  public class VisualforceComponentCreateOptions : SFDXOptions {
    /// <summary>
    /// [Required] The Visualforce component name. The name can be up to 40 characters and must start with a letter.
    /// </summary>  
    [SwitchName("--componentname")]
    public string componentname  {get; set;}
  
    /// <summary>
    /// [Required] The label saved in the metadata for the Visualforce component.
    /// </summary>  
    [SwitchName("--label")]
    public string label  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Required] Formats output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public string json  {get; set;}
  
    /// <summary>
    /// [Required] The API version of the created source.
    /// </summary>  
    [SwitchName("--apiversion")]
    public string apiversion  {get; set;}
  
    /// <summary>
    /// [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
    /// </summary>  
    [SwitchName("--reflect")]
    public string reflect  {get; set;}
  
    /// <summary>
    /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
    /// </summary>  
    [SwitchName("--outputdir")]
    public string outputdir  {get; set;}
  
    /// <summary>
    /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
    /// </summary>  
    [SwitchName("--template")]
    public string template  {get; set;}
  }
  
  /// <summary>
  /// Options for the method pageCreate of class Visualforce.
  /// </summary>
  public class VisualforcePageCreateOptions : SFDXOptions {
    /// <summary>
    /// [Required] The Visualforce page name. The name can be up to 40 characters and must start with a letter.
    /// </summary>  
    [SwitchName("--pagename")]
    public string pagename  {get; set;}
  
    /// <summary>
    /// [Required] The label saved in the metadata for the Visualforce page.
    /// </summary>  
    [SwitchName("--label")]
    public string label  {get; set;}
  
    /// <summary>
    /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
    /// </summary>  
    [SwitchName("--loglevel")]
    public LogLevel? loglevel  {get; set;}
  
    /// <summary>
    /// [Required] Formats output as JSON.
    /// </summary>  
    [SwitchName("--json")]
    public string json  {get; set;}
  
    /// <summary>
    /// [Required] The API version of the created source.
    /// </summary>  
    [SwitchName("--apiversion")]
    public string apiversion  {get; set;}
  
    /// <summary>
    /// [Required] Return reflection description of the command, options, and possible values. Allows IDE to tailor to the capabilities of the command
    /// </summary>  
    [SwitchName("--reflect")]
    public string reflect  {get; set;}
  
    /// <summary>
    /// [Required] The directory to store the newly created files. The location can be an absolute path or relative to the current working directory. The default is the current directory.
    /// </summary>  
    [SwitchName("--outputdir")]
    public string outputdir  {get; set;}
  
    /// <summary>
    /// [Required] The template to use to create the file. Supplied parameter values or default values are filled into a copy of the template.
    /// </summary>  
    [SwitchName("--template")]
    public string template  {get; set;}
  }
  

  /// <summary>
  /// Visualforce
  /// </summary>
  [CommandClass("force:visualforce")]
  public class Visualforce : SFDXCommand {

    /// Constructor.
    public Visualforce(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// create a Visualforce component
    /// </summary>
    /// <remarks>
    /// Creates a Visualforce component in the specified directory or the current working directory. The command creates the .component file and associated metadata file.
    /// </remarks>
    /// <example>  
    /// If not supplied, the apiversion, template, and outputdir use default values.
    /// The outputdir can be an absolute path or relative to the current working directory.
    /// Name and label are required.
    /// 
    /// Examples:
    ///    $ sfdx force:visualforce:component:create -n mycomponent -l mylabel
    ///    $ sfdx force:visualforce:component:create -n mycomponent -l mylabel -d components
    /// 
    /// force:visualforce:component:create -n <string> -l <string> [-t <string>] [-d <string>] [-a <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("component:create")]
      public JToken ComponentCreate(VisualforceComponentCreateOptions p_Options) {
        return ExecuteCommand<VisualforceComponentCreateOptions, JToken>(nameof(ComponentCreate), p_Options);      
      }
    
    /// <summary>
    /// create a Visualforce page
    /// </summary>
    /// <remarks>
    /// Creates a Visualforce page in the specified directory or the current working directory. The command creates the .page file and associated metadata file.
    /// </remarks>
    /// <example>  
    /// If not supplied, the apiversion, template, and outputdir use default values.
    /// The outputdir can be an absolute path or relative to the current working directory.
    /// Name and label are required.
    /// 
    /// Examples:
    ///    $ sfdx force:visualforce:page:create -n mypage -l mylabel
    ///    $ sfdx force:visualforce:page:create -n mypage -l mylabel -d pages
    /// 
    /// force:visualforce:page:create -n <string> -l <string> [-t <string>] [-d <string>] [-a <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("page:create")]
      public JToken PageCreate(VisualforcePageCreateOptions p_Options) {
        return ExecuteCommand<VisualforcePageCreateOptions, JToken>(nameof(PageCreate), p_Options);      
      }
    
  }
}

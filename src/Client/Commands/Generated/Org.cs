// Generated on September 20th 2018, 2:58:04 pm. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method create of class Org.
  /// </summary>
  public class OrgCreateOptions : SFDXOptions {
    /// <summary>
    /// [Required] The key pair expression for the command
    /// </summary>  
    [SwitchName("")]
    public string expression  {get; set;}
  
    /// <summary>
    /// [Required] Environment where the scratch org is created: [sandbox*,virtual,prototype].
    /// </summary>  
    [SwitchName("--env")]
    public string env  {get; set;}
  
    /// <summary>
    /// [Required] Sets the streaming client socket timeout, in minutes. If the streaming client socket has no contact from the server for a number of minutes, the client exits. Specify a longer wait time if timeouts occur frequently.
    /// </summary>  
    [SwitchName("--wait")]
    public string wait  {get; set;}
  
    /// <summary>
    /// [Required] Path to a scratch org definition file. Either --definitionfile or --definitionjson is required.
    /// </summary>  
    [SwitchName("--definitionfile")]
    public string definitionfile  {get; set;}
  
    /// <summary>
    /// [Optional] Creates the scratch org with no namespace. Useful when using a scratch org to test installations of packages with namespaces.
    /// </summary>  
    [SwitchName("--nonamespace")]
    public bool? nonamespace  {get; set;}
  
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
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  
    /// <summary>
    /// [Required] Sets the duration of the scratch org, in days. Valid values are from 1-30. The default is 7 days.
    /// </summary>  
    [SwitchName("--durationdays")]
    public string durationdays  {get; set;}
  
    /// <summary>
    /// [Optional] Do not include second-generation package ancestors in the scratch org.
    /// </summary>  
    [SwitchName("--noancestors")]
    public bool? noancestors  {get; set;}
  
    /// <summary>
    /// [Required] Scratch org definition in JSON format. Either --definitionfile or --definitionjson is required.
    /// </summary>  
    [SwitchName("--definitionjson")]
    public string definitionjson  {get; set;}
  
    /// <summary>
    /// [Required] Sets an alias for for the created scratch org.
    /// </summary>  
    [SwitchName("--setalias")]
    public string setalias  {get; set;}
  
    /// <summary>
    /// [Optional] Sets the created org as the default username.
    /// </summary>  
    [SwitchName("--setdefaultusername")]
    public bool? setdefaultusername  {get; set;}
  
    /// <summary>
    /// [Required] Connected app consumer key, as configured in your Dev Hub.
    /// </summary>  
    [SwitchName("--clientid")]
    public string clientid  {get; set;}
  }
  
  /// <summary>
  /// Options for the method delete of class Org.
  /// </summary>
  public class OrgDeleteOptions : SFDXOptions {
    /// <summary>
    /// [Required] A username or alias for the target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
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
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  
    /// <summary>
    /// [Optional] No prompt to confirm deletion.
    /// </summary>  
    [SwitchName("--noprompt")]
    public bool? noprompt  {get; set;}
  }
  
  /// <summary>
  /// Options for the method display of class Org.
  /// </summary>
  public class OrgDisplayOptions : SFDXOptions {
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
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  }
  
  /// <summary>
  /// Options for the method list of class Org.
  /// </summary>
  public class OrgListOptions : SFDXOptions {
    /// <summary>
    /// [Optional] Lists more information about each org.
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
  
    /// <summary>
    /// [Optional] Do not prompt for confirmation.
    /// </summary>  
    [SwitchName("--noprompt")]
    public bool? noprompt  {get; set;}
  
    /// <summary>
    /// [Optional] Remove all local org authorizations for deleted or expired orgs.
    /// </summary>  
    [SwitchName("--clean")]
    public bool? clean  {get; set;}
  
    /// <summary>
    /// [Optional] Lists all authenticated orgs, including expired, deleted, and unknown-status scratch orgs.
    /// </summary>  
    [SwitchName("--all")]
    public bool? all  {get; set;}
  }
  
  /// <summary>
  /// Options for the method open of class Org.
  /// </summary>
  public class OrgOpenOptions : SFDXOptions {
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
    /// [Optional] Displays a navigation URL, but doesn’t launch your browser.
    /// </summary>  
    [SwitchName("--urlonly")]
    public bool? urlonly  {get; set;}
  
    /// <summary>
    /// [Required] Navigation URL path (not including domain).
    /// </summary>  
    [SwitchName("--path")]
    public string path  {get; set;}
  }
  
  /// <summary>
  /// Options for the method shapeCreate of class Org.
  /// </summary>
  public class OrgShapeCreateOptions : SFDXOptions {
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
  /// Options for the method shapeDelete of class Org.
  /// </summary>
  public class OrgShapeDeleteOptions : SFDXOptions {
    /// <summary>
    /// [Required] Username for the target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
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
    /// [Optional] Do not prompt for confirmation.
    /// </summary>  
    [SwitchName("--noprompt")]
    public bool? noprompt  {get; set;}
  }
  
  /// <summary>
  /// Options for the method shapeList of class Org.
  /// </summary>
  public class OrgShapeListOptions : SFDXOptions {
    /// <summary>
    /// [Optional] Lists more information about each org shape.
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
  /// Org
  /// </summary>
  [CommandClass("force:org")]
  public class Org : SFDXCommand {

    /// Constructor.
    public Org(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// create a scratch org
    /// </summary>
    /// <remarks>
    /// Creates a scratch org using values specified in a configuration file or key=value pairs that you specify on the command line. Values specified on the command line override values in the configuration file.
    /// </remarks>
    /// <example>  
    /// To set up a connected app for your new scratch org, specify the value that was returned when you created a connected app in your Dev Hub org as --clientid.
    /// 
    /// Examples:
    ///    $ sfdx force:org:create -f config/enterprise-scratch-def.json -a TestOrg1
    ///    $ sfdx force:org:create -a MyDevOrg -s -v me@myhub.org edition=Developer
    ///    $ sfdx force:org:create -f config/enterprise-scratch-def.json -a OrgWithOverrides username=testuser1@mycompany.org
    /// force:org:create name=value... [-f <filepath>] [-n] [-c] [-i <string>] [-s] [-a <string>] [-w <minutes>] [-d <number>] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("create")]
      public JToken Create(OrgCreateOptions p_Options) {
        return ExecuteCommand<OrgCreateOptions, JToken>(nameof(Create), p_Options);      
      }
    
    /// <summary>
    /// mark a scratch org for deletion
    /// </summary>
    /// <remarks>
    /// Marks a scratch org for deletion.
    /// </remarks>
    /// <example>  
    /// To mark the org for deletion without being prompted to confirm, specify --noprompt.
    /// 
    /// Examples:
    ///    $ sfdx force:org:delete -u me@my.org
    ///    $ sfdx force:org:delete -u MyOrgAlias -p
    /// force:org:delete -u <string> [-p] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("delete")]
      public JToken Delete(OrgDeleteOptions p_Options) {
        return ExecuteCommand<OrgDeleteOptions, JToken>(nameof(Delete), p_Options);      
      }
    
    /// <summary>
    /// get org description
    /// </summary>
    /// <remarks>
    /// Gets the description for the current or target org.
    /// </remarks>
    /// <example>  
    /// Output includes your access token, client ID, connected status, org ID, instance URL, username, and alias, if applicable. 
    /// 
    /// Use --verbose to include the SFDX auth URL. Including --verbose displays the sfdxAuthUrl property only if you authenticated to the org using force:auth:web:login (not force:auth:jwt:grant).
    /// 
    /// Examples:
    ///    $ sfdx force:org:display
    ///    $ sfdx force:org:display -u me@my.org
    ///    $ sfdx force:org:display -u TestOrg1 --json
    ///    $ sfdx force:org:display -u TestOrg1 --json > tmp/MyOrgDesc.json
    /// force:org:display [-u <string>] [--json] [--loglevel <string>] [--verbose]
    /// </example>
    [Command("display")]
      public JToken Display(OrgDisplayOptions p_Options) {
        return ExecuteCommand<OrgDisplayOptions, JToken>(nameof(Display), p_Options);      
      }
    
    /// <summary>
    /// list all orgs you’ve created or authenticated to
    /// </summary>
    /// <remarks>
    /// Lists all orgs that the Salesforce CLI has created or authenticated to.
    /// </remarks>
    /// <example>  
    /// Examples:
    ///    $ sfdx force:org:list
    ///    $ sfdx force:org:list --verbose --json
    ///    $ sfdx force:org:list --verbose --json > tmp/MyOrgList.json
    /// force:org:list [--all] [--clean] [-p] [--json] [--loglevel <string>]
    /// </example>
    [Command("list")]
      public JToken List(OrgListOptions p_Options = null) {
        return ExecuteCommand<OrgListOptions, JToken>(nameof(List), p_Options);      
      }
    
    /// <summary>
    /// open an org in your browser
    /// </summary>
    /// <remarks>
    /// Opens an org in your browser.
    /// </remarks>
    /// <example>  
    /// Opens your default scratch org, or another org that you specify.
    /// 
    /// To open a specific page, specify the portion of the URL after "yourInstance.salesforce.com/" as --path. 
    /// For example, specify "--path lightning" to open Lightning Experience, or specify "--path /apex/YourPage" to open a Visualforce page.
    /// 
    /// To generate a URL but not launch your browser, specify --urlonly.
    /// 
    /// Examples:
    ///   $ sfdx force:org:open
    ///   $ sfdx force:org:open -u me@my.org
    ///   $ sfdx force:org:open -u MyTestOrg1
    ///   $ sfdx force:org:open -r -p lightning
    /// force:org:open [-p <string>] [-r] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("open")]
      public JToken Open(OrgOpenOptions p_Options) {
        return ExecuteCommand<OrgOpenOptions, JToken>(nameof(Open), p_Options);      
      }
    
    /// <summary>
    /// create a snapshot of org edition, features, and licenses
    /// </summary>
    /// <remarks>
    /// Creates a snapshot of org edition, features, and licenses to use for scratch org creation, allowing your scratch org to look like another org for testing.
    /// </remarks>
    /// <example>  
    /// Examples:
    ///    $ sfdx force:org:shape:create -u me@my.org
    ///    $ sfdx force:org:shape:create -u me@my.org --json --loglevel debug
    /// force:org:shape:create [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("shape:create")]
      public JToken ShapeCreate(OrgShapeCreateOptions p_Options) {
        return ExecuteCommand<OrgShapeCreateOptions, JToken>(nameof(ShapeCreate), p_Options);      
      }
    
    /// <summary>
    /// delete all org shapes for a target org
    /// </summary>
    /// <remarks>
    /// Deletes all org shapes that you’ve created for an org using the Salesforce CLI.
    /// </remarks>
    /// <example>  
    /// Examples:
    ///    $ sfdx force:org:shape:delete -u me@my.org
    ///    $ sfdx force:org:shape:delete -u MyOrgAlias -p
    ///    $ sfdx force:org:shape:delete -u me@my.org --json
    ///    $ sfdx force:org:shape:delete -u me@my.org -p --json > tmp/MyOrgShapeDelete.json
    /// force:org:shape:delete -u <string> [-p] [--json] [--loglevel <string>]
    /// </example>
    [Command("shape:delete")]
      public JToken ShapeDelete(OrgShapeDeleteOptions p_Options) {
        return ExecuteCommand<OrgShapeDeleteOptions, JToken>(nameof(ShapeDelete), p_Options);      
      }
    
    /// <summary>
    /// list all org shapes you’ve created
    /// </summary>
    /// <remarks>
    /// Lists all org shapes that you’ve created using the Salesforce CLI.
    /// </remarks>
    /// <example>  
    /// Examples:
    ///    $ sfdx force:org:shape:list
    ///    $ sfdx force:org:shape:list --json
    ///    $ sfdx force:org:shape:list --json > tmp/MyOrgShapeList.json
    /// force:org:shape:list [--json] [--loglevel <string>]
    /// </example>
    [Command("shape:list")]
      public JToken ShapeList(OrgShapeListOptions p_Options = null) {
        return ExecuteCommand<OrgShapeListOptions, JToken>(nameof(ShapeList), p_Options);      
      }
    
  }
}

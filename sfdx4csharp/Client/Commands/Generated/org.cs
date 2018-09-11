// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method create of class Org.
 *
 * IOrgCreate
 */
public class OrgCreateOptions : SFDXOptions {

  /**
   * [Required] The key pair expression for the command
   * @type {string}
   * @memberof OrgCreateOptions
   */
  [SwitchName("")]
  public string expression  {get; set;}

  /**
   * [Required] Environment where the scratch org is created: [sandbox*,virtual,prototype].
   * @type {string}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--env")]
  public string env  {get; set;}

  /**
   * [Required] Sets the streaming client socket timeout, in minutes. If the streaming client socket has no contact from the server for a number of minutes, the client exits. Specify a longer wait time if timeouts occur frequently.
   * @type {string}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Required] Path to a scratch org definition file. Either --definitionfile or --definitionjson is required.
   * @type {string}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--definitionfile")]
  public string definitionfile  {get; set;}

  /**
   * [Optional] Creates the scratch org with no namespace. Useful when using a scratch org to test installations of packages with namespaces.
   * @type {bool}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--nonamespace")]
  public bool? nonamespace  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] Sets the duration of the scratch org, in days. Valid values are from 1-30. The default is 7 days.
   * @type {string}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--durationdays")]
  public string durationdays  {get; set;}

  /**
   * [Optional] Do not include second-generation package ancestors in the scratch org.
   * @type {bool}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--noancestors")]
  public bool? noancestors  {get; set;}

  /**
   * [Required] Scratch org definition in JSON format. Either --definitionfile or --definitionjson is required.
   * @type {string}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--definitionjson")]
  public string definitionjson  {get; set;}

  /**
   * [Required] Sets an alias for for the created scratch org.
   * @type {string}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--setalias")]
  public string setalias  {get; set;}

  /**
   * [Optional] Sets the created org as the default username.
   * @type {bool}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--setdefaultusername")]
  public bool? setdefaultusername  {get; set;}

  /**
   * [Required] Connected app consumer key, as configured in your Dev Hub.
   * @type {string}
   * @memberof OrgCreateOptions
   */
  [SwitchName("--clientid")]
  public string clientid  {get; set;}
}

/**
 * Options for the method delete of class Org.
 *
 * IOrgDelete
 */
public class OrgDeleteOptions : SFDXOptions {

  /**
   * [Required] A username or alias for the target org.
   * @type {string}
   * @memberof OrgDeleteOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof OrgDeleteOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof OrgDeleteOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof OrgDeleteOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Optional] No prompt to confirm deletion.
   * @type {bool}
   * @memberof OrgDeleteOptions
   */
  [SwitchName("--noprompt")]
  public bool? noprompt  {get; set;}
}

/**
 * Options for the method display of class Org.
 *
 * IOrgDisplay
 */
public class OrgDisplayOptions : SFDXOptions {

  /**
   * [Optional] Emit additional command output to stdout.
   * @type {bool}
   * @memberof OrgDisplayOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof OrgDisplayOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof OrgDisplayOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof OrgDisplayOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method list of class Org.
 *
 * IOrgList
 */
public class OrgListOptions : SFDXOptions {

  /**
   * [Optional] Lists more information about each org.
   * @type {bool}
   * @memberof OrgListOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof OrgListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof OrgListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Optional] Do not prompt for confirmation.
   * @type {bool}
   * @memberof OrgListOptions
   */
  [SwitchName("--noprompt")]
  public bool? noprompt  {get; set;}

  /**
   * [Optional] Remove all local org authorizations for deleted or expired orgs.
   * @type {bool}
   * @memberof OrgListOptions
   */
  [SwitchName("--clean")]
  public bool? clean  {get; set;}

  /**
   * [Optional] Lists all authenticated orgs, including expired, deleted, and unknown-status scratch orgs.
   * @type {bool}
   * @memberof OrgListOptions
   */
  [SwitchName("--all")]
  public bool? all  {get; set;}
}

/**
 * Options for the method open of class Org.
 *
 * IOrgOpen
 */
public class OrgOpenOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof OrgOpenOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof OrgOpenOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof OrgOpenOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] Displays a navigation URL, but doesn’t launch your browser.
   * @type {bool}
   * @memberof OrgOpenOptions
   */
  [SwitchName("--urlonly")]
  public bool? urlonly  {get; set;}

  /**
   * [Required] Navigation URL path (not including domain).
   * @type {string}
   * @memberof OrgOpenOptions
   */
  [SwitchName("--path")]
  public string path  {get; set;}
}

/**
 * Options for the method shapeCreate of class Org.
 *
 * IOrgShapeCreate
 */
public class OrgShapeCreateOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof OrgShapeCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof OrgShapeCreateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof OrgShapeCreateOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method shapeDelete of class Org.
 *
 * IOrgShapeDelete
 */
public class OrgShapeDeleteOptions : SFDXOptions {

  /**
   * [Required] Username for the target org.
   * @type {string}
   * @memberof OrgShapeDeleteOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof OrgShapeDeleteOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof OrgShapeDeleteOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Optional] Do not prompt for confirmation.
   * @type {bool}
   * @memberof OrgShapeDeleteOptions
   */
  [SwitchName("--noprompt")]
  public bool? noprompt  {get; set;}
}

/**
 * Options for the method shapeList of class Org.
 *
 * IOrgShapeList
 */
public class OrgShapeListOptions : SFDXOptions {

  /**
   * [Optional] Lists more information about each org shape.
   * @type {bool}
   * @memberof OrgShapeListOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof OrgShapeListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof OrgShapeListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}
}


/**
 * Org
 *
 * @class Org
 */
[CommandClass("force:org")]
public class Org : SFDXCommand {
        /// <inheritDoc />
    public Org(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * create a scratch org
   * @returns {(Promise<Object | void>)}
   * @memberof Org
   * @description Creates a scratch org using values specified in a configuration file or key=value pairs that you specify on the command line. Values specified on the command line override values in the configuration file.
   * @example To set up a connected app for your new scratch org, specify the value that was returned when you created a connected app in your Dev Hub org as --clientid.
   * 
   * Examples:
   *    $ sfdx force:org:create -f config/enterprise-scratch-def.json -a TestOrg1
   *    $ sfdx force:org:create -a MyDevOrg -s -v me@myhub.org edition=Developer
   *    $ sfdx force:org:create -f config/enterprise-scratch-def.json -a OrgWithOverrides username=testuser1@mycompany.org
   * force:org:create name=value... [-f <filepath>] [-n] [-c] [-i <string>] [-s] [-a <string>] [-w <minutes>] [-d <number>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("create")]
    public JToken create(OrgCreateOptions p_Options) {
      return ExecuteCommand<OrgCreateOptions, JToken>(nameof(create), p_Options);      
    }
  
  /**
   * mark a scratch org for deletion
   * @returns {(Promise<Object | void>)}
   * @memberof Org
   * @description Marks a scratch org for deletion.
   * @example To mark the org for deletion without being prompted to confirm, specify --noprompt.
   * 
   * Examples:
   *    $ sfdx force:org:delete -u me@my.org
   *    $ sfdx force:org:delete -u MyOrgAlias -p
   * force:org:delete -u <string> [-p] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("delete")]
    public JToken delete(OrgDeleteOptions p_Options) {
      return ExecuteCommand<OrgDeleteOptions, JToken>(nameof(delete), p_Options);      
    }
  
  /**
   * get org description
   * @returns {(Promise<Object | void>)}
   * @memberof Org
   * @description Gets the description for the current or target org.
   * @example Output includes your access token, client ID, connected status, org ID, instance URL, username, and alias, if applicable. 
   * 
   * Use --verbose to include the SFDX auth URL. Including --verbose displays the sfdxAuthUrl property only if you authenticated to the org using force:auth:web:login (not force:auth:jwt:grant).
   * 
   * Examples:
   *    $ sfdx force:org:display
   *    $ sfdx force:org:display -u me@my.org
   *    $ sfdx force:org:display -u TestOrg1 --json
   *    $ sfdx force:org:display -u TestOrg1 --json > tmp/MyOrgDesc.json
   * force:org:display [-u <string>] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("display")]
    public JToken display(OrgDisplayOptions p_Options) {
      return ExecuteCommand<OrgDisplayOptions, JToken>(nameof(display), p_Options);      
    }
  
  /**
   * list all orgs you’ve created or authenticated to
   * @returns {(Promise<Object | void>)}
   * @memberof Org
   * @description Lists all orgs that the Salesforce CLI has created or authenticated to.
   * @example Examples:
   *    $ sfdx force:org:list
   *    $ sfdx force:org:list --verbose --json
   *    $ sfdx force:org:list --verbose --json > tmp/MyOrgList.json
   * force:org:list [--all] [--clean] [-p] [--json] [--loglevel <string>]
   */
   [Command("list")]
    public JToken list(OrgListOptions p_Options = null) {
      return ExecuteCommand<OrgListOptions, JToken>(nameof(list), p_Options);      
    }
  
  /**
   * open an org in your browser
   * @returns {(Promise<Object | void>)}
   * @memberof Org
   * @description Opens an org in your browser.
   * @example Opens your default scratch org, or another org that you specify.
   * 
   * To open a specific page, specify the portion of the URL after "yourInstance.salesforce.com/" as --path. 
   * For example, specify "--path lightning" to open Lightning Experience, or specify "--path /apex/YourPage" to open a Visualforce page.
   * 
   * To generate a URL but not launch your browser, specify --urlonly.
   * 
   * Examples:
   *   $ sfdx force:org:open
   *   $ sfdx force:org:open -u me@my.org
   *   $ sfdx force:org:open -u MyTestOrg1
   *   $ sfdx force:org:open -r -p lightning
   * force:org:open [-p <string>] [-r] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("open")]
    public JToken open(OrgOpenOptions p_Options) {
      return ExecuteCommand<OrgOpenOptions, JToken>(nameof(open), p_Options);      
    }
  
  /**
   * create a snapshot of org edition, features, and licenses
   * @returns {(Promise<Object | void>)}
   * @memberof Org
   * @description Creates a snapshot of org edition, features, and licenses to use for scratch org creation, allowing your scratch org to look like another org for testing.
   * @example Examples:
   *    $ sfdx force:org:shape:create -u me@my.org
   *    $ sfdx force:org:shape:create -u me@my.org --json --loglevel debug
   * force:org:shape:create [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("shape:create")]
    public JToken shapeCreate(OrgShapeCreateOptions p_Options) {
      return ExecuteCommand<OrgShapeCreateOptions, JToken>(nameof(shapeCreate), p_Options);      
    }
  
  /**
   * delete all org shapes for a target org
   * @returns {(Promise<Object | void>)}
   * @memberof Org
   * @description Deletes all org shapes that you’ve created for an org using the Salesforce CLI.
   * @example Examples:
   *    $ sfdx force:org:shape:delete -u me@my.org
   *    $ sfdx force:org:shape:delete -u MyOrgAlias -p
   *    $ sfdx force:org:shape:delete -u me@my.org --json
   *    $ sfdx force:org:shape:delete -u me@my.org -p --json > tmp/MyOrgShapeDelete.json
   * force:org:shape:delete -u <string> [-p] [--json] [--loglevel <string>]
   */
   [Command("shape:delete")]
    public JToken shapeDelete(OrgShapeDeleteOptions p_Options) {
      return ExecuteCommand<OrgShapeDeleteOptions, JToken>(nameof(shapeDelete), p_Options);      
    }
  
  /**
   * list all org shapes you’ve created
   * @returns {(Promise<Object | void>)}
   * @memberof Org
   * @description Lists all org shapes that you’ve created using the Salesforce CLI.
   * @example Examples:
   *    $ sfdx force:org:shape:list
   *    $ sfdx force:org:shape:list --json
   *    $ sfdx force:org:shape:list --json > tmp/MyOrgShapeList.json
   * force:org:shape:list [--json] [--loglevel <string>]
   */
   [Command("shape:list")]
    public JToken shapeList(OrgShapeListOptions p_Options = null) {
      return ExecuteCommand<OrgShapeListOptions, JToken>(nameof(shapeList), p_Options);      
    }
  
}

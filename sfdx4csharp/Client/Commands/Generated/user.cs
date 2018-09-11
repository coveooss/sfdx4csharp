// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method create of class User.
 *
 * IUserCreate
 */
public class UserCreateOptions : SFDXOptions {

  /**
   * [Required] The key pair expression for the command
   * @type {string}
   * @memberof UserCreateOptions
   */
  [SwitchName("")]
  public string expression  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof UserCreateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof UserCreateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof UserCreateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof UserCreateOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Sets an alias for the created username to reference within the CLI.
   * @type {string}
   * @memberof UserCreateOptions
   */
  [SwitchName("--setalias")]
  public string setalias  {get; set;}

  /**
   * [Required] File path to a user definition.
   * @type {string}
   * @memberof UserCreateOptions
   */
  [SwitchName("--definitionfile")]
  public string definitionfile  {get; set;}
}

/**
 * Options for the method display of class User.
 *
 * IUserDisplay
 */
public class UserDisplayOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof UserDisplayOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof UserDisplayOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof UserDisplayOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof UserDisplayOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method list of class User.
 *
 * IUserList
 */
public class UserListOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof UserListOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof UserListOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof UserListOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof UserListOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}
}

/**
 * Options for the method passwordGenerate of class User.
 *
 * IUserPasswordGenerate
 */
public class UserPasswordGenerateOptions : SFDXOptions {

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof UserPasswordGenerateOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof UserPasswordGenerateOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
   * @type {string}
   * @memberof UserPasswordGenerateOptions
   */
  [SwitchName("--targetdevhubusername")]
  public string targetdevhubusername  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof UserPasswordGenerateOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] A comma-separated list of usernames for which to generate passwords.
   * @type {string}
   * @memberof UserPasswordGenerateOptions
   */
  [SwitchName("--onbehalfof")]
  public string onbehalfof  {get; set;}
}

/**
 * Options for the method permsetAssign of class User.
 *
 * IUserPermsetAssign
 */
public class UserPermsetAssignOptions : SFDXOptions {

  /**
   * [Required] The name of the permission set to assign.
   * @type {string}
   * @memberof UserPermsetAssignOptions
   */
  [SwitchName("--permsetname")]
  public string permsetname  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof UserPermsetAssignOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof UserPermsetAssignOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof UserPermsetAssignOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] Comma-separated list of usernames or aliases to assign the permission set to.
   * @type {string}
   * @memberof UserPermsetAssignOptions
   */
  [SwitchName("--onbehalfof")]
  public string onbehalfof  {get; set;}
}


/**
 * User
 *
 * @class User
 */
[CommandClass("force:user")]
public class User : SFDXCommand {
        /// <inheritDoc />
    public User(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * create a user for a scratch org
   * @returns {(Promise<Object | void>)}
   * @memberof User
   * @description Creates a user for a scratch org.
   * @example Create a user for a scratch org, optionally setting an alias for use by the CLI, assigning permission sets (e.g., permsets=ps1,ps2), generating a password (e.g., generatepassword=true), and setting User sObject fields.
   * 
   * Examples:
   *    $ sfdx force:user:create
   *    $ sfdx force:user:create -a testuser1 -f config/project-user-def.json
   *    $ sfdx force:user:create username=testuser1@my.org email=me@my.org permsets=DreamHouse
   *    $ sfdx force:user:create -f config/project-user-def.json email=me@my.org generatepassword=true
   * force:user:create name=value... [-f <filepath>] [-a <string>] [-u <string>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("create")]
    public JToken create(UserCreateOptions p_Options) {
      return ExecuteCommand<UserCreateOptions, JToken>(nameof(create), p_Options);      
    }
  
  /**
   * displays information about a user of a scratch org
   * @returns {(Promise<Object | void>)}
   * @memberof User
   * @description Displays information about a user of a scratch org that the Salesforce CLI has created or authenticated.
   * @example Output includes the profile name, org ID, access token, instance URL, login URL, and alias if applicable.
   * Examples:
   *    $ sfdx force:user:display
   *    $ sfdx force:user:display -u me@my.org --json
   * force:user:display [-u <string>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("display")]
    public JToken display(UserDisplayOptions p_Options) {
      return ExecuteCommand<UserDisplayOptions, JToken>(nameof(display), p_Options);      
    }
  
  /**
   * lists all users of a scratch org
   * @returns {(Promise<Object | void>)}
   * @memberof User
   * @description Lists all users of a scratch org that the Salesforce CLI has created or authenticated.
   * @example The original scratch org admin is marked with "(A)"
   * Examples:
   *    $ sfdx force:user:list
   *    $ sfdx force:user:list -u me@my.org --json
   *    $ sfdx force:user:list --json > tmp/MyUserList.json
   * force:user:list [-u <string>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("list")]
    public JToken list(UserListOptions p_Options) {
      return ExecuteCommand<UserListOptions, JToken>(nameof(list), p_Options);      
    }
  
  /**
   * generate a password for scratch org users
   * @returns {(Promise<Object | void>)}
   * @memberof User
   * @description Generates a password for scratch org users. Targets the usernames listed with the --onbehalfof parameter or the --targetusername parameter. Defaults to the defaultusername.
   * @example Generates and sets a random password for one or more scratch org users.
   * 
   * If you haven’t set a default Dev Hub, or if your scratch org isn’t associated with your default Dev Hub, --targetdevhubusername is required.
   * 
   * To see a password that was previously generated, run "sfdx force:user:display".
   * 
   * Examples:
   *    $ sfdx force:user:password:generate
   *    $ sfdx force:user:password:generate -u me@my.org --json
   *    $ sfdx force:user:password:generate -o user1@my.org,user2@my.org,user3@my.org
   * force:user:password:generate [-o <string>...] [-u <string>] [-v <string>] [--json] [--loglevel <string>]
   */
   [Command("password:generate")]
    public JToken passwordGenerate(UserPasswordGenerateOptions p_Options) {
      return ExecuteCommand<UserPasswordGenerateOptions, JToken>(nameof(passwordGenerate), p_Options);      
    }
  
  /**
   * assign a permission set to one or more users of an org
   * @returns {(Promise<Object | void>)}
   * @memberof User
   * @description Assigns a named permission set to one or more users of an org.
   * @example Defaults to the defaultusername.
   * 
   * Examples:
   *    $ sfdx force:user:permset:assign -n DreamHouse
   *    $ sfdx force:user:permset:assign -n DreamHouse -u me@my.org
   *    $ sfdx force:user:permset:assign -n DreamHouse -o user1@my.org,user2,user3
   * force:user:permset:assign -n <string> [-o <string>...] [-u <string>] [--json] [--loglevel <string>]
   */
   [Command("permset:assign")]
    public JToken permsetAssign(UserPermsetAssignOptions p_Options) {
      return ExecuteCommand<UserPermsetAssignOptions, JToken>(nameof(permsetAssign), p_Options);      
    }
  
}

// Generated on September 11th 2018, 5:23:30 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  
  /// <summary>
  /// Options for the method create of class User.
  /// </summary>
  public class UserCreateOptions : SFDXOptions {
  
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
    /// [Required] A username or alias for the target Dev Hub org. Overrides the default Dev Hub org.
    /// </summary>  
    [SwitchName("--targetdevhubusername")]
    public string targetdevhubusername  {get; set;}
  
    /// <summary>
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Required] Sets an alias for the created username to reference within the CLI.
    /// </summary>  
    [SwitchName("--setalias")]
    public string setalias  {get; set;}
  
    /// <summary>
    /// [Required] File path to a user definition.
    /// </summary>  
    [SwitchName("--definitionfile")]
    public string definitionfile  {get; set;}
  }
  
  /// <summary>
  /// Options for the method display of class User.
  /// </summary>
  public class UserDisplayOptions : SFDXOptions {
  
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
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  }
  
  /// <summary>
  /// Options for the method list of class User.
  /// </summary>
  public class UserListOptions : SFDXOptions {
  
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
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  }
  
  /// <summary>
  /// Options for the method passwordGenerate of class User.
  /// </summary>
  public class UserPasswordGenerateOptions : SFDXOptions {
  
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
    /// [Required] A username or alias for the target org. Overrides the default target org.
    /// </summary>  
    [SwitchName("--targetusername")]
    public string targetusername  {get; set;}
  
    /// <summary>
    /// [Required] A comma-separated list of usernames for which to generate passwords.
    /// </summary>  
    [SwitchName("--onbehalfof")]
    public string onbehalfof  {get; set;}
  }
  
  /// <summary>
  /// Options for the method permsetAssign of class User.
  /// </summary>
  public class UserPermsetAssignOptions : SFDXOptions {
  
    /// <summary>
    /// [Required] The name of the permission set to assign.
    /// </summary>  
    [SwitchName("--permsetname")]
    public string permsetname  {get; set;}
  
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
    /// [Required] Comma-separated list of usernames or aliases to assign the permission set to.
    /// </summary>  
    [SwitchName("--onbehalfof")]
    public string onbehalfof  {get; set;}
  }
  

  /// <summary>
  /// User
  /// </summary>
  [CommandClass("force:user")]
  public class User : SFDXCommand {

    /// Constructor.
    public User(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// create a user for a scratch org
    /// </summary>
    /// <remarks>
    /// Creates a user for a scratch org.
    /// </remarks>
    /// <example>  
    /// Create a user for a scratch org, optionally setting an alias for use by the CLI, assigning permission sets (e.g., permsets=ps1,ps2), generating a password (e.g., generatepassword=true), and setting User sObject fields.
    /// 
    /// Examples:
    ///    $ sfdx force:user:create
    ///    $ sfdx force:user:create -a testuser1 -f config/project-user-def.json
    ///    $ sfdx force:user:create username=testuser1@my.org email=me@my.org permsets=DreamHouse
    ///    $ sfdx force:user:create -f config/project-user-def.json email=me@my.org generatepassword=true
    /// force:user:create name=value... [-f <filepath>] [-a <string>] [-u <string>] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("create")]
      public JToken create(UserCreateOptions p_Options) {
        return ExecuteCommand<UserCreateOptions, JToken>(nameof(create), p_Options);      
      }
    
    /// <summary>
    /// displays information about a user of a scratch org
    /// </summary>
    /// <remarks>
    /// Displays information about a user of a scratch org that the Salesforce CLI has created or authenticated.
    /// </remarks>
    /// <example>  
    /// Output includes the profile name, org ID, access token, instance URL, login URL, and alias if applicable.
    /// Examples:
    ///    $ sfdx force:user:display
    ///    $ sfdx force:user:display -u me@my.org --json
    /// force:user:display [-u <string>] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("display")]
      public JToken display(UserDisplayOptions p_Options) {
        return ExecuteCommand<UserDisplayOptions, JToken>(nameof(display), p_Options);      
      }
    
    /// <summary>
    /// lists all users of a scratch org
    /// </summary>
    /// <remarks>
    /// Lists all users of a scratch org that the Salesforce CLI has created or authenticated.
    /// </remarks>
    /// <example>  
    /// The original scratch org admin is marked with "(A)"
    /// Examples:
    ///    $ sfdx force:user:list
    ///    $ sfdx force:user:list -u me@my.org --json
    ///    $ sfdx force:user:list --json > tmp/MyUserList.json
    /// force:user:list [-u <string>] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("list")]
      public JToken list(UserListOptions p_Options) {
        return ExecuteCommand<UserListOptions, JToken>(nameof(list), p_Options);      
      }
    
    /// <summary>
    /// generate a password for scratch org users
    /// </summary>
    /// <remarks>
    /// Generates a password for scratch org users. Targets the usernames listed with the --onbehalfof parameter or the --targetusername parameter. Defaults to the defaultusername.
    /// </remarks>
    /// <example>  
    /// Generates and sets a random password for one or more scratch org users.
    /// 
    /// If you haven’t set a default Dev Hub, or if your scratch org isn’t associated with your default Dev Hub, --targetdevhubusername is required.
    /// 
    /// To see a password that was previously generated, run "sfdx force:user:display".
    /// 
    /// Examples:
    ///    $ sfdx force:user:password:generate
    ///    $ sfdx force:user:password:generate -u me@my.org --json
    ///    $ sfdx force:user:password:generate -o user1@my.org,user2@my.org,user3@my.org
    /// force:user:password:generate [-o <string>...] [-u <string>] [-v <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("password:generate")]
      public JToken passwordGenerate(UserPasswordGenerateOptions p_Options) {
        return ExecuteCommand<UserPasswordGenerateOptions, JToken>(nameof(passwordGenerate), p_Options);      
      }
    
    /// <summary>
    /// assign a permission set to one or more users of an org
    /// </summary>
    /// <remarks>
    /// Assigns a named permission set to one or more users of an org.
    /// </remarks>
    /// <example>  
    /// Defaults to the defaultusername.
    /// 
    /// Examples:
    ///    $ sfdx force:user:permset:assign -n DreamHouse
    ///    $ sfdx force:user:permset:assign -n DreamHouse -u me@my.org
    ///    $ sfdx force:user:permset:assign -n DreamHouse -o user1@my.org,user2,user3
    /// force:user:permset:assign -n <string> [-o <string>...] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("permset:assign")]
      public JToken permsetAssign(UserPermsetAssignOptions p_Options) {
        return ExecuteCommand<UserPermsetAssignOptions, JToken>(nameof(permsetAssign), p_Options);      
      }
    
  }
}

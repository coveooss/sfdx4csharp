// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method create of class User.
    /// </summary>
    public class UserCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] Set an alias for the created username to reference within the CLI
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Required] File path to a user definition
        /// </summary>
        [SwitchName("--definitionfile")]
        public string definitionfile { get; set; }

        /// <summary>
        /// [Optional] Force the username, if specified in the definition file or at the command line, to be unique by appending the org ID
        /// </summary>
        [SwitchName("--setuniqueusername")]
        public bool? setuniqueusername { get; set; }
    }

    /// <summary>
    /// Options for the method display of class User.
    /// </summary>
    public class UserDisplayOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method list of class User.
    /// </summary>
    public class UserListOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method passwordGenerate of class User.
    /// </summary>
    public class UserPasswordGenerateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the dev hub org; overrides default dev hub org
        /// </summary>
        [SwitchName("--targetdevhubusername")]
        public string targetdevhubusername { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of usernames or aliases to assign the password to
        /// </summary>
        [SwitchName("--onbehalfof")]
        public string onbehalfof { get; set; }

        /// <summary>
        /// [Required] Number of characters in the generated password; valid values are between 8 and 1000
        /// </summary>
        [SwitchName("--length")]
        public string length { get; set; }

        /// <summary>
        /// [Required] Level of password complexity or strength; the higher the value, the stronger the password
        /// </summary>
        [SwitchName("--complexity")]
        public string complexity { get; set; }
    }

    /// <summary>
    /// Options for the method permsetAssign of class User.
    /// </summary>
    public class UserPermsetAssignOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of permission sets to assign
        /// </summary>
        [SwitchName("--permsetname")]
        public string permsetname { get; set; }

        /// <summary>
        /// [Optional] Logging level for this command invocation
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] Username or alias for the target org; overrides default target org
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of usernames or aliases to assign the permission set to
        /// </summary>
        [SwitchName("--onbehalfof")]
        public string onbehalfof { get; set; }
    }

    /// <summary>
    /// User
    /// </summary>
    [CommandClass("force:user")]
    public class User : SFDXCommand
    {
        /// Constructor.
        public User(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// create a user for a scratch org
        /// Create a user for a scratch org, optionally setting an alias for use by the CLI, assigning permission sets (e.g., permsets=ps1,ps2), generating a password (e.g., generatepassword=true), and setting User sObject fields.
        /// </summary>
        /// <remarks>
        /// create a user for a scratch org
        /// Create a user for a scratch org, optionally setting an alias for use by the CLI, assigning permission sets (e.g., permsets=ps1,ps2), generating a password (e.g., generatepassword=true), and setting User sObject fields.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:user:create
        /// sfdx force:user:create -a testuser1 -f config/project-user-def.json profileName='Chatter Free User'
        /// sfdx force:user:create username=testuser1@my.org email=me@my.org permsets=DreamHouse
        /// sfdx force:user:create -f config/project-user-def.json email=me@my.org generatepassword=true
        /// force:user:create [name=value...] [-a <string>] [-f <string>] [-s] [-v <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("create")]
        public SFDXResponse Create(UserCreateOptions p_Options)
        {
            return ExecuteCommand<UserCreateOptions>(nameof(Create), p_Options);
        }

        /// <summary>
        /// displays information about a user of a scratch org
        /// Output includes the profile name, org ID, access token, instance URL, login URL, and alias if applicable.
        /// </summary>
        /// <remarks>
        /// displays information about a user of a scratch org
        /// Output includes the profile name, org ID, access token, instance URL, login URL, and alias if applicable.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:user:display
        /// sfdx force:user:display -u me@my.org --json
        /// force:user:display [-v <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("display")]
        public SFDXResponse Display(UserDisplayOptions p_Options)
        {
            return ExecuteCommand<UserDisplayOptions>(nameof(Display), p_Options);
        }

        /// <summary>
        /// list all authenticated users of an org
        /// The original scratch org admin is marked with "(A)"
        /// </summary>
        /// <remarks>
        /// list all authenticated users of an org
        /// The original scratch org admin is marked with "(A)"
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:user:list
        /// sfdx force:user:list -u me@my.org --json
        /// sfdx force:user:list --json > tmp/MyUserList.json
        /// force:user:list [-v <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("list")]
        public SFDXResponse List(UserListOptions p_Options)
        {
            return ExecuteCommand<UserListOptions>(nameof(List), p_Options);
        }

        /// <summary>
        /// generate a password for scratch org users
        /// Generates and sets a random password for one or more scratch org users. Targets the usernames listed with the --onbehalfof parameter or the --targetusername parameter. Defaults to the defaultusername.
        /// 
        /// If you haven’t set a default Dev Hub, or if your scratch org isn’t associated with your default Dev Hub, --targetdevhubusername is required.
        /// 
        /// To change the password strength, set the --complexity parameter to a value between 0 and 5. 
        /// Each value specifies the types of characters used in the generated password: 
        /// 
        /// 0 - lower case letters only.
        /// 1 - lower case letters and numbers only.
        /// 2 - lower case letters and symbols only.
        /// 3 - lower and upper case letters and numbers only
        /// 4 - lower and upper case letters and symbols only
        /// 5 - lower and upper case letters and numbers and symbols only 
        /// 
        /// To see a password that was previously generated, run "sfdx force:user:display".
        /// </summary>
        /// <remarks>
        /// generate a password for scratch org users
        /// Generates and sets a random password for one or more scratch org users. Targets the usernames listed with the --onbehalfof parameter or the --targetusername parameter. Defaults to the defaultusername.
        /// 
        /// If you haven’t set a default Dev Hub, or if your scratch org isn’t associated with your default Dev Hub, --targetdevhubusername is required.
        /// 
        /// To change the password strength, set the --complexity parameter to a value between 0 and 5. 
        /// Each value specifies the types of characters used in the generated password: 
        /// 
        /// 0 - lower case letters only.
        /// 1 - lower case letters and numbers only.
        /// 2 - lower case letters and symbols only.
        /// 3 - lower and upper case letters and numbers only
        /// 4 - lower and upper case letters and symbols only
        /// 5 - lower and upper case letters and numbers and symbols only 
        /// 
        /// To see a password that was previously generated, run "sfdx force:user:display".
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:user:password:generate
        /// sfdx force:user:password:generate -l 12
        /// sfdx force:user:password:generate -c 3
        /// sfdx force:user:password:generate -u me@my.org --json
        /// sfdx force:user:password:generate -o "user1@my.org,user2@my.org,user3@my.org"
        /// force:user:password:generate [-o <array>] [-l <integer>] [-c <integer>] [-v <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("password:generate")]
        public SFDXResponse PasswordGenerate(UserPasswordGenerateOptions p_Options)
        {
            return ExecuteCommand<UserPasswordGenerateOptions>(nameof(PasswordGenerate), p_Options);
        }

        /// <summary>
        /// assign a permission set to one or more users of an org
        /// To specify an alias for the -u or -o parameter, use the username alias you set with the "alias:set" CLI command, not the User.Alias value of the org user.
        /// </summary>
        /// <remarks>
        /// assign a permission set to one or more users of an org
        /// To specify an alias for the -u or -o parameter, use the username alias you set with the "alias:set" CLI command, not the User.Alias value of the org user.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:user:permset:assign -n "DreamHouse, LargeDreamHouse"
        /// sfdx force:user:permset:assign -n DreamHouse -u me@my.org
        /// sfdx force:user:permset:assign -n DreamHouse -o "user1@my.org,user2,user3"
        /// force:user:permset:assign -n <array> [-o <array>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("permset:assign")]
        public SFDXResponse PermsetAssign(UserPermsetAssignOptions p_Options)
        {
            return ExecuteCommand<UserPermsetAssignOptions>(nameof(PermsetAssign), p_Options);
        }
    }
}

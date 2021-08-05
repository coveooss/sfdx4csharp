// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method clone of class Org.
    /// </summary>
    public class OrgCloneOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The type of org to create. Only "sandbox" is supported.
        /// </summary>
        [SwitchName("--type")]
        public string type { get; set; }

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
        /// [Required] The path to an org definition file. Either --definitionfile or a vararg value for edition (for example, edition=Developer) is required. Varargs override the values in the scratch org definition file.
        /// </summary>
        [SwitchName("--definitionfile")]
        public string definitionfile { get; set; }

        /// <summary>
        /// [Required] An org definition in JSON format. Either --definitionfile or --definitionjson is required.
        /// </summary>
        [SwitchName("--definitionjson")]
        public string definitionjson { get; set; }

        /// <summary>
        /// [Optional] Sets the created org as the default username.
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] An alias for the created org.
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Optional] Sets the streaming client socket timeout, in minutes. If the streaming client socket has no contact from the server for a number of minutes, the client exits. Specify a longer wait time if timeouts occur frequently.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }
    }

    /// <summary>
    /// Options for the method create of class Org.
    /// </summary>
    public class OrgCreateOptions : SFDXOptions
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
        /// [Required] Type of org to create
        /// </summary>
        [SwitchName("--type")]
        public string type { get; set; }

        /// <summary>
        /// [Required] Path to an org definition file
        /// </summary>
        [SwitchName("--definitionfile")]
        public string definitionfile { get; set; }

        /// <summary>
        /// [Required] Org definition in JSON format
        /// </summary>
        [SwitchName("--definitionjson")]
        public string definitionjson { get; set; }

        /// <summary>
        /// [Optional] Create the scratch org with no namespace
        /// </summary>
        [SwitchName("--nonamespace")]
        public bool? nonamespace { get; set; }

        /// <summary>
        /// [Optional] Do not include second-generation package ancestors in the scratch org
        /// </summary>
        [SwitchName("--noancestors")]
        public bool? noancestors { get; set; }

        /// <summary>
        /// [Required] Connected app consumer key; not supported for sandbox org creation
        /// </summary>
        [SwitchName("--clientid")]
        public string clientid { get; set; }

        /// <summary>
        /// [Optional] Set the created org as the default username
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] Alias for the created org
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Required] Environment where the scratch org is created: sandbox*,virtual,prototype
        /// </summary>
        [SwitchName("--env")]
        public string env { get; set; }

        /// <summary>
        /// [Optional] The streaming client socket timeout (in minutes)
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Optional] Duration of the scratch org (in days) (default:7, min:1, max:30)
        /// </summary>
        [SwitchName("--durationdays")]
        public int? durationdays { get; set; }
    }

    /// <summary>
    /// Options for the method delete of class Org.
    /// </summary>
    public class OrgDeleteOptions : SFDXOptions
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
        /// [Optional] No prompt to confirm deletion
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Options for the method display of class Org.
    /// </summary>
    public class OrgDisplayOptions : SFDXOptions
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
        /// [Optional] Emit additional command output to stdout
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method list of class Org.
    /// </summary>
    public class OrgListOptions : SFDXOptions
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
        /// [Optional] List more information about each org'
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Optional] Include expired, deleted, and unknown-status scratch orgs
        /// </summary>
        [SwitchName("--all")]
        public bool? all { get; set; }

        /// <summary>
        /// [Optional] Remove all local org authorizations for non-active orgs
        /// </summary>
        [SwitchName("--clean")]
        public bool? clean { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for confirmation
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }

        /// <summary>
        /// [Optional] Skip retrieving the connection status of non-scratch orgs
        /// </summary>
        [SwitchName("--skipconnectionstatus")]
        public bool? skipconnectionstatus { get; set; }
    }

    /// <summary>
    /// Options for the method open of class Org.
    /// </summary>
    public class OrgOpenOptions : SFDXOptions
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
        /// [Required] Navigation URL path
        /// </summary>
        [SwitchName("--path")]
        public string path { get; set; }

        /// <summary>
        /// [Optional] Display navigation URL, but don’t launch browser
        /// </summary>
        [SwitchName("--urlonly")]
        public bool? urlonly { get; set; }
    }

    /// <summary>
    /// Options for the method shapeCreate of class Org.
    /// </summary>
    public class OrgShapeCreateOptions : SFDXOptions
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
    /// Options for the method shapeDelete of class Org.
    /// </summary>
    public class OrgShapeDeleteOptions : SFDXOptions
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
        /// [Optional] Do not prompt for confirmation
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Options for the method shapeList of class Org.
    /// </summary>
    public class OrgShapeListOptions : SFDXOptions
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
        /// [Optional] List more information about each org shape
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method snapshotCreate of class Org.
    /// </summary>
    public class OrgSnapshotCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The unique name of the snapshot. Use this name to create scratch orgs from the snapshot.
        /// </summary>
        [SwitchName("--snapshotname")]
        public string snapshotname { get; set; }

        /// <summary>
        /// [Required] The org ID, or a locally authenticated username or alias, of the scratch org to snapshot.
        /// </summary>
        [SwitchName("--sourceorg")]
        public string sourceorg { get; set; }

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
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Required] A description of the snapshot. Use this description to document the contents of the snapshot. We suggest that you include a reference point, such as a version control system tag or commit ID.
        /// </summary>
        [SwitchName("--description")]
        public string description { get; set; }
    }

    /// <summary>
    /// Options for the method snapshotDelete of class Org.
    /// </summary>
    public class OrgSnapshotDeleteOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The name or ID (starts with 0Oo) of the snapshot to delete.
        /// </summary>
        [SwitchName("--snapshot")]
        public string snapshot { get; set; }

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
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method snapshotGet of class Org.
    /// </summary>
    public class OrgSnapshotGetOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The name or ID (starts with 0Oo) of the snapshot to retrieve.
        /// </summary>
        [SwitchName("--snapshot")]
        public string snapshot { get; set; }

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
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method snapshotList of class Org.
    /// </summary>
    public class OrgSnapshotListOptions : SFDXOptions
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
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }
    }

    /// <summary>
    /// Options for the method status of class Org.
    /// </summary>
    public class OrgStatusOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The name of the sandbox org whose creation status you want to check.
        /// </summary>
        [SwitchName("--sandboxname")]
        public string sandboxname { get; set; }

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
        /// [Optional] Sets the created org as the default username.
        /// </summary>
        [SwitchName("--setdefaultusername")]
        public bool? setdefaultusername { get; set; }

        /// <summary>
        /// [Required] An alias for the created org.
        /// </summary>
        [SwitchName("--setalias")]
        public string setalias { get; set; }

        /// <summary>
        /// [Optional] The number of minutes to wait for the org to be ready while polling for its creation status.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }
    }

    /// <summary>
    /// Org
    /// </summary>
    [CommandClass("force:org")]
    public class Org : SFDXCommand
    {
        /// Constructor.
        public Org(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// clone a sandbox org
        /// 
        /// Specify a configuration file with a sourceSandboxName or provide key=value pairs while cloning a sandbox. The --targetusername (-u) must be a production org with sandbox licenses. The —type (-t) is required if cloning a sandbox.
        /// 
        /// Examples:
        ///    $ sfdx force:org:clone -t sandbox -f config/dev-sandbox-def.json -u prodOrg -a MyDevSandbox
        ///    $ sfdx force:org:clone -t sandbox sandboxName=DevSbx1 sourceSandboxName=Sbx2Clone -u prodOrg -a MyDevSandbox
        /// </summary>
        /// <remarks>
        /// clone a sandbox org
        /// 
        /// Specify a configuration file with a sourceSandboxName or provide key=value pairs while cloning a sandbox. The --targetusername (-u) must be a production org with sandbox licenses. The —type (-t) is required if cloning a sandbox.
        /// 
        /// Examples:
        ///    $ sfdx force:org:clone -t sandbox -f config/dev-sandbox-def.json -u prodOrg -a MyDevSandbox
        ///    $ sfdx force:org:clone -t sandbox sandboxName=DevSbx1 sourceSandboxName=Sbx2Clone -u prodOrg -a MyDevSandbox
        /// </remarks>
        /// <example>
        /// Specify a configuration file with a sourceSandboxName or provide key=value pairs while cloning a sandbox. The --targetusername (-u) must be a production org with sandbox licenses. The —type (-t) is required if cloning a sandbox.
        /// 
        /// Examples:
        ///    $ sfdx force:org:clone -t sandbox -f config/dev-sandbox-def.json -u prodOrg -a MyDevSandbox
        ///    $ sfdx force:org:clone -t sandbox sandboxName=DevSbx1 sourceSandboxName=Sbx2Clone -u prodOrg -a MyDevSandbox
        /// force:org:clone [name=value...] -t sandbox [-f <filepath>] [-s] [-a <string>] [-w <minutes>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("clone")]
        public SFDXResponse Clone(OrgCloneOptions p_Options)
        {
            return ExecuteCommand<OrgCloneOptions>(nameof(Clone), p_Options);
        }

        /// <summary>
        /// Creates a scratch org or a sandbox org using the values specified in a configuration file or key=value pairs that you specify on the command line. Values specified on the command line override values in the configuration file.
        /// </summary>
        /// <remarks>
        /// Creates a scratch org or a sandbox org using the values specified in a configuration file or key=value pairs that you specify on the command line. Values specified on the command line override values in the configuration file.
        /// </remarks>
        /// <example>
        /// Specify a configuration file or provide key=value pairs while creating a scratch org or a sandbox. When creating scratch orgs, —targetdevhubusername (-v) must be a Dev Hub org. When creating sandboxes, the --targetusername (-u) must be a production org with sandbox licenses. The —type (-t) is required if creating a sandbox.
        /// 
        /// Examples:
        ///    $ sfdx force:org:create -f config/enterprise-scratch-def.json -a MyScratchOrg
        ///    $ sfdx force:org:create edition=Developer -a MyScratchOrg -s -v devHub
        ///    $ sfdx force:org:create -f config/enterprise-scratch-def.json -a ScratchOrgWithOverrides username=testuser1@mycompany.org
        ///    $ sfdx force:org:create -t sandbox -f config/dev-sandbox-def.json -a MyDevSandbox -u prodOrg
        /// force:org:create [name=value...] [-t scratch|sandbox] [-f <filepath>] [-n] [-c] [-i <string>] [-s] [-a <string>] [-w <minutes>] [-d <integer>] [-v <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("create")]
        public SFDXResponse Create(OrgCreateOptions p_Options)
        {
            return ExecuteCommand<OrgCreateOptions>(nameof(Create), p_Options);
        }

        /// <summary>
        /// mark a scratch or sandbox org for deletion
        /// </summary>
        /// <remarks>
        /// mark a scratch or sandbox org for deletion
        /// </remarks>
        /// <example>
        /// To mark the org for deletion without being prompted to confirm, specify --noprompt. 
        /// 
        /// Examples:
        ///    $ sfdx force:org:delete -u me@my.org
        ///    $ sfdx force:org:delete -u MyOrgAlias -p
        /// force:org:delete [-p] [-v <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("delete")]
        public SFDXResponse Delete(OrgDeleteOptions p_Options)
        {
            return ExecuteCommand<OrgDeleteOptions>(nameof(Delete), p_Options);
        }

        /// <summary>
        /// get the description for the current or target org
        /// Output includes your access token, client Id, connected status, org ID, instance URL, username, and alias, if applicable.
        /// Use --verbose to include the SFDX auth URL.
        /// Including --verbose displays the sfdxAuthUrl property only if you authenticated to the org using auth:web:login (not auth:jwt:grant)
        /// </summary>
        /// <remarks>
        /// get the description for the current or target org
        /// Output includes your access token, client Id, connected status, org ID, instance URL, username, and alias, if applicable.
        /// Use --verbose to include the SFDX auth URL.
        /// Including --verbose displays the sfdxAuthUrl property only if you authenticated to the org using auth:web:login (not auth:jwt:grant)
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:org:display
        /// sfdx force:org:display -u me@my.org
        /// sfdx force:org:display -u TestOrg1 --json
        /// sfdx force:org:display -u TestOrg1 --json > tmp/MyOrgDesc.json
        /// force:org:display [-u <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("display")]
        public SFDXResponse Display(OrgDisplayOptions p_Options)
        {
            return ExecuteCommand<OrgDisplayOptions>(nameof(Display), p_Options);
        }

        /// <summary>
        /// list all orgs you’ve created or authenticated to
        /// </summary>
        /// <remarks>
        /// list all orgs you’ve created or authenticated to
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:org:list
        /// sfdx force:org:list --verbose --json
        /// sfdx force:org:list --verbose --json > tmp/MyOrgList.json
        /// force:org:list [--all] [-p --clean] [--skipconnectionstatus] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("list")]
        public SFDXResponse List(OrgListOptions p_Options)
        {
            return ExecuteCommand<OrgListOptions>(nameof(List), p_Options);
        }

        /// <summary>
        /// open your default scratch org, or another specified org
        /// To open a specific page, specify the portion of the URL after "yourInstance.salesforce.com/" as --path.
        /// For example, specify "--path lightning" to open Lightning Experience, or specify "--path /apex/YourPage" to open a Visualforce page.
        /// To generate a URL but not launch it in your browser, specify --urlonly.
        /// </summary>
        /// <remarks>
        /// open your default scratch org, or another specified org
        /// To open a specific page, specify the portion of the URL after "yourInstance.salesforce.com/" as --path.
        /// For example, specify "--path lightning" to open Lightning Experience, or specify "--path /apex/YourPage" to open a Visualforce page.
        /// To generate a URL but not launch it in your browser, specify --urlonly.
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:org:open
        /// sfdx force:org:open -u me@my.org
        /// sfdx force:org:open -u MyTestOrg1
        /// sfdx force:org:open -r -p lightning
        /// force:org:open [-p <string>] [-r] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("open")]
        public SFDXResponse Open(OrgOpenOptions p_Options)
        {
            return ExecuteCommand<OrgOpenOptions>(nameof(Open), p_Options);
        }

        /// <summary>
        /// Create a scratch org configuration (shape) based on the specified source org
        /// </summary>
        /// <remarks>
        /// Create a scratch org configuration (shape) based on the specified source org
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:org:shape:create -u me@my.org
        /// sfdx force:org:shape:create -u me@my.org --json --loglevel debug
        /// force:org:shape:create [name=value...] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("shape:create")]
        public SFDXResponse ShapeCreate(OrgShapeCreateOptions p_Options)
        {
            return ExecuteCommand<OrgShapeCreateOptions>(nameof(ShapeCreate), p_Options);
        }

        /// <summary>
        /// delete all org shapes for a target org
        /// </summary>
        /// <remarks>
        /// delete all org shapes for a target org
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:org:shape:delete -u me@my.org
        /// sfdx force:org:shape:delete -u MyOrgAlias -p
        /// sfdx force:org:shape:delete -u me@my.org --json
        /// sfdx force:org:shape:delete -u me@my.org -p --json > tmp/MyOrgShapeDelete.json
        /// force:org:shape:delete [-p] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("shape:delete")]
        public SFDXResponse ShapeDelete(OrgShapeDeleteOptions p_Options)
        {
            return ExecuteCommand<OrgShapeDeleteOptions>(nameof(ShapeDelete), p_Options);
        }

        /// <summary>
        /// list all org shapes you’ve created
        /// </summary>
        /// <remarks>
        /// list all org shapes you’ve created
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:org:shape:list
        /// sfdx force:org:shape:list --json
        /// sfdx force:org:shape:list --json > tmp/MyOrgShapeList.json
        /// force:org:shape:list [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("shape:list")]
        public SFDXResponse ShapeList(OrgShapeListOptions p_Options)
        {
            return ExecuteCommand<OrgShapeListOptions>(nameof(ShapeList), p_Options);
        }

        /// <summary>
        /// snapshot a scratch org
        /// 
        /// A snapshot is a point-in-time export of a scratch org. The export is stored in Salesforce and referenced by its unique name in a scratch definition file.
        /// 
        /// Use "sfdx force:org:snapshot:get" to get details, including status, about a snapshot creation request.
        /// 
        /// With "snapshot" in your scratch org definition file, use "sfdx force:org:create" to create a scratch org from a snapshot.
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:create --sourceorg 00Dxx0000000000 --snapshotname Dependencies --description "Contains PackageA v1.1.0"
        /// 
        ///    $ sfdx force:org:snapshot:create -o myuser@myorg -n NightlyBranch -d "Contains PkgA v2.1.0 and PkgB 3.3.0"
        /// </summary>
        /// <remarks>
        /// snapshot a scratch org
        /// 
        /// A snapshot is a point-in-time export of a scratch org. The export is stored in Salesforce and referenced by its unique name in a scratch definition file.
        /// 
        /// Use "sfdx force:org:snapshot:get" to get details, including status, about a snapshot creation request.
        /// 
        /// With "snapshot" in your scratch org definition file, use "sfdx force:org:create" to create a scratch org from a snapshot.
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:create --sourceorg 00Dxx0000000000 --snapshotname Dependencies --description "Contains PackageA v1.1.0"
        /// 
        ///    $ sfdx force:org:snapshot:create -o myuser@myorg -n NightlyBranch -d "Contains PkgA v2.1.0 and PkgB 3.3.0"
        /// </remarks>
        /// <example>
        /// A snapshot is a point-in-time export of a scratch org. The export is stored in Salesforce and referenced by its unique name in a scratch definition file.
        /// 
        /// Use "sfdx force:org:snapshot:get" to get details, including status, about a snapshot creation request.
        /// 
        /// With "snapshot" in your scratch org definition file, use "sfdx force:org:create" to create a scratch org from a snapshot.
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:create --sourceorg 00Dxx0000000000 --snapshotname Dependencies --description "Contains PackageA v1.1.0"
        /// 
        ///    $ sfdx force:org:snapshot:create -o myuser@myorg -n NightlyBranch -d "Contains PkgA v2.1.0 and PkgB 3.3.0"
        /// force:org:snapshot:create -o <string> -n <string> [-d <string>] [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("snapshot:create")]
        public SFDXResponse SnapshotCreate(OrgSnapshotCreateOptions p_Options)
        {
            return ExecuteCommand<OrgSnapshotCreateOptions>(nameof(SnapshotCreate), p_Options);
        }

        /// <summary>
        /// delete a scratch org snapshot
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:delete --snapshot 0Oo...
        /// 
        ///    $ sfdx force:org:snapshot:delete -s BaseSnapshot
        /// </summary>
        /// <remarks>
        /// delete a scratch org snapshot
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:delete --snapshot 0Oo...
        /// 
        ///    $ sfdx force:org:snapshot:delete -s BaseSnapshot
        /// </remarks>
        /// <example>
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:delete --snapshot 0Oo...
        /// 
        ///    $ sfdx force:org:snapshot:delete -s BaseSnapshot
        /// force:org:snapshot:delete -s <string> [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("snapshot:delete")]
        public SFDXResponse SnapshotDelete(OrgSnapshotDeleteOptions p_Options)
        {
            return ExecuteCommand<OrgSnapshotDeleteOptions>(nameof(SnapshotDelete), p_Options);
        }

        /// <summary>
        /// get details about a scratch org snapshot
        /// 
        /// Use "sfdx force:org:snapshot:create" to create a snapshot.
        /// 
        /// Use "sfdx force:org:snapshot:list" to retrieve all snapshots.
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:get --snapshot 0Oo...
        /// 
        ///    $ sfdx force:org:snapshot:get -s Dependencies
        /// </summary>
        /// <remarks>
        /// get details about a scratch org snapshot
        /// 
        /// Use "sfdx force:org:snapshot:create" to create a snapshot.
        /// 
        /// Use "sfdx force:org:snapshot:list" to retrieve all snapshots.
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:get --snapshot 0Oo...
        /// 
        ///    $ sfdx force:org:snapshot:get -s Dependencies
        /// </remarks>
        /// <example>
        /// Use "sfdx force:org:snapshot:create" to create a snapshot.
        /// 
        /// Use "sfdx force:org:snapshot:list" to retrieve all snapshots.
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:get --snapshot 0Oo...
        /// 
        ///    $ sfdx force:org:snapshot:get -s Dependencies
        /// force:org:snapshot:get -s <string> [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("snapshot:get")]
        public SFDXResponse SnapshotGet(OrgSnapshotGetOptions p_Options)
        {
            return ExecuteCommand<OrgSnapshotGetOptions>(nameof(SnapshotGet), p_Options);
        }

        /// <summary>
        /// list scratch org snapshots
        /// 
        /// Use "sfdx force:org:snapshot:get" to get details about a snapshot request.
        /// 
        /// Use "sfdx force:org:snapshot:create" to create a snapshot.
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:list
        /// 
        ///    $ sfdx force:org:snapshot:list -v OtherDevHub@example.com
        /// </summary>
        /// <remarks>
        /// list scratch org snapshots
        /// 
        /// Use "sfdx force:org:snapshot:get" to get details about a snapshot request.
        /// 
        /// Use "sfdx force:org:snapshot:create" to create a snapshot.
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:list
        /// 
        ///    $ sfdx force:org:snapshot:list -v OtherDevHub@example.com
        /// </remarks>
        /// <example>
        /// Use "sfdx force:org:snapshot:get" to get details about a snapshot request.
        /// 
        /// Use "sfdx force:org:snapshot:create" to create a snapshot.
        /// 
        /// Examples:
        /// 
        ///    $ sfdx force:org:snapshot:list
        /// 
        ///    $ sfdx force:org:snapshot:list -v OtherDevHub@example.com
        /// force:org:snapshot:list [-v <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("snapshot:list")]
        public SFDXResponse SnapshotList(OrgSnapshotListOptions p_Options)
        {
            return ExecuteCommand<OrgSnapshotListOptions>(nameof(SnapshotList), p_Options);
        }

        /// <summary>
        /// report sandbox org creation status and authenticate to org
        /// 
        /// Use this command to check the status of your sandbox org creation and, if the org is ready, authenticate to the org.
        /// To specify the number of minutes that the command will wait for the sandbox org creation to complete before returning control of the terminal to you, include a -w | --wait value.
        /// 
        /// Examples:
        ///    $ sfdx force:org:status -n YourSandboxName -w 10
        /// </summary>
        /// <remarks>
        /// report sandbox org creation status and authenticate to org
        /// 
        /// Use this command to check the status of your sandbox org creation and, if the org is ready, authenticate to the org.
        /// To specify the number of minutes that the command will wait for the sandbox org creation to complete before returning control of the terminal to you, include a -w | --wait value.
        /// 
        /// Examples:
        ///    $ sfdx force:org:status -n YourSandboxName -w 10
        /// </remarks>
        /// <example>
        /// Use this command to check the status of your sandbox org creation and, if the org is ready, authenticate to the org.
        /// To specify the number of minutes that the command will wait for the sandbox org creation to complete before returning control of the terminal to you, include a -w | --wait value.
        /// 
        /// Examples:
        ///    $ sfdx force:org:status -n YourSandboxName -w 10
        /// force:org:status -n <string> [-s] [-a <string>] [-w <minutes>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("status")]
        public SFDXResponse Status(OrgStatusOptions p_Options)
        {
            return ExecuteCommand<OrgStatusOptions>(nameof(Status), p_Options);
        }
    }
}

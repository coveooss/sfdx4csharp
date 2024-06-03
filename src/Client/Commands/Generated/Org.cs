// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method AssignPermset of class Org.
    /// </summary>
    public class OrgAssignPermsetOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for on-behalf-of
        /// </summary>
        [SwitchName("--on-behalf-of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }
    }

    /// <summary>
    /// Options for the method AssignPermsetlicense of class Org.
    /// </summary>
    public class OrgAssignPermsetlicenseOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for on-behalf-of
        /// </summary>
        [SwitchName("--on-behalf-of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }
    }

    /// <summary>
    /// Options for the method CreateSandbox of class Org.
    /// </summary>
    public class OrgCreateSandboxOptions : SfOptions
    {
        /// <summary>
        /// [Required] When it creates the sandbox org, Salesforce copies the metadata, and optionally data, from your production org to the new sandbox org.
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] The sandbox definition file is a blueprint for the sandbox. You can create different definition files for each sandbox type that you use in the development process. See [https://developer.salesforce.com/docs/atlas.en-us.sfdx_dev.meta/sfdx_dev/sfdx_dev_sandbox_definition.htm] for all the options you can specify in the definition file.
        /// </summary>
        [SwitchName("--definition-file")]
        public string DefinitionFile { get; set; }

        /// <summary>
        /// [Optional] No description for set-default
        /// </summary>
        [SwitchName("--set-default")]
        public bool? SetDefault { get; set; }

        /// <summary>
        /// [Optional] When you create a sandbox, the generated usernames are based on the usernames present in the production org. To ensure uniqueness, the new usernames are appended with the name of the sandbox. For example, the username "user@example.com" in the production org results in the username "user@example.com.mysandbox" in a sandbox named "mysandbox". When you set an alias for a sandbox org, it's assigned to the resulting username of the user running this command.
        /// </summary>
        [SwitchName("--alias")]
        public string Alias { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal to you and displays the "$ sf org resume sandbox" command you run to check the status of the create. The displayed command includes the job ID for the running sandbox creation.
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] No description for poll-interval
        /// </summary>
        [SwitchName("--poll-interval")]
        public int? PollInterval { get; set; }

        /// <summary>
        /// [Optional] The command immediately displays the job ID and returns control of the terminal to you. This way, you can continue to use the CLI. To check the status of the sandbox creation, run "$ sf org resume sandbox".
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] The name must be a unique alphanumeric string (10 or fewer characters) to identify the sandbox. You can’t reuse a name while a sandbox is in the process of being deleted.
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] The value of --clone must be an existing sandbox. The existing sandbox, and the new sandbox specified with the --name flag, must both be associated with the production org (--target-org) that contains the sandbox licenses.
        /// </summary>
        [SwitchName("--clone")]
        public string Clone { get; set; }

        /// <summary>
        /// [Optional] No description for license-type
        /// </summary>
        [SwitchName("--license-type")]
        public string LicenseType { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Optional] We recommend you enable source tracking in Developer and Developer Pro sandbox, which is why it's the default behavior. Source tracking allows you to track the changes you make to your metadata, both in your local project and in the sandbox, and to detect any conflicts between the two.
        /// 
        /// To disable source tracking in the new sandbox, specify the --no-track-source flag. The main reason to disable source tracking is for performance. For example, while you probably want to deploy metadata and run Apex tests in your CI/CD jobs, you probably don't want to incur the costs of source tracking (checking for conflicts, polling the SourceMember object, various file system operations.) This is a good use case for disabling source tracking in the sandbox.
        /// </summary>
        [SwitchName("--no-track-source")]
        public bool? NoTrackSource { get; set; }
    }

    /// <summary>
    /// Options for the method CreateScratch of class Org.
    /// </summary>
    public class OrgCreateScratchOptions : SfOptions
    {
        /// <summary>
        /// [Required] Overrides the value of the target-dev-hub configuration variable, if set.
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] New scratch orgs include one administrator by default. The admin user's username is auto-generated and looks something like test-wvkpnfm5z113@example.com. When you set an alias for a new scratch org, it's assigned this username.
        /// </summary>
        [SwitchName("--alias")]
        public string Alias { get; set; }

        /// <summary>
        /// [Optional] The command immediately displays the job ID and returns control of the terminal to you. This way, you can continue to use the CLI. To resume the scratch org creation, run "$ sf org resume scratch".
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] No description for set-default
        /// </summary>
        [SwitchName("--set-default")]
        public bool? SetDefault { get; set; }

        /// <summary>
        /// [Optional] The scratch org definition file is a blueprint for the scratch org. It mimics the shape of an org that you use in the development life cycle, such as acceptance testing, packaging, or production. See [https://developer.salesforce.com/docs/atlas.en-us.sfdx_dev.meta/sfdx_dev/sfdx_dev_scratch_orgs_def_file.htm] for all the option you can specify in the definition file.
        /// </summary>
        [SwitchName("--definition-file")]
        public string DefinitionFile { get; set; }

        /// <summary>
        /// [Optional] No description for no-ancestors
        /// </summary>
        [SwitchName("--no-ancestors")]
        public bool? NoAncestors { get; set; }

        /// <summary>
        /// [Optional] The editions that begin with "partner-" are available only if the Dev Hub org is a Partner Business Org.
        /// </summary>
        [SwitchName("--edition")]
        public string Edition { get; set; }

        /// <summary>
        /// [Optional] No description for no-namespace
        /// </summary>
        [SwitchName("--no-namespace")]
        public bool? NoNamespace { get; set; }

        /// <summary>
        /// [Optional] No description for duration-days
        /// </summary>
        [SwitchName("--duration-days")]
        public int? DurationDays { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal to you and displays the job ID. To resume the scratch org creation, run the org resume scratch command and pass it the job ID.
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for client-id
        /// </summary>
        [SwitchName("--client-id")]
        public string ClientId { get; set; }

        /// <summary>
        /// [Optional] We recommend you enable source tracking in scratch orgs, which is why it's the default behavior. Source tracking allows you to track the changes you make to your metadata, both in your local project and in the scratch org, and to detect any conflicts between the two.
        /// 
        /// To disable source tracking in the new scratch org, specify the --no-track-source flag. The main reason to disable source tracking is for performance. For example, while you probably want to deploy metadata and run Apex tests in your CI/CD jobs, you probably don't want to incur the costs of source tracking (checking for conflicts, polling the SourceMember object, various file system operations.) This is a good use case for disabling source tracking in the scratch org.
        /// </summary>
        [SwitchName("--track-source")]
        public bool? TrackSource { get; set; }

        /// <summary>
        /// [Optional] The username must be unique within the entire scratch org and sandbox universe. You must add your own logic to ensure uniqueness.
        /// 
        /// Omit this flag to have Salesforce generate a unique username for your org.
        /// </summary>
        [SwitchName("--username")]
        public string Username { get; set; }

        /// <summary>
        /// [Optional] No description for description
        /// </summary>
        [SwitchName("--description")]
        public string Description { get; set; }

        /// <summary>
        /// [Optional] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] By default, scratch orgs are on the same release as the Dev Hub. During Salesforce release transition periods, you can override this default behavior and opt in or out of the new release.
        /// </summary>
        [SwitchName("--release")]
        public string Release { get; set; }

        /// <summary>
        /// [Optional] No description for admin-email
        /// </summary>
        [SwitchName("--admin-email")]
        public string AdminEmail { get; set; }

        /// <summary>
        /// [Optional] No description for source-org
        /// </summary>
        [SwitchName("--source-org")]
        public string SourceOrg { get; set; }
    }

    /// <summary>
    /// Options for the method CreateShape of class Org.
    /// </summary>
    public class OrgCreateShapeOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method CreateSnapshot of class Org.
    /// </summary>
    public class OrgCreateSnapshotOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Required] No description for source-org
        /// </summary>
        [SwitchName("--source-org")]
        public string SourceOrg { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }

        /// <summary>
        /// [Optional] Use this description to document the contents of the snapshot. We suggest that you include a reference point, such as a version control system tag or commit ID.
        /// </summary>
        [SwitchName("--description")]
        public string Description { get; set; }
    }

    /// <summary>
    /// Options for the method CreateUser of class Org.
    /// </summary>
    public class OrgCreateUserOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for set-alias
        /// </summary>
        [SwitchName("--set-alias")]
        public string SetAlias { get; set; }

        /// <summary>
        /// [Optional] The user definition file uses JSON format and can include any Salesforce User sObject field and Salesforce DX-specific options. See https://developer.salesforce.com/docs/atlas.en-us.sfdx_dev.meta/sfdx_dev/sfdx_dev_scratch_orgs_users_def_file.htm for more information.
        /// </summary>
        [SwitchName("--definition-file")]
        public string DefinitionFile { get; set; }

        /// <summary>
        /// [Optional] The new user’s username must be unique across all Salesforce orgs and in the form of an email address. If you let this command generate a username for you, it's guaranteed to be unique. If you specify an existing username in a definition file, the command fails. Set this flag to force the username to be unique; as a result, the username might be different than what you specify in the definition file.
        /// </summary>
        [SwitchName("--set-unique-username")]
        public bool? SetUniqueUsername { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method DeleteSandbox of class Org.
    /// </summary>
    public class OrgDeleteSandboxOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }
    }

    /// <summary>
    /// Options for the method DeleteScratch of class Org.
    /// </summary>
    public class OrgDeleteScratchOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }
    }

    /// <summary>
    /// Options for the method DeleteShape of class Org.
    /// </summary>
    public class OrgDeleteShapeOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }
    }

    /// <summary>
    /// Options for the method DeleteSnapshot of class Org.
    /// </summary>
    public class OrgDeleteSnapshotOptions : SfOptions
    {
        /// <summary>
        /// [Required] The IDs of scratch org snapshots start with 0Oo.
        /// </summary>
        [SwitchName("--snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }
    }

    /// <summary>
    /// Options for the method DisableTracking of class Org.
    /// </summary>
    public class OrgDisableTrackingOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }
    }

    /// <summary>
    /// Options for the method Display of class Org.
    /// </summary>
    public class OrgDisplayOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method DisplayUser of class Org.
    /// </summary>
    public class OrgDisplayUserOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method EnableTracking of class Org.
    /// </summary>
    public class OrgEnableTrackingOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }
    }

    /// <summary>
    /// Options for the method GeneratePassword of class Org.
    /// </summary>
    public class OrgGeneratePasswordOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for on-behalf-of
        /// </summary>
        [SwitchName("--on-behalf-of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// [Optional] No description for length
        /// </summary>
        [SwitchName("--length")]
        public string Length { get; set; }

        /// <summary>
        /// [Optional] No description for complexity
        /// </summary>
        [SwitchName("--complexity")]
        public string Complexity { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }
    }

    /// <summary>
    /// Options for the method GetSnapshot of class Org.
    /// </summary>
    public class OrgGetSnapshotOptions : SfOptions
    {
        /// <summary>
        /// [Required] The IDs of scratch org snapshots start with 0Oo.
        /// </summary>
        [SwitchName("--snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method List of class Org.
    /// </summary>
    public class OrgListOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] No description for all
        /// </summary>
        [SwitchName("--all")]
        public bool? All { get; set; }

        /// <summary>
        /// [Optional] No description for clean
        /// </summary>
        [SwitchName("--clean")]
        public bool? Clean { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Optional] No description for skip-connection-status
        /// </summary>
        [SwitchName("--skip-connection-status")]
        public bool? SkipConnectionStatus { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method ListAuth of class Org.
    /// </summary>
    public class OrgListAuthOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method ListLimits of class Org.
    /// </summary>
    public class OrgListLimitsOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method ListMetadata of class Org.
    /// </summary>
    public class OrgListMetadataOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for metadata-type
        /// </summary>
        [SwitchName("--metadata-type")]
        public string MetadataType { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for output-file
        /// </summary>
        [SwitchName("--output-file")]
        public string OutputFile { get; set; }

        /// <summary>
        /// [Optional] Examples of metadata types that use folders are Dashboard, Document, EmailTemplate, and Report.
        /// </summary>
        [SwitchName("--folder")]
        public string Folder { get; set; }
    }

    /// <summary>
    /// Options for the method ListMetadataTypes of class Org.
    /// </summary>
    public class OrgListMetadataTypesOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] Directing the output to a file makes it easier to extract relevant information for your package.xml manifest file. The default output destination is the terminal or command window console.
        /// </summary>
        [SwitchName("--output-file")]
        public string OutputFile { get; set; }

        /// <summary>
        /// [Optional] No description for filter-known
        /// </summary>
        [SwitchName("--filter-known")]
        public bool? FilterKnown { get; set; }
    }

    /// <summary>
    /// Options for the method ListShape of class Org.
    /// </summary>
    public class OrgListShapeOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method ListSnapshot of class Org.
    /// </summary>
    public class OrgListSnapshotOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-dev-hub
        /// </summary>
        [SwitchName("--target-dev-hub")]
        public string TargetDevHub { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method ListSobjectRecordCounts of class Org.
    /// </summary>
    public class OrgListSobjectRecordCountsOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for sobject
        /// </summary>
        [SwitchName("--sobject")]
        public string Sobject { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method ListUsers of class Org.
    /// </summary>
    public class OrgListUsersOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method LoginAccessToken of class Org.
    /// </summary>
    public class OrgLoginAccessTokenOptions : SfOptions
    {
        /// <summary>
        /// [Required] If you specify an --instance-url value, this value overrides the sfdcLoginUrl value in your sfdx-project.json file.
        /// 
        /// To specify a My Domain URL, use the format "https://[MyDomainName].my.salesforce.com".
        /// 
        /// To specify a sandbox, set --instance-url to "https://[MyDomainName]--[SandboxName].sandbox.my.salesforce.com".
        /// </summary>
        [SwitchName("--instance-url")]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for set-default-dev-hub
        /// </summary>
        [SwitchName("--set-default-dev-hub")]
        public bool? SetDefaultDevHub { get; set; }

        /// <summary>
        /// [Optional] No description for set-default
        /// </summary>
        [SwitchName("--set-default")]
        public bool? SetDefault { get; set; }

        /// <summary>
        /// [Optional] No description for alias
        /// </summary>
        [SwitchName("--alias")]
        public string Alias { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method LoginDevice of class Org.
    /// </summary>
    public class OrgLoginDeviceOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for client-id
        /// </summary>
        [SwitchName("--client-id")]
        public string ClientId { get; set; }

        /// <summary>
        /// [Optional] If you specify an --instance-url value, this value overrides the sfdcLoginUrl value in your sfdx-project.json file.
        /// 
        /// To specify a My Domain URL, use the format "https://[MyDomainName].my.salesforce.com".
        /// 
        /// To specify a sandbox, set --instance-url to "https://[MyDomainName]--[SandboxName].sandbox.my.salesforce.com".
        /// </summary>
        [SwitchName("--instance-url")]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// [Optional] No description for set-default-dev-hub
        /// </summary>
        [SwitchName("--set-default-dev-hub")]
        public bool? SetDefaultDevHub { get; set; }

        /// <summary>
        /// [Optional] No description for set-default
        /// </summary>
        [SwitchName("--set-default")]
        public bool? SetDefault { get; set; }

        /// <summary>
        /// [Optional] No description for alias
        /// </summary>
        [SwitchName("--alias")]
        public string Alias { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method LoginJwt of class Org.
    /// </summary>
    public class OrgLoginJwtOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for client-id
        /// </summary>
        [SwitchName("--client-id")]
        public string ClientId { get; set; }

        /// <summary>
        /// [Required] No description for jwt-key-file
        /// </summary>
        [SwitchName("--jwt-key-file")]
        public string JwtKeyFile { get; set; }

        /// <summary>
        /// [Required] No description for username
        /// </summary>
        [SwitchName("--username")]
        public string Username { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] If you specify an --instance-url value, this value overrides the sfdcLoginUrl value in your sfdx-project.json file.
        /// 
        /// To specify a My Domain URL, use the format "https://[MyDomainName].my.salesforce.com".
        /// 
        /// To specify a sandbox, set --instance-url to "https://[MyDomainName]--[SandboxName].sandbox.my.salesforce.com".
        /// </summary>
        [SwitchName("--instance-url")]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// [Optional] No description for set-default-dev-hub
        /// </summary>
        [SwitchName("--set-default-dev-hub")]
        public bool? SetDefaultDevHub { get; set; }

        /// <summary>
        /// [Optional] No description for set-default
        /// </summary>
        [SwitchName("--set-default")]
        public bool? SetDefault { get; set; }

        /// <summary>
        /// [Optional] No description for alias
        /// </summary>
        [SwitchName("--alias")]
        public string Alias { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method LoginSfdxUrl of class Org.
    /// </summary>
    public class OrgLoginSfdxUrlOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for sfdx-url-file
        /// </summary>
        [SwitchName("--sfdx-url-file")]
        public string SfdxUrlFile { get; set; }

        /// <summary>
        /// [Optional] No description for sfdx-url-stdin
        /// </summary>
        [SwitchName("--sfdx-url-stdin")]
        public string SfdxUrlStdin { get; set; }

        /// <summary>
        /// [Optional] No description for set-default-dev-hub
        /// </summary>
        [SwitchName("--set-default-dev-hub")]
        public bool? SetDefaultDevHub { get; set; }

        /// <summary>
        /// [Optional] No description for set-default
        /// </summary>
        [SwitchName("--set-default")]
        public bool? SetDefault { get; set; }

        /// <summary>
        /// [Optional] No description for alias
        /// </summary>
        [SwitchName("--alias")]
        public string Alias { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method LoginWeb of class Org.
    /// </summary>
    public class OrgLoginWebOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] If you don’t specify --browser, the command uses your default browser. The exact names of the browser applications differ depending on the operating system you're on; check your documentation for details.
        /// </summary>
        [SwitchName("--browser")]
        public string Browser { get; set; }

        /// <summary>
        /// [Optional] No description for client-id
        /// </summary>
        [SwitchName("--client-id")]
        public string ClientId { get; set; }

        /// <summary>
        /// [Optional] If you specify an --instance-url value, this value overrides the sfdcLoginUrl value in your sfdx-project.json file.
        /// 
        /// To specify a My Domain URL, use the format "https://[MyDomainName].my.salesforce.com".
        /// 
        /// To specify a sandbox, set --instance-url to "https://[MyDomainName]--[SandboxName].sandbox.my.salesforce.com".
        /// </summary>
        [SwitchName("--instance-url")]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// [Optional] No description for set-default-dev-hub
        /// </summary>
        [SwitchName("--set-default-dev-hub")]
        public bool? SetDefaultDevHub { get; set; }

        /// <summary>
        /// [Optional] No description for set-default
        /// </summary>
        [SwitchName("--set-default")]
        public bool? SetDefault { get; set; }

        /// <summary>
        /// [Optional] No description for alias
        /// </summary>
        [SwitchName("--alias")]
        public string Alias { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method Logout of class Org.
    /// </summary>
    public class OrgLogoutOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] All orgs includes Dev Hubs, sandboxes, DE orgs, and expired, deleted, and unknown-status scratch orgs.
        /// </summary>
        [SwitchName("--all")]
        public bool? All { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }
    }

    /// <summary>
    /// Options for the method Open of class Org.
    /// </summary>
    public class OrgOpenOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] No description for private
        /// </summary>
        [SwitchName("--private")]
        public bool? Private { get; set; }

        /// <summary>
        /// [Optional] No description for browser
        /// </summary>
        [SwitchName("--browser")]
        public string Browser { get; set; }

        /// <summary>
        /// [Optional] No description for path
        /// </summary>
        [SwitchName("--path")]
        public string Path { get; set; }

        /// <summary>
        /// [Optional] No description for url-only
        /// </summary>
        [SwitchName("--url-only")]
        public bool? UrlOnly { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] No description for source-file
        /// </summary>
        [SwitchName("--source-file")]
        public string SourceFile { get; set; }
    }

    /// <summary>
    /// Options for the method RefreshSandbox of class Org.
    /// </summary>
    public class OrgRefreshSandboxOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] By default, a sandbox auto-activates after a refresh. Use this flag to control sandbox activation manually.
        /// </summary>
        [SwitchName("--no-auto-activate")]
        public bool? NoAutoActivate { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal to you and displays the "$ sf org resume sandbox" command for you run to check the status of the refresh. The displayed command includes the job ID for the running sandbox refresh.
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] No description for poll-interval
        /// </summary>
        [SwitchName("--poll-interval")]
        public int? PollInterval { get; set; }

        /// <summary>
        /// [Optional] The command immediately displays the job ID and returns control of the terminal to you. This way, you can continue to use the CLI. To check the status of the sandbox refresh, run "$ sf org resume sandbox".
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] The sandbox definition file is a blueprint for the sandbox; use the file to change the sandbox configuration during a refresh. If you don't want to change the sandbox configuration when you refresh it, then simply use the --name flag to specify the sandbox and don't use this flag. See [https://developer.salesforce.com/docs/atlas.en-us.sfdx_dev.meta/sfdx_dev/sfdx_dev_sandbox_definition.htm] for all the options you can specify in the definition file.
        /// </summary>
        [SwitchName("--definition-file")]
        public string DefinitionFile { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }
    }

    /// <summary>
    /// Options for the method ResumeSandbox of class Org.
    /// </summary>
    public class OrgResumeSandboxOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you and returns the job ID. To resume checking the sandbox creation, rerun this command.
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] The job ID is valid for 24 hours after you start the sandbox creation.
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] No description for use-most-recent
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }

        /// <summary>
        /// [Optional] When it creates the sandbox org, Salesforce copies the metadata, and optionally data, from your production org to the new sandbox org.
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }
    }

    /// <summary>
    /// Options for the method ResumeScratch of class Org.
    /// </summary>
    public class OrgResumeScratchOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] The job ID is the same as the record ID of the incomplete scratch org in the ScratchOrgInfo object of the Dev Hub.
        /// 
        /// The job ID is valid for 24 hours after you start the scratch org creation.
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] No description for use-most-recent
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }
    }

    /// <summary>
    /// Org
    /// </summary>
    [CommandClass("org")]
    public class Org : SfCommand
    {
        /// Constructor.
        public Org(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Assign a permission set to one or more users of a scratch org.
        /// </summary>
        /// <remarks>
        /// To specify an alias for the --target-org or --on-behalf-of flags, use the CLI username alias, such as the one you set with the "alias set" command. Don't use the value of the Alias field of the User Salesforce object for the org user.
        /// 
        /// To assign multiple permission sets, either set multiple --name flags or a single --name flag with multiple names separated by spaces. Enclose names that contain spaces in one set of double quotes. The same syntax applies to --on-behalf-of.
        /// </remarks>
        /// <example>
        /// Assign two permission sets called DreamHouse and CloudHouse to original admin user of your default scratch org:
        /// $ sf assign permset --name DreamHouse --name CloudHouse
        /// Assign the Dreamhouse permission set to the original admin user of the scratch org with alias "my-scratch":
        /// $ sf assign permset --name DreamHouse --target-org my-scratch
        /// Assign the Dreamhouse permission set to the specified list of users of your default scratch org:
        /// $ sf assign permset --name DreamHouse --on-behalf-of user1@my.org --on-behalf-of user2 --on-behalf-of user
        /// </example>
        [Command("assign permset")]
        public SfResponse AssignPermset(OrgAssignPermsetOptions options)
        {
            return ExecuteCommand(nameof(AssignPermset), options);
        }

        /// <summary>
        /// Assign a permission set license to one or more users of a scratch org.
        /// </summary>
        /// <remarks>
        /// To specify an alias for the --target-org or --on-behalf-of flags, use the CLI username alias, such as the one you set with the "alias set" command. Don't use the value of the Alias field of the User Salesforce object for the org user.
        /// 
        /// To assign multiple permission sets, either set multiple --name flags or a single --name flag with multiple names separated by spaces. Enclose names that contain spaces in one set of double quotes. The same syntax applies to --on-behalf-of.
        /// </remarks>
        /// <example>
        /// Assign the DreamHouse permission set license to original admin user of your default scratch org:
        /// $ sf assign permsetlicense --name DreamHouse
        /// Assign two permission set licenses to the original admin user of the scratch org with alias "my-scratch":
        /// $ sf assign permsetlicense --name DreamHouse --name CloudHouse --target-org my-scratch
        /// Assign the Dreamhouse permission set license to the specified list of users of your default scratch org:
        /// $ sf assign permsetlicense --name DreamHouse --on-behalf-of user1@my.org --on-behalf-of user2 --on-behalf-of user3
        /// </example>
        [Command("assign permsetlicense")]
        public SfResponse AssignPermsetlicense(OrgAssignPermsetlicenseOptions options)
        {
            return ExecuteCommand(nameof(AssignPermsetlicense), options);
        }

        /// <summary>
        /// Create a sandbox org.
        /// </summary>
        /// <remarks>
        /// There are two ways to create a sandbox org: specify a definition file that contains the sandbox options or use the --name and --license-type flags to specify the two required options. If you want to set an option other than name or license type, such as apexClassId, you must use a definition file.
        /// 
        /// You can also use this command to clone an existing sandbox. Use the --clone flag to specify the existing sandbox name and the --name flag to the name of the new sandbox.
        /// </remarks>
        /// <example>
        /// Create a sandbox org using a definition file and give it the alias "MyDevSandbox". The production org that contains the sandbox license has the alias "prodOrg".
        /// $ sf create sandbox --definition-file config/dev-sandbox-def.json --alias MyDevSandbox --target-org prodOrg
        /// Create a sandbox org by directly specifying its name and type of license (Developer) instead of using a definition file. Set the sandbox org as your default.
        /// $ sf create sandbox --name mysandbox --license-type Developer --alias MyDevSandbox --target-org prodOrg --set-default
        /// Clone the existing sandbox with name "ExistingSandbox" and name the new sandbox "NewClonedSandbox". Set the new sandbox as your default org. Wait for 30 minutes for the sandbox creation to complete.
        /// $ sf create sandbox --clone ExistingSandbox --name NewClonedSandbox --target-org prodOrg --alias MyDevSandbox --set-default --wait 30
        /// </example>
        [Command("create sandbox")]
        public SfResponse CreateSandbox(OrgCreateSandboxOptions options)
        {
            return ExecuteCommand(nameof(CreateSandbox), options);
        }

        /// <summary>
        /// Create a scratch org.
        /// </summary>
        /// <remarks>
        /// There are two ways to create a scratch org: either specify a definition file that contains the options or use the --edition flag to specify the one required option.
        /// 
        /// For either method, you can also use these flags; if you use them with --definition-file, they override their equivalent option in the scratch org definition file:
        /// 
        ///     * --description
        ///     * --name  (equivalent to the "orgName" option)
        ///     * --username
        ///     * --release
        ///     * --edition
        ///     * --admin-email (equivalent to the "adminEmail" option)
        ///     * --source-org (equivalent to the "sourceOrg" option)
        /// 
        /// If you want to set options other than the preceding ones, such as org features or settings, you must use a definition file.
        /// 
        /// You must specify a Dev Hub to create a scratch org, either with the --target-dev-hub flag or by setting your default Dev Hub with the target-dev-hub configuration variable.
        /// </remarks>
        /// <example>
        /// Create a Developer edition scratch org using your default Dev Hub and give the scratch org an alias:
        /// $ sf create scratch --edition developer --alias my-scratch-org
        /// Create a scratch org with a definition file. Specify the Dev Hub using its alias, set the scratch org as your default, and specify that it expires in 3 days:
        /// $ sf create scratch --target-dev-hub MyHub --definition-file config/project-scratch-def.json --set-default --duration-days 3
        /// Create a preview Enterprise edition scratch org; for use only during Salesforce release transition periods:
        /// $ sf create scratch --edition enterprise --alias my-scratch-org --target-dev-hub MyHub --release preview
        /// </example>
        [Command("create scratch")]
        public SfResponse CreateScratch(OrgCreateScratchOptions options)
        {
            return ExecuteCommand(nameof(CreateScratch), options);
        }

        /// <summary>
        /// Create a scratch org configuration (shape) based on the specified source org.
        /// </summary>
        /// <remarks>
        /// Scratch org shapes mimic the baseline setup (features, limits, edition, and Metadata API settings) of a source org without the extraneous data and metadata.
        /// 
        /// Run "sf org list shape" to view the available org shapes and their IDs.
        /// 
        /// To create a scratch org from an org shape, include the "sourceOrg" property in the scratch org definition file and set it to the org ID of the source org. Then create a scratch org with the "sf force:org:create" command.
        /// </remarks>
        /// <example>
        /// Create an org shape for the source org with alias SourceOrg:
        /// $ sf create shape --target-org SourceOrg
        /// </example>
        [Command("create shape")]
        public SfResponse CreateShape(OrgCreateShapeOptions options)
        {
            return ExecuteCommand(nameof(CreateShape), options);
        }

        /// <summary>
        /// Create a snapshot of a scratch org.
        /// </summary>
        /// <remarks>
        /// A snapshot is a point-in-time copy of a scratch org. The copy is referenced by its unique name in a scratch org definition file.
        /// 
        /// Use "sf org get snapshot" to get details, including status, about a snapshot creation request.
        /// 
        /// To create a scratch org from a snapshot, include the "snapshot" option (instead of "edition") in the scratch org definition file and set it to the name of the snapshot. Then use "sf force:org:create" to create the scratch org.
        /// </remarks>
        /// <example>
        /// Create a snapshot called "Dependencies" using the source scratch org ID and your default Dev Hub org:
        /// $ sf create snapshot --source-org 00Dxx0000000000 --name Dependencies --description 'Contains PackageA v1.1.0'
        /// Create a snapshot called "NightlyBranch" using the source scratch org username and a Dev Hub org with alias NightlyDevHub:
        /// $ sf create snapshot --source-org myuser@myorg --name NightlyBranch --description 'Contains PkgA v2.1.0 and PkgB 3.3.0' --target-dev-hub NightlyDevHub
        /// </example>
        [Command("create snapshot")]
        public SfResponse CreateSnapshot(OrgCreateSnapshotOptions options)
        {
            return ExecuteCommand(nameof(CreateSnapshot), options);
        }

        /// <summary>
        /// Create a user for a scratch org.
        /// </summary>
        /// <remarks>
        /// A scratch org includes one administrator user by default. For testing purposes, however, you sometimes need to create additional users.
        /// 
        /// The easiest way to create a user is to let this command assign default or generated characteristics to the new user. If you want to customize your new user, create a definition file and specify it with the --definition-file flag. In the file, you can include all the User sObject (SSalesforce object) fields and Salesforce DX-specific options, as described in "User Definition File for Customizing a Scratch Org User" (https://developer.salesforce.com/docs/atlas.en-us.sfdx_dev.meta/sfdx_dev/sfdx_dev_scratch_orgs_users_def_file.htm). You can also specify these options on the command line.
        /// 
        /// If you don't customize your new user, this command creates a user with the following default characteristics:
        /// 
        ///     * The username is the existing administrator’s username prepended with a timestamp, such as 1505759162830_test-wvkpnfm5z113@example.com.
        ///     * The user’s profile is Standard User.
        ///     * The values of the required fields of the User sObject are the corresponding values of the administrator user.
        ///     * The user has no password.
        /// 
        /// Use the --set-alias flag to assign a simple name to the user that you can reference in later CLI commands. This alias is local and different from the Alias field of the User sObject record of the new user, which you set in the Setup UI.
        /// 
        /// When this command completes, it displays the new username and user ID. Run the "org display user" command to get more information about the new user.
        /// 
        /// After the new user has been created, Salesforce CLI automatically authenticates it to the scratch org so the new user can immediately start using the scratch org. The CLI uses the same authentication method that was used on the associated Dev Hub org. Due to Hyperforce limitations, the scratch org user creation fails if the Dev Hub authentication used the JWT flow and the scratch org is on Hyperforce. For this reason, if you plan to create scratch org users, authenticate to the Dev Hub org with either the "org login web" or "org login sfdx-url" command, and not "org login jwt".
        /// 
        /// For more information about user limits, defaults, and other considerations when creating a new scratch org user, see https://developer.salesforce.com/docs/atlas.en-us.sfdx_dev.meta/sfdx_dev/sfdx_dev_scratch_orgs_users.htm.
        /// </remarks>
        /// <example>
        /// Create a user for your default scratch org and let this command generate a username, user ID, and other characteristics:
        /// $ sf create user
        /// Create a user with alias "testuser1" using a user definition file. Set the "profileName" option to "Chatter Free User", which overrides the value in the defintion file if it also exists there. Create the user for the scratch org with alias "my-scratch":
        /// $ sf create user --set-alias testuser1 --definition-file config/project-user-def.json profileName='Chatter Free User' --target-org my-scratch
        /// Create a user by specifying the username, email, and perm set assignment at the command line; command fails if the username already exists in Salesforce:
        /// $ sf create user username=testuser1@my.org email=me@my.org permsets=DreamHouse
        /// Create a user with a definition file, set the email value as specified (overriding any value in the definition file), and generate a password for the user. If the username in the definition file isn't unique, the command appends the org ID to make it unique:
        /// $ sf create user --definition-file config/project-user-def.json email=me@my.org generatepassword=true --set-unique-username
        /// </example>
        [Command("create user")]
        public SfResponse CreateUser(OrgCreateUserOptions options)
        {
            return ExecuteCommand(nameof(CreateUser), options);
        }

        /// <summary>
        /// Delete a sandbox.
        /// </summary>
        /// <remarks>
        /// Salesforce CLI marks the org for deletion in the production org that contains the sandbox licenses and then deletes all local references to the org from your computer.
        /// Specify a sandbox with either the username you used when you logged into it, or the alias you gave the sandbox when you created it. Run "$ sf org list" to view all your orgs, including sandboxes, and their aliases.
        /// Both the sandbox and the associated production org must already be authenticated with the CLI to successfully delete the sandbox.
        /// </remarks>
        /// <example>
        /// Delete a sandbox with alias my-sandbox:
        /// $ sf delete sandbox --target-org my-sandbox
        /// Specify a username instead of an alias:
        /// $ sf delete sandbox --target-org myusername@example.com.qa
        /// Delete the sandbox without prompting to confirm:
        /// $ sf delete sandbox --target-org my-sandbox --no-prompt
        /// </example>
        [Command("delete sandbox")]
        public SfResponse DeleteSandbox(OrgDeleteSandboxOptions options)
        {
            return ExecuteCommand(nameof(DeleteSandbox), options);
        }

        /// <summary>
        /// Delete a scratch org.
        /// </summary>
        /// <remarks>
        /// Salesforce CLI marks the org for deletion in the Dev Hub org and then deletes all local references to the org from your computer.
        /// Specify a scratch org with either the username or the alias you gave the scratch org when you created it. Run "$ sf org list" to view all your orgs, including scratch orgs, and their aliases.
        /// </remarks>
        /// <example>
        /// Delete a scratch org with alias my-scratch-org:
        /// $ sf delete scratch --target-org my-scratch-org
        /// Specify a username instead of an alias:
        /// $ sf delete scratch --target-org test-123456-abcdefg@example.com
        /// Delete the scratch org without prompting to confirm :
        /// $ sf delete scratch --target-org my-scratch-org --no-prompt
        /// </example>
        [Command("delete scratch")]
        public SfResponse DeleteScratch(OrgDeleteScratchOptions options)
        {
            return ExecuteCommand(nameof(DeleteScratch), options);
        }

        /// <summary>
        /// Delete all org shapes for a target org.
        /// </summary>
        /// <remarks>
        /// A source org can have only one active org shape. If you try to create an org shape for a source org that already has one, the previous shape is marked inactive and replaced by a new active shape. If you don’t want to create scratch orgs based on this shape, you can delete the org shape.
        /// </remarks>
        /// <example>
        /// Delete all org shapes for the source org with alias SourceOrg:
        /// $ sf delete shape --target-org SourceOrg
        /// Delete all org shapes without prompting:
        /// $ sf delete shape --target-org SourceOrg --no-prompt
        /// </example>
        [Command("delete shape")]
        public SfResponse DeleteShape(OrgDeleteShapeOptions options)
        {
            return ExecuteCommand(nameof(DeleteShape), options);
        }

        /// <summary>
        /// Delete a scratch org snapshot.
        /// </summary>
        /// <remarks>
        /// Dev Hub admins can delete any snapshot. Users can delete only their own snapshots, unless a Dev Hub admin gives the user Modify All permission, which works only with the Salesforce license.
        /// </remarks>
        /// <example>
        /// Delete a snapshot from the default Dev Hub using the snapshot ID:
        /// $ sf delete snapshot --snapshot 0Oo...
        /// Delete a snapshot from the specified Dev Hub using the snapshot name:
        /// $ sf delete snapshot --snapshot BaseSnapshot --target-dev-hub SnapshotDevHub
        /// </example>
        [Command("delete snapshot")]
        public SfResponse DeleteSnapshot(OrgDeleteSnapshotOptions options)
        {
            return ExecuteCommand(nameof(DeleteSnapshot), options);
        }

        /// <summary>
        /// Prevent Salesforce CLI from tracking changes in your source files between your project and an org.
        /// </summary>
        /// <remarks>
        /// Disabling source tracking has no direct effect on the org, it affects only your local environment. Specifically, Salesforce CLI stores the setting in the org's local configuration file so that no source tracking operations are executed when working with the org.
        /// </remarks>
        /// <example>
        /// Disable source tracking for an org with alias "myscratch":
        /// $ sf disable tracking --target-org myscratch
        /// Disable source tracking for an org using a username:
        /// $ sf disable tracking --target-org you@example.com
        /// Disable source tracking for your default org:
        /// $ sf disable tracking
        /// </example>
        [Command("disable tracking")]
        public SfResponse DisableTracking(OrgDisableTrackingOptions options)
        {
            return ExecuteCommand(nameof(DisableTracking), options);
        }

        /// <summary>
        /// Display information about an org.
        /// </summary>
        /// <remarks>
        /// Output includes your access token, client Id, connected status, org ID, instance URL, username, and alias, if applicable.
        /// 
        /// Use --verbose to include the SFDX auth URL. WARNING: The SFDX auth URL contains sensitive information, such as a refresh token that can be used to access an org. Don't share or distribute this URL or token.
        /// 
        /// Including --verbose displays the sfdxAuthUrl property only if you authenticated to the org using "org login web" (not "org login jwt").
        /// </remarks>
        /// <example>
        /// Display information about your default org:
        /// $ $ sf display
        /// Display information, including the sfdxAuthUrl property, about the org with alias TestOrg1:
        /// $ $ sf display --target-org TestOrg1 --verbose
        /// </example>
        [Command("display")]
        public SfResponse Display(OrgDisplayOptions options)
        {
            return ExecuteCommand(nameof(Display), options);
        }

        /// <summary>
        /// Display information about a Salesforce user.
        /// </summary>
        /// <remarks>
        /// Output includes the profile name, org ID, access token, instance URL, login URL, and alias if applicable. The displayed alias is local and different from the Alias field of the User sObject record of the new user, which you set in the Setup UI.
        /// </remarks>
        /// <example>
        /// Display information about the admin user of your default scratch org:
        /// $ sf display user
        /// Display information about the specified user and output in JSON format:
        /// $ sf display user --target-org me@my.org --json
        /// </example>
        [Command("display user")]
        public SfResponse DisplayUser(OrgDisplayUserOptions options)
        {
            return ExecuteCommand(nameof(DisplayUser), options);
        }

        /// <summary>
        /// Allow Salesforce CLI to track changes in your source files between your project and an org.
        /// </summary>
        /// <remarks>
        /// Enabling source tracking has no direct effect on the org, it affects only your local environment. Specifically, Salesforce CLI stores the setting in the org's local configuration file so that source tracking operations are executed when working with the org.
        /// 
        /// This command throws an error if the org doesn't support tracking. Examples of orgs that don't support source tracking include Developer Edition orgs, production orgs, Partial Copy sandboxes, and Full sandboxes.
        /// </remarks>
        /// <example>
        /// Enable source tracking for an org with alias "myscratch":
        /// $ sf enable tracking --target-org myscratch
        /// Enable source tracking for an org using a username:
        /// $ sf enable tracking --target-org you@example.com
        /// Enable source tracking for your default org:
        /// $ sf enable tracking
        /// </example>
        [Command("enable tracking")]
        public SfResponse EnableTracking(OrgEnableTrackingOptions options)
        {
            return ExecuteCommand(nameof(EnableTracking), options);
        }

        /// <summary>
        /// Generate a random password for scratch org users.
        /// </summary>
        /// <remarks>
        /// By default, new scratch orgs contain one admin user with no password. Use this command to generate or change a password for this admin user. After it's set, you can’t unset a password, you can only change it.
        /// 
        /// You can also use the --on-behalf-of flag to generate a password for a scratch org user that you've created locally with the "org create user" command. This command doesn't work for users you created in the scratch org using Setup.
        /// 
        /// To change the password strength, set the --complexity flag to a value between 0 and 5. Each value specifies the types of characters used in the generated password:
        /// 
        /// 0 - lower case letters only
        /// 1 - lower case letters and numbers only
        /// 2 - lower case letters and symbols only
        /// 3 - lower and upper case letters and numbers only
        /// 4 - lower and upper case letters and symbols only
        /// 5 - lower and upper case letters and numbers and symbols only
        /// 
        /// To see a password that was previously generated, run "org display user".
        /// </remarks>
        /// <example>
        /// Generate a password for the original admin user of your default scratch org:
        /// $ sf generate password
        /// Generate a password that contains 12 characters for the original admin user of the scratch org with alias "my-scratch":
        /// $ sf generate password --length 12 --target-org my-scratch
        /// Generate a password for your default scratch org admin user that uses lower and upper case letters and numbers only:
        /// $ sf generate password --complexity 3
        /// Generate a password for the specified users in the default scratch org; these users must have been created locally with the "org create user" command:
        /// $ sf generate password --on-behalf-of user1@my.org --on-behalf-of user2@my.org --on-behalf-of user3@my.org
        /// </example>
        [Command("generate password")]
        public SfResponse GeneratePassword(OrgGeneratePasswordOptions options)
        {
            return ExecuteCommand(nameof(GeneratePassword), options);
        }

        /// <summary>
        /// Get details about a scratch org snapshot.
        /// </summary>
        /// <remarks>
        /// Snapshot creation can take a while. Use this command with the snapshot name or ID to check its creation status. After the status changes to Active, you can use the snapshot to create scratch orgs.
        /// 
        /// To create a snapshot, use the "sf org create snapshot" command. To retrieve a list of all snapshots, use "sf org list snapshot".
        /// </remarks>
        /// <example>
        /// Get snapshot details using its ID and the default Dev Hub org:
        /// $ sf get snapshot --snapshot 0Oo...
        /// Get snapshot details using its name from a Dev Hub org with alias SnapshotDevHub:
        /// $ sf get snapshot --snapshot Dependencies --target-dev-hub SnapshotDevHub
        /// </example>
        [Command("get snapshot")]
        public SfResponse GetSnapshot(OrgGetSnapshotOptions options)
        {
            return ExecuteCommand(nameof(GetSnapshot), options);
        }

        /// <summary>
        /// List all orgs you’ve created or authenticated to.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// List all orgs you've created or authenticated to:
        /// $ $ sf list
        /// List all orgs, including expired, deleted, and unknown-status orgs; don't include the connection status:
        /// $ $ sf list --skip-connection-status --all
        /// List orgs and remove local org authorization info about non-active scratch orgs:
        /// $ $ sf list --clean
        /// </example>
        [Command("list")]
        public SfResponse List(OrgListOptions options = null)
        {
            return ExecuteCommand(nameof(List), options);
        }

        /// <summary>
        /// List authorization information about the orgs you created or logged into.
        /// </summary>
        /// <remarks>
        /// This command uses local authorization information that Salesforce CLI caches when you create a scratch org or log into an org. The command doesn't actually connect to the orgs to verify that they're still active. As a result, this command executes very quickly. If you want to view live information about your authorized orgs, such as their connection status, use the "org list" command.
        /// </remarks>
        /// <example>
        /// List local authorization information about your orgs:
        /// $ sf list auth
        /// </example>
        [Command("list auth")]
        public SfResponse ListAuth(OrgListAuthOptions options = null)
        {
            return ExecuteCommand(nameof(ListAuth), options);
        }

        /// <summary>
        /// Display information about limits in your org.
        /// </summary>
        /// <remarks>
        /// For each limit, this command returns the maximum allocation and the remaining allocation based on usage. See this topic for a description of each limit: https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_limits.htm.
        /// </remarks>
        /// <example>
        /// Display limits in your default org:
        /// $ sf list limits
        /// Display limits in the org with alias "my-scratch-org":
        /// $ sf list limits --target-org my-scratch-org
        /// </example>
        [Command("list limits")]
        public SfResponse ListLimits(OrgListLimitsOptions options)
        {
            return ExecuteCommand(nameof(ListLimits), options);
        }

        /// <summary>
        /// List the metadata components and properties of a specified type.
        /// </summary>
        /// <remarks>
        /// Use this command to identify individual components in your manifest file or if you want a high-level view of particular metadata types in your org. For example, you can use this command to return a list of names of all the CustomObject or Layout components in your org, then use this information in a retrieve command that returns a subset of these components.
        /// 
        /// The username that you use to connect to the org must have the Modify All Data or Modify Metadata Through Metadata API Functions permission.
        /// </remarks>
        /// <example>
        /// List the CustomObject components, and their properties, in the org with alias "my-dev-org":
        /// $ $ sf list metadata --metadata-type CustomObject --target-org my-dev-org
        /// List the CustomObject components in your default org, write the output to the specified file, and use API version 57.0:
        /// $ $ sf list metadata --metadata-type CustomObject --api-version 57.0 --output-file /path/to/outputfilename.txt
        /// List the Dashboard components in your default org that are contained in the "folderSales" folder, write the output to the specified file, and use API version 57.0:
        /// $ $ sf list metadata --metadata-type Dashboard --folder folderSales --api-version 57.0 --output-file /path/to/outputfilename.txt
        /// </example>
        [Command("list metadata")]
        public SfResponse ListMetadata(OrgListMetadataOptions options)
        {
            return ExecuteCommand(nameof(ListMetadata), options);
        }

        /// <summary>
        /// Display details about the metadata types that are enabled for your org.
        /// </summary>
        /// <remarks>
        /// The information includes Apex classes and triggers, custom objects, custom fields on standard objects, tab sets that define an app, and many other metadata types. Use this information to identify the syntax needed for a [name] element in a manifest file (package.xml).
        /// 
        /// The username that you use to connect to the org must have the Modify All Data or Modify Metadata Through Metadata API Functions permission.
        /// </remarks>
        /// <example>
        /// Display information about all known and enabled metadata types in the org with alias "my-dev-org" using API version 57.0:
        /// $ $ sf list metadata-types --api-version 57.0 --target-org my-dev-org
        /// Display only the metadata types that aren't yet supported by Salesforce CLI in your default org and write the results to the specified file:
        /// $ $ sf list metadata-types --output-file /path/to/outputfilename.txt --filter-known
        /// </example>
        [Command("list metadata-types")]
        public SfResponse ListMetadataTypes(OrgListMetadataTypesOptions options)
        {
            return ExecuteCommand(nameof(ListMetadataTypes), options);
        }

        /// <summary>
        /// List all org shapes you’ve created.
        /// </summary>
        /// <remarks>
        /// The output includes the alias, username, and ID of the source org, the status of the org shape creation, and more. Use the org ID to update your scratch org configuration file so you can create a scratch org based on this org shape.
        /// </remarks>
        /// <example>
        /// List all org shapes you've created:
        /// $ sf list shape
        /// List all org shapes in JSON format and write the output to a file:
        /// $ sf list shape --json ] tmp/MyOrgShapeList.json
        /// </example>
        [Command("list shape")]
        public SfResponse ListShape(OrgListShapeOptions options = null)
        {
            return ExecuteCommand(nameof(ListShape), options);
        }

        /// <summary>
        /// List scratch org snapshots.
        /// </summary>
        /// <remarks>
        /// You can view all the snapshots in a Dev Hub that you have access to. If you’re an admin, you can see all snapshots associated with the Dev Hub org. If you’re a user, you can see only your snapshots unless a Dev Hub admin gives you View All permissions.
        /// 
        /// To create a snapshot, use the "sf org create snapshot" command. To get details about a snapshot request, use "sf org get snapshot".
        /// </remarks>
        /// <example>
        /// List snapshots in the default Dev Hub:
        /// $ sf list snapshot
        /// List snapshots in the Dev Hub with alias SnapshotDevHub:
        /// $ sf list snapshot --target-dev-hub SnapshotDevHub
        /// </example>
        [Command("list snapshot")]
        public SfResponse ListSnapshot(OrgListSnapshotOptions options)
        {
            return ExecuteCommand(nameof(ListSnapshot), options);
        }

        /// <summary>
        /// Display record counts for the specified standard or custom objects.
        /// </summary>
        /// <remarks>
        /// Use this command to get an approximate count of the records in standard or custom objects in your org. These record counts are the same as the counts listed in the Storage Usage page in the Setup UI. The record counts are approximate because they're calculated asynchronously and your org's storage usage isn't updated immediately. To display all available record counts, run the command without the --sobject flag.
        /// </remarks>
        /// <example>
        /// Display all available record counts in your default org:
        /// $ sf list sobject record-counts
        /// Display record counts for the Account, Contact, Lead, and Opportunity objects in your default org:
        /// $ sf list sobject record-counts --sobject Account --sobject Contact --sobject Lead --sobject Opportunity
        /// Display record counts for the Account and Lead objects for the org with alias "my-scratch-org":
        /// $ sf list sobject record-counts --sobject Account --sobject Lead --target-org my-scratch-org
        /// </example>
        [Command("list sobject record-counts")]
        public SfResponse ListSobjectRecordCounts(OrgListSobjectRecordCountsOptions options)
        {
            return ExecuteCommand(nameof(ListSobjectRecordCounts), options);
        }

        /// <summary>
        /// List all locally-authenticated users of an org.
        /// </summary>
        /// <remarks>
        /// For scratch orgs, the list includes any users you've created with the "org create user" command; the original scratch org admin user is marked with "(A)". For other orgs, the list includes the users you used to authenticate to the org.
        /// </remarks>
        /// <example>
        /// List the locally-authenticated users of your default org:
        /// $ sf list users
        /// List the locally-authenticated users of the specified org:
        /// $ sf list users --target-org me@my.org
        /// </example>
        [Command("list users")]
        public SfResponse ListUsers(OrgListUsersOptions options)
        {
            return ExecuteCommand(nameof(ListUsers), options);
        }

        /// <summary>
        /// Authorize an org using an existing Salesforce access token.
        /// </summary>
        /// <remarks>
        /// By default, the command runs interactively and asks you for the access token. If you previously authorized the org, the command prompts whether you want to overwrite the local file. Specify --no-prompt to not be prompted.
        /// 
        /// To use the command in a CI/CD script, set the SFDX_ACCESS_TOKEN environment variable to the access token. Then run the command with the --no-prompt parameter.
        /// </remarks>
        /// <example>
        /// Authorize an org on https://mycompany.my.salesforce.com; the command prompts you for the access token:
        /// $ sf login access-token --instance-url https://mycompany.my.salesforce.com
        /// Authorize the org without being prompted; you must have previously set the SF_ACCESS_TOKEN environment variable to the access token:
        /// $ sf login access-token --instance-url https://dev-hub.my.salesforce.com --no-prompt
        /// </example>
        [Command("login access-token")]
        public SfResponse LoginAccessToken(OrgLoginAccessTokenOptions options)
        {
            return ExecuteCommand(nameof(LoginAccessToken), options);
        }

        /// <summary>
        /// Authorize an org using a device code.
        /// </summary>
        /// <remarks>
        /// Use this command to allow a device to connect to an org.
        /// 
        /// When you run this command, it first displays an 8-digit device code and the URL for verifying the code on your org. The default instance URL is https://login.salesforce.com, so if the org you're authorizing is on a different instance, use the --instance-url. The command waits while you complete the verification. Open a browser and navigate to the displayed verification URL, enter the code, then click Connect. If you aren't already logged into your org, log in, and then you're prompted to allow the device to connect to the org. After you successfully authorize the org, you can close the browser window.
        /// </remarks>
        /// <example>
        /// Authorize an org using a device code, give the org the alias TestOrg1, and set it as your default Dev Hub org:
        /// $ sf login device --set-default-dev-hub --alias TestOrg1
        /// Authorize an org in which you've created a custom connected app with the specified client ID (consumer key):
        /// $ sf login device --client-id [OAuth client id]
        /// Authorize a sandbox org with the specified instance URL:
        /// $ sf login device --instance-url https://MyDomainName--SandboxName.sandbox.my.salesforce.com
        /// </example>
        [Command("login device")]
        public SfResponse LoginDevice(OrgLoginDeviceOptions options = null)
        {
            return ExecuteCommand(nameof(LoginDevice), options);
        }

        /// <summary>
        /// Log in to a Salesforce org using a JSON web token (JWT).
        /// </summary>
        /// <remarks>
        /// Use this command in automated environments where you can’t interactively log in with a browser, such as in CI/CD scripts.
        /// 
        /// Logging into an org authorizes the CLI to run other commands that connect to that org, such as deploying or retrieving a project. You can log into many types of orgs, such as sandboxes, Dev Hubs, Env Hubs, production orgs, and scratch orgs.
        /// 
        /// Complete these steps before you run this command:
        /// 
        ///     1. Create a digital certificate (also called digital signature) and the private key to sign the certificate. You can use your own key and certificate issued by a certification authority. Or use OpenSSL to create a key and a self-signed digital certificate.
        ///     2. Store the private key in a file on your computer. When you run this command, you set the --jwt-key-file flag to this file.
        ///     3. Create a custom connected app in your org using the digital certificate. Make note of the consumer key (also called client id) that’s generated for you. Be sure the username of the user logging in is approved to use the connected app. When you run this command, you set the --client-id flag to the consumer key.
        /// 
        /// See https://developer.salesforce.com/docs/atlas.en-us.sfdx_dev.meta/sfdx_dev/sfdx_dev_auth_jwt_flow.htm for more information.
        /// 
        /// We recommend that you set an alias when you log into an org. Aliases make it easy to later reference this org when running commands that require it. If you don’t set an alias, you use the username that you specified when you logged in to the org. If you run multiple commands that reference the same org, consider setting the org as your default. Use --set-default for your default scratch org or sandbox, or --set-default-dev-hub for your default Dev Hub.
        /// </remarks>
        /// <example>
        /// Log into an org with username jdoe@example.org and on the default instance URL (https://login.salesforce.com). The private key is stored in the file /Users/jdoe/JWT/server.key and the command uses the connected app with consumer key (client id) 04580y4051234051.
        /// $ sf login jwt --username jdoe@example.org --jwt-key-file /Users/jdoe/JWT/server.key --client-id 04580y4051234051
        /// Set the org as the default and give it an alias:
        /// $ sf login jwt --username jdoe@example.org --jwt-key-file /Users/jdoe/JWT/server.key --client-id 04580y4051234051 --alias ci-org --set-default
        /// Set the org as the default Dev Hub and give it an alias:
        /// $ sf login jwt --username jdoe@example.org --jwt-key-file /Users/jdoe/JWT/server.key --client-id 04580y4051234051 --alias ci-dev-hub --set-default-dev-hub
        /// Log in to a sandbox using URL https://MyDomainName--SandboxName.sandbox.my.salesforce.com:
        /// $ sf login jwt --username jdoe@example.org --jwt-key-file /Users/jdoe/JWT/server.key --client-id 04580y4051234051 --alias ci-org --set-default --instance-url https://MyDomainName--SandboxName.sandbox.my.salesforce.com
        /// </example>
        [Command("login jwt")]
        public SfResponse LoginJwt(OrgLoginJwtOptions options)
        {
            return ExecuteCommand(nameof(LoginJwt), options);
        }

        /// <summary>
        /// Authorize an org using a Salesforce DX authorization URL stored in a file or through standard input (stdin).
        /// </summary>
        /// <remarks>
        /// The Salesforce DX (SFDX) authorization URL must have the format "force://[clientId]:[clientSecret]:[refreshToken]@[instanceUrl]". NOTE: The SFDX authorization URL uses the "force" protocol, and not "http" or "https". Also, the "instanceUrl" inside the SFDX authorization URL doesn't include the protocol ("https://").
        /// 
        /// You have three options when creating the authorization file. The easiest option is to redirect the output of the "$ sf org display --verbose --json" command into a file. For example, using an org with alias my-org that you've already authorized:
        /// 
        ///     $ $ sf org display --target-org my-org --verbose --json ] authFile.json
        /// 
        /// The resulting JSON file contains the URL in the "sfdxAuthUrl" property of the "result" object. You can then reference the file when running this command:
        /// 
        ///     $ $ sf login sfdx-url --sfdx-url-file authFile.json
        /// 
        /// NOTE: The "$ sf org display --verbose" command displays the refresh token only for orgs authorized with the web server flow, and not the JWT bearer flow.
        /// 
        /// You can also create a JSON file that has a top-level property named sfdxAuthUrl whose value is the authorization URL. Finally, you can create a normal text file that includes just the URL and nothing else.
        /// 
        /// Alternatively, you can pipe the SFDX authorization URL through standard input by specifying the --sfdx-url-stdin flag.
        /// </remarks>
        /// <example>
        /// Authorize an org using the SFDX authorization URL in the files/authFile.json file:
        /// $ sf login sfdx-url --sfdx-url-file files/authFile.json
        /// Similar to previous example, but set the org as your default and give it an alias MyDefaultOrg:
        /// $ sf login sfdx-url --sfdx-url-file files/authFile.json --set-default --alias MyDefaultOrg
        /// Pipe the SFDX authorization URL from stdin:
        /// $ echo url | sf login sfdx-url --sfdx-url-stdin
        /// </example>
        [Command("login sfdx-url")]
        public SfResponse LoginSfdxUrl(OrgLoginSfdxUrlOptions options = null)
        {
            return ExecuteCommand(nameof(LoginSfdxUrl), options);
        }

        /// <summary>
        /// Log in to a Salesforce org using the web server flow.
        /// </summary>
        /// <remarks>
        /// Opens a Salesforce instance URL in a web browser so you can enter your credentials and log in to your org. After you log in, you can close the browser window.
        /// 
        /// Logging into an org authorizes the CLI to run other commands that connect to that org, such as deploying or retrieving metadata. You can log into many types of orgs, such as sandboxes, Dev Hubs, Env Hubs, production orgs, and scratch orgs.
        /// 
        /// We recommend that you set an alias when you log into an org. Aliases make it easy to later reference this org when running commands that require it. If you don’t set an alias, you use the username that you specified when you logged in to the org. If you run multiple commands that reference the same org, consider setting the org as your default. Use --set-default for your default scratch org or sandbox, or --set-default-dev-hub for your default Dev Hub.
        /// 
        /// By default, this command uses the global out-of-the-box connected app in your org. If you need more security or control, such as setting the refresh token timeout or specifying IP ranges, create your own connected app using a digital certificate. Make note of the consumer key (also called cliend id) that’s generated for you. Then specify the consumer key with the --client-id flag.
        /// </remarks>
        /// <example>
        /// Run the command with no flags to open the default Salesforce login page (https://login.salesforce.com):
        /// $ sf login web
        /// Log in to your Dev Hub, set it as your default Dev Hub, and set an alias that you reference later when you create a scratch org:
        /// $ sf login web --set-default-dev-hub --alias dev-hub
        /// Log in to a sandbox and set it as your default org:
        /// $ sf login web --instance-url https://MyDomainName--SandboxName.sandbox.my.salesforce.com --set-default
        /// Use --browser to specify a specific browser, such as Google Chrome:
        /// $ sf login web --instance-url https://MyDomainName--SandboxName.sandbox.my.salesforce.com --set-default --browser chrome
        /// Use your own connected app by specifying its consumer key (also called client ID):
        /// $ sf login web --instance-url https://MyDomainName--SandboxName.sandbox.my.salesforce.com --set-default --browser chrome --client-id 04580y4051234051
        /// </example>
        [Command("login web")]
        public SfResponse LoginWeb(OrgLoginWebOptions options = null)
        {
            return ExecuteCommand(nameof(LoginWeb), options);
        }

        /// <summary>
        /// Log out of a Salesforce org.
        /// </summary>
        /// <remarks>
        /// If you run this command with no flags and no default org set in your config or environment, it first displays a list of orgs you've created or logged into, with none of the orgs selected. Use the arrow keys to scroll through the list and the space bar to select the orgs you want to log out of. Press Enter when you're done; the command asks for a final confirmation before logging out of the selected orgs.
        /// 
        /// The process is similar if you specify --all, except that in the initial list of orgs, they're all selected. Use --target-org to logout of a specific org. In both these cases by default, you must still confirm that you want to log out. Use --no-prompt to never be asked for confirmation when also using --all or --target-org.
        /// 
        /// Be careful! If you log out of a scratch org without having access to its password, you can't access the scratch org again, either through the CLI or the Salesforce UI.
        /// </remarks>
        /// <example>
        /// Interactively select the orgs to log out of:
        /// $ sf logout
        /// Log out of the org with username me@my.org:
        /// $ sf logout --target-org me@my.org
        /// Log out of all orgs after confirmation:
        /// $ sf logout --all
        /// Logout of the org with alias my-scratch and don't prompt for confirmation:
        /// $ sf logout --target-org my-scratch --no-prompt
        /// </example>
        [Command("logout")]
        public SfResponse Logout(OrgLogoutOptions options = null)
        {
            return ExecuteCommand(nameof(Logout), options);
        }

        /// <summary>
        /// Open your default scratch org, or another specified org, in a browser.
        /// </summary>
        /// <remarks>
        /// To open a specific page, specify the portion of the URL after "https://mydomain.my.salesforce.com" as the value for the --path flag. For example, specify "--path lightning" to open Lightning Experience, or specify "--path /apex/YourPage" to open a Visualforce page.
        /// 
        /// Use the --source-file to open a Lightning Page from your local project in Lightning App Builder. Lightning page files have the suffix .flexipage-meta.xml, and are stored in the "flexipages" directory.
        /// 
        /// To generate a URL but not launch it in your browser, specify --url-only.
        /// 
        /// To open in a specific browser, use the --browser flag. Supported browsers are "chrome", "edge", and "firefox". If you don't specify --browser, the org opens in your default browser.
        /// </remarks>
        /// <example>
        /// Open your default org in your default browser:
        /// $ $ sf open
        /// Open your default org in an incognito window of your default browser:
        /// $ $ sf open --private
        /// Open the org with alias MyTestOrg1 in the Firefox browser:
        /// $ $ sf open --target-org MyTestOrg1 --browser firefox
        /// Display the navigation URL for the Lightning Experience page for your default org, but don't open the page in a browser:
        /// $ $ sf open --url-only --path lightning
        /// Open a local Lightning page in your default org's Lightning App Builder:
        /// $ $ sf open --source-file force-app/main/default/flexipages/Hello.flexipage-meta.xml
        /// Open a local Flow in Flow Builder:
        /// $ $ sf open --source-file force-app/main/default/flows/Hello.flow-meta.xml
        /// </example>
        [Command("open")]
        public SfResponse Open(OrgOpenOptions options)
        {
            return ExecuteCommand(nameof(Open), options);
        }

        /// <summary>
        /// Refresh a sandbox org using the sandbox name.
        /// </summary>
        /// <remarks>
        /// Refreshing a sandbox copies the metadata, and optionally data, from your source org to the refreshed sandbox org. You can optionally specify a definition file if you want to change the configuration of the refreshed sandbox, such as its license type or template ID.
        /// 
        /// You're not allowed to change the sandbox name when you refresh it with this command. If you want to change the sandbox name, first delete it with the "org delete sandbox" command. And then recreate it with the "org create sandbox" command and give it a new name.
        /// </remarks>
        /// <example>
        /// Refresh the sandbox named "devSbx1". The production org that contains the sandbox license has the alias "prodOrg".
        /// $ sf refresh sandbox --name devSbx1 --target-org prodOrg
        /// Refresh the sandbox named "devSbx2", and override the configuration of the refreshed sandbox with the properties in the specified defintion file. The default target org is the production org, so you don't need to specify the `--target-org` flag in this case.
        /// $ sf refresh sandbox --name devSbx2 --definition-file devSbx2-config.json
        /// Refresh the sandbox using the name defined in the definition file. The production org that contains the sandbox license has the alias "prodOrg".
        /// $ sf refresh sandbox --definition-file devSbx3-config.json --target-org prodOrg
        /// </example>
        [Command("refresh sandbox")]
        public SfResponse RefreshSandbox(OrgRefreshSandboxOptions options)
        {
            return ExecuteCommand(nameof(RefreshSandbox), options);
        }

        /// <summary>
        /// Check the status of a sandbox creation, and log in to it if it's ready.
        /// </summary>
        /// <remarks>
        /// Sandbox creation can take a long time. If the original "$ sf org create sandbox" command either times out, or you specified the --async flag, the command displays a job ID. Use this job ID to check whether the sandbox creation is complete, and if it is, the command then logs into it.
        /// 
        /// You can also use the sandbox name to check the status or the --use-most-recent flag to use the job ID of the most recent sandbox creation.
        /// </remarks>
        /// <example>
        /// Check the status of a sandbox creation using its name and specify a production org with alias "prodOrg":
        /// $ sf resume sandbox --name mysandbox --target-org prodOrg
        /// Check the status using the job ID:
        /// $ sf resume sandbox --job-id 0GRxxxxxxxx
        /// Check the status of the most recent sandbox create request:
        /// $ sf resume sandbox --use-most-recent
        /// </example>
        [Command("resume sandbox")]
        public SfResponse ResumeSandbox(OrgResumeSandboxOptions options = null)
        {
            return ExecuteCommand(nameof(ResumeSandbox), options);
        }

        /// <summary>
        /// Resume the creation of an incomplete scratch org.
        /// </summary>
        /// <remarks>
        /// When the original "$ sf org create scratch" command either times out or is run with the --async flag, it displays a job ID.
        /// 
        /// Run this command by either passing it a job ID or using the --use-most-recent flag to specify the most recent incomplete scratch org.
        /// </remarks>
        /// <example>
        /// Resume a scratch org create with a job ID:
        /// $ sf resume scratch --job-id 2SR3u0000008fBDGAY
        /// Resume your most recent incomplete scratch org:
        /// $ sf resume scratch --use-most-recent
        /// </example>
        [Command("resume scratch")]
        public SfResponse ResumeScratch(OrgResumeScratchOptions options = null)
        {
            return ExecuteCommand(nameof(ResumeScratch), options);
        }
    }
}

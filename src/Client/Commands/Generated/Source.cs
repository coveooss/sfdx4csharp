// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method convert of class Source.
    /// </summary>
    public class SourceConvertOptions : SFDXOptions
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
        /// [Required] A source directory other than the default package to convert
        /// </summary>
        [SwitchName("--rootdir")]
        public string rootdir { get; set; }

        /// <summary>
        /// [Required] Output directory to store the Metadata API–formatted files in
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] Name of the package to associate with the metadata-formatted files
        /// </summary>
        [SwitchName("--packagename")]
        public string packagename { get; set; }

        /// <summary>
        /// [Required] File path to manifest (package.xml) of metadata types to convert.
        /// </summary>
        [SwitchName("--manifest")]
        public string manifest { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of paths to the local source files to convert
        /// </summary>
        [SwitchName("--sourcepath")]
        public string sourcepath { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of metadata component names to convert
        /// </summary>
        [SwitchName("--metadata")]
        public string metadata { get; set; }
    }

    /// <summary>
    /// Options for the method delete of class Source.
    /// </summary>
    public class SourceDeleteOptions : SFDXOptions
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
        /// [Optional] Validates the deleted metadata and runs all Apex tests, but prevents the deletion from being saved to the org. 
        /// If you change a field type from Master-Detail to Lookup or vice versa, that change isn’t supported when using the --checkonly parameter to test a deletion (validation). This kind of change isn’t supported for test deletions to avoid the risk of data loss or corruption. If a change that isn’t supported for test deletions is included in a deletion package, the test deletion fails and issues an error.
        /// If your deletion package changes a field type from Master-Detail to Lookup or vice versa, you can still validate the changes prior to deploying to Production by performing a full deletion to another test Sandbox. A full deletion includes a validation of the changes as part of the deletion process.
        /// Note: A Metadata API deletion that includes Master-Detail relationships deletes all detail records in the Recycle Bin in the following cases.
        /// 1. For a deletion with a new Master-Detail field, soft delete (send to the Recycle Bin) all detail records before proceeding to delete the Master-Detail field, or the deletion fails. During the deletion, detail records are permanently deleted from the Recycle Bin and cannot be recovered.
        /// 2. For a deletion that converts a Lookup field relationship to a Master-Detail relationship, detail records must reference a master record or be soft-deleted (sent to the Recycle Bin) for the deletion to succeed. However, a successful deletion permanently deletes any detail records in the Recycle Bin.
        /// </summary>
        [SwitchName("--checkonly")]
        public bool? checkonly { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for delete confirmation.
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }

        /// <summary>
        /// [Required] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of paths to the local metadata to delete. The supplied paths can be a single file (in which case the operation is applied to only one file) or a folder (in which case the operation is applied to all metadata types in the directory and its sub-directories).
        /// If you specify this parameter, don’t specify --manifest or --metadata.
        /// </summary>
        [SwitchName("--sourcepath")]
        public string sourcepath { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of names of metadata components to delete from your project and your org.
        /// </summary>
        [SwitchName("--metadata")]
        public string metadata { get; set; }
    }

    /// <summary>
    /// Options for the method deploy of class Source.
    /// </summary>
    public class SourceDeployOptions : SFDXOptions
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
        /// [Optional] Validate deploy but don’t save to the org
        /// </summary>
        [SwitchName("--checkonly")]
        public bool? checkonly { get; set; }

        /// <summary>
        /// [Optional] Deploy metadata with SOAP API instead of REST API
        /// </summary>
        [SwitchName("--soapdeploy")]
        public bool? soapdeploy { get; set; }

        /// <summary>
        /// [Required] Wait time for command to finish in minutes
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }

        /// <summary>
        /// [Required] Deployment testing level
        /// </summary>
        [SwitchName("--testlevel")]
        public string testlevel { get; set; }

        /// <summary>
        /// [Required] Tests to run if --testlevel RunSpecifiedTests
        /// </summary>
        [SwitchName("--runtests")]
        public string runtests { get; set; }

        /// <summary>
        /// [Optional] Ignore any errors and do not roll back deployment
        /// </summary>
        [SwitchName("--ignoreerrors")]
        public bool? ignoreerrors { get; set; }

        /// <summary>
        /// [Optional] Whether a warning will allow a deployment to complete successfully
        /// </summary>
        [SwitchName("--ignorewarnings")]
        public bool? ignorewarnings { get; set; }

        /// <summary>
        /// [Required] Deploy request ID of the validated deployment to run a Quick Deploy
        /// </summary>
        [SwitchName("--validateddeployrequestid")]
        public string validateddeployrequestid { get; set; }

        /// <summary>
        /// [Optional] Verbose output of deploy result
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of metadata component names
        /// </summary>
        [SwitchName("--metadata")]
        public string metadata { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of source file paths to deploy
        /// </summary>
        [SwitchName("--sourcepath")]
        public string sourcepath { get; set; }

        /// <summary>
        /// [Required] File path for manifest (package.xml) of components to deploy
        /// </summary>
        [SwitchName("--manifest")]
        public string manifest { get; set; }
    }

    /// <summary>
    /// Options for the method deployCancel of class Source.
    /// </summary>
    public class SourceDeployCancelOptions : SFDXOptions
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
        /// [Required] Wait time for command to finish in minutes
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }

        /// <summary>
        /// [Required] Job ID of the deployment you want to cancel; defaults to your most recent CLI deployment if not specified
        /// </summary>
        [SwitchName("--jobid")]
        public string jobid { get; set; }
    }

    /// <summary>
    /// Options for the method deployReport of class Source.
    /// </summary>
    public class SourceDeployReportOptions : SFDXOptions
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
        /// [Required] Wait time for command to finish in minutes
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }

        /// <summary>
        /// [Required] Job ID of the deployment you want to check; defaults to your most recent CLI deployment if not specified
        /// </summary>
        [SwitchName("--jobid")]
        public string jobid { get; set; }

        /// <summary>
        /// [Optional] Verbose output of deploy result
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method ignoredList of class Source.
    /// </summary>
    public class SourceIgnoredListOptions : SFDXOptions
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
        /// [Required] File or directory of files that the command checks for foreceignored files
        /// </summary>
        [SwitchName("--sourcepath")]
        public string sourcepath { get; set; }
    }

    /// <summary>
    /// Options for the method open of class Source.
    /// </summary>
    public class SourceOpenOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] File to edit
        /// </summary>
        [SwitchName("--sourcefile")]
        public string sourcefile { get; set; }

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
        /// [Optional] Generate a navigation URL; don’t launch the editor
        /// </summary>
        [SwitchName("--urlonly")]
        public bool? urlonly { get; set; }
    }

    /// <summary>
    /// Options for the method pull of class Source.
    /// </summary>
    public class SourcePullOptions : SFDXOptions
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
        /// [Required] The number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }

        /// <summary>
        /// [Optional] Runs the pull command even if conflicts exist. Changes in the scratch org overwrite changes in the project.
        /// </summary>
        [SwitchName("--forceoverwrite")]
        public bool? forceoverwrite { get; set; }
    }

    /// <summary>
    /// Options for the method push of class Source.
    /// </summary>
    public class SourcePushOptions : SFDXOptions
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
        /// [Optional] Runs the push command even if conflicts exist. Changes in the project overwrite changes in the scratch org.
        /// </summary>
        [SwitchName("--forceoverwrite")]
        public bool? forceoverwrite { get; set; }

        /// <summary>
        /// [Optional] Completes the deployment even if warnings are generated.
        /// </summary>
        [SwitchName("--ignorewarnings")]
        public bool? ignorewarnings { get; set; }

        /// <summary>
        /// [Optional] Replaces tokens in source files prior to deployment.
        /// </summary>
        [SwitchName("--replacetokens")]
        public bool? replacetokens { get; set; }

        /// <summary>
        /// [Required] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }
    }

    /// <summary>
    /// Options for the method retrieve of class Source.
    /// </summary>
    public class SourceRetrieveOptions : SFDXOptions
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
        /// [Required] Comma-separated list of source file paths to retrieve
        /// </summary>
        [SwitchName("--sourcepath")]
        public string sourcepath { get; set; }

        /// <summary>
        /// [Required] Wait time for command to finish in minutes
        /// </summary>
        [SwitchName("--wait")]
        public string wait { get; set; }

        /// <summary>
        /// [Required] File path for manifest (package.xml) of components to retrieve
        /// </summary>
        [SwitchName("--manifest")]
        public string manifest { get; set; }

        /// <summary>
        /// [Required] Comma-separated list of metadata component names
        /// </summary>
        [SwitchName("--metadata")]
        public string metadata { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of packages to retrieve
        /// </summary>
        [SwitchName("--packagenames")]
        public string packagenames { get; set; }

        /// <summary>
        /// [Optional] Verbose output of retrieve result
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }
    }

    /// <summary>
    /// Options for the method status of class Source.
    /// </summary>
    public class SourceStatusOptions : SFDXOptions
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
        /// [Optional] Lists all the changes that have been made.
        /// </summary>
        [SwitchName("--all")]
        public bool? all { get; set; }

        /// <summary>
        /// [Optional] Lists the changes that have been made locally.
        /// </summary>
        [SwitchName("--local")]
        public bool? local { get; set; }

        /// <summary>
        /// [Optional] Lists the changes that have been made in the scratch org.
        /// </summary>
        [SwitchName("--remote")]
        public bool? remote { get; set; }
    }

    /// <summary>
    /// Options for the method trackingClear of class Source.
    /// </summary>
    public class SourceTrackingClearOptions : SFDXOptions
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
        /// [Optional] Do not prompt for source tracking override confirmation
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Options for the method trackingReset of class Source.
    /// </summary>
    public class SourceTrackingResetOptions : SFDXOptions
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
        /// [Required] Reset to a specific SourceMember revision counter number
        /// </summary>
        [SwitchName("--revision")]
        public string revision { get; set; }

        /// <summary>
        /// [Optional] Do not prompt for source tracking override confirmation
        /// </summary>
        [SwitchName("--noprompt")]
        public bool? noprompt { get; set; }
    }

    /// <summary>
    /// Source
    /// </summary>
    [CommandClass("force:source")]
    public class Source : SFDXCommand
    {
        /// Constructor.
        public Source(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// convert source into Metadata API format
        /// </summary>
        /// <remarks>
        /// convert source into Metadata API format
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:source:convert -r path/to/source
        /// $ sfdx force:source:convert -r path/to/source -d path/to/outputdir -n 'My Package'
        /// force:source:convert [-r <directory>] [-d <directory>] [-n <string>] [-p <array> | -x <string> | -m <array>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("convert")]
        public SFDXResponse Convert(SourceConvertOptions p_Options)
        {
            return ExecuteCommand<SourceConvertOptions>(nameof(Convert), p_Options);
        }

        /// <summary>
        /// delete source from your project and from a non-source-tracked org
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Use this command to delete components from orgs that don’t have source tracking.
        /// To remove deleted items from scratch orgs, which have change tracking, use "sfdx force:source:push".
        /// 
        /// Examples:
        ///    $ sfdx force:source:delete -p path/to/source
        ///    $ sfdx force:source:delete -m <metadata>
        /// </summary>
        /// <remarks>
        /// delete source from your project and from a non-source-tracked org
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Use this command to delete components from orgs that don’t have source tracking.
        /// To remove deleted items from scratch orgs, which have change tracking, use "sfdx force:source:push".
        /// 
        /// Examples:
        ///    $ sfdx force:source:delete -p path/to/source
        ///    $ sfdx force:source:delete -m <metadata>
        /// </remarks>
        /// <example>
        /// Use this command to delete components from orgs that don’t have source tracking.
        /// To remove deleted items from scratch orgs, which have change tracking, use "sfdx force:source:push".
        /// 
        /// Examples:
        ///    $ sfdx force:source:delete -p path/to/source
        ///    $ sfdx force:source:delete -m <metadata>
        /// force:source:delete [-c] [-r] [-w <minutes>] [-p <array> | -m <array>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("delete")]
        public SFDXResponse Delete(SourceDeleteOptions p_Options)
        {
            return ExecuteCommand<SourceDeleteOptions>(nameof(Delete), p_Options);
        }

        /// <summary>
        /// deploy source to an org
        /// </summary>
        /// <remarks>
        /// deploy source to an org
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:source:deploy -p path/to/source
        /// $ sfdx force:source:deploy -p "path/to/apex/classes/MyClass.cls,path/to/source/objects"
        /// $ sfdx force:source:deploy -p "path/to/objects/MyCustomObject/fields/MyField.field-meta.xml, path/to/apex/classes"
        /// $ sfdx force:source:deploy -m ApexClass
        /// $ sfdx force:source:deploy -m ApexClass:MyApexClass
        /// $ sfdx force:source:deploy -m "CustomObject,ApexClass"
        /// $ sfdx force:source:deploy -m "ApexClass, Profile:My Profile, Profile: AnotherProfile"
        /// $ sfdx force:source:deploy -x path/to/package.xml
        /// $ sfdx force:source:deploy -m ApexClass -l RunLocalTests
        /// $ sfdx force:source:deploy -m ApexClass -l RunAllTestsInOrg -c
        /// $ sfdx force:source:deploy -q 0Af9A00000FTM6pSAH
        /// force:source:deploy [--soapdeploy] [-w <minutes>] [-q <id> | -x <filepath> | -m <array> | -p <array> | -c | -l NoTestRun|RunSpecifiedTests|RunLocalTests|RunAllTestsInOrg | -r <array> | -o | -g] [-u <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("deploy")]
        public SFDXResponse Deploy(SourceDeployOptions p_Options)
        {
            return ExecuteCommand<SourceDeployOptions>(nameof(Deploy), p_Options);
        }

        /// <summary>
        /// cancel a source deployment
        /// </summary>
        /// <remarks>
        /// cancel a source deployment
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:source:deploy:cancel
        /// $ sfdx force:source:deploy:cancel -w 2
        /// $ sfdx force:source:deploy:cancel -i <jobid>
        /// force:source:deploy:cancel [-w <minutes>] [-i <id>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("deploy:cancel")]
        public SFDXResponse DeployCancel(SourceDeployCancelOptions p_Options)
        {
            return ExecuteCommand<SourceDeployCancelOptions>(nameof(DeployCancel), p_Options);
        }

        /// <summary>
        /// check the status of a metadata deployment
        /// </summary>
        /// <remarks>
        /// check the status of a metadata deployment
        /// </remarks>
        /// <example>
        /// 
        /// Deploy a directory of files to the org
        ///  $ sfdx force:source:deploy -d <directory>
        /// Now cancel this deployment and wait two minutes
        ///  $ sfdx force:source:deploy:cancel -w 2
        /// If you have multiple deployments in progress and want to cancel a specific one, specify the job ID
        ///  $ sfdx force:source:deploy:cancel -i <jobid>
        /// Check the status of the cancel job
        ///  $ sfdx force:source:deploy:report
        /// force:source:deploy:report [-w <minutes>] [-i <id>] [-u <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("deploy:report")]
        public SFDXResponse DeployReport(SourceDeployReportOptions p_Options)
        {
            return ExecuteCommand<SourceDeployReportOptions>(nameof(DeployReport), p_Options);
        }

        /// <summary>
        /// check your local project package directories for forceignored files
        /// 
        /// Check your local project's package directories for forceignored files.
        /// 
        /// Use the --sourcepath parameter to limit the check to a specific file or directory. If you specify a directory, the command checks all sub-directories recursively.
        /// </summary>
        /// <remarks>
        /// check your local project package directories for forceignored files
        /// 
        /// Check your local project's package directories for forceignored files.
        /// 
        /// Use the --sourcepath parameter to limit the check to a specific file or directory. If you specify a directory, the command checks all sub-directories recursively.
        /// </remarks>
        /// <example>
        /// 
        /// force:source:ignored:list [-p <filepath>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("ignored:list")]
        public SFDXResponse IgnoredList(SourceIgnoredListOptions p_Options)
        {
            return ExecuteCommand<SourceIgnoredListOptions>(nameof(IgnoredList), p_Options);
        }

        /// <summary>
        /// edit a Lightning Page with Lightning App Builder
        /// Opens the specified Lightning Page in Lightning App Builder. Lightning Page files have the suffix .flexipage-meta.xml, and are stored in the flexipages directory. If you specify a different type of file, this command opens your org’s home page.
        /// </summary>
        /// <remarks>
        /// edit a Lightning Page with Lightning App Builder
        /// Opens the specified Lightning Page in Lightning App Builder. Lightning Page files have the suffix .flexipage-meta.xml, and are stored in the flexipages directory. If you specify a different type of file, this command opens your org’s home page.
        /// </remarks>
        /// <example>
        /// 
        /// $ sfdx force:source:open -f path/to/source
        /// $ sfdx force:source:open -r -f path/to/source
        /// $ sfdx force:source:open -f path/to/source -u my-user@my-org.com
        /// force:source:open -f <filepath> [-r] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("open")]
        public SFDXResponse Open(SourceOpenOptions p_Options)
        {
            return ExecuteCommand<SourceOpenOptions>(nameof(Open), p_Options);
        }

        /// <summary>
        /// pull source from the scratch org to the project
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
        /// </summary>
        /// <remarks>
        /// pull source from the scratch org to the project
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
        /// </remarks>
        /// <example>
        /// If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
        /// force:source:pull [-w <minutes>] [-f] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("pull")]
        public SFDXResponse Pull(SourcePullOptions p_Options)
        {
            return ExecuteCommand<SourcePullOptions>(nameof(Pull), p_Options);
        }

        /// <summary>
        /// push source to a scratch org from the project
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
        /// </summary>
        /// <remarks>
        /// push source to a scratch org from the project
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
        /// </remarks>
        /// <example>
        /// If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
        /// force:source:push [-f] [-g] [-w <minutes>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("push")]
        public SFDXResponse Push(SourcePushOptions p_Options)
        {
            return ExecuteCommand<SourcePushOptions>(nameof(Push), p_Options);
        }

        /// <summary>
        /// retrieve source from an org
        /// </summary>
        /// <remarks>
        /// retrieve source from an org
        /// </remarks>
        /// <example>
        /// 
        /// sfdx force:source:retrieve -p path/to/source
        /// sfdx force:source:retrieve -p "path/to/apex/classes/MyClass.cls,path/to/source/objects"
        /// sfdx force:source:retrieve -p "path/to/objects/MyCustomObject/fields/MyField.field-meta.xml, path/to/apex/classes"
        /// sfdx force:source:retrieve -m ApexClass
        /// sfdx force:source:retrieve -m ApexClass:MyApexClass
        /// sfdx force:source:retrieve -m "CustomObject,ApexClass"
        /// sfdx force:source:retrieve -x path/to/package.xml
        /// sfdx force:source:retrieve -n "Package1, PackageName With Spaces, Package3"
        /// sfdx force:source:retrieve -n MyPackageName -p path/to/apex/classes
        /// sfdx force:source:retrieve -n MyPackageName -x path/to/package.xml
        /// force:source:retrieve [-p <array> | -x <filepath> | -m <array>] [-w <minutes>] [-n <array>] [-u <string>] [-a <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("retrieve")]
        public SFDXResponse Retrieve(SourceRetrieveOptions p_Options)
        {
            return ExecuteCommand<SourceRetrieveOptions>(nameof(Retrieve), p_Options);
        }

        /// <summary>
        /// list local changes and/or changes in a scratch org
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Examples:
        ///    $ sfdx force:source:status -l
        ///    $ sfdx force:source:status -r
        ///    $ sfdx force:source:status -a
        ///    $ sfdx force:source:status -a -u me@example.com --json
        /// </summary>
        /// <remarks>
        /// list local changes and/or changes in a scratch org
        /// 
        /// NOTE: This command must be run from within a project.
        /// 
        /// Examples:
        ///    $ sfdx force:source:status -l
        ///    $ sfdx force:source:status -r
        ///    $ sfdx force:source:status -a
        ///    $ sfdx force:source:status -a -u me@example.com --json
        /// </remarks>
        /// <example>
        /// Examples:
        ///    $ sfdx force:source:status -l
        ///    $ sfdx force:source:status -r
        ///    $ sfdx force:source:status -a
        ///    $ sfdx force:source:status -a -u me@example.com --json
        /// force:source:status [-a] [-l] [-r] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("status")]
        public SFDXResponse Status(SourceStatusOptions p_Options)
        {
            return ExecuteCommand<SourceStatusOptions>(nameof(Status), p_Options);
        }

        /// <summary>
        /// clear all local source tracking information
        /// 
        /// WARNING: This command deletes or overwrites all existing source tracking files. Use with extreme caution.
        /// 
        /// Clears all local source tracking information. When you next run force:source:status, the CLI displays all local and remote files as changed, and any files with the same name are listed as conflicts.
        /// </summary>
        /// <remarks>
        /// clear all local source tracking information
        /// 
        /// WARNING: This command deletes or overwrites all existing source tracking files. Use with extreme caution.
        /// 
        /// Clears all local source tracking information. When you next run force:source:status, the CLI displays all local and remote files as changed, and any files with the same name are listed as conflicts.
        /// </remarks>
        /// <example>
        /// 
        /// force:source:tracking:clear [-p] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("tracking:clear")]
        public SFDXResponse TrackingClear(SourceTrackingClearOptions p_Options)
        {
            return ExecuteCommand<SourceTrackingClearOptions>(nameof(TrackingClear), p_Options);
        }

        /// <summary>
        /// reset local and remote source tracking
        /// 
        /// WARNING: This command deletes or overwrites all existing source tracking files. Use with extreme caution.
        /// 
        /// Resets local and remote source tracking so that the CLI no longer registers differences between your local files and those in the org. When you next run force:source:status, the CLI returns no results, even though conflicts might actually exist. The CLI then resumes tracking new source changes as usual.
        /// 
        /// Use the --revision parameter to reset source tracking to a specific revision number of an org source member. To get the revision number, query the SourceMember Tooling API object with the force:data:soql:query command. For example:
        ///   $ sfdx force:data:soql:query -q "SELECT MemberName, MemberType, RevisionCounter FROM SourceMember" -t
        /// </summary>
        /// <remarks>
        /// reset local and remote source tracking
        /// 
        /// WARNING: This command deletes or overwrites all existing source tracking files. Use with extreme caution.
        /// 
        /// Resets local and remote source tracking so that the CLI no longer registers differences between your local files and those in the org. When you next run force:source:status, the CLI returns no results, even though conflicts might actually exist. The CLI then resumes tracking new source changes as usual.
        /// 
        /// Use the --revision parameter to reset source tracking to a specific revision number of an org source member. To get the revision number, query the SourceMember Tooling API object with the force:data:soql:query command. For example:
        ///   $ sfdx force:data:soql:query -q "SELECT MemberName, MemberType, RevisionCounter FROM SourceMember" -t
        /// </remarks>
        /// <example>
        /// 
        /// force:source:tracking:reset [-r <integer>] [-p] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("tracking:reset")]
        public SFDXResponse TrackingReset(SourceTrackingResetOptions p_Options)
        {
            return ExecuteCommand<SourceTrackingResetOptions>(nameof(TrackingReset), p_Options);
        }
    }
}

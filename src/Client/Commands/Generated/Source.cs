// Generated on Tue Mar 10 2020 using sfdx-cli/7.43.1 win32-x64 node-v12.16.1. DO NOT MODIFY
// Copyright (c) 2005-2020, Coveo Solutions Inc.

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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A directory other than the default package directory that contains the source-formatted files to convert.
        /// </summary>
        [SwitchName("--rootdir")]
        public string rootdir { get; set; }

        /// <summary>
        /// [Required] The output directory to store the Metadata API–formatted metadata files in.
        /// </summary>
        [SwitchName("--outputdir")]
        public string outputdir { get; set; }

        /// <summary>
        /// [Required] The name of the package to associate with the metadata-formatted files.
        /// </summary>
        [SwitchName("--packagename")]
        public string packagename { get; set; }

        /// <summary>
        /// [Required] The complete path to the manifest (package.xml) file that specifies the metadata types to convert.
        /// If you specify this parameter, don’t specify --metadata or --sourcepath.
        /// </summary>
        [SwitchName("--manifest")]
        public string manifest { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of paths to the local source files to convert. The supplied paths can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all metadata types in the directory and its sub-directories).
        /// If you specify this parameter, don’t specify --manifest or --metadata.
        /// </summary>
        [SwitchName("--sourcepath")]
        public string sourcepath { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of metadata component names to convert.
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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
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
        /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Validates the deployed metadata and runs all Apex tests, but prevents the deployment from being saved to the org.
        /// If you change a field type from Master-Detail to Lookup or vice versa, that change isn’t supported when using the --checkonly parameter to test a deployment (validation). This kind of change isn’t supported for test deployments to avoid the risk of data loss or corruption. If a change that isn’t supported for test deployments is included in a deployment package, the test deployment fails and issues an error.
        /// If your deployment package changes a field type from Master-Detail to Lookup or vice versa, you can still validate the changes prior to deploying to Production by performing a full deployment to another test Sandbox. A full deployment includes a validation of the changes as part of the deployment process.
        /// Note: A Metadata API deployment that includes Master-Detail relationships deletes all detail records in the Recycle Bin in the following cases.
        /// 1. For a deployment with a new Master-Detail field, soft delete (send to the Recycle Bin) all detail records before proceeding to deploy the Master-Detail field, or the deployment fails. During the deployment, detail records are permanently deleted from the Recycle Bin and cannot be recovered.
        /// 2. For a deployment that converts a Lookup field relationship to a Master-Detail relationship, detail records must reference a master record or be soft-deleted (sent to the Recycle Bin) for the deployment to succeed. However, a successful deployment permanently deletes any detail records in the Recycle Bin.
        /// </summary>
        [SwitchName("--checkonly")]
        public bool? checkonly { get; set; }

        /// <summary>
        /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Required] Specifies which level of deployment tests to run. Valid values are:
        /// NoTestRun—No tests are run. This test level applies only to deployments to development environments, such as sandbox, Developer Edition, or trial orgs. This test level is the default for development environments.
        /// RunSpecifiedTests—Runs only the tests that you specify in the --runtests option. Code coverage requirements differ from the default coverage requirements when using this test level. Executed tests must comprise a minimum of 75% code coverage for each class and trigger in the deployment package. This coverage is computed for each class and trigger individually and is different than the overall coverage percentage.
        /// RunLocalTests—All tests in your org are run, except the ones that originate from installed managed packages. This test level is the default for production deployments that include Apex classes or triggers.
        /// RunAllTestsInOrg—All tests in your org are run, including tests of managed packages.
        /// If you don’t specify a test level, the default behavior depends on the contents of your deployment package. For more information, see “Running Tests in a Deployment” in the Metadata API Developer Guide.
        /// </summary>
        [SwitchName("--testlevel")]
        public string testlevel { get; set; }

        /// <summary>
        /// [Required] Lists the Apex classes containing the deployment tests to run. Use this parameter when you set --testlevel to RunSpecifiedTests.
        /// </summary>
        [SwitchName("--runtests")]
        public string runtests { get; set; }

        /// <summary>
        /// [Optional] Ignores the deploy errors, and continues with the deploy operation. The default is false. Keep this parameter set to false when deploying to a production org. If set to true, components without errors are deployed, and components with errors are skipped.
        /// </summary>
        [SwitchName("--ignoreerrors")]
        public bool? ignoreerrors { get; set; }

        /// <summary>
        /// [Optional] If a warning occurs and ignoreWarnings is set to true, the success field in DeployMessage is true. When ignoreWarnings is set to false, success is set to false, and the warning is treated like an error.
        /// This field is available in API version 18.0 and later. Prior to version 18.0, there was no distinction between warnings and errors. All problems were treated as errors and prevented a successful deployment.
        /// </summary>
        [SwitchName("--ignorewarnings")]
        public bool? ignorewarnings { get; set; }

        /// <summary>
        /// [Required] Specifies the ID of a package with recently validated components to run a Quick Deploy. Deploying a validation helps you shorten your deployment time because tests aren’t rerun. If you have a recent successful validation, you can deploy the validated components without running tests. A validation doesn’t save any components in the org. You use a validation only to check the success or failure messages that you would receive with an actual deployment. To validate your components, add the -c | --checkonly flag when you run "sfdx force:mdapi:deploy". This flag sets the checkOnly="true" parameter for your deployment. Before deploying a recent validation, ensure that the following requirements are met:
        /// 1. The components have been validated successfully for the target environment within the last 10 days.
        /// 2. As part of the validation, Apex tests in the target org have passed.
        /// 3. Code coverage requirements are met.
        ///      - If all tests in the org or all local tests are run, overall code coverage is at least 75%, and Apex triggers have some coverage.
        ///      - If specific tests are run with the RunSpecifiedTests test level, each class and trigger that was deployed is covered by at least 75% individually.
        /// </summary>
        [SwitchName("--validateddeployrequestid")]
        public string validateddeployrequestid { get; set; }

        /// <summary>
        /// [Optional] Indicates that you want verbose output from the deploy operation.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? verbose { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of names of metadata components to deploy to the org.
        /// </summary>
        [SwitchName("--metadata")]
        public string metadata { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of paths to the local source files to deploy. The supplied paths can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all metadata types in the directory and its sub-directories).
        /// If you specify this parameter, don’t specify --manifest or --metadata.
        /// </summary>
        [SwitchName("--sourcepath")]
        public string sourcepath { get; set; }

        /// <summary>
        /// [Required] The complete path for the manifest (package.xml) file that specifies the components to deploy.
        /// If you specify this parameter, don’t specify --metadata or --sourcepath.
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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Required] The job ID (requestId) of the deployment you want to cancel. If not specified, the default value is the ID of the most recent source deployment you ran using Salesforce CLI.
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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Required] The job ID (asyncId) of the deployment you want to check. If not specified, the default value is the ID of the most recent metadata deployment you ran using Salesforce CLI. Use with -w to resume waiting.
        /// </summary>
        [SwitchName("--jobid")]
        public string jobid { get; set; }
    }

    /// <summary>
    /// Options for the method open of class Source.
    /// </summary>
    public class SourceOpenOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] File to edit.
        /// </summary>
        [SwitchName("--sourcefile")]
        public string sourcefile { get; set; }

        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Generate a navigation URL path, but don’t launch a browser-based editor.
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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] The number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
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
        /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }
    }

    /// <summary>
    /// Options for the method retrieve of class Source.
    /// </summary>
    public class SourceRetrieveOptions : SFDXOptions
    {
        /// <summary>
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Use to override the default, which is the latest version supported by your CLI plug-in, with the version in your package.xml file.
        /// </summary>
        [SwitchName("--apiversion")]
        public string apiversion { get; set; }

        /// <summary>
        /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
        /// </summary>
        [SwitchName("--wait")]
        public int? wait { get; set; }

        /// <summary>
        /// [Required] The complete path for the manifest (package.xml) file that specifies the components to retrieve.
        /// If you specify this parameter, don’t specify --metadata or --sourcepath.
        /// </summary>
        [SwitchName("--manifest")]
        public string manifest { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of names of metadata components to retrieve from the org.
        /// </summary>
        [SwitchName("--metadata")]
        public string metadata { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of package names to retrieve.
        /// </summary>
        [SwitchName("--packagenames")]
        public string packagenames { get; set; }

        /// <summary>
        /// [Required] A comma-separated list of file paths for source to retrieve from the org. The supplied paths can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all source files in the directory and its sub-directories).
        /// </summary>
        [SwitchName("--sourcepath")]
        public string sourcepath { get; set; }

        /// <summary>
        /// [Optional] Indicates that you want verbose output from the retrieve operation.
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
        /// [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? loglevel { get; set; }

        /// <summary>
        /// [Required] A username or alias for the target org. Overrides the default target org.
        /// </summary>
        [SwitchName("--targetusername")]
        public string targetusername { get; set; }

        /// <summary>
        /// [Required] Override the API version used for API requests made by this command.
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
        /// Converts source-formatted files into metadata that you can deploy using Metadata API.
        /// </remarks>
        /// <example>
        /// To convert source-formatted files into the metadata format, so that you can deploy them using Metadata API, run "sfdx force:source:convert". Then deploy the metadata using "sfdx force:mdapi:deploy".
        /// 
        /// To convert Metadata API–formatted files into the source format, run "sfdx force:mdapi:convert".
        /// 
        /// To specify a package name that includes spaces, enclose the name in single quotes.
        /// 
        /// Examples:
        ///    $ sfdx force:source:convert -r path/to/source
        ///    $ sfdx force:source:convert -r path/to/source -d path/to/outputdir -n 'My Package'
        /// force:source:convert [-r <directory>] [-d <directory>] [-n <string>] [-p <array> | -x <string> | -m <array>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("convert")]
        public SFDXResponse Convert(SourceConvertOptions p_Options)
        {
            return ExecuteCommand<SourceConvertOptions>(nameof(Convert), p_Options);
        }

        /// <summary>
        /// delete source from your project and from a non-source-tracked org
        /// </summary>
        /// <remarks>
        /// Deletes source files from your project and from a non-source-tracked org, such as a sandbox.
        /// </remarks>
        /// <example>
        /// Use this command to delete components from orgs that don’t have source tracking, such as sandboxes.
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
        /// Deploys metadata in source format to an org.
        /// </remarks>
        /// <example>
        /// Use this command to deploy source (metadata that’s in source format) to an org.
        /// To take advantage of change tracking with scratch orgs, use "sfdx force:source:push".
        /// To deploy metadata that’s in metadata format, use "sfdx force:mdapi:deploy".
        /// 
        /// The source you deploy overwrites the corresponding metadata in your org. This command does not attempt to merge your source with the versions in your org.
        /// 
        /// To run the command asynchronously, set --wait to 0, which immediately returns the job ID. This way, you can continue to use the CLI.
        /// To check the status of the job, use force:source:deploy:report.
        /// 
        /// If the comma-separated list you’re supplying contains spaces, enclose the entire comma-separated list in one set of double quotes.
        /// 
        /// Examples:
        /// 
        /// To deploy the source files in a directory:
        ///    $ sfdx force:source:deploy -p path/to/source
        /// To deploy a specific Apex class and the objects whose source is in a directory:
        ///    $ sfdx force:source:deploy -p path/to/apex/classes/MyClass.cls,path/to/source/objects
        /// To deploy source files in a comma-separated list that contains spaces:
        ///    $ sfdx force:source:deploy -p "path/to/objects/MyCustomObject/fields/MyField.field-meta.xml, path/to/apex/classes"
        /// 
        /// To deploy all Apex classes:
        ///    $ sfdx force:source:deploy -m ApexClass
        /// To deploy a specific Apex class:
        ///    $ sfdx force:source:deploy -m ApexClass:MyApexClass
        /// To deploy all custom objects and Apex classes:
        ///    $ sfdx force:source:deploy -m CustomObject,ApexClass
        /// To deploy all Apex classes and two specific profiles (one of which has a space in its name):
        ///    $ sfdx force:source:deploy -m "ApexClass, Profile:My Profile, Profile: AnotherProfile"
        /// 
        /// To deploy all components listed in a manifest:
        ///    $ sfdx force:source:deploy -x path/to/package.xml
        /// 
        /// To run the tests that aren’t in any managed packages as part of a deployment:
        ///    $ sfdx force:source:deploy -m ApexClass -l RunLocalTests
        /// 
        /// To check whether a deployment would succeed (to prepare for Quick Deploy):
        ///    $ sfdx force:source:deploy -m ApexClass -l RunAllTestsInOrg -c
        /// 
        /// To deploy an already validated deployment (Quick Deploy):
        ///     $ sfdx force:source:deploy -q 0Af9A00000FTM6pSAH
        /// force:source:deploy [-w <minutes>] [-q <id> | -x <filepath> | -m <array> | -p <array> | -c | -l NoTestRun|RunSpecifiedTests|RunLocalTests|RunAllTestsInOrg | -r <array> | -o | -g] [-u <string>] [--apiversion <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
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
        /// Cancels an asynchronous source deployment.
        /// </remarks>
        /// <example>
        /// Use this command to cancel a specified asynchronous source deployment. You can also specify a wait time (in minutes) to check for updates to the canceled deploy status.
        /// 
        /// To run the command asynchronously, set --wait to 0, which immediately returns the job ID. This way, you can continue to use the CLI.
        /// To check the status of the job, use force:source:deploy:report.
        /// 
        /// Examples:
        /// 
        /// Deploy a directory of files to the org
        ///   $ sfdx force:source:deploy -d <directory>
        /// Now cancel this deployment and wait two minutes
        ///   $ sfdx force:source:deploy:cancel -w 2
        /// 
        /// If you have multiple deployments in progress and want to cancel a specific one, specify the job ID
        ///   $ sfdx force:source:deploy:cancel -i <jobid>
        /// Check the status of the cancel job
        ///   $ sfdx force:source:deploy:report
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
        /// Checks the current status of an asynchronous metadata deployment.
        /// </remarks>
        /// <example>
        /// Specify the job ID for the deploy you want to check. You can also specify a wait time (minutes) to check for updates to the deploy status.
        /// 
        /// Examples:
        /// 
        /// Deploy a directory of files to the org
        ///   $ sfdx force:source:deploy -d <directory>
        /// Now cancel this deployment and wait two minutes
        ///   $ sfdx force:source:deploy:cancel -w 2
        /// 
        /// If you have multiple deployments in progress and want to cancel a specific one, specify the job ID
        ///   $ sfdx force:source:deploy:cancel -i <jobid>
        /// Check the status of the cancel job
        ///   $ sfdx force:source:deploy:report
        /// force:source:deploy:report [-w <minutes>] [-i <id>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("deploy:report")]
        public SFDXResponse DeployReport(SourceDeployReportOptions p_Options)
        {
            return ExecuteCommand<SourceDeployReportOptions>(nameof(DeployReport), p_Options);
        }

        /// <summary>
        /// edit a Lightning Page with Lightning App Builder
        /// </summary>
        /// <remarks>
        /// Opens the specified Lightning Page in Lightning App Builder. Lightning Page files have the suffix .flexipage-meta.xml, and are stored in the flexipages directory. If you specify a different type of file, this command opens your org’s home page.
        /// </remarks>
        /// <example>
        /// The file opens in your default browser.
        /// If no browser-based editor is available for the selected file, this command opens your org’s home page.
        /// To generate a URL for the browser-based editor but not open the editor, use --urlonly.
        /// 
        /// Examples:
        ///    $ sfdx force:source:open -f Property_Record_Page.flexipage-meta.xml
        ///    $ sfdx force:source:open -f Property_Record_Page.flexipage-meta.xml -r
        /// force:source:open -f <filepath> [-r] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("open")]
        public SFDXResponse Open(SourceOpenOptions p_Options)
        {
            return ExecuteCommand<SourceOpenOptions>(nameof(Open), p_Options);
        }

        /// <summary>
        /// pull source from the scratch org to the project
        /// </summary>
        /// <remarks>
        /// Pulls changed source from the scratch org to your project to keep them in sync.
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
        /// </summary>
        /// <remarks>
        /// Pushes changed source from your project to a scratch org to keep them in sync.
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
        /// Retrieves metadata in source format from an org to your local Salesforce DX project.
        /// </remarks>
        /// <example>
        /// Use this command to retrieve source (metadata that’s in source format) from an org.
        /// To take advantage of change tracking with scratch orgs, use "sfdx force:source:pull".
        /// To retrieve metadata that’s in metadata format, use "sfdx force:mdapi:retrieve".
        /// 
        /// The source you retrieve overwrites the corresponding source files in your local project. This command does not attempt to merge the source from your org with your local source files.
        /// 
        /// If the comma-separated list you’re supplying contains spaces, enclose the entire comma-separated list in one set of double quotes.
        /// 
        /// Examples:
        /// 
        /// To retrieve the source files in a directory:
        ///    $ sfdx force:source:retrieve -p path/to/source
        /// To retrieve a specific Apex class and the objects whose source is in a directory:
        ///    $ sfdx force:source:retrieve -p path/to/apex/classes/MyClass.cls,path/to/source/objects
        /// To retrieve source files in a comma-separated list that contains spaces:
        ///    $ sfdx force:source:retrieve -p "path/to/objects/MyCustomObject/fields/MyField.field-meta.xml, path/to/apex/classes"
        /// 
        /// To retrieve all Apex classes:
        ///    $ sfdx force:source:retrieve -m ApexClass
        /// To retrieve a specific Apex class:
        ///    $ sfdx force:source:retrieve -m ApexClass:MyApexClass
        /// To retrieve all custom objects and Apex classes:
        ///    $ sfdx force:source:retrieve -m CustomObject,ApexClass
        /// To retrieve all Apex classes and two specific profiles (one of which has a space in its name):
        ///    $ sfdx force:source:retrieve -m "ApexClass, Profile:My Profile, Profile: AnotherProfile"
        /// 
        /// To retrieve all metadata components listed in a manifest:
        ///    $ sfdx force:source:retrieve -x path/to/package.xml
        /// 
        /// To retrieve metadata from a package or multiple packages:
        ///    $ sfdx force:source:retrieve -n MyPackageName
        ///    $ sfdx force:source:retrieve -n "Package1, PackageName With Spaces, Package3"
        /// 
        /// To retrieve all metadata from a package and specific components that aren’t in the package, specify both -n | --packagenames and one other scoping parameter:
        ///    $ sfdx force:source:retrieve -n MyPackageName -p path/to/apex/classes
        ///    $ sfdx force:source:retrieve -n MyPackageName -m ApexClass:MyApexClass
        ///    $ sfdx force:source:retrieve -n MyPackageName -x path/to/package.xml
        /// force:source:retrieve [-w <minutes>] [-x <filepath> | -m <array> | -p <array>] [-n <array>] [-u <string>] [-a <string>] [--verbose] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("retrieve")]
        public SFDXResponse Retrieve(SourceRetrieveOptions p_Options)
        {
            return ExecuteCommand<SourceRetrieveOptions>(nameof(Retrieve), p_Options);
        }

        /// <summary>
        /// list local changes and/or changes in a scratch org
        /// </summary>
        /// <remarks>
        /// Lists changes that have been made locally, in a scratch org, or both.
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
    }
}

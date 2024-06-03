// Generated on Mon Jun 03 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method ConvertMdapi of class Project.
    /// </summary>
    public class ProjectConvertMdapiOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for root-dir
        /// </summary>
        [SwitchName("--root-dir")]
        public string RootDir { get; set; }

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
        /// [Optional] No description for output-dir
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

        /// <summary>
        /// [Optional] If you specify this parameter, don’t specify --metadata or --source-dir.
        /// </summary>
        [SwitchName("--manifest")]
        public string Manifest { get; set; }

        /// <summary>
        /// [Optional] The supplied paths can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all metadata types in the directory and its sub-directories).
        /// 
        /// If you specify this flag, don’t specify --manifest or --metadata. If the comma-separated list you’re supplying contains spaces, enclose the entire comma-separated list in one set of double quotes.
        /// </summary>
        [SwitchName("--metadata-dir")]
        public string MetadataDir { get; set; }

        /// <summary>
        /// [Optional] No description for metadata
        /// </summary>
        [SwitchName("--metadata")]
        public string Metadata { get; set; }
    }

    /// <summary>
    /// Options for the method ConvertSource of class Project.
    /// </summary>
    public class ProjectConvertSourceOptions : SfOptions
    {
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
        /// [Optional] No description for root-dir
        /// </summary>
        [SwitchName("--root-dir")]
        public string RootDir { get; set; }

        /// <summary>
        /// [Optional] No description for output-dir
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

        /// <summary>
        /// [Optional] No description for package-name
        /// </summary>
        [SwitchName("--package-name")]
        public string PackageName { get; set; }

        /// <summary>
        /// [Optional] If you specify this parameter, don’t specify --metadata or --source-dir.
        /// </summary>
        [SwitchName("--manifest")]
        public string Manifest { get; set; }

        /// <summary>
        /// [Optional] The supplied paths can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all metadata types in the directory and its sub-directories).
        /// 
        /// If you specify this parameter, don’t specify --manifest or --metadata.
        /// </summary>
        [SwitchName("--source-dir")]
        public string SourceDir { get; set; }

        /// <summary>
        /// [Optional] No description for metadata
        /// </summary>
        [SwitchName("--metadata")]
        public string Metadata { get; set; }
    }

    /// <summary>
    /// Options for the method DeleteSource of class Project.
    /// </summary>
    public class ProjectDeleteSourceOptions : SfOptions
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
        /// [Optional] IMPORTANT: Where possible, we changed noninclusive terms to align with our company value of Equality. We maintained certain terms to avoid any effect on customer implementations.
        /// 
        /// Validates the deleted metadata and runs all Apex tests, but prevents the deletion from being saved to the org.
        /// 
        /// If you change a field type from Master-Detail to Lookup or vice versa, that change isn’t supported when using the --chec-konly parameter to test a deletion (validation). This kind of change isn’t supported for test deletions to avoid the risk of data loss or corruption. If a change that isn’t supported for test deletions is included in a deletion package, the test deletion fails and issues an error.
        /// 
        /// If your deletion package changes a field type from Master-Detail to Lookup or vice versa, you can still validate the changes prior to deploying to Production by performing a full deletion to another test Sandbox. A full deletion includes a validation of the changes as part of the deletion process.
        /// 
        /// Note: A Metadata API deletion that includes Master-Detail relationships deletes all detail records in the Recycle Bin in the following cases.
        /// 
        ///     1. For a deletion with a new Master-Detail field, soft delete (send to the Recycle Bin) all detail records before proceeding to delete the Master-Detail field, or the deletion fails. During the deletion, detail records are permanently deleted from the Recycle Bin and cannot be recovered.
        /// 
        ///     2. For a deletion that converts a Lookup field relationship to a Master-Detail relationship, detail records must reference a master record or be soft-deleted (sent to the Recycle Bin) for the deletion to succeed. However, a successful deletion permanently deletes any detail records in the Recycle Bin.
        /// </summary>
        [SwitchName("--check-only")]
        public bool? CheckOnly { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you.
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] If a test name contains a space, enclose it in double quotes.
        /// For multiple test names, use one of the following formats:
        /// 
        /// - Repeat the flag for multiple test names: --tests Test1 --tests Test2 --tests "Test With Space"
        /// - Separate the test names with spaces: --tests Test1 Test2 "Test With Space"
        /// </summary>
        [SwitchName("--tests")]
        public string Tests { get; set; }

        /// <summary>
        /// [Optional] Valid values are:
        /// 
        /// - NoTestRun — No tests are run. This test level applies only to deployments to development environments, such as sandbox, Developer Edition, or trial orgs. This test level is the default for development environments.
        /// 
        /// - RunSpecifiedTests — Runs only the tests that you specify with the --tests flag. Code coverage requirements differ from the default coverage requirements when using this test level. Executed tests must comprise a minimum of 75% code coverage for each class and trigger in the deployment package. This coverage is computed for each class and trigger individually and is different than the overall coverage percentage.
        /// 
        /// - RunLocalTests — All tests in your org are run, except the ones that originate from installed managed and unlocked packages. This test level is the default for production deployments that include Apex classes or triggers.
        /// 
        /// - RunAllTestsInOrg — All tests in your org are run, including tests of managed packages.
        /// 
        /// If you don’t specify a test level, the default behavior depends on the contents of your deployment package and target org. For more information, see “Running Tests in a Deployment” in the Metadata API Developer Guide.
        /// </summary>
        [SwitchName("--test-level")]
        public string TestLevel { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }

        /// <summary>
        /// [Optional] If you specify this parameter, don’t specify --source-dir.
        /// </summary>
        [SwitchName("--metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// [Optional] The supplied paths can be a single file (in which case the operation is applied to only one file) or a folder (in which case the operation is applied to all metadata types in the directory and its sub-directories).
        /// 
        /// If you specify this parameter, don’t specify --metadata.
        /// </summary>
        [SwitchName("--source-dir")]
        public string SourceDir { get; set; }

        /// <summary>
        /// [Optional] No description for track-source
        /// </summary>
        [SwitchName("--track-source")]
        public bool? TrackSource { get; set; }

        /// <summary>
        /// [Optional] No description for force-overwrite
        /// </summary>
        [SwitchName("--force-overwrite")]
        public bool? ForceOverwrite { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }
    }

    /// <summary>
    /// Options for the method DeleteTracking of class Project.
    /// </summary>
    public class ProjectDeleteTrackingOptions : SfOptions
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
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }
    }

    /// <summary>
    /// Options for the method DeployCancel of class Project.
    /// </summary>
    public class ProjectDeployCancelOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Overrides your default org.
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] The command immediately returns the control of the terminal to you. This way, you can continue to use the CLI. To resume watching the cancellation, run "$ sf project deploy resume". To check the status of the cancellation, run "$ sf project deploy report".
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] These commands return a job ID if they time out or you specified the --async flag:
        /// 
        /// - $ sf project deploy start
        /// - $ sf project deploy validate
        /// - $ sf project deploy quick
        /// - $ sf project deploy cancel
        /// 
        /// The job ID is valid for 10 days from when you started the deploy operation.
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] For performance reasons, this flag uses job IDs for deploy operations that started only in the past 3 days or less. If your most recent deploy operations was more than 3 days ago, this flag won't find a job ID.
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you. To resume watching the cancellation, run "$ sf project deploy resume". To check the status of the cancellation, run "$ sf project deploy report".
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }
    }

    /// <summary>
    /// Options for the method DeployPipelineQuick of class Project.
    /// </summary>
    public class ProjectDeployPipelineQuickOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for devops-center-username
        /// </summary>
        [SwitchName("--devops-center-username")]
        public string DevopsCenterUsername { get; set; }

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
        /// [Optional] The command immediately returns the job ID and control of the terminal to you. This way, you can continue to use the CLI. To resume the deployment, run "sf project deploy pipeline resume". To check the status of the deployment, run "sf project deploy pipeline report".
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you and returns the job ID. To check the status of the operation, run "$ sf [%= command.id.split(' ').slice(0, -1).join(' ') %] report".
        /// </summary>
        [SwitchName("--wait")]
        public string Wait { get; set; }

        /// <summary>
        /// [Optional] The job ID is valid for 10 days from when you started the validation.
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] For performance reasons, this flag uses only job IDs that were validated in the past 3 days or less. If your most recent deployment validation was more than 3 days ago, this flag won't find the job ID.
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }
    }

    /// <summary>
    /// Options for the method DeployPipelineReport of class Project.
    /// </summary>
    public class ProjectDeployPipelineReportOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for devops-center-username
        /// </summary>
        [SwitchName("--devops-center-username")]
        public string DevopsCenterUsername { get; set; }

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
        /// [Optional] The job ID is valid for 10 days from when you started the deploy operation.
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] For performance reasons, this flag uses job IDs for deploy operations that started in the past 3 days or fewer. If your most recent operation was longer than 3 days ago, this flag won't find the job ID.
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }
    }

    /// <summary>
    /// Options for the method DeployPipelineResume of class Project.
    /// </summary>
    public class ProjectDeployPipelineResumeOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for devops-center-username
        /// </summary>
        [SwitchName("--devops-center-username")]
        public string DevopsCenterUsername { get; set; }

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
        /// [Optional] These commands return a job ID if they time out or you specified the --async flag:
        /// 
        /// - sf project deploy pipeline start
        /// - sf project deploy pipeline validate
        /// - sf project deploy pipeline quick
        /// 
        /// The job ID is valid for 10 days from when you started the deploy operation.
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] For performance reasons, this flag uses job IDs for operations that started in the past 3 days or fewer. If your most recent operation was longer than 3 days ago, this flag won't find a job ID.
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you and returns the job ID. To check the status of the operation, run "$ sf [%= command.id.split(' ').slice(0, -1).join(' ') %] report".
        /// </summary>
        [SwitchName("--wait")]
        public string Wait { get; set; }
    }

    /// <summary>
    /// Options for the method DeployPipelineStart of class Project.
    /// </summary>
    public class ProjectDeployPipelineStartOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for devops-center-username
        /// </summary>
        [SwitchName("--devops-center-username")]
        public string DevopsCenterUsername { get; set; }

        /// <summary>
        /// [Required] No description for devops-center-project-name
        /// </summary>
        [SwitchName("--devops-center-project-name")]
        public string DevopsCenterProjectName { get; set; }

        /// <summary>
        /// [Required] No description for branch-name
        /// </summary>
        [SwitchName("--branch-name")]
        public string BranchName { get; set; }

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
        /// [Optional] You must indicate the bundle version if deploying to the environment that corresponds to the first stage after the bundling stage.
        /// </summary>
        [SwitchName("--bundle-version-name")]
        public string BundleVersionName { get; set; }

        /// <summary>
        /// [Optional] If you don’t specify this flag, only changes in the stage’s branch are deployed.
        /// </summary>
        [SwitchName("--deploy-all")]
        public bool? DeployAll { get; set; }

        /// <summary>
        /// [Optional] Separate multiple test names with commas. Enclose the entire flag value in double quotes if a test name contains spaces.
        /// </summary>
        [SwitchName("--tests")]
        public string Tests { get; set; }

        /// <summary>
        /// [Optional] Valid values are:
        /// 
        /// - NoTestRun — No tests are run. This test level applies only to deployments to development environments, such as sandbox, Developer Edition, or trial orgs. This test level is the default for development environments.
        /// 
        /// - RunSpecifiedTests — Runs only the tests that you specify with the --tests flag. Code coverage requirements differ from the default coverage requirements when using this test level. Executed tests must comprise a minimum of 75% code coverage for each class and trigger in the deployment package. This coverage is computed for each class and trigger individually and is different than the overall coverage percentage.
        /// 
        /// - RunLocalTests — All tests in your org are run, except the ones that originate from installed managed and unlocked packages. This test level is the default for production deployments that include Apex classes or triggers.
        /// 
        /// - RunAllTestsInOrg — All tests in your org are run, including tests of managed packages.
        /// 
        /// If you don’t specify a test level, the default behavior depends on the contents of your deployment package. For more information, see [Running Tests in a Deployment](https://developer.salesforce.com/docs/atlas.en-us.api_meta.meta/api_meta/meta_deploy_running_tests.htm) in the "Metadata API Developer Guide".
        /// </summary>
        [SwitchName("--test-level")]
        public string TestLevel { get; set; }

        /// <summary>
        /// [Optional] The command immediately returns the job ID and control of the terminal to you. This way, you can continue to use the CLI. To resume the deployment, run "sf project deploy pipeline resume". To check the status of the deployment, run "sf project deploy pipeline report".
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you and returns the job ID. To check the status of the operation, run "$ sf [%= command.id.split(' ').slice(0, -1).join(' ') %] report".
        /// </summary>
        [SwitchName("--wait")]
        public string Wait { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }
    }

    /// <summary>
    /// Options for the method DeployPipelineValidate of class Project.
    /// </summary>
    public class ProjectDeployPipelineValidateOptions : SfOptions
    {
        /// <summary>
        /// [Required] No description for devops-center-username
        /// </summary>
        [SwitchName("--devops-center-username")]
        public string DevopsCenterUsername { get; set; }

        /// <summary>
        /// [Required] No description for devops-center-project-name
        /// </summary>
        [SwitchName("--devops-center-project-name")]
        public string DevopsCenterProjectName { get; set; }

        /// <summary>
        /// [Required] No description for branch-name
        /// </summary>
        [SwitchName("--branch-name")]
        public string BranchName { get; set; }

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
        /// [Optional] You must indicate the bundle version if deploying to the environment that corresponds to the first stage after the bundling stage.
        /// </summary>
        [SwitchName("--bundle-version-name")]
        public string BundleVersionName { get; set; }

        /// <summary>
        /// [Optional] If you don’t specify this flag, only changes in the stage’s branch are deployed.
        /// </summary>
        [SwitchName("--deploy-all")]
        public bool? DeployAll { get; set; }

        /// <summary>
        /// [Optional] Separate multiple test names with commas. Enclose the entire flag value in double quotes if a test name contains spaces.
        /// </summary>
        [SwitchName("--tests")]
        public string Tests { get; set; }

        /// <summary>
        /// [Optional] Valid values are:
        /// 
        /// - NoTestRun — No tests are run. This test level applies only to deployments to development environments, such as sandbox, Developer Edition, or trial orgs. This test level is the default for development environments.
        /// 
        /// - RunSpecifiedTests — Runs only the tests that you specify with the --tests flag. Code coverage requirements differ from the default coverage requirements when using this test level. Executed tests must comprise a minimum of 75% code coverage for each class and trigger in the deployment package. This coverage is computed for each class and trigger individually and is different than the overall coverage percentage.
        /// 
        /// - RunLocalTests — All tests in your org are run, except the ones that originate from installed managed and unlocked packages. This test level is the default for production deployments that include Apex classes or triggers.
        /// 
        /// - RunAllTestsInOrg — All tests in your org are run, including tests of managed packages.
        /// 
        /// If you don’t specify a test level, the default behavior depends on the contents of your deployment package. For more information, see [Running Tests in a Deployment](https://developer.salesforce.com/docs/atlas.en-us.api_meta.meta/api_meta/meta_deploy_running_tests.htm) in the "Metadata API Developer Guide".
        /// </summary>
        [SwitchName("--test-level")]
        public string TestLevel { get; set; }

        /// <summary>
        /// [Optional] The command immediately returns the job ID and control of the terminal to you. This way, you can continue to use the CLI. To resume the deployment, run "sf project deploy pipeline resume". To check the status of the deployment, run "sf project deploy pipeline report".
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you and returns the job ID. To check the status of the operation, run "$ sf [%= command.id.split(' ').slice(0, -1).join(' ') %] report".
        /// </summary>
        [SwitchName("--wait")]
        public string Wait { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }
    }

    /// <summary>
    /// Options for the method DeployPreview of class Project.
    /// </summary>
    public class ProjectDeployPreviewOptions : SfOptions
    {
        /// <summary>
        /// [Required] Overrides your default org.
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] This flag applies only to orgs that allow source tracking. It has no effect on orgs that don't allow it, such as production orgs.
        /// </summary>
        [SwitchName("--ignore-conflicts")]
        public bool? IgnoreConflicts { get; set; }

        /// <summary>
        /// [Optional] All child components are included. If you specify this flag, don’t specify --metadata or --source-dir.
        /// </summary>
        [SwitchName("--manifest")]
        public string Manifest { get; set; }

        /// <summary>
        /// [Optional] No description for metadata
        /// </summary>
        [SwitchName("--metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// [Optional] The supplied path can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all metadata types in the directory and its subdirectories).
        /// 
        /// If you specify this flag, don’t specify --metadata or --manifest.
        /// </summary>
        [SwitchName("--source-dir")]
        public string SourceDir { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }
    }

    /// <summary>
    /// Options for the method DeployQuick of class Project.
    /// </summary>
    public class ProjectDeployQuickOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] The command immediately returns the control of the terminal to you. This way, you can continue to use the CLI. To resume watching the deploy, run "$ sf project deploy resume". To check the status of the deploy, run "$ sf project deploy report".
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }

        /// <summary>
        /// [Optional] The job ID is valid for 10 days from when you started the validation.
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] Overrides your default org.
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] For performance reasons, this flag uses only job IDs that were validated in the past 3 days or less. If your most recent deployment validation was more than 3 days ago, this flag won't find a job ID.
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you. To resume watching the deploy, run "$ sf project deploy resume". To check the status of the deploy, run "$ sf project deploy report".
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] Use this flag to override the default API version with the API version of your package.xml file. The default API version is the latest version supported by the CLI.
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }
    }

    /// <summary>
    /// Options for the method DeployReport of class Project.
    /// </summary>
    public class ProjectDeployReportOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Overrides your default org.
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] These commands return a job ID if they time out or you specified the --async flag:
        /// 
        /// - $ sf project deploy start
        /// - $ sf project deploy validate
        /// - $ sf project deploy quick
        /// - $ sf project deploy cancel
        /// 
        /// The job ID is valid for 10 days from when you started the deploy operation.
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] For performance reasons, this flag uses job IDs for deploy operations that started only in the past 3 days or less. If your most recent operation was more than 3 days ago, this flag won't find a job ID.
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }

        /// <summary>
        /// [Optional] For multiple formatters, repeat the flag for each formatter.
        /// --coverage-formatters lcov --coverage-formatters clover
        /// </summary>
        [SwitchName("--coverage-formatters")]
        public string CoverageFormatters { get; set; }

        /// <summary>
        /// [Optional] No description for junit
        /// </summary>
        [SwitchName("--junit")]
        public bool? Junit { get; set; }

        /// <summary>
        /// [Optional] No description for results-dir
        /// </summary>
        [SwitchName("--results-dir")]
        public string ResultsDir { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you and returns the job ID. To resume the deployment, run "$ sf project deploy resume". To check the status of the deployment, run "$ sf project deploy report".
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }
    }

    /// <summary>
    /// Options for the method DeployResume of class Project.
    /// </summary>
    public class ProjectDeployResumeOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }

        /// <summary>
        /// [Optional] These commands return a job ID if they time out or you specified the --async flag:
        /// 
        /// - $ sf project deploy start
        /// - $ sf project deploy validate
        /// - $ sf project deploy quick
        /// - $ sf project deploy cancel
        /// 
        /// The job ID is valid for 10 days from when you started the deploy operation.
        /// </summary>
        [SwitchName("--job-id")]
        public string JobId { get; set; }

        /// <summary>
        /// [Optional] For performance reasons, this flag uses job IDs for deploy operations that started only in the past 3 days or less. If your most recent operation was more than 3 days ago, this flag won't find a job ID.
        /// </summary>
        [SwitchName("--use-most-recent")]
        public bool? UseMostRecent { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you. To resume watching the deploy operation, run this command again. To check the status of the deploy operation, run "$ sf project deploy report".
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] For multiple formatters, repeat the flag for each formatter.
        /// --coverage-formatters lcov --coverage-formatters clover
        /// </summary>
        [SwitchName("--coverage-formatters")]
        public string CoverageFormatters { get; set; }

        /// <summary>
        /// [Optional] No description for junit
        /// </summary>
        [SwitchName("--junit")]
        public bool? Junit { get; set; }

        /// <summary>
        /// [Optional] No description for results-dir
        /// </summary>
        [SwitchName("--results-dir")]
        public string ResultsDir { get; set; }
    }

    /// <summary>
    /// Options for the method DeployStart of class Project.
    /// </summary>
    public class ProjectDeployStartOptions : SfOptions
    {
        /// <summary>
        /// [Required] Overrides your default org.
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Use this flag to override the default API version with the API version of your package.xml file. The default API version is the latest version supported by the CLI.
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] The command immediately returns the job ID and control of the terminal to you. This way, you can continue to use the CLI. To resume the deployment, run "$ sf project deploy resume". To check the status of the deployment, run "$ sf project deploy report".
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }

        /// <summary>
        /// [Optional] No description for dry-run
        /// </summary>
        [SwitchName("--dry-run")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// [Optional] This flag applies only to orgs that allow source tracking. It has no effect on orgs that don't allow it, such as production orgs.
        /// </summary>
        [SwitchName("--ignore-conflicts")]
        public bool? IgnoreConflicts { get; set; }

        /// <summary>
        /// [Optional] Never use this flag when deploying to a production org. If you specify it, components without errors are deployed and components with errors are skipped, and could result in an inconsistent production org.
        /// </summary>
        [SwitchName("--ignore-errors")]
        public bool? IgnoreErrors { get; set; }

        /// <summary>
        /// [Optional] If you specify this flag, and a warning occurs, the success status of the deployment is set to true. If you don't specify this flag, and a warning occurs, then the success status is set to false, and the warning is treated like an error.
        /// 
        /// This flag is useful in a CI environment and your deployment includes destructive changes; if you try to delete a component that doesn't exist in the org, you get a warning. In this case, to ensure that the command returns a success value of true, specify this flag.
        /// </summary>
        [SwitchName("--ignore-warnings")]
        public bool? IgnoreWarnings { get; set; }

        /// <summary>
        /// [Optional] All child components are included. If you specify this flag, don’t specify --metadata or --source-dir.
        /// </summary>
        [SwitchName("--manifest")]
        public string Manifest { get; set; }

        /// <summary>
        /// [Optional] No description for metadata
        /// </summary>
        [SwitchName("--metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// [Optional] No description for metadata-dir
        /// </summary>
        [SwitchName("--metadata-dir")]
        public string MetadataDir { get; set; }

        /// <summary>
        /// [Optional] No description for single-package
        /// </summary>
        [SwitchName("--single-package")]
        public bool? SinglePackage { get; set; }

        /// <summary>
        /// [Optional] The supplied path can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all metadata types in the directory and its subdirectories).
        /// 
        /// If you specify this flag, don’t specify --metadata or --manifest.
        /// </summary>
        [SwitchName("--source-dir")]
        public string SourceDir { get; set; }

        /// <summary>
        /// [Optional] If a test name contains a space, enclose it in double quotes.
        /// For multiple test names, use one of the following formats:
        /// 
        /// - Repeat the flag for multiple test names: --tests Test1 --tests Test2 --tests "Test With Space"
        /// - Separate the test names with spaces: --tests Test1 Test2 "Test With Space"
        /// </summary>
        [SwitchName("--tests")]
        public string Tests { get; set; }

        /// <summary>
        /// [Optional] Valid values are:
        /// 
        /// - NoTestRun — No tests are run. This test level applies only to deployments to development environments, such as sandbox, Developer Edition, or trial orgs. This test level is the default for development environments.
        /// 
        /// - RunSpecifiedTests — Runs only the tests that you specify with the --tests flag. Code coverage requirements differ from the default coverage requirements when using this test level. Executed tests must comprise a minimum of 75% code coverage for each class and trigger in the deployment package. This coverage is computed for each class and trigger individually and is different than the overall coverage percentage.
        /// 
        /// - RunLocalTests — All tests in your org are run, except the ones that originate from installed managed and unlocked packages. This test level is the default for production deployments that include Apex classes or triggers.
        /// 
        /// - RunAllTestsInOrg — All tests in your org are run, including tests of managed packages.
        /// 
        ///   If you don’t specify a test level, the default behavior depends on the contents of your deployment package and target org. For more information, see [Running Tests in a Deployment](https://developer.salesforce.com/docs/atlas.en-us.api_meta.meta/api_meta/meta_deploy_running_tests.htm) in the "Metadata API Developer Guide".
        /// </summary>
        [SwitchName("--test-level")]
        public string TestLevel { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you and returns the job ID. To resume the deployment, run "$ sf project deploy resume". To check the status of the deployment, run "$ sf project deploy report".
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] No description for purge-on-delete
        /// </summary>
        [SwitchName("--purge-on-delete")]
        public bool? PurgeOnDelete { get; set; }

        /// <summary>
        /// [Optional] No description for pre-destructive-changes
        /// </summary>
        [SwitchName("--pre-destructive-changes")]
        public string PreDestructiveChanges { get; set; }

        /// <summary>
        /// [Optional] No description for post-destructive-changes
        /// </summary>
        [SwitchName("--post-destructive-changes")]
        public string PostDestructiveChanges { get; set; }

        /// <summary>
        /// [Optional] For multiple formatters, repeat the flag for each formatter.
        /// --coverage-formatters lcov --coverage-formatters clover
        /// </summary>
        [SwitchName("--coverage-formatters")]
        public string CoverageFormatters { get; set; }

        /// <summary>
        /// [Optional] No description for junit
        /// </summary>
        [SwitchName("--junit")]
        public bool? Junit { get; set; }

        /// <summary>
        /// [Optional] No description for results-dir
        /// </summary>
        [SwitchName("--results-dir")]
        public string ResultsDir { get; set; }
    }

    /// <summary>
    /// Options for the method DeployValidate of class Project.
    /// </summary>
    public class ProjectDeployValidateOptions : SfOptions
    {
        /// <summary>
        /// [Required] Overrides your default org.
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Use this flag to override the default API version with the API version of your package.xml file. The default API version is the latest version supported by the CLI.
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] The command immediately returns the job ID and control of the terminal to you. This way, you can continue to use the CLI. To resume watching the validation, run "$ sf project deploy resume". To check the status of the validation, run "$ sf project deploy report".
        /// </summary>
        [SwitchName("--async")]
        public bool? Async { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }

        /// <summary>
        /// [Optional] All child components are included. If you specify this flag, don’t specify --metadata or --source-dir.
        /// </summary>
        [SwitchName("--manifest")]
        public string Manifest { get; set; }

        /// <summary>
        /// [Optional] No description for metadata
        /// </summary>
        [SwitchName("--metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// [Optional] The supplied path can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all metadata types in the directory and its subdirectories).
        /// 
        /// If you specify this flag, don’t specify --metadata or --manifest.
        /// </summary>
        [SwitchName("--source-dir")]
        public string SourceDir { get; set; }

        /// <summary>
        /// [Optional] No description for metadata-dir
        /// </summary>
        [SwitchName("--metadata-dir")]
        public string MetadataDir { get; set; }

        /// <summary>
        /// [Optional] No description for single-package
        /// </summary>
        [SwitchName("--single-package")]
        public bool? SinglePackage { get; set; }

        /// <summary>
        /// [Optional] If a test name contains a space, enclose it in double quotes.
        /// For multiple test names, use one of the following formats:
        /// 
        /// - Repeat the flag for multiple test names: --tests Test1 --tests Test2 --tests "Test With Space"
        /// - Separate the test names with spaces: --tests Test1 Test2 "Test With Space"
        /// </summary>
        [SwitchName("--tests")]
        public string Tests { get; set; }

        /// <summary>
        /// [Optional] Valid values are:
        /// 
        /// - RunSpecifiedTests — Runs only the tests that you specify with the --tests flag. Code coverage requirements differ from the default coverage requirements when using this test level. Executed tests must comprise a minimum of 75% code coverage for each class and trigger in the deployment package. This coverage is computed for each class and trigger individually and is different than the overall coverage percentage.
        /// 
        /// - RunLocalTests — All tests in your org are run, except the ones that originate from installed managed and unlocked packages. This test level is the default.
        /// 
        /// - RunAllTestsInOrg — All tests in your org are run, including tests of managed packages.
        /// </summary>
        [SwitchName("--test-level")]
        public string TestLevel { get; set; }

        /// <summary>
        /// [Optional] No description for verbose
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you and returns the job ID. To resume watching the validation, run "$ sf project deploy resume". To check the status of the validation, run "$ sf project deploy report".
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] If you specify this flag, and a warning occurs, the success status of the deployment is set to true. If you don't specify this flag, and a warning occurs, then the success status is set to false, and the warning is treated like an error.
        /// 
        /// This flag is useful in a CI environment and your deployment includes destructive changes; if you try to delete a component that doesn't exist in the org, you get a warning. In this case, to ensure that the command returns a success value of true, specify this flag.
        /// </summary>
        [SwitchName("--ignore-warnings")]
        public bool? IgnoreWarnings { get; set; }

        /// <summary>
        /// [Optional] For multiple formatters, repeat the flag for each formatter.
        /// --coverage-formatters lcov --coverage-formatters clover
        /// </summary>
        [SwitchName("--coverage-formatters")]
        public string CoverageFormatters { get; set; }

        /// <summary>
        /// [Optional] No description for junit
        /// </summary>
        [SwitchName("--junit")]
        public bool? Junit { get; set; }

        /// <summary>
        /// [Optional] No description for results-dir
        /// </summary>
        [SwitchName("--results-dir")]
        public string ResultsDir { get; set; }

        /// <summary>
        /// [Optional] No description for purge-on-delete
        /// </summary>
        [SwitchName("--purge-on-delete")]
        public bool? PurgeOnDelete { get; set; }

        /// <summary>
        /// [Optional] No description for pre-destructive-changes
        /// </summary>
        [SwitchName("--pre-destructive-changes")]
        public string PreDestructiveChanges { get; set; }

        /// <summary>
        /// [Optional] No description for post-destructive-changes
        /// </summary>
        [SwitchName("--post-destructive-changes")]
        public string PostDestructiveChanges { get; set; }
    }

    /// <summary>
    /// Options for the method Generate of class Project.
    /// </summary>
    public class ProjectGenerateOptions : SfOptions
    {
        /// <summary>
        /// [Required] Generates a project directory with this name; any valid directory name is accepted. Also sets the "name" property in the sfdx-project.json file to this name.
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] The template determines the sample configuration files and directories that this command generates. For example, the empty template provides these files and directory to get you started.
        /// 
        /// - .forceignore
        /// - config/project-scratch-def.json
        /// - sfdx-project.json
        /// - package.json
        /// - force-app (basic source directory structure)
        /// 
        /// The standard template provides a complete force-app directory structure so you know where to put your source. It also provides additional files and scripts, especially useful when using Salesforce Extensions for VS Code. For example:
        /// 
        /// - .gitignore: Use Git for version control.
        /// - .prettierrc and .prettierignore: Use Prettier to format your Aura components.
        /// - .vscode/extensions.json: When launched, Visual Studio Code, prompts you to install the recommended extensions for your project.
        /// - .vscode/launch.json: Configures Replay Debugger.
        /// - .vscode/settings.json: Additional configuration settings.
        /// 
        /// The analytics template provides similar files and the force-app/main/default/waveTemplates directory.
        /// </summary>
        [SwitchName("--template")]
        public string Template { get; set; }

        /// <summary>
        /// [Optional] The location can be an absolute path or relative to the current working directory. The default is the current directory.
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

        /// <summary>
        /// [Optional] No description for namespace
        /// </summary>
        [SwitchName("--namespace")]
        public string Namespace { get; set; }

        /// <summary>
        /// [Optional] Metadata items such as classes and Lightning bundles are placed inside this folder.
        /// </summary>
        [SwitchName("--default-package-dir")]
        public string DefaultPackageDir { get; set; }

        /// <summary>
        /// [Optional] Generates a default manifest (package.xml) for fetching Apex, Visualforce, Lightning components, and static resources.
        /// </summary>
        [SwitchName("--manifest")]
        public bool? Manifest { get; set; }

        /// <summary>
        /// [Optional] Normally defaults to https://login.salesforce.com.
        /// </summary>
        [SwitchName("--login-url")]
        public string LoginUrl { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// [Optional] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }
    }

    /// <summary>
    /// Options for the method GenerateManifest of class Project.
    /// </summary>
    public class ProjectGenerateManifestOptions : SfOptions
    {
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
        /// [Optional] No description for metadata
        /// </summary>
        [SwitchName("--metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// [Optional] No description for source-dir
        /// </summary>
        [SwitchName("--source-dir")]
        public string SourceDir { get; set; }

        /// <summary>
        /// [Optional] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] No description for type
        /// </summary>
        [SwitchName("--type")]
        public string Type { get; set; }

        /// <summary>
        /// [Optional] No description for include-packages
        /// </summary>
        [SwitchName("--include-packages")]
        public string IncludePackages { get; set; }

        /// <summary>
        /// [Optional] No description for from-org
        /// </summary>
        [SwitchName("--from-org")]
        public string FromOrg { get; set; }

        /// <summary>
        /// [Optional] No description for output-dir
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }
    }

    /// <summary>
    /// Options for the method ListIgnored of class Project.
    /// </summary>
    public class ProjectListIgnoredOptions : SfOptions
    {
        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] No description for source-dir
        /// </summary>
        [SwitchName("--source-dir")]
        public string SourceDir { get; set; }
    }

    /// <summary>
    /// Options for the method ResetTracking of class Project.
    /// </summary>
    public class ProjectResetTrackingOptions : SfOptions
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
        /// [Optional] No description for revision
        /// </summary>
        [SwitchName("--revision")]
        public string Revision { get; set; }

        /// <summary>
        /// [Optional] No description for no-prompt
        /// </summary>
        [SwitchName("--no-prompt")]
        public bool? NoPrompt { get; set; }
    }

    /// <summary>
    /// Options for the method RetrievePreview of class Project.
    /// </summary>
    public class ProjectRetrievePreviewOptions : SfOptions
    {
        /// <summary>
        /// [Required] Overrides your default org.
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] This flag applies only to orgs that allow source tracking. It has no effect on orgs that don't allow it, such as production orgs.
        /// </summary>
        [SwitchName("--ignore-conflicts")]
        public bool? IgnoreConflicts { get; set; }

        /// <summary>
        /// [Optional] No description for concise
        /// </summary>
        [SwitchName("--concise")]
        public bool? Concise { get; set; }
    }

    /// <summary>
    /// Options for the method RetrieveStart of class Project.
    /// </summary>
    public class ProjectRetrieveStartOptions : SfOptions
    {
        /// <summary>
        /// [Required] Overrides your default org.
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Use this flag to override the default API version, which is the latest version supported the CLI, with the API version in your package.xml file.
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// [Optional] This flag applies only to orgs that allow source tracking. It has no effect on orgs that don't allow it, such as production orgs.
        /// </summary>
        [SwitchName("--ignore-conflicts")]
        public bool? IgnoreConflicts { get; set; }

        /// <summary>
        /// [Optional] If you specify this parameter, don’t specify --metadata or --source-dir.
        /// </summary>
        [SwitchName("--manifest")]
        public string Manifest { get; set; }

        /// <summary>
        /// [Optional] No description for metadata
        /// </summary>
        [SwitchName("--metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// [Optional] No description for package-name
        /// </summary>
        [SwitchName("--package-name")]
        public string PackageName { get; set; }

        /// <summary>
        /// [Optional] The root of the directory structure into which the source files are retrieved.
        /// If the target directory matches one of the package directories in your sfdx-project.json file, the command fails.
        /// Running the command multiple times with the same target adds new files and overwrites existing files.
        /// </summary>
        [SwitchName("--output-dir")]
        public string OutputDir { get; set; }

        /// <summary>
        /// [Optional] No description for single-package
        /// </summary>
        [SwitchName("--single-package")]
        public bool? SinglePackage { get; set; }

        /// <summary>
        /// [Optional] The supplied paths can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all source files in the directory and its subdirectories).
        /// </summary>
        [SwitchName("--source-dir")]
        public string SourceDir { get; set; }

        /// <summary>
        /// [Optional] No description for target-metadata-dir
        /// </summary>
        [SwitchName("--target-metadata-dir")]
        public string TargetMetadataDir { get; set; }

        /// <summary>
        /// [Optional] If the command continues to run after the wait period, the CLI returns control of the terminal window to you.
        /// </summary>
        [SwitchName("--wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// [Optional] No description for unzip
        /// </summary>
        [SwitchName("--unzip")]
        public bool? Unzip { get; set; }

        /// <summary>
        /// [Optional] No description for zip-file-name
        /// </summary>
        [SwitchName("--zip-file-name")]
        public string ZipFileName { get; set; }
    }

    /// <summary>
    /// Project
    /// </summary>
    [CommandClass("project")]
    public class Project : SfCommand
    {
        /// Constructor.
        public Project(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Convert metadata retrieved via Metadata API into the source format used in Salesforce DX projects.
        /// </summary>
        /// <remarks>
        /// To use Salesforce CLI to work with components that you retrieved via Metadata API, first convert your files from the metadata format to the source format using this command.
        /// 
        /// To convert files from the source format back to the metadata format, run "$ sf project convert source".
        /// 
        /// To convert multiple metadata components, either set multiple --metadata [name] flags or a single --metadata flag with multiple names separated by spaces. Enclose names that contain spaces in one set of double quotes. The same syntax applies to --manifest and --source-dir.
        /// </remarks>
        /// <example>
        /// Convert metadata formatted files in the specified directory into source formatted files; writes converted files to your default package directory:
        /// $ $ sf convert mdapi --root-dir path/to/metadata
        /// Similar to previous example, but writes converted files to the specified output directory:
        /// $ $ sf convert mdapi --root-dir path/to/metadata --output-dir path/to/outputdir
        /// </example>
        [Command("convert mdapi")]
        public SfResponse ConvertMdapi(ProjectConvertMdapiOptions options)
        {
            return ExecuteCommand(nameof(ConvertMdapi), options);
        }

        /// <summary>
        /// Convert source-formatted files into metadata that you can deploy using Metadata API.
        /// </summary>
        /// <remarks>
        /// To convert source-formatted files into the metadata format, so that you can deploy them using Metadata API, run this command. Then deploy the metadata using "$ sf project deploy".
        /// 
        /// To convert Metadata API–formatted files into the source format, run "$ sf project convert mdapi".
        /// 
        /// To specify a package name that includes spaces, enclose the name in single quotes.
        /// 
        /// To convert multiple components, either set multiple --metadata [name] flags or a single --metadata flag with multiple names separated by spaces. Enclose names that contain spaces in one set of double quotes. The same syntax applies to --manifest and --source-dir.
        /// </remarks>
        /// <example>
        /// Convert source-formatted files in the specified directory into metadata-formatted files; writes converted files into a new directory:
        /// $ $ sf convert source --root-dir path/to/source
        /// Similar to previous example, but writes converted files to the specified output directory and associates the files with the specified package:
        /// $ $ sf convert source --root-dir path/to/source --output-dir path/to/outputdir --package-name 'My Package'
        /// </example>
        [Command("convert source")]
        public SfResponse ConvertSource(ProjectConvertSourceOptions options = null)
        {
            return ExecuteCommand(nameof(ConvertSource), options);
        }

        /// <summary>
        /// Delete source from your project and from a non-source-tracked org.
        /// </summary>
        /// <remarks>
        /// Use this command to delete components from orgs that don’t have source tracking. To remove deleted items from orgs that have source tracking enabled, "$ sf project deploy start".
        /// 
        /// When you run this command, both the local source file and the metadata component in the org are deleted.
        /// 
        /// To delete multiple metadata components, either set multiple --metadata [name] flags or a single --metadata flag with multiple names separated by spaces. Enclose names that contain spaces in one set of double quotes. The same syntax applies to --manifest and --source-dir.
        /// </remarks>
        /// <example>
        /// Delete all local Apex source files and all Apex classes from the org with alias "my-scratch":
        /// $ sf delete source --metadata ApexClass --target-org my-scratch
        /// Delete a specific Apex class and a Profile that has a space in it from your default org; don't prompt for confirmation:
        /// $ sf delete source --metadata ApexClass:MyFabulousApexClass --metadata "Profile: My Profile" --no-prompt
        /// Run the tests that aren’t in any managed packages as part of the deletion; if the delete succeeds, and the org has source-tracking enabled, update the source tracking information:
        /// $ sf delete source --metadata ApexClass --test-level RunLocalTests --track-source
        /// Delete the Apex source files in a directory and the corresponding components from your default org:
        /// $ sf delete source --source-dir force-app/main/default/classes
        /// </example>
        [Command("delete source")]
        public SfResponse DeleteSource(ProjectDeleteSourceOptions options)
        {
            return ExecuteCommand(nameof(DeleteSource), options);
        }

        /// <summary>
        /// Delete all local source tracking information.
        /// </summary>
        /// <remarks>
        /// WARNING: This command deletes or overwrites all existing source tracking files. Use with extreme caution.
        /// 
        /// Deletes all local source tracking information. When you next run 'project deploy preview', Salesforce CLI displays all local and remote files as changed, and any files with the same name are listed as conflicts.
        /// </remarks>
        /// <example>
        /// Delete local source tracking for the org with alias "my-scratch":
        /// $ $ sf delete tracking --target-org my-scratch
        /// </example>
        [Command("delete tracking")]
        public SfResponse DeleteTracking(ProjectDeleteTrackingOptions options)
        {
            return ExecuteCommand(nameof(DeleteTracking), options);
        }

        /// <summary>
        /// Cancel a deploy operation.
        /// </summary>
        /// <remarks>
        /// Use this command to cancel a deploy operation that hasn't yet completed in the org. Deploy operations include standard deploys, quick deploys, deploy validations, and deploy cancellations.
        /// 
        /// Run this command by either passing it a job ID or specifying the --use-most-recent flag to use the job ID of the most recent deploy operation.
        /// </remarks>
        /// <example>
        /// Cancel a deploy operation using a job ID:
        /// $ sf deploy cancel --job-id 0Af0x000017yLUFCA2
        /// Cancel the most recent deploy operation:
        /// $ sf deploy cancel --use-most-recent
        /// </example>
        [Command("deploy cancel")]
        public SfResponse DeployCancel(ProjectDeployCancelOptions options = null)
        {
            return ExecuteCommand(nameof(DeployCancel), options);
        }

        /// <summary>
        /// Quickly deploy a validated deployment to an org.
        /// </summary>
        /// <remarks>
        /// The first time you run any "project deploy pipeline" command, be sure to authorize the org in which DevOps Center is installed. The easiest way to authorize an org is with the "org login web" command.
        /// 
        /// Before you run this command, create a validated deployment with the "project deploy pipeline validate" command, which returns a job ID. Validated deployments haven't been deployed to the org yet; you deploy them with this command. Either pass the job ID to this command or use the --use-most-recent flag to use the job ID of the most recently validated deployment. For the quick deploy to succeed, the associated validated deployment must also have succeeded.
        /// 
        /// Executing this quick deploy command takes less time than a standard deploy because it skips running Apex tests. These tests were previously run as part of the validation. Validating first and then running a quick deploy is useful if the deployment to your production org take several hours and you don’t want to risk a failed deploy.
        /// 
        /// This command doesn't support source-tracking. The source you deploy overwrites the corresponding metadata in your org. This command doesn’t attempt to merge your source with the versions in your org.
        /// </remarks>
        /// <example>
        /// Run a quick deploy using your default Devops Center org and a job ID:
        /// $ sf deploy pipeline quick --job-id 0Af0x000017yLUFCA2
        /// Asynchronously run a quick deploy of the most recently validated deployment using an org with alias "my-prod-org":
        /// $ sf deploy pipeline quick --async --use-most-recent --devops-center-username my-prod-org
        /// </example>
        [Command("deploy pipeline quick")]
        public SfResponse DeployPipelineQuick(ProjectDeployPipelineQuickOptions options)
        {
            return ExecuteCommand(nameof(DeployPipelineQuick), options);
        }

        /// <summary>
        /// Check the status of a pipeline deploy operation.
        /// </summary>
        /// <remarks>
        /// The first time you run any "project deploy pipeline" command, be sure to authorize the org in which DevOps Center is installed. The easiest way to authorize an org is with the "org login web" command.
        /// 
        /// Run this command by either indicating a job ID or specifying the —use-most-recent flag to use the job ID of the most recent deploy operation.
        /// </remarks>
        /// <example>
        /// Check the status using a job ID:
        /// $ sf deploy pipeline report --devops-center-username MyStagingSandbox --job-id 0Af0x000017yLUFCA2
        /// Check the status of the most recent deploy operation:
        /// $ sf deploy pipeline report --devops-center-username MyStagingSandbox --use-most-recent
        /// </example>
        [Command("deploy pipeline report")]
        public SfResponse DeployPipelineReport(ProjectDeployPipelineReportOptions options)
        {
            return ExecuteCommand(nameof(DeployPipelineReport), options);
        }

        /// <summary>
        /// Resume watching a pipeline deploy operation.
        /// </summary>
        /// <remarks>
        /// The first time you run any "project deploy pipeline" command, be sure to authorize the org in which DevOps Center is installed. The easiest way to authorize an org is with the "org login web" command. 
        /// 
        /// Use this command to resume watching a pipeline deploy operation if the original command times out or you specified the --async flag.
        /// 
        /// Run this command by either indicating a job ID or specifying the --use-most-recent flag to use the job ID of the most recent deploy operation.
        /// </remarks>
        /// <example>
        /// Resume watching a deploy operation using a job ID:
        /// $ sf deploy pipeline resume --job-id 0Af0x000017yLUFCA2
        /// Resume watching the most recent deploy operation:
        /// $ sf deploy pipeline resume --use-most-recent
        /// </example>
        [Command("deploy pipeline resume")]
        public SfResponse DeployPipelineResume(ProjectDeployPipelineResumeOptions options)
        {
            return ExecuteCommand(nameof(DeployPipelineResume), options);
        }

        /// <summary>
        /// Deploy changes from a branch to the pipeline stage’s org.
        /// </summary>
        /// <remarks>
        /// The first time you run any "project deploy pipeline" command, be sure to authorize the org in which DevOps Center is installed. The easiest way to authorize an org is with the "org login web" command.
        /// 
        /// Before you run this command, changes in the pipeline stage's branch must be merged in the source control repository.
        /// </remarks>
        /// <example>
        /// Deploy changes in the Staging branch to the Staging environment (sandbox), if the previous stage is the bundling stage:
        /// $ sf deploy pipeline start --devops-center-project-name “Recruiting App” --branch-name staging --devops-center-username MyStagingSandbox --bundle-version-name 1.0
        /// Deploy all changes in the main branch to the release environment:
        /// $ sf deploy pipeline start --devops-center-project-name “Recruiting App” --branch-name main --devops-center-username MyReleaseOrg --deploy-all
        /// </example>
        [Command("deploy pipeline start")]
        public SfResponse DeployPipelineStart(ProjectDeployPipelineStartOptions options)
        {
            return ExecuteCommand(nameof(DeployPipelineStart), options);
        }

        /// <summary>
        /// Perform a validate-only deployment from a branch to the pipeline stage’s org.
        /// </summary>
        /// <remarks>
        /// The first time you run any "project deploy pipeline" command, be sure to authorize the org in which DevOps Center is installed. The easiest way to authorize an org is with the "org login web" command.
        /// 
        /// A validation runs Apex tests to verify whether a deployment will succeed without actually deploying the metadata to your environment, so you can then quickly deploy the changes later without re-running the tests.
        /// </remarks>
        /// <example>
        /// Perform a validate-only deployment from the Staging branch to the Staging environment (sandbox):
        /// $ sf deploy pipeline validate --devops-center-project-name “Recruiting App” --branch-name staging --devops-center-username MyStagingSandbox
        /// Perform a validate-only deployment of all changes from the main branch to the release environment:
        /// $ sf deploy pipeline validate --devops-center-project-name “Recruiting App” --branch-name main --devops-center-username MyReleaseOrg --deploy-all
        /// </example>
        [Command("deploy pipeline validate")]
        public SfResponse DeployPipelineValidate(ProjectDeployPipelineValidateOptions options)
        {
            return ExecuteCommand(nameof(DeployPipelineValidate), options);
        }

        /// <summary>
        /// Preview a deployment to see what will deploy to the org, the potential conflicts, and the ignored files.
        /// </summary>
        /// <remarks>
        /// You must run this command from within a project.
        /// 
        /// The command outputs a table that describes what will happen if you run the "$ sf project deploy start" command. The table lists the metadata components that will be deployed and deleted. The table also lists the current conflicts between files in your local project and components in the org. Finally, the table lists the files that won't be deployed because they're included in your .forceignore file.
        /// 
        /// If your org allows source tracking, then this command displays potential conflicts between the org and your local project. Some orgs, such as production org, never allow source tracking. Source tracking is enabled by default on scratch and sandbox orgs; you can disable source tracking when you create the orgs by specifying the --no-track-source flag on the "$ sf org create scratch|sandbox" commands.
        /// 
        /// To preview the deployment of multiple metadata components, either set multiple --metadata [name] flags or a single --metadata flag with multiple names separated by spaces. Enclose names that contain spaces in one set of double quotes. The same syntax applies to --manifest and --source-dir.
        /// </remarks>
        /// <example>
        /// NOTE: The commands to preview a deployment and actually deploy it use similar flags. We provide a few preview examples here, but see the help for "$ sf project deploy start" for more examples that you can adapt for previewing.
        /// Preview the deployment of source files in a directory, such as force-app, to your default org:
        /// $ sf deploy preview  --source-dir force-app
        /// Preview the deployment of all Apex classes to an org with alias "my-scratch":
        /// $ sf deploy preview --metadata ApexClass --target-org my-scratch
        /// Preview deployment of a specific Apex class:
        /// $ sf deploy preview --metadata ApexClass:MyApexClass
        /// Preview deployment of all components listed in a manifest:
        /// $ sf deploy preview --manifest path/to/package.xml
        /// </example>
        [Command("deploy preview")]
        public SfResponse DeployPreview(ProjectDeployPreviewOptions options)
        {
            return ExecuteCommand(nameof(DeployPreview), options);
        }

        /// <summary>
        /// Quickly deploy a validated deployment to an org.
        /// </summary>
        /// <remarks>
        /// Before you run this command, first create a validated deployment with the "$ sf project deploy validate" command, which returns a job ID. Validated deployments haven't been deployed to the org yet; you deploy them with this command. Either pass the job ID to this command or use the --use-most-recent flag to use the job ID of the most recently validated deployment. For the quick deploy to succeed, the associated validated deployment must also have succeeded.
        /// 
        /// Executing this quick deploy command takes less time than a standard deploy because it skips running Apex tests. These tests were previously run as part of the validation. Validating first and then running a quick deploy is useful if the deployment to your production org take several hours and you don’t want to risk a failed deploy.
        /// 
        /// This command doesn't support source-tracking. The source you deploy overwrites the corresponding metadata in your org. This command doesn’t attempt to merge your source with the versions in your org.
        /// 
        /// Note: Don't use this command on sandboxes; the command is intended to be used on production orgs.  By default, sandboxes don't run tests during a deploy. Use `sf project deploy start` instead.
        /// </remarks>
        /// <example>
        /// Run a quick deploy to your default org using a job ID:
        /// $ sf deploy quick --job-id 0Af0x000017yLUFCA2
        /// Asynchronously run a quick deploy of the most recently validated deployment to an org with alias "my-prod-org":
        /// $ sf deploy quick --async --use-most-recent --target-org my-prod-org
        /// </example>
        [Command("deploy quick")]
        public SfResponse DeployQuick(ProjectDeployQuickOptions options = null)
        {
            return ExecuteCommand(nameof(DeployQuick), options);
        }

        /// <summary>
        /// Check or poll for the status of a deploy operation.
        /// </summary>
        /// <remarks>
        /// Deploy operations include standard deploys, quick deploys, deploy validations, and deploy cancellations.
        /// 
        /// Run this command by either passing it a job ID or specifying the --use-most-recent flag to use the job ID of the most recent deploy operation. If you specify the --wait flag, the command polls for the status every second until the timeout of --wait minutes. If you don't specify the --wait flag, the command simply checks and displays the status of the deploy; the command doesn't poll for the status.
        /// 
        /// You typically don't specify the --target-org flag because the cached job already references the org to which you deployed. But if you run this command on a computer different than the one from which you deployed, then you must specify the --target-org and it must point to the same org.
        /// 
        /// This command doesn't update source tracking information.
        /// </remarks>
        /// <example>
        /// Check the status using a job ID:
        /// $ sf deploy report --job-id 0Af0x000017yLUFCA2
        /// Check the status of the most recent deploy operation:
        /// $ sf deploy report --use-most-recent
        /// Poll for the status using a job ID and target org:
        /// $ sf deploy report --job-id 0Af0x000017yLUFCA2 --target-org me@my.org --wait 30
        /// </example>
        [Command("deploy report")]
        public SfResponse DeployReport(ProjectDeployReportOptions options = null)
        {
            return ExecuteCommand(nameof(DeployReport), options);
        }

        /// <summary>
        /// Resume watching a deploy operation and update source tracking when the deploy completes.
        /// </summary>
        /// <remarks>
        /// Use this command to resume watching a deploy operation if the original command times out or you specified the --async flag. Deploy operations include standard deploys, quick deploys, deploy validations, and deploy cancellations. This command doesn't resume the original operation itself, because the operation always continues after you've started it, regardless of whether you're watching it or not. When the deploy completes, source tracking information is updated as needed.
        /// 
        /// Run this command by either passing it a job ID or specifying the --use-most-recent flag to use the job ID of the most recent deploy operation.
        /// </remarks>
        /// <example>
        /// Resume watching a deploy operation using a job ID:
        /// $ sf deploy resume --job-id 0Af0x000017yLUFCA2
        /// Resume watching the most recent deploy operation:
        /// $ sf deploy resume --use-most-recent
        /// </example>
        [Command("deploy resume")]
        public SfResponse DeployResume(ProjectDeployResumeOptions options = null)
        {
            return ExecuteCommand(nameof(DeployResume), options);
        }

        /// <summary>
        /// Deploy metadata to an org from your local project.
        /// </summary>
        /// <remarks>
        /// You must run this command from within a project.
        /// 
        /// Metadata components are deployed in source format by default. Deploy them in metadata format by specifying the --metadata-dir flag, which specifies the root directory or ZIP file that contains the metadata formatted files you want to deploy.
        /// 
        /// If your org allows source tracking, then this command tracks the changes in your source. Some orgs, such as production orgs, never allow source tracking. Source tracking is enabled by default on scratch and sandbox orgs; you can disable source tracking when you create the orgs by specifying the --no-track-source flag on the "$ sf org create scratch|sandbox" commands.
        /// 
        /// To deploy multiple metadata components, either set multiple --metadata [name] flags or a single --metadata flag with multiple names separated by spaces. Enclose names that contain spaces in one set of double quotes. The same syntax applies to --manifest and --source-dir.
        /// </remarks>
        /// <example>
        /// Deploy local changes not in the org; uses your default org:
        /// $ sf deploy start
        /// Deploy all source files in the "force-app" directory to an org with alias "my-scratch"; show only concise output, in other words don't print a list of all the source that was deployed:
        /// $ sf deploy start  --source-dir force-app --target-org my-scratch --concise
        /// Deploy all the Apex classes and custom objects that are in the "force-app" directory. The list views, layouts, etc, that are associated with the custom objects are also deployed. Both examples are equivalent:
        /// $ sf deploy start --source-dir force-app/main/default/classes force-app/main/default/objects
        /// $ sf deploy start --source-dir force-app/main/default/classes --source-dir force-app/main/default/objects
        /// Deploy all Apex classes that are in all package directories defined in the "sfdx-project.json" file:
        /// $ sf deploy start --metadata ApexClass
        /// Deploy a specific Apex class; ignore any conflicts between the local project and org (be careful with this flag, because it will overwrite the Apex class in the org if there are conflicts!):
        /// $ sf deploy start --metadata ApexClass:MyApexClass --ignore-conflicts
        /// Deploy specific Apex classes that match a pattern; in this example, deploy Apex classes whose names contain the string "MyApex". Also ignore any deployment warnings (again, be careful with this flag! You typically want to see the warnings):
        /// $ sf deploy start --metadata 'ApexClass:MyApex*' --ignore-warnings
        /// Deploy all custom objects and Apex classes found in all defined package directories (both examples are equivalent):
        /// $ sf deploy start --metadata CustomObject ApexClass
        /// $ sf deploy start --metadata CustomObject --metadata ApexClass
        /// Deploy all Apex classes and a profile that has a space in its name:
        /// $ sf deploy start --metadata ApexClass --metadata "Profile:My Profile"
        /// Deploy all components listed in a manifest:
        /// $ sf deploy start --manifest path/to/package.xml
        /// Run the tests that aren’t in any managed packages as part of a deployment:
        /// $ sf deploy start --metadata ApexClass --test-level RunLocalTests
        /// </example>
        [Command("deploy start")]
        public SfResponse DeployStart(ProjectDeployStartOptions options)
        {
            return ExecuteCommand(nameof(DeployStart), options);
        }

        /// <summary>
        /// Validate a metadata deployment without actually executing it.
        /// </summary>
        /// <remarks>
        /// Use this command to verify whether a deployment will succeed without actually deploying the metadata to your org. This command is similar to "$ sf project deploy start", except you're required to run Apex tests, and the command returns a job ID rather than executing the deployment. If the validation succeeds, then you pass this job ID to the "$ sf project deploy quick" command to actually deploy the metadata. This quick deploy takes less time because it skips running Apex tests. The job ID is valid for 10 days from when you started the validation. Validating first is useful if the deployment to your production org take several hours and you don’t want to risk a failed deploy.
        /// 
        /// You must run this command from within a project.
        /// 
        /// This command doesn't support source-tracking. When you quick deploy with the resulting job ID, the source you deploy overwrites the corresponding metadata in your org.
        /// 
        /// To validate the deployment of multiple metadata components, either set multiple --metadata [name] flags or a single --metadata flag with multiple names separated by spaces. Enclose names that contain spaces in one set of double quotes. The same syntax applies to --manifest and --source-dir.
        /// 
        /// Note: Don't use this command on sandboxes; the command is intended to be used on production orgs. By default, sandboxes don't run tests during a deploy.  If you want to validate a deployment with tests on a sandbox, use "sf project deploy start --dry-run --test-level RunLocalTests" instead.
        /// </remarks>
        /// <example>
        /// NOTE: These examples focus on validating large deployments. See the help for "$ sf project deploy start" for examples of deploying smaller sets of metadata which you can also use to validate.
        /// Validate the deployment of all source files in the "force-app" directory to the default org:
        /// $ sf deploy validate --source-dir force-app
        /// Validate the deployment of all source files in two directories: "force-app" and "force-app-utils":
        /// $ sf deploy validate --source-dir force-app --source-dir force-app-utils
        /// Asynchronously validate the deployment and run all tests in the org with alias "my-prod-org"; command immediately returns the job ID:
        /// $ sf deploy validate --source-dir force-app --async --test-level RunAllTestsInOrg --target-org my-prod-org
        /// Validate the deployment of all components listed in a manifest:
        /// $ sf deploy validate --manifest path/to/package.xml
        /// </example>
        [Command("deploy validate")]
        public SfResponse DeployValidate(ProjectDeployValidateOptions options)
        {
            return ExecuteCommand(nameof(DeployValidate), options);
        }

        /// <summary>
        /// Generate a Salesforce DX project.
        /// </summary>
        /// <remarks>
        /// A Salesforce DX project has a specific structure and a configuration file (sfdx-project.json) that identifies the directory as a Salesforce DX project. This command generates the necessary configuration files and directories to get you started.
        /// 
        /// By default, the generated sfdx-project.json file sets the sourceApiVersion property to the default API version currently used by Salesforce CLI. To specify a different version, set the apiVersion configuration variable. For example: "sf config set apiVersion=57.0 --global".
        /// </remarks>
        /// <example>
        /// Generate a project called "mywork":
        /// $ sf generate --name mywork
        /// Similar to previous example, but generate the files in a directory called "myapp":
        /// $ sf generate --name mywork --default-package-dir myapp
        /// Similar to prevoius example, but also generate a default package.xml manifest file:
        /// $ sf generate --name mywork --default-package-dir myapp --manifest
        /// Generate a project with the minimum files and directories:
        /// $ sf generate --name mywork --template empty
        /// </example>
        [Command("generate")]
        public SfResponse Generate(ProjectGenerateOptions options)
        {
            return ExecuteCommand(nameof(Generate), options);
        }

        /// <summary>
        /// Create a project manifest that lists the metadata components you want to deploy or retrieve.
        /// </summary>
        /// <remarks>
        /// Create a manifest from a list of metadata components (--metadata) or from one or more local directories that contain source files (--source-dir). You can specify either of these parameters, not both.
        /// 
        /// Use --type to specify the type of manifest you want to create. The resulting manifest files have specific names, such as the standard package.xml or destructiveChanges.xml to delete metadata. Valid values for this parameter, and their respective file names, are:
        /// 
        ///     * package : package.xml (default)
        ///     * pre : destructiveChangesPre.xml
        ///     * post : destructiveChangesPost.xml
        ///     * destroy : destructiveChanges.xml
        /// 
        /// See https://developer.salesforce.com/docs/atlas.en-us.api_meta.meta/api_meta/meta_deploy_deleting_files.htm for information about these destructive manifest files.
        /// 
        /// Use --name to specify a custom name for the generated manifest if the pre-defined ones don’t suit your needs. You can specify either --type or --name, but not both.
        /// 
        /// To include multiple metadata components, either set multiple --metadata [name] flags or a single --metadata flag with multiple names separated by spaces. Enclose names that contain spaces in one set of double quotes. The same syntax applies to --include-packages and --source-dir.
        /// </remarks>
        /// <example>
        /// Create a manifest for deploying or retrieving all Apex classes and custom objects:
        /// $ $ sf generate manifest --metadata ApexClass --metadata CustomObject
        /// Create a manifest for deleting the specified Apex class:
        /// $ $ sf generate manifest --metadata ApexClass:MyApexClass --type destroy
        /// Create a manifest for deploying or retrieving all the metadata components in the specified local directory; name the file myNewManifest.xml:
        /// $ $ sf generate manifest --source-dir force-app --name myNewManifest
        /// Create a manifest from the metadata components in the specified org and include metadata in any unlocked packages:
        /// $ $ sf generate manifest --from-org test@myorg.com --include-packages unlocked
        /// </example>
        [Command("generate manifest")]
        public SfResponse GenerateManifest(ProjectGenerateManifestOptions options = null)
        {
            return ExecuteCommand(nameof(GenerateManifest), options);
        }

        /// <summary>
        /// Check your local project package directories for forceignored files.
        /// </summary>
        /// <remarks>
        /// When deploying or retrieving metadata between your local project and an org, you can specify the source files you want to exclude with a .forceignore file. The .forceignore file structure mimics the .gitignore structure. Each line in .forceignore specifies a pattern that corresponds to one or more files. The files typically represent metadata components, but can be any files you want to exclude, such as LWC configuration JSON files or tests.
        /// </remarks>
        /// <example>
        /// List all the files in all package directories that are ignored:
        /// $ sf list ignored
        /// List all the files in a specific directory that are ignored:
        /// $ sf list ignored --source-dir force-app
        /// Check if a particular file is ignored:
        /// $ sf list ignored --source-dir package.xml
        /// </example>
        [Command("list ignored")]
        public SfResponse ListIgnored(ProjectListIgnoredOptions options = null)
        {
            return ExecuteCommand(nameof(ListIgnored), options);
        }

        /// <summary>
        /// Reset local and remote source tracking.
        /// </summary>
        /// <remarks>
        /// WARNING: This command deletes or overwrites all existing source tracking files. Use with extreme caution.
        /// 
        /// Resets local and remote source tracking so that Salesforce CLI no longer registers differences between your local files and those in the org. When you next run 'project deploy preview', Salesforce CLI returns no results, even though conflicts might actually exist. Salesforce CLI then resumes tracking new source changes as usual.
        /// 
        /// Use the --revision parameter to reset source tracking to a specific revision number of an org source member. To get the revision number, query the SourceMember Tooling API object with the 'data soql' command. For example:
        /// 
        ///     $ sf data query --query "SELECT MemberName, MemberType, RevisionCounter FROM SourceMember" --use-tooling-api --target-org my-scratch
        /// </remarks>
        /// <example>
        /// Reset source tracking for the org with alias "my-scratch":
        /// $ $ sf reset tracking --target-org my-scratch
        /// Reset source tracking to revision number 30 for your default org:
        /// $ $ sf reset tracking --revision 30
        /// </example>
        [Command("reset tracking")]
        public SfResponse ResetTracking(ProjectResetTrackingOptions options)
        {
            return ExecuteCommand(nameof(ResetTracking), options);
        }

        /// <summary>
        /// Preview a retrieval to see what will be retrieved from the org, the potential conflicts, and the ignored files.
        /// </summary>
        /// <remarks>
        /// You must run this command from within a project.
        /// 
        /// The command outputs a table that describes what will happen if you run the "$ sf project retrieve start" command. The table lists the metadata components that will be retrieved and deleted. The table also lists the current conflicts between files in your local project and components in the org. Finally, the table lists the files that won't be retrieved because they're included in your .forceignore file.
        /// 
        /// If your org allows source tracking, then this command displays potential conflicts between the org and your local project. Some orgs, such as production org, never allow source tracking. Source tracking is enabled by default on scratch and sandbox orgs; you can disable source tracking when you create the orgs by specifying the --no-track-source flag on the "$ sf org create scratch|sandbox" commands.
        /// </remarks>
        /// <example>
        /// Preview the retrieve of all changes from your default org:
        /// $ sf retrieve preview
        /// Preview the retrieve when ignoring any conflicts from an org with alias "my-scratch":
        /// $ sf retrieve preview --ignore-conflicts --target-org my-scratch
        /// </example>
        [Command("retrieve preview")]
        public SfResponse RetrievePreview(ProjectRetrievePreviewOptions options)
        {
            return ExecuteCommand(nameof(RetrievePreview), options);
        }

        /// <summary>
        /// Retrieve metadata from an org to your local project.
        /// </summary>
        /// <remarks>
        /// You must run this command from within a project.
        /// 
        /// Metadata components are retrieved in source format by default. Retrieve them in metadata format by specifying the --target-metadata-dir flag, which retrieves the components into a ZIP file in the specified directory.
        /// 
        /// If your org allows source tracking, then this command tracks the changes in your source. Some orgs, such as production orgs, never allow source tracking. Source tracking is enabled by default on scratch and sandbox orgs; you can disable source tracking when you create the orgs by specifying the --no-track-source flag on the "$ sf org create scratch|sandbox" commands.
        /// 
        /// To retrieve multiple metadata components, either use multiple --metadata [name] flags or use a single --metadata flag with multiple names separated by spaces. Enclose names that contain spaces in one set of double quotes. The same syntax applies to --manifest and --source-dir.
        /// </remarks>
        /// <example>
        /// Retrieve all remote changes from your default org:
        /// $ sf retrieve start
        /// Retrieve the source files in the "force-app" directory from an org with alias "my-scratch":
        /// $ sf retrieve start --source-dir force-app --target-org my-scratch
        /// Retrieve all the Apex classes and custom objects whose source is in the "force-app" directory. The list views, layouts, etc, that are associated with the custom objects are also retrieved. Both examples are equivalent:
        /// $ sf retrieve start --source-dir force-app/main/default/classes force-app/main/default/objects
        /// $ sf retrieve start --source-dir force-app/main/default/classes --source-dir force-app/main/default/objects
        /// Retrieve all Apex classes that are in all package directories defined in the "sfdx-project.json" file:
        /// $ sf retrieve start --metadata ApexClass
        /// Retrieve a specific Apex class; ignore any conflicts between the local project and org (be careful with this flag, because it will overwrite the Apex class source files in your local project if there are conflicts!):
        /// $ sf retrieve start --metadata ApexClass:MyApexClass --ignore-conflicts
        /// Retrieve specific Apex classes that match a pattern; in this example, retrieve Apex classes whose names contain the string "MyApex":
        /// $ sf retrieve start --metadata 'ApexClass:MyApex*'
        /// Retrieve all custom objects and Apex classes found in all defined package directories (both examples are equivalent):
        /// $ sf retrieve start --metadata CustomObject ApexClass
        /// $ sf retrieve start --metadata CustomObject --metadata ApexClass
        /// Retrieve all metadata components listed in a manifest:
        /// $ sf retrieve start --manifest path/to/package.xml
        /// Retrieve metadata from a package:
        /// $ sf retrieve start --package-name MyPackageName
        /// Retrieve metadata from multiple packages, one of which has a space in its name (both examples are equivalent):
        /// $ sf retrieve start --package-name Package1 "PackageName With Spaces" Package3
        /// $ sf retrieve start --package-name Package1 --package-name "PackageName With Spaces" --package-name Package3
        /// Retrieve the metadata components listed in the force-app directory, but retrieve them in metadata format into a ZIP file in the "output" directory:
        /// $ sf retrieve start --source-dir force-app --target-metadata-dir output
        /// Retrieve in metadata format and automatically extract the contents into the "output" directory:
        /// $ sf retrieve start --source-dir force-app --target-metadata-dir output --unzip
        /// </example>
        [Command("retrieve start")]
        public SfResponse RetrieveStart(ProjectRetrieveStartOptions options)
        {
            return ExecuteCommand(nameof(RetrieveStart), options);
        }
    }
}

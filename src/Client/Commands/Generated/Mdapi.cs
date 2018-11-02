// Generated on November 2nd 2018, 11:11:11 am using sfdx-cli/6.38.0-0d66175ccf (windows-x64) node-v8.9.4. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method convert of class Mdapi.
  /// </summary>
  public class MdapiConvertOptions : SFDXOptions {
    /// <summary>
    /// [Required] The root directory that contains the metadata you retrieved using Metadata API.
    /// </summary>  
    [SwitchName("--rootdir")]
    public string rootdir  {get; set;}
  
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
    /// [Required] The directory to store your files in after they’re converted to the source format. Can be an absolute or relative path.
    /// </summary>  
    [SwitchName("--outputdir")]
    public string outputdir  {get; set;}
  }
  
  /// <summary>
  /// Options for the method deploy of class Mdapi.
  /// </summary>
  public class MdapiDeployOptions : SFDXOptions {
    /// <summary>
    /// [Optional] Ignores the deploy errors, and continues with the deploy operation. The default is false. Keep this parameter set to false when deploying to a production org. If set to true, components without errors are deployed, and components with errors are skipped.
    /// </summary>  
    [SwitchName("--ignoreerrors")]
    public bool? ignoreerrors  {get; set;}
  
    /// <summary>
    /// [Optional] Indicates that you want verbose output from the deploy operation.
    /// </summary>  
    [SwitchName("--verbose")]
    public bool? verbose  {get; set;}
  
    /// <summary>
    /// [Optional] If a warning occurs and ignoreWarnings is set to true, the success field in DeployMessage is true. When ignoreWarnings is set to false, success is set to false, and the warning is treated like an error.
    /// This field is available in API version 18.0 and later. Prior to version 18.0, there was no distinction between warnings and errors. All problems were treated as errors and prevented a successful deployment.
    /// </summary>  
    [SwitchName("--ignorewarnings")]
    public bool? ignorewarnings  {get; set;}
  
    /// <summary>
    /// [Required] Validates the deployed metadata and runs all Apex tests, but prevents the deployment from being saved to the org.
    /// If you change a field type from Master-Detail to Lookup or vice versa, that change isn’t supported when using the --checkonly parameter to test a deployment (validation). This kind of change isn’t supported for test deployments to avoid the risk of data loss or corruption. If a change that isn’t supported for test deployments is included in a deployment package, the test deployment fails and issues an error.
    /// If your deployment package changes a field type from Master-Detail to Lookup or vice versa, you can still validate the changes prior to deploying to Production by performing a full deployment to another test Sandbox. A full deployment includes a validation of the changes as part of the deployment process.
    /// Note: A Metadata API deployment that includes Master-Detail relationships deletes all detail records in the Recycle Bin in the following cases.
    /// 1. For a deployment with a new Master-Detail field, soft delete (send to the Recycle Bin) all detail records before proceeding to deploy the Master-Detail field, or the deployment fails. During the deployment, detail records are permanently deleted from the Recycle Bin and cannot be recovered.
    /// 2. For a deployment that converts a Lookup field relationship to a Master-Detail relationship, detail records must reference a master record or be soft-deleted (sent to the Recycle Bin) for the deployment to succeed. However, a successful deployment permanently deletes any detail records in the Recycle Bin.
    /// </summary>  
    [SwitchName("--checkonly")]
    public string checkonly  {get; set;}
  
    /// <summary>
    /// [Optional] The number of minutes to wait for the command to complete. The default is –1 (no limit). 0
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  
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
    /// [Required] The path to the .zip file of metadata files to deploy. You must indicate this option or --deploydir.If you specify both --zipfile and --deploydir, a .zip file of the contents of the deploy directory is created at the path specified for the .zip file.
    /// </summary>  
    [SwitchName("--zipfile")]
    public string zipfile  {get; set;}
  
    /// <summary>
    /// [Required] The job ID (asyncId) of the deployment you want to check. If not specified, the default value is the ID of the most recent metadata deployment you ran using Salesforce CLI. Use with -w to resume waiting.
    /// </summary>  
    [SwitchName("--jobid")]
    public string jobid  {get; set;}
  
    /// <summary>
    /// [Required] The root of the directory tree that contains the files to deploy. The root must contain a valid package.xml file describing the entities in the directory structure. Required to initiate a deployment if you don’t use --zipfile. If you specify both --zipfile and --deploydir, a zip file of the contents of the --deploydir directory is written to the location specified by --zipfile.
    /// </summary>  
    [SwitchName("--deploydir")]
    public string deploydir  {get; set;}
  
    /// <summary>
    /// [Required] Indicates whether any failure causes a complete rollback of the deploy operation. The default is true. If set to false, the operation performs actions that don’t have errors and returns errors for the remaining actions. You must set this parameter to true if you are deploying to a production org.
    /// </summary>  
    [SwitchName("--rollbackonerror")]
    public string rollbackonerror  {get; set;}
  
    /// <summary>
    /// [Required] Lists the Apex classes containing the deployment tests to run. Use this parameter when you set --testlevel to RunSpecifiedTests.
    /// </summary>  
    [SwitchName("--runtests")]
    public string runtests  {get; set;}
  
    /// <summary>
    /// [Required] Specifies which level of deployment tests to run. Valid values are:
    /// NoTestRun—No tests are run. This test level applies only to deployments to development environments, such as sandbox, Developer Edition, or trial orgs. This test level is the default for development environments.
    /// RunSpecifiedTests—Runs only the tests that you specify in the --runtests option. Code coverage requirements differ from the default coverage requirements when using this test level. Executed tests must comprise a minimum of 75% code coverage for each class and trigger in the deployment package. This coverage is computed for each class and trigger individually and is different than the overall coverage percentage.
    /// RunLocalTests—All tests in your org are run, except the ones that originate from installed managed packages. This test level is the default for production deployments that include Apex classes or triggers.
    /// RunAllTestsInOrg—All tests in your org are run, including tests of managed packages.
    /// If you don’t specify a test level, the default behavior depends on the contents of your deployment package. For more information, see “Running Tests in a Deployment” in the Metadata API Developer Guide.
    /// </summary>  
    [SwitchName("--testlevel")]
    public string testlevel  {get; set;}
  }
  
  /// <summary>
  /// Options for the method deployCancel of class Mdapi.
  /// </summary>
  public class MdapiDeployCancelOptions : SFDXOptions {
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
    /// [Required] The job ID (requestId) of the deployment you want to cancel. If not specified, the default value is the ID of the most recent metadata deployment you ran using Salesforce CLI.
    /// </summary>  
    [SwitchName("--jobid")]
    public string jobid  {get; set;}
  
    /// <summary>
    /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  }
  
  /// <summary>
  /// Options for the method deployReport of class Mdapi.
  /// </summary>
  public class MdapiDeployReportOptions : SFDXOptions {
    /// <summary>
    /// [Optional] Indicates that you want verbose output for deploy results.
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
  
    /// <summary>
    /// [Required] The job ID (asyncId) of the deployment you want to check. If not specified, the default value is the ID of the most recent metadata deployment you ran using Salesforce CLI. Use with -w to resume waiting.
    /// </summary>  
    [SwitchName("--jobid")]
    public string jobid  {get; set;}
  
    /// <summary>
    /// [Optional] The number of minutes to wait for the command to complete. The default is –1 (no limit). 0
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  }
  
  /// <summary>
  /// Options for the method retrieve of class Mdapi.
  /// </summary>
  public class MdapiRetrieveOptions : SFDXOptions {
    /// <summary>
    /// [Required] The root of the directory structure where the retrieved .zip or metadata files are put.
    /// </summary>  
    [SwitchName("--retrievetargetdir")]
    public string retrievetargetdir  {get; set;}
  
    /// <summary>
    /// [Optional] Specifies whether only a single package is being retrieved (true) or more than one package (false).
    /// </summary>  
    [SwitchName("--singlepackage")]
    public bool? singlepackage  {get; set;}
  
    /// <summary>
    /// [Optional] Indicates that you want verbose output from the retrieve operation.
    /// </summary>  
    [SwitchName("--verbose")]
    public bool? verbose  {get; set;}
  
    /// <summary>
    /// [Optional] Use to override the default, which is the latest version supported by your CLI plug-in, with the version in your package.xml file.
    /// </summary>  
    [SwitchName("--apiversion")]
    public int? apiversion  {get; set;}
  
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
    /// [Required] The job ID (asyncId) of the retrieve you want to check. If not specified, the default value is the ID of the most recent metadata retrieval you ran using Salesforce CLI. You must specify a --retrievetargetdir. Use with --wait to resume waiting.
    /// </summary>  
    [SwitchName("--jobid")]
    public string jobid  {get; set;}
  
    /// <summary>
    /// [Optional] The number of minutes to wait for the command to complete. -1
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  
    /// <summary>
    /// [Required] A comma-separated list of package names to retrieve.
    /// </summary>  
    [SwitchName("--packagenames")]
    public string packagenames  {get; set;}
  
    /// <summary>
    /// [Required] The source directory to use instead of the default manifest specified in sfdx-config.json.
    /// </summary>  
    [SwitchName("--sourcedir")]
    public string sourcedir  {get; set;}
  
    /// <summary>
    /// [Required] The complete path for the manifest file that specifies the components to retrieve.
    /// </summary>  
    [SwitchName("--unpackaged")]
    public string unpackaged  {get; set;}
  }
  
  /// <summary>
  /// Options for the method retrieveReport of class Mdapi.
  /// </summary>
  public class MdapiRetrieveReportOptions : SFDXOptions {
    /// <summary>
    /// [Optional] Indicates that you want verbose output from the retrieve operation.
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
  
    /// <summary>
    /// [Required] The job ID (asyncId) of the retrieve you want to check. If not specified, the default value is the ID of the most recent metadata retrieval you ran using Salesforce CLI. You must specify a --retrievetargetdir. Use with --wait to resume waiting.
    /// </summary>  
    [SwitchName("--jobid")]
    public string jobid  {get; set;}
  
    /// <summary>
    /// [Required] The root of the directory structure where the retrieved .zip or metadata files are put.
    /// </summary>  
    [SwitchName("--retrievetargetdir")]
    public string retrievetargetdir  {get; set;}
  
    /// <summary>
    /// [Optional] The number of minutes to wait for the command to complete. -1
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  }
  

  /// <summary>
  /// Mdapi
  /// </summary>
  [CommandClass("force:mdapi")]
  public class Mdapi : SFDXCommand {

    /// Constructor.
    public Mdapi(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

    
    /// <summary>
    /// convert metadata from the Metadata API format into the source format
    /// </summary>
    /// <remarks>
    /// Converts metadata retrieved via Metadata API into the source format used in Salesforce DX projects.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// To use Salesforce CLI to work with components that you retrieved via Metadata API, first convert your files from the metadata format to the source format using "sfdx force:mdapi:convert".
    /// 
    /// To convert files from the source format back to the metadata format, so that you can deploy them using "sfdx force:mdapi:deploy", run "sfdx force:source:convert".
    /// 
    /// Examples:
    ///    $ sfdx force:mdapi:convert -r path/to/metadata
    ///    $ sfdx force:mdapi:convert -r path/to/metadata -d path/to/outputdir
    /// force:mdapi:convert -r <directory> [-d <directory>] [--json] [--loglevel <string>]
    /// </example>
    [Command("convert")]
      public JToken Convert(MdapiConvertOptions p_Options) {
        return ExecuteCommand<MdapiConvertOptions, JToken>(nameof(Convert), p_Options);      
      }
    
    /// <summary>
    /// deploy metadata to an org using Metadata API
    /// </summary>
    /// <remarks>
    /// Deploys file representations of components into an org by creating or updating the components they represent. You can deploy and retrieve up to 10,000 files or 400 MB (39 MB compressed) at one time. The default target username is the admin user for the default scratch org.
    /// </remarks>
    /// <example>  
    /// Specify the location of the files to deploy as a .zip file or by the root of the directory tree containing the files. To check the status of a deployment, specify its job ID.
    /// 
    /// The default value of --rollbackonerror is true, but the corresponding parameter in the Metadata API deploy() call defaults to false.
    /// 
    /// To wait for the command to finish running no matter how long the deployment takes, set --wait to -1: "sfdx force mdapi:deploy -w -1 ...".
    /// force:mdapi:deploy (-c | -i <id>) (-d <directory> | -f <filepath>) [-w <minutes>] [-l <string>] [-r <string>...] [-e <boolean>] [-o] [-g] [-u <string>] [--json] [--loglevel <string>] [--verbose]
    /// </example>
    [Command("deploy")]
      public JToken Deploy(MdapiDeployOptions p_Options) {
        return ExecuteCommand<MdapiDeployOptions, JToken>(nameof(Deploy), p_Options);      
      }
    
    /// <summary>
    /// cancel a metadata deployment
    /// </summary>
    /// <remarks>
    /// Cancels an asynchronous metadata deployment.
    /// </remarks>
    /// <example>  
    /// Use this command to cancel a specified asynchronous metadata deployment. You can also specify a wait time (in minutes) to check for updates to the canceled deploy status.
    /// 
    /// Examples:
    /// 
    /// Deploy a directory of files to the org
    ///   $ sfdx force:mdapi:deploy -d <directory>
    /// Now cancel this deployment and wait two minutes
    ///   $ sfdx force:mdapi:deploy:cancel -w 2
    /// 
    /// If you have multiple deployments in progress and want to cancel a specific one, specify the job ID
    ///   $ sfdx force:mdapi:deploy:cancel -i <jobid>
    /// Check the status of the cancel job
    ///   $ sfdx force:mdapi:deploy:report
    /// force:mdapi:deploy:cancel [-w <minutes>] [-i <id>] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("deploy:cancel")]
      public JToken DeployCancel(MdapiDeployCancelOptions p_Options) {
        return ExecuteCommand<MdapiDeployCancelOptions, JToken>(nameof(DeployCancel), p_Options);      
      }
    
    /// <summary>
    /// check the status of a metadata deployment
    /// </summary>
    /// <remarks>
    /// Checks the current status of an asynchronous metadata deployment.
    /// </remarks>
    /// <example>  
    /// Specify the job ID for the deploy you want to check. You can also specify a wait time (minutes) to check for updates to the deploy status.
    /// force:mdapi:deploy:report [-w <minutes>] [-i <id>] [-u <string>] [--json] [--loglevel <string>] [--verbose]
    /// </example>
    [Command("deploy:report")]
      public JToken DeployReport(MdapiDeployReportOptions p_Options) {
        return ExecuteCommand<MdapiDeployReportOptions, JToken>(nameof(DeployReport), p_Options);      
      }
    
    /// <summary>
    /// retrieve metadata from an org using Metadata API
    /// </summary>
    /// <remarks>
    /// Uses Metadata API to retrieve a .zip of XML files that represent metadata from the targeted org. The default target username is the admin user for the default scratch org. You can retrieve and deploy up to 10,000 files or 400 MB (39 MB compressed) at one time.
    /// </remarks>
    /// <example>  
    /// The default target username is the admin user for the default scratch org. You can retrieve and deploy up to 10,000 files or 400 MB (39 MB compressed) at one time.
    /// force:mdapi:retrieve -r <directory> [-a <number>] [-w <minutes>] [-k <filepath>] [-d <directory>] [-p <string>...] [-s] [-i <id>] [-u <string>] [--json] [--loglevel <string>] [--verbose]
    /// </example>
    [Command("retrieve")]
      public JToken Retrieve(MdapiRetrieveOptions p_Options) {
        return ExecuteCommand<MdapiRetrieveOptions, JToken>(nameof(Retrieve), p_Options);      
      }
    
    /// <summary>
    /// check the status of a metadata retrieval
    /// </summary>
    /// <remarks>
    /// Check the status of an asynchronous metadata retrieval.
    /// </remarks>
    /// <example>  
    /// Specify the job ID and a target directory for the retrieve you want to check. You can also specify a wait time (minutes) to check for updates to the deploy status. If the retrieve was successful, the resulting zip file will be saved to the location passed in with the retrieve target parameter.
    /// force:mdapi:retrieve:report [-w <minutes>] [-r <directory>] [-i <id>] [-u <string>] [--json] [--loglevel <string>] [--verbose]
    /// </example>
    [Command("retrieve:report")]
      public JToken RetrieveReport(MdapiRetrieveReportOptions p_Options) {
        return ExecuteCommand<MdapiRetrieveReportOptions, JToken>(nameof(RetrieveReport), p_Options);      
      }
    
  }
}

// Generated on September 11th 2018, 4:34:12 pm. DO NOT MODIFY
using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;


/**
 * Options for the method convert of class Mdapi.
 *
 * IMdapiConvert
 */
public class MdapiConvertOptions : SFDXOptions {

  /**
   * [Required] The root directory that contains the metadata you retrieved using Metadata API.
   * @type {string}
   * @memberof MdapiConvertOptions
   */
  [SwitchName("--rootdir")]
  public string rootdir  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof MdapiConvertOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof MdapiConvertOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] The directory to store your source in after it’s converted to the Salesforce DX format. Can be an absolute or relative path.
   * @type {string}
   * @memberof MdapiConvertOptions
   */
  [SwitchName("--outputdir")]
  public string outputdir  {get; set;}
}

/**
 * Options for the method deploy of class Mdapi.
 *
 * IMdapiDeploy
 */
public class MdapiDeployOptions : SFDXOptions {

  /**
   * [Optional] Ignores the deploy errors, and continues with the deploy operation. The default is false. Keep this parameter set to false when deploying to a production org. If set to true, components without errors are deployed, and components with errors are skipped.
   * @type {bool}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--ignoreerrors")]
  public bool? ignoreerrors  {get; set;}

  /**
   * [Optional] Indicates that you want verbose output from the deploy operation.
   * @type {bool}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] If a warning occurs and ignoreWarnings is set to true, the success field in DeployMessage is true. When ignoreWarnings is set to false, success is set to false, and the warning is treated like an error.
   * This field is available in API version 18.0 and later. Prior to version 18.0, there was no distinction between warnings and errors. All problems were treated as errors and prevented a successful deployment.
   * @type {bool}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--ignorewarnings")]
  public bool? ignorewarnings  {get; set;}

  /**
   * [Required] Validates the deployed metadata and runs all Apex tests, but prevents the deployment from being saved to the org.
   * If you change a field type from Master-Detail to Lookup or vice versa, that change isn’t supported when using the --checkonly parameter to test a deployment (validation). This kind of change isn’t supported for test deployments to avoid the risk of data loss or corruption. If a change that isn’t supported for test deployments is included in a deployment package, the test deployment fails and issues an error.
   * If your deployment package changes a field type from Master-Detail to Lookup or vice versa, you can still validate the changes prior to deploying to Production by performing a full deployment to another test Sandbox. A full deployment includes a validation of the changes as part of the deployment process.
   * Note: A Metadata API deployment that includes Master-Detail relationships deletes all detail records in the Recycle Bin in the following cases.
   * 1. For a deployment with a new Master-Detail field, soft delete (send to the Recycle Bin) all detail records before proceeding to deploy the Master-Detail field, or the deployment fails. During the deployment, detail records are permanently deleted from the Recycle Bin and cannot be recovered.
   * 2. For a deployment that converts a Lookup field relationship to a Master-Detail relationship, detail records must reference a master record or be soft-deleted (sent to the Recycle Bin) for the deployment to succeed. However, a successful deployment permanently deletes any detail records in the Recycle Bin.
   * @type {string}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--checkonly")]
  public string checkonly  {get; set;}

  /**
   * [Required] The number of minutes to wait for the command to complete. The default is –1 (no limit). 0
   * @type {string}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] The path to the .zip file of metadata files to deploy. You must indicate this option or --deploydir.If you specify both --zipfile and --deploydir, a .zip file of the contents of the deploy directory is created at the path specified for the .zip file.
   * @type {string}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--zipfile")]
  public string zipfile  {get; set;}

  /**
   * [Required] The job ID (asyncId) of the deployment you want to check. Use with -w to resume waiting.
   * @type {string}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--jobid")]
  public string jobid  {get; set;}

  /**
   * [Required] The root of the directory tree that contains the files to deploy. The root must contain a valid package.xml file describing the entities in the directory structure. Required to initiate a deployment if you don’t use --zipfile. If you specify both --zipfile and --deploydir, a zip file of the contents of the --deploydir directory is written to the location specified by --zipfile.
   * @type {string}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--deploydir")]
  public string deploydir  {get; set;}

  /**
   * [Required] Indicates whether any failure causes a complete rollback of the deploy operation. The default is true. If set to false, the operation performs actions that don’t have errors and returns errors for the remaining actions. You must set this parameter to true if you are deploying to a production org.
   * @type {string}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--rollbackonerror")]
  public string rollbackonerror  {get; set;}

  /**
   * [Required] Lists the Apex classes containing the deployment tests to run. Use this parameter when you set --testlevel to RunSpecifiedTests.
   * @type {string}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--runtests")]
  public string runtests  {get; set;}

  /**
   * [Required] Specifies which level of deployment tests to run. Valid values are:
   * NoTestRun—No tests are run. This test level applies only to deployments to development environments, such as sandbox, Developer Edition, or trial orgs. This test level is the default for development environments.
   * RunSpecifiedTests—Runs only the tests that you specify in the --runtests option. Code coverage requirements differ from the default coverage requirements when using this test level. Executed tests must comprise a minimum of 75% code coverage for each class and trigger in the deployment package. This coverage is computed for each class and trigger individually and is different than the overall coverage percentage.
   * RunLocalTests—All tests in your org are run, except the ones that originate from installed managed packages. This test level is the default for production deployments that include Apex classes or triggers.
   * RunAllTestsInOrg—All tests in your org are run, including tests of managed packages.
   * If you don’t specify a test level, the default behavior depends on the contents of your deployment package. For more information, see “Running Tests in a Deployment” in the Metadata API Developer Guide.
   * @type {string}
   * @memberof MdapiDeployOptions
   */
  [SwitchName("--testlevel")]
  public string testlevel  {get; set;}
}

/**
 * Options for the method deployReport of class Mdapi.
 *
 * IMdapiDeployReport
 */
public class MdapiDeployReportOptions : SFDXOptions {

  /**
   * [Optional] Indicates that you want verbose output for deploy results.
   * @type {bool}
   * @memberof MdapiDeployReportOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof MdapiDeployReportOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof MdapiDeployReportOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof MdapiDeployReportOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] The job ID (asyncId) of the deployment you want to check. Use with -w to resume waiting.
   * @type {string}
   * @memberof MdapiDeployReportOptions
   */
  [SwitchName("--jobid")]
  public string jobid  {get; set;}

  /**
   * [Required] The number of minutes to wait for the command to complete. The default is –1 (no limit). 0
   * @type {string}
   * @memberof MdapiDeployReportOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}
}

/**
 * Options for the method retrieve of class Mdapi.
 *
 * IMdapiRetrieve
 */
public class MdapiRetrieveOptions : SFDXOptions {

  /**
   * [Required] The root of the directory structure where the retrieved .zip or metadata files are put.
   * @type {string}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--retrievetargetdir")]
  public string retrievetargetdir  {get; set;}

  /**
   * [Optional] Specifies whether only a single package is being retrieved (true) or more than one package (false).
   * @type {bool}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--singlepackage")]
  public bool? singlepackage  {get; set;}

  /**
   * [Optional] Indicates that you want verbose output from the retrieve operation.
   * @type {bool}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Required] Use to override the default, which is the latest version supported by your CLI plug-in, with the version in your package.xml file.
   * @type {string}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--apiversion")]
  public string apiversion  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] The job ID (asyncId) of the retrieve you want to check. You must specify a --retrievetargetdir. Use with --wait to resume waiting.
   * @type {string}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--jobid")]
  public string jobid  {get; set;}

  /**
   * [Required] The number of minutes to wait for the command to complete. -1
   * @type {string}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}

  /**
   * [Required] A comma-separated list of package names to retrieve.
   * @type {string}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--packagenames")]
  public string packagenames  {get; set;}

  /**
   * [Required] The source directory to use instead of the default manifest specified in sfdx-config.json.
   * @type {string}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--sourcedir")]
  public string sourcedir  {get; set;}

  /**
   * [Required] The complete path for the manifest file that specifies the components to retrieve.
   * @type {string}
   * @memberof MdapiRetrieveOptions
   */
  [SwitchName("--unpackaged")]
  public string unpackaged  {get; set;}
}

/**
 * Options for the method retrieveReport of class Mdapi.
 *
 * IMdapiRetrieveReport
 */
public class MdapiRetrieveReportOptions : SFDXOptions {

  /**
   * [Optional] Indicates that you want verbose output from the retrieve operation.
   * @type {bool}
   * @memberof MdapiRetrieveReportOptions
   */
  [SwitchName("--verbose")]
  public bool? verbose  {get; set;}

  /**
   * [Optional] The logging level for this command invocation. Logs are stored in $HOME/.sfdx/sfdx.log.
   * @type {LogLevel}
   * @memberof MdapiRetrieveReportOptions
   */
  [SwitchName("--loglevel")]
  public LogLevel? loglevel  {get; set;}

  /**
   * [Optional] Format output as JSON.
   * @type {bool}
   * @memberof MdapiRetrieveReportOptions
   */
  [SwitchName("--json")]
  public bool? json  {get; set;}

  /**
   * [Required] A username or alias for the target org. Overrides the default target org.
   * @type {string}
   * @memberof MdapiRetrieveReportOptions
   */
  [SwitchName("--targetusername")]
  public string targetusername  {get; set;}

  /**
   * [Required] The job ID (asyncId) of the retrieve you want to check. You must specify a --retrievetargetdir. Use with --wait to resume waiting.
   * @type {string}
   * @memberof MdapiRetrieveReportOptions
   */
  [SwitchName("--jobid")]
  public string jobid  {get; set;}

  /**
   * [Required] The root of the directory structure where the retrieved .zip or metadata files are put.
   * @type {string}
   * @memberof MdapiRetrieveReportOptions
   */
  [SwitchName("--retrievetargetdir")]
  public string retrievetargetdir  {get; set;}

  /**
   * [Required] The number of minutes to wait for the command to complete. -1
   * @type {string}
   * @memberof MdapiRetrieveReportOptions
   */
  [SwitchName("--wait")]
  public string wait  {get; set;}
}


/**
 * Mdapi
 *
 * @class Mdapi
 */
[CommandClass("force:mdapi")]
public class Mdapi : SFDXCommand {
        /// <inheritDoc />
    public Mdapi(CommandExecutioner p_CommandExecutioner)
        : base(p_CommandExecutioner)
    {
    }

  
  /**
   * convert metadata from the Metadata API format into the Salesforce DX format
   * @returns {(Promise<Object | void>)}
   * @memberof Mdapi
   * @description Converts metadata retrieved via Metadata API into the source format used in Salesforce DX projects.
   * @example NOTE: This command must be run from within a project.
   * 
   * To work with metadata that you retrieved via Metadata API using the Salesforce DX tools, convert the metadata to the Salesforce DX source format using "sfdx force:mdapi:convert".
   * 
   * To convert the source back to the Metadata API format, so that you can deploy it using "sfdx force:mdapi:deploy", run "sfdx force:source:convert".
   * 
   * Examples:
   *    $ sfdx force:mdapi:convert -r <path to source>
   *    $ sfdx force:mdapi:convert -r <path to source> -d <path to outputdir>
   * force:mdapi:convert -r <directory> [-d <directory>] [--json] [--loglevel <string>]
   */
   [Command("convert")]
    public JToken convert(MdapiConvertOptions p_Options) {
      return ExecuteCommand<MdapiConvertOptions, JToken>(nameof(convert), p_Options);      
    }
  
  /**
   * deploy metadata to an org using Metadata API
   * @returns {(Promise<Object | void>)}
   * @memberof Mdapi
   * @description Deploys file representations of components into an org by creating or updating the components they represent. You can deploy and retrieve up to 10,000 files or 400 MB (39 MB compressed) at one time. The default target username is the admin user for the default scratch org.
   * @example Specify the location of the files to deploy as a .zip file or by the root of the directory tree containing the files. To check the status of a deployment, specify its job ID.
   * 
   * The default value of --rollbackonerror is true, but the corresponding parameter in the Metadata API deploy() call defaults to false.
   * 
   * To wait for the command to finish running no matter how long the deployment takes, set --wait to -1: "sfdx force mdapi:deploy -w -1 ...".
   * force:mdapi:deploy (-c | -i <id>) (-d <directory> | -f <filepath>) [-w <minutes>] [-l <string>] [-r <string>...] [-e <boolean>] [-o] [-g] [-u <string>] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("deploy")]
    public JToken deploy(MdapiDeployOptions p_Options) {
      return ExecuteCommand<MdapiDeployOptions, JToken>(nameof(deploy), p_Options);      
    }
  
  /**
   * check the status of a metadata deployment
   * @returns {(Promise<Object | void>)}
   * @memberof Mdapi
   * @description Checks the current status of an asynchronous metadata deployment.
   * @example Specify the job ID for the deploy you want to check. You can also specify a wait time (minutes) to check for updates to the deploy status.
   * force:mdapi:deploy:report [-w <minutes>] [-i <id>] [-u <string>] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("deploy:report")]
    public JToken deployReport(MdapiDeployReportOptions p_Options) {
      return ExecuteCommand<MdapiDeployReportOptions, JToken>(nameof(deployReport), p_Options);      
    }
  
  /**
   * retrieve metadata from an org using Metadata API
   * @returns {(Promise<Object | void>)}
   * @memberof Mdapi
   * @description Uses Metadata API to retrieve a .zip of XML files that represent metadata from the targeted org. The default target username is the admin user for the default scratch org. You can retrieve and deploy up to 10,000 files or 400 MB (39 MB compressed) at one time.
   * @example The default target username is the admin user for the default scratch org. You can retrieve and deploy up to 10,000 files or 400 MB (39 MB compressed) at one time.
   * force:mdapi:retrieve -r <directory> [-a <number>] [-w <minutes>] [-k <filepath>] [-d <directory>] [-p <string>...] [-s] [-i <id>] [-u <string>] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("retrieve")]
    public JToken retrieve(MdapiRetrieveOptions p_Options) {
      return ExecuteCommand<MdapiRetrieveOptions, JToken>(nameof(retrieve), p_Options);      
    }
  
  /**
   * check the status of a metadata retrieval
   * @returns {(Promise<Object | void>)}
   * @memberof Mdapi
   * @description Check the status of an asynchronous metadata retrieval.
   * @example Specify the job ID and a target directory for the retrieve you want to check. You can also specify a wait time (minutes) to check for updates to the deploy status. If the retrieve was successful, the resulting zip file will be saved to the location passed in with the retrieve target parameter.
   * force:mdapi:retrieve:report [-w <minutes>] [-r <directory>] [-i <id>] [-u <string>] [--json] [--loglevel <string>] [--verbose]
   */
   [Command("retrieve:report")]
    public JToken retrieveReport(MdapiRetrieveReportOptions p_Options) {
      return ExecuteCommand<MdapiRetrieveReportOptions, JToken>(nameof(retrieveReport), p_Options);      
    }
  
}

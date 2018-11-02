// Generated on November 2nd 2018, 11:11:11 am using sfdx-cli/6.38.0-0d66175ccf (windows-x64) node-v8.9.4. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using Newtonsoft.Json.Linq;
using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
  /// <summary>
  /// Options for the method convert of class Source.
  /// </summary>
  public class SourceConvertOptions : SFDXOptions {
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
    /// [Required] The name of the package to associate with the metadata-formatted files.
    /// </summary>  
    [SwitchName("--packagename")]
    public string packagename  {get; set;}
  
    /// <summary>
    /// [Required] The output directory to store the Metadata API–formatted metadata files in.
    /// </summary>  
    [SwitchName("--outputdir")]
    public string outputdir  {get; set;}
  
    /// <summary>
    /// [Required] A directory other than the default package directory that contains the source-formatted files to convert.
    /// </summary>  
    [SwitchName("--rootdir")]
    public string rootdir  {get; set;}
  }
  
  /// <summary>
  /// Options for the method delete of class Source.
  /// </summary>
  public class SourceDeleteOptions : SFDXOptions {
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
    /// [Required] A comma-separated list of names of metadata components to delete from your project and your org.
    /// </summary>  
    [SwitchName("--metadata")]
    public string metadata  {get; set;}
  
    /// <summary>
    /// [Required] A comma-separated list of paths to the local metadata to delete. The supplied paths can be a single file (in which case the operation is applied to only one file) or a folder (in which case the operation is applied to all metadata types in the directory and its sub-directories).
    /// If you specify this parameter, don’t specify --manifest or --metadata.
    /// </summary>  
    [SwitchName("--sourcepath")]
    public string sourcepath  {get; set;}
  
    /// <summary>
    /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  
    /// <summary>
    /// [Optional] Do not prompt for delete confirmation.
    /// </summary>  
    [SwitchName("--noprompt")]
    public bool? noprompt  {get; set;}
  }
  
  /// <summary>
  /// Options for the method deploy of class Source.
  /// </summary>
  public class SourceDeployOptions : SFDXOptions {
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
    /// [Required] The complete path for the manifest (package.xml) file that specifies the components to deploy.
    /// If you specify this parameter, don’t specify --metadata or --sourcepath.
    /// </summary>  
    [SwitchName("--manifest")]
    public string manifest  {get; set;}
  
    /// <summary>
    /// [Required] A comma-separated list of paths to the local source files to deploy. The supplied paths can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all metadata types in the directory and its sub-directories).
    /// If you specify this parameter, don’t specify --manifest or --metadata.
    /// </summary>  
    [SwitchName("--sourcepath")]
    public string sourcepath  {get; set;}
  
    /// <summary>
    /// [Required] A comma-separated list of names of metadata components to deploy to the org.
    /// </summary>  
    [SwitchName("--metadata")]
    public string metadata  {get; set;}
  
    /// <summary>
    /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  }
  
  /// <summary>
  /// Options for the method open of class Source.
  /// </summary>
  public class SourceOpenOptions : SFDXOptions {
    /// <summary>
    /// [Required] File to edit.
    /// </summary>  
    [SwitchName("--sourcefile")]
    public string sourcefile  {get; set;}
  
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
    /// [Optional] Generate a navigation URL path, but don’t launch a browser-based editor.
    /// </summary>  
    [SwitchName("--urlonly")]
    public bool? urlonly  {get; set;}
  }
  
  /// <summary>
  /// Options for the method pull of class Source.
  /// </summary>
  public class SourcePullOptions : SFDXOptions {
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
    /// [Optional] Runs the pull command even if conflicts exist. Changes in the scratch org overwrite changes in the project.
    /// </summary>  
    [SwitchName("--forceoverwrite")]
    public bool? forceoverwrite  {get; set;}
  
    /// <summary>
    /// [Optional] The number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  }
  
  /// <summary>
  /// Options for the method push of class Source.
  /// </summary>
  public class SourcePushOptions : SFDXOptions {
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
    /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  
    /// <summary>
    /// [Optional] Replaces tokens in source files prior to deployment.
    /// </summary>  
    [SwitchName("--replacetokens")]
    public bool? replacetokens  {get; set;}
  
    /// <summary>
    /// [Optional] Completes the deployment even if warnings are generated.
    /// </summary>  
    [SwitchName("--ignorewarnings")]
    public bool? ignorewarnings  {get; set;}
  
    /// <summary>
    /// [Optional] Runs the push command even if conflicts exist. Changes in the project overwrite changes in the scratch org.
    /// </summary>  
    [SwitchName("--forceoverwrite")]
    public bool? forceoverwrite  {get; set;}
  }
  
  /// <summary>
  /// Options for the method retrieve of class Source.
  /// </summary>
  public class SourceRetrieveOptions : SFDXOptions {
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
    /// [Required] A comma-separated list of file paths for source to retrieve from the org. The supplied paths can be to a single file (in which case the operation is applied to only one file) or to a folder (in which case the operation is applied to all source files in the directory and its sub-directories).
    /// </summary>  
    [SwitchName("--sourcepath")]
    public string sourcepath  {get; set;}
  
    /// <summary>
    /// [Required] A comma-separated list of names of metadata components to retrieve from the org.
    /// </summary>  
    [SwitchName("--metadata")]
    public string metadata  {get; set;}
  
    /// <summary>
    /// [Required] The complete path for the manifest (package.xml) file that specifies the components to retrieve.
    /// If you specify this parameter, don’t specify --metadata or --sourcepath.
    /// </summary>  
    [SwitchName("--manifest")]
    public string manifest  {get; set;}
  
    /// <summary>
    /// [Optional] Number of minutes to wait for the command to complete and display results to the terminal window. If the command continues to run after the wait period, the CLI returns control of the terminal window to you. The default is 33 minutes.
    /// </summary>  
    [SwitchName("--wait")]
    public int? wait  {get; set;}
  }
  
  /// <summary>
  /// Options for the method status of class Source.
  /// </summary>
  public class SourceStatusOptions : SFDXOptions {
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
    /// [Optional] Lists the changes that have been made in the scratch org.
    /// </summary>  
    [SwitchName("--remote")]
    public bool? remote  {get; set;}
  
    /// <summary>
    /// [Optional] Lists the changes that have been made locally.
    /// </summary>  
    [SwitchName("--local")]
    public bool? local  {get; set;}
  
    /// <summary>
    /// [Optional] Lists all the changes that have been made.
    /// </summary>  
    [SwitchName("--all")]
    public bool? all  {get; set;}
  }
  

  /// <summary>
  /// Source
  /// </summary>
  [CommandClass("force:source")]
  public class Source : SFDXCommand {

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
    /// NOTE: This command must be run from within a project.
    /// 
    /// To convert source-formatted files into the metadata format, so that you can deploy them using Metadata API, run "sfdx force:source:convert". Then deploy the metadata using "sfdx force:mdapi:deploy".
    /// 
    /// To convert Metadata API–formatted files into the source format, run "sfdx force:mdapi:convert".
    /// 
    /// To specify a package name that includes spaces, enclose the name in single quotes.
    /// 
    /// Examples:
    ///    $ sfdx force:source:convert -r path/to/source
    ///    $ sfdx force:source:convert -r path/to/source -d path/to/outputdir -n 'My Package'
    /// force:source:convert [-r <directory>] [-d <directory>] [-n <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("convert")]
      public JToken Convert(SourceConvertOptions p_Options) {
        return ExecuteCommand<SourceConvertOptions, JToken>(nameof(Convert), p_Options);      
      }
    
    /// <summary>
    /// delete source from your project and from a non-source-tracked org
    /// </summary>
    /// <remarks>
    /// Deletes source files from your project and from a non-source-tracked org, such as a sandbox.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// Use this command to delete components from orgs that don’t have source tracking, such as sandboxes.
    /// To remove deleted items from scratch orgs, which have change tracking, use "sfdx force:source:push".
    /// 
    /// Examples:
    ///    $ sfdx force:source:delete -p path/to/source
    ///    $ sfdx force:source:delete -m <metadata>
    /// force:source:delete (-p <filepath>... | -m <string>...) [-r] [-w <minutes>] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("delete")]
      public JToken Delete(SourceDeleteOptions p_Options) {
        return ExecuteCommand<SourceDeleteOptions, JToken>(nameof(Delete), p_Options);      
      }
    
    /// <summary>
    /// deploy source to a non-source-tracked org
    /// </summary>
    /// <remarks>
    /// Deploys source to a non-source-tracked org, such as a sandbox.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// Use this command to deploy source to orgs that don’t have source tracking, such as sandboxes.
    /// To push source to scratch orgs, which have change tracking, use "sfdx force:source:push".
    /// To deploy metadata that’s in the Metadata API format, use "sfdx force:mdapi:deploy".
    /// 
    /// The source you deploy overwrites the corresponding metadata in your org. This command does not attempt to merge your source with the versions in your org.
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
    /// force:source:deploy (-p <filepath>... | -x <filepath>) [-w <minutes>] [-m <string>...] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("deploy")]
      public JToken Deploy(SourceDeployOptions p_Options) {
        return ExecuteCommand<SourceDeployOptions, JToken>(nameof(Deploy), p_Options);      
      }
    
    /// <summary>
    /// edit a Lightning Page with Lightning App Builder
    /// </summary>
    /// <remarks>
    /// Opens the specified Lightning Page in Lightning App Builder. Lightning Page files have the suffix .flexipage-meta.xml, and are stored in the flexipages directory. If you specify a different type of file, this command opens your org’s home page.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// The file opens in your default browser.
    /// If no browser-based editor is available for the selected file, this command opens your org’s home page.
    /// To generate a URL for the browser-based editor but not open the editor, use --urlonly.
    /// 
    /// Examples:
    ///    $ sfdx force:source:open -f Property_Record_Page.flexipage-meta.xml
    ///    $ sfdx force:source:open -f Property_Record_Page.flexipage-meta.xml -r
    /// force:source:open -f <filepath> [-r] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("open")]
      public JToken Open(SourceOpenOptions p_Options) {
        return ExecuteCommand<SourceOpenOptions, JToken>(nameof(Open), p_Options);      
      }
    
    /// <summary>
    /// pull source from the scratch org to the project
    /// </summary>
    /// <remarks>
    /// Pulls changed source from the scratch org to your project to keep them in sync.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
    /// force:source:pull [-w <minutes>] [-f] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("pull")]
      public JToken Pull(SourcePullOptions p_Options) {
        return ExecuteCommand<SourcePullOptions, JToken>(nameof(Pull), p_Options);      
      }
    
    /// <summary>
    /// push source to a scratch org from the project
    /// </summary>
    /// <remarks>
    /// Pushes changed source from your project to a scratch org to keep them in sync.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// If the command detects a conflict, it displays the conflicts but does not complete the process. After reviewing the conflict, rerun the command with the --forceoverwrite parameter.
    /// force:source:push [-f] [-g] [-w <minutes>] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("push")]
      public JToken Push(SourcePushOptions p_Options) {
        return ExecuteCommand<SourcePushOptions, JToken>(nameof(Push), p_Options);      
      }
    
    /// <summary>
    /// retrieve source from a non-source-tracked org
    /// </summary>
    /// <remarks>
    /// Retrieves source from a non-source-tracked org, such as a sandbox, to your local Salesforce DX project.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// Use this command to retrieve source from orgs that don’t have source tracking, such as sandboxes.
    /// To pull source from scratch orgs, which have change tracking, use "sfdx force:source:pull".
    /// To retrieve metadata that’s in the Metadata API format, use "sfdx force:mdapi:retrieve".
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
    /// force:source:retrieve (-x <filepath> | -m <string>... | -p <filepath>...) [-w <minutes>] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("retrieve")]
      public JToken Retrieve(SourceRetrieveOptions p_Options) {
        return ExecuteCommand<SourceRetrieveOptions, JToken>(nameof(Retrieve), p_Options);      
      }
    
    /// <summary>
    /// list local changes and/or changes in a scratch org
    /// </summary>
    /// <remarks>
    /// Lists changes that have been made locally, in a scratch org, or both.
    /// </remarks>
    /// <example>  
    /// NOTE: This command must be run from within a project.
    /// 
    /// Examples:
    ///    $ sfdx force:source:status -l
    ///    $ sfdx force:source:status -r
    ///    $ sfdx force:source:status -a
    ///    $ sfdx force:source:status -a -u me@example.com --json
    /// force:source:status [-a] [-l] [-r] [-u <string>] [--json] [--loglevel <string>]
    /// </example>
    [Command("status")]
      public JToken Status(SourceStatusOptions p_Options) {
        return ExecuteCommand<SourceStatusOptions, JToken>(nameof(Status), p_Options);      
      }
    
  }
}

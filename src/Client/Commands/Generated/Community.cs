// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method Create of class Community.
    /// </summary>
    public class CommunityCreateOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Required] An example of a template is Customer Service. Run the "community template list" command to see which templates are available in your org.
        /// </summary>
        [SwitchName("--template-name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// [Required] No description for name
        /// </summary>
        [SwitchName("--name")]
        public string Name { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Required] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Required] For example, if your domain name is https://MyDomainName.my.site.com and you create a customer site, enter 'customers' to create the unique URL https://MyDomainName.my.site.com/customers.
        /// </summary>
        [SwitchName("--url-path-prefix")]
        public string UrlPathPrefix { get; set; }

        /// <summary>
        /// [Required] The description displays in Digital Experiences - All Sites in Setup and helps with site identification.
        /// </summary>
        [SwitchName("--description")]
        public string Description { get; set; }

        /// <summary>
        /// [Optional] No description for loglevel
        /// </summary>
        [SwitchName("--loglevel")]
        public LogLevel? Loglevel { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
        /// </summary>
        [SwitchName("--api-version")]
        public string ApiVersion { get; set; }
    }

    /// <summary>
    /// Options for the method ListTemplate of class Community.
    /// </summary>
    public class CommunityListTemplateOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] No description for target-org
        /// </summary>
        [SwitchName("--target-org")]
        public string TargetOrg { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Required] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
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
    /// Options for the method Publish of class Community.
    /// </summary>
    public class CommunityPublishOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

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
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Required] No description for flags-dir
        /// </summary>
        [SwitchName("--flags-dir")]
        public string FlagsDir { get; set; }

        /// <summary>
        /// [Required] Override the api version used for api requests made by this command
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
    /// Community
    /// </summary>
    [CommandClass("community")]
    public class Community : SfdxCommand
    {
        /// Constructor.
        public Community(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Run the "community list template" command to see the templates available in your org. See 'Which Experience Cloud Template Should I Use?' in Salesforce Help for more information about the different template types available. (https://help.salesforce.com/s/articleView?id=sf.siteforce_commtemp_intro.htm&type=5)
        /// 
        /// When you create a site with the Build Your Own (LWR) template, you must also specify the AuthenticationType value using the format templateParams.AuthenticationType=value, where value is AUTHENTICATED or AUTHENTICATED_WITH_PUBLIC_ACCESS_ENABLED. Name and values are case-sensitive. See 'DigitalExperienceBundle' in the Metadata API Developer Guide for more information. (https://developer.salesforce.com/docs/atlas.en-us.api_meta.meta/api_meta/meta_digitalexperiencebundle.htm)
        /// 
        /// The site creation process is an async job that generates a jobId. To check the site creation status, query the BackgroundOperation object and enter the jobId as the Id. See ‘BackgroundOperation’ in the Object Reference for the Salesforce Platform for more information. (https://developer.salesforce.com/docs/atlas.en-us.object_reference.meta/object_reference/sforce_api_objects_backgroundoperation.htm)
        /// 
        /// If the job doesn’t complete within 10 minutes, it times out. You receive an error message and must restart the site creation process. Completed jobs expire after 24 hours and are removed from the database.
        /// 
        /// When you run this command, it creates the site in preview status, which means that the site isn't yet live. After you finish building your site, you can make it live.
        /// 
        /// If you have an Experience Builder site, publish the site using the "community publish" command to make it live.
        /// 
        /// If you have a Salesforce Tabs + Visualforce site, to activate the site and make it live, update the status field of the Network type in Metadata API. (https://developer.salesforce.com/docs/atlas.en-us.api_meta.meta/api_meta/meta_network.htm) Alternatively, in Experience Workspaces, go to Administration | Settings, and click Activate.
        /// 
        /// For Experience Builder sites, activating the site sends a welcome email to site members.
        /// </summary>
        /// <remarks>
        /// Run the "community list template" command to see the templates available in your org. See 'Which Experience Cloud Template Should I Use?' in Salesforce Help for more information about the different template types available. (https://help.salesforce.com/s/articleView?id=sf.siteforce_commtemp_intro.htm&type=5)
        /// 
        /// When you create a site with the Build Your Own (LWR) template, you must also specify the AuthenticationType value using the format templateParams.AuthenticationType=value, where value is AUTHENTICATED or AUTHENTICATED_WITH_PUBLIC_ACCESS_ENABLED. Name and values are case-sensitive. See 'DigitalExperienceBundle' in the Metadata API Developer Guide for more information. (https://developer.salesforce.com/docs/atlas.en-us.api_meta.meta/api_meta/meta_digitalexperiencebundle.htm)
        /// 
        /// The site creation process is an async job that generates a jobId. To check the site creation status, query the BackgroundOperation object and enter the jobId as the Id. See ‘BackgroundOperation’ in the Object Reference for the Salesforce Platform for more information. (https://developer.salesforce.com/docs/atlas.en-us.object_reference.meta/object_reference/sforce_api_objects_backgroundoperation.htm)
        /// 
        /// If the job doesn’t complete within 10 minutes, it times out. You receive an error message and must restart the site creation process. Completed jobs expire after 24 hours and are removed from the database.
        /// 
        /// When you run this command, it creates the site in preview status, which means that the site isn't yet live. After you finish building your site, you can make it live.
        /// 
        /// If you have an Experience Builder site, publish the site using the "community publish" command to make it live.
        /// 
        /// If you have a Salesforce Tabs + Visualforce site, to activate the site and make it live, update the status field of the Network type in Metadata API. (https://developer.salesforce.com/docs/atlas.en-us.api_meta.meta/api_meta/meta_network.htm) Alternatively, in Experience Workspaces, go to Administration | Settings, and click Activate.
        /// 
        /// For Experience Builder sites, activating the site sends a welcome email to site members.
        /// </remarks>
        /// <example>
        /// 
        /// Create an Experience Cloud site using template 'Customer Service' and URL path prefix 'customers':
        /// <%= config.bin %> <%= command.id %> --name 'My Customer Site' --template-name 'Customer Service' --url-path-prefix customers --description 'My customer site'
        /// Create a site using 'Partner Central' template:
        /// <%= config.bin %> <%= command.id %> --name partnercentral --template-name 'Partner Central' --url-path-prefix partners
        /// Create a site using the 'Build Your Own (LWR)' template with authentication type of UNAUTHENTICATED:
        /// <%= config.bin %> <%= command.id %> --name lwrsite --template-name 'Build Your Own (LWR)' --url-path-prefix lwrsite templateParams.AuthenticationType=UNAUTHENTICATED
        /// </example>
        [Command("create")]
        public SfdxResponse Create(CommunityCreateOptions options)
        {
            return ExecuteCommand(nameof(Create), options);
        }

        /// <summary>
        /// See 'Which Experience Cloud Template Should I Use?' (https://help.salesforce.com/s/articleView?id=sf.siteforce_commtemp_intro.htm&type=5) in Salesforce Help for more information about the different template types available for Experience Cloud.
        /// </summary>
        /// <remarks>
        /// See 'Which Experience Cloud Template Should I Use?' (https://help.salesforce.com/s/articleView?id=sf.siteforce_commtemp_intro.htm&type=5) in Salesforce Help for more information about the different template types available for Experience Cloud.
        /// </remarks>
        /// <example>
        /// 
        /// Retrieve the template list from an org with alias my-scratch-org:
        /// <%= config.bin %> <%= command.id %> --target-org my-scratch-org
        /// </example>
        [Command("list template")]
        public SfdxResponse ListTemplate(CommunityListTemplateOptions options)
        {
            return ExecuteCommand(nameof(ListTemplate), options);
        }

        /// <summary>
        /// Each time you publish a site, you update the live site with the most recent updates. When you publish an Experience Builder site for the first time, you make the site's URL live and enable login access for site members.
        /// 
        /// In addition to publishing, you must activate a site to send a welcome email to all site members. Activation is also required to set up SEO for Experience Builder sites. To activate a site, update the status field of the Network type in Metadata API. (https://developer.salesforce.com/docs/atlas.en-us.api_meta.meta/api_meta/meta_network.htm) Alternatively, in Experience Workspaces, go to Administration | Settings, and click Activate.
        /// 
        /// An email notification informs you when your changes are live on the published site. The site publish process is an async job that generates a jobId. To check the site publish status manually, query the BackgroundOperation object and enter the jobId as the Id. See ‘BackgroundOperation’ in the Object Reference for the Salesforce Platform for more information. (https://developer.salesforce.com/docs/atlas.en-us.object_reference.meta/object_reference/sforce_api_objects_backgroundoperation.htm)
        /// 
        /// If the job doesn’t complete within 15 minutes, it times out. You receive an error message and must restart the site publish process. Completed jobs expire after 24 hours and are removed from the database.
        /// </summary>
        /// <remarks>
        /// Each time you publish a site, you update the live site with the most recent updates. When you publish an Experience Builder site for the first time, you make the site's URL live and enable login access for site members.
        /// 
        /// In addition to publishing, you must activate a site to send a welcome email to all site members. Activation is also required to set up SEO for Experience Builder sites. To activate a site, update the status field of the Network type in Metadata API. (https://developer.salesforce.com/docs/atlas.en-us.api_meta.meta/api_meta/meta_network.htm) Alternatively, in Experience Workspaces, go to Administration | Settings, and click Activate.
        /// 
        /// An email notification informs you when your changes are live on the published site. The site publish process is an async job that generates a jobId. To check the site publish status manually, query the BackgroundOperation object and enter the jobId as the Id. See ‘BackgroundOperation’ in the Object Reference for the Salesforce Platform for more information. (https://developer.salesforce.com/docs/atlas.en-us.object_reference.meta/object_reference/sforce_api_objects_backgroundoperation.htm)
        /// 
        /// If the job doesn’t complete within 15 minutes, it times out. You receive an error message and must restart the site publish process. Completed jobs expire after 24 hours and are removed from the database.
        /// </remarks>
        /// <example>
        /// 
        /// Publish the Experience Builder site with name "My Customer Site':
        /// <%= config.bin %> <%= command.id %> --name 'My Customer Site'
        /// </example>
        [Command("publish")]
        public SfdxResponse Publish(CommunityPublishOptions options)
        {
            return ExecuteCommand(nameof(Publish), options);
        }
    }
}

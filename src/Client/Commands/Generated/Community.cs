// Generated on Thu Aug 05 2021 using sfdx-cli/7.110.0 win32-x64 node-v16.2.0. DO NOT MODIFY
// Copyright (c) 2005-2021, Coveo Solutions Inc.

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method create of class Community.
    /// </summary>
    public class CommunityCreateOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The URL to append to the domain that you created when you enabled Digital Experiences for this org. For example, if your domain name is UniversalTelco.force.com and you’re creating a customer site, enter "customers" to create the unique URL 
        /// UniversalTelco.force.com/customers.
        /// </summary>
        [SwitchName("--urlpathprefix")]
        public string urlpathprefix { get; set; }

        /// <summary>
        /// [Required] The template to use to create the site, such as the Customer Service template. Run force:community:template:list to see which templates are available in your org.
        /// </summary>
        [SwitchName("--templatename")]
        public string templatename { get; set; }

        /// <summary>
        /// [Required] The name of the site to create.
        /// </summary>
        [SwitchName("--name")]
        public string name { get; set; }

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
        /// [Required] The description of the site. The description displays in Digital Experiences - All Sites in Setup and helps with site identification.
        /// </summary>
        [SwitchName("--description")]
        public string description { get; set; }
    }

    /// <summary>
    /// Options for the method publish of class Community.
    /// </summary>
    public class CommunityPublishOptions : SFDXOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string expression { get; set; }

        /// <summary>
        /// [Required] The name of the Experience Builder site that you want to publish.
        /// </summary>
        [SwitchName("--name")]
        public string name { get; set; }

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
    /// Options for the method templateList of class Community.
    /// </summary>
    public class CommunityTemplateListOptions : SFDXOptions
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
    /// Community
    /// </summary>
    [CommandClass("force:community")]
    public class Community : SFDXCommand
    {
        /// Constructor.
        public Community(CommandExecutioner p_CommandExecutioner)
                : base(p_CommandExecutioner)
        {
        }

        /// <summary>
        /// creates an Experience Cloud site using a template
        /// 
        /// See "Which Experience Cloud Template Should I Use?" in Salesforce Help for more information about the different template types available for Experience Cloud.
        /// 
        /// When creating a site with the Build Your Own (LWR) template, you must also specify the AuthenticationType value using the format templateParams.AuthenticationType=value, where value is AUTHENTICATED, UNAUTHENTICATED, or AUTHENTICATED_WITH_PUBLIC_ACCESS. Name and values are case-sensitive. See "ExperienceBundle" in the Metadata API Developer Guide for more information.
        /// 
        /// When you execute this command, it creates the site in preview status, which means that it isn’t yet live. After you finish building your site, you can make it live.
        /// 
        /// If you have an Experience Builder site, publish the site using the sfdx force:community:publish command to make it live.
        /// 
        /// If you have a Salesforce Tabs + Visualforce site, activate the site to make it live by updating the status field of the Network type in the Metadata API. Alternatively, in Experience Workspaces, go to Administration | Settings, and click Activate.
        /// 
        /// For Experience Builder sites, activating the site just sends out a welcome email to site members.
        /// 
        /// Examples:
        ///    $ sfdx force:community:create --name "My Customer Site" --templatename "Customer Service" --urlpathprefix customers --description "My customer site"
        ///    $ sfdx force:community:create -n partnercentral -t "Partner Central" -p partners
        ///    $ sfdx force:community:create -n lwrsite -t "Build Your Own (LWR)" -p lwrsite templateParams.AuthenticatedType=UNAUTHENTICATED
        /// </summary>
        /// <remarks>
        /// creates an Experience Cloud site using a template
        /// 
        /// See "Which Experience Cloud Template Should I Use?" in Salesforce Help for more information about the different template types available for Experience Cloud.
        /// 
        /// When creating a site with the Build Your Own (LWR) template, you must also specify the AuthenticationType value using the format templateParams.AuthenticationType=value, where value is AUTHENTICATED, UNAUTHENTICATED, or AUTHENTICATED_WITH_PUBLIC_ACCESS. Name and values are case-sensitive. See "ExperienceBundle" in the Metadata API Developer Guide for more information.
        /// 
        /// When you execute this command, it creates the site in preview status, which means that it isn’t yet live. After you finish building your site, you can make it live.
        /// 
        /// If you have an Experience Builder site, publish the site using the sfdx force:community:publish command to make it live.
        /// 
        /// If you have a Salesforce Tabs + Visualforce site, activate the site to make it live by updating the status field of the Network type in the Metadata API. Alternatively, in Experience Workspaces, go to Administration | Settings, and click Activate.
        /// 
        /// For Experience Builder sites, activating the site just sends out a welcome email to site members.
        /// 
        /// Examples:
        ///    $ sfdx force:community:create --name "My Customer Site" --templatename "Customer Service" --urlpathprefix customers --description "My customer site"
        ///    $ sfdx force:community:create -n partnercentral -t "Partner Central" -p partners
        ///    $ sfdx force:community:create -n lwrsite -t "Build Your Own (LWR)" -p lwrsite templateParams.AuthenticatedType=UNAUTHENTICATED
        /// </remarks>
        /// <example>
        /// See "Which Experience Cloud Template Should I Use?" in Salesforce Help for more information about the different template types available for Experience Cloud.
        /// 
        /// When creating a site with the Build Your Own (LWR) template, you must also specify the AuthenticationType value using the format templateParams.AuthenticationType=value, where value is AUTHENTICATED, UNAUTHENTICATED, or AUTHENTICATED_WITH_PUBLIC_ACCESS. Name and values are case-sensitive. See "ExperienceBundle" in the Metadata API Developer Guide for more information.
        /// 
        /// When you execute this command, it creates the site in preview status, which means that it isn’t yet live. After you finish building your site, you can make it live.
        /// 
        /// If you have an Experience Builder site, publish the site using the sfdx force:community:publish command to make it live.
        /// 
        /// If you have a Salesforce Tabs + Visualforce site, activate the site to make it live by updating the status field of the Network type in the Metadata API. Alternatively, in Experience Workspaces, go to Administration | Settings, and click Activate.
        /// 
        /// For Experience Builder sites, activating the site just sends out a welcome email to site members.
        /// 
        /// Examples:
        ///    $ sfdx force:community:create --name "My Customer Site" --templatename "Customer Service" --urlpathprefix customers --description "My customer site"
        ///    $ sfdx force:community:create -n partnercentral -t "Partner Central" -p partners
        ///    $ sfdx force:community:create -n lwrsite -t "Build Your Own (LWR)" -p lwrsite templateParams.AuthenticatedType=UNAUTHENTICATED
        /// force:community:create [name=value...] -n <string> -t <string> -p <string> [-d <string>] [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("create")]
        public SFDXResponse Create(CommunityCreateOptions p_Options)
        {
            return ExecuteCommand<CommunityCreateOptions>(nameof(Create), p_Options);
        }

        /// <summary>
        /// publishes an Experience Builder site to make it live
        /// 
        /// When you publish an Experience Builder site for the first time, you make the site’s URL live and enable login access for site members.
        /// 
        /// Additionally, to send a welcome email to all site members, you must activate the site. (Activation is also required to successfully set up SEO for Experience Builder sites.) To activate a site, update the status field of the Network type in the Metadata API. Alternatively, in Experience Workspaces, go to Administration | Settings, and click Activate.
        /// 
        /// Subsequently, each time you publish the site, you update the live site with all changes made to the site since it was last published.
        /// 
        /// An email notification informs you when your changes are live.
        /// 
        /// Example:
        ///    $ sfdx force:community:publish --name "My Customer Site"
        /// </summary>
        /// <remarks>
        /// publishes an Experience Builder site to make it live
        /// 
        /// When you publish an Experience Builder site for the first time, you make the site’s URL live and enable login access for site members.
        /// 
        /// Additionally, to send a welcome email to all site members, you must activate the site. (Activation is also required to successfully set up SEO for Experience Builder sites.) To activate a site, update the status field of the Network type in the Metadata API. Alternatively, in Experience Workspaces, go to Administration | Settings, and click Activate.
        /// 
        /// Subsequently, each time you publish the site, you update the live site with all changes made to the site since it was last published.
        /// 
        /// An email notification informs you when your changes are live.
        /// 
        /// Example:
        ///    $ sfdx force:community:publish --name "My Customer Site"
        /// </remarks>
        /// <example>
        /// When you publish an Experience Builder site for the first time, you make the site’s URL live and enable login access for site members.
        /// 
        /// Additionally, to send a welcome email to all site members, you must activate the site. (Activation is also required to successfully set up SEO for Experience Builder sites.) To activate a site, update the status field of the Network type in the Metadata API. Alternatively, in Experience Workspaces, go to Administration | Settings, and click Activate.
        /// 
        /// Subsequently, each time you publish the site, you update the live site with all changes made to the site since it was last published.
        /// 
        /// An email notification informs you when your changes are live.
        /// 
        /// Example:
        ///    $ sfdx force:community:publish --name "My Customer Site"
        /// force:community:publish -n <string> [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("publish")]
        public SFDXResponse Publish(CommunityPublishOptions p_Options)
        {
            return ExecuteCommand<CommunityPublishOptions>(nameof(Publish), p_Options);
        }

        /// <summary>
        /// retrieves the list of templates available in your org
        /// 
        /// See "Which Experience Cloud Template Should I Use?" in Salesforce Help for more information about the different template types available for Experience Cloud.
        /// 
        /// Example:
        ///    $ sfdx force:community:template:list
        /// </summary>
        /// <remarks>
        /// retrieves the list of templates available in your org
        /// 
        /// See "Which Experience Cloud Template Should I Use?" in Salesforce Help for more information about the different template types available for Experience Cloud.
        /// 
        /// Example:
        ///    $ sfdx force:community:template:list
        /// </remarks>
        /// <example>
        /// See "Which Experience Cloud Template Should I Use?" in Salesforce Help for more information about the different template types available for Experience Cloud.
        /// 
        /// Example:
        ///    $ sfdx force:community:template:list
        /// force:community:template:list [-u <string>] [--apiversion <string>] [--json] [--loglevel trace|debug|info|warn|error|fatal|TRACE|DEBUG|INFO|WARN|ERROR|FATAL]
        /// </example>
        [Command("template:list")]
        public SFDXResponse TemplateList(CommunityTemplateListOptions p_Options)
        {
            return ExecuteCommand<CommunityTemplateListOptions>(nameof(TemplateList), p_Options);
        }
    }
}

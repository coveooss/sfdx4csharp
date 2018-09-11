// Generated on September 11th 2018, 5:23:30 pm. DO NOT MODIFY
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using System.Diagnostics;
using System.IO;
using sfdx4csharpClient.Core;

namespace sfdx4csharpClient
{
    /// <summary>
    /// A client using the Salesforce Developer Experience (SFDX) command-line interface.
    /// </summary>
    /// <remarks>
    /// In order to use this client, you need to install the sfdxcli on your machine.
    /// How to: https://developer.salesforce.com/docs/atlas.en-us.sfdx_setup.meta/sfdx_setup/sfdx_setup_intro.htm
    /// </remarks>
    public class GeneratedSFDXClient
    {
  
      public Limits limits { get; }
      public Lightning lightning { get; }
      public Data data { get; }
      public Apex apex { get; }
      public Doc doc { get; }
      public Visualforce visualforce { get; }
      public Mdapi mdapi { get; }
      public Source source { get; }
      public Org org { get; }
      public Package package { get; }
      public Package2 package2 { get; }
      public User user { get; }
      public Project project { get; }
      public Config config { get; }
      public Auth auth { get; }
      public Alias alias { get; }
      public Schema schema { get; }
      public Package1 package1 { get; }

      private CommandExecutioner CommandExecutioner { get; }

      /// <summary>
      /// Initialize the modules that encapsulate the commands in the force namespace.
      /// </summary>
      /// <param name="p_Path">File path to the SFDC CLI executable</param>
      public GeneratedSFDXClient(string p_Path)
      {
          Debug.Assert(!string.IsNullOrEmpty(p_Path));
          Debug.Assert(File.Exists(p_Path));

          CommandExecutioner = new CommandExecutioner(new CommandRunner(p_Path));
          this.limits = new Limits(CommandExecutioner);
          this.lightning = new Lightning(CommandExecutioner);
          this.data = new Data(CommandExecutioner);
          this.apex = new Apex(CommandExecutioner);
          this.doc = new Doc(CommandExecutioner);
          this.visualforce = new Visualforce(CommandExecutioner);
          this.mdapi = new Mdapi(CommandExecutioner);
          this.source = new Source(CommandExecutioner);
          this.org = new Org(CommandExecutioner);
          this.package = new Package(CommandExecutioner);
          this.package2 = new Package2(CommandExecutioner);
          this.user = new User(CommandExecutioner);
          this.project = new Project(CommandExecutioner);
          this.config = new Config(CommandExecutioner);
          this.auth = new Auth(CommandExecutioner);
          this.alias = new Alias(CommandExecutioner);
          this.schema = new Schema(CommandExecutioner);
          this.package1 = new Package1(CommandExecutioner);

        }
    }
}
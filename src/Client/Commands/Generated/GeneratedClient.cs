// Generated on November 2nd 2018, 11:11:11 am using sfdx-cli/6.38.0-0d66175ccf (windows-x64) node-v8.9.4. DO NOT MODIFY
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
      public Limits Limits { get; }
      public Lightning Lightning { get; }
      public Data Data { get; }
      public Apex Apex { get; }
      public Doc Doc { get; }
      public Visualforce Visualforce { get; }
      public Mdapi Mdapi { get; }
      public Source Source { get; }
      public Org Org { get; }
      public Package Package { get; }
      public User User { get; }
      public Project Project { get; }
      public Config Config { get; }
      public Auth Auth { get; }
      public Alias Alias { get; }
      public Schema Schema { get; }
      public Package1 Package1 { get; }

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
          this.Limits = new Limits(CommandExecutioner);
          this.Lightning = new Lightning(CommandExecutioner);
          this.Data = new Data(CommandExecutioner);
          this.Apex = new Apex(CommandExecutioner);
          this.Doc = new Doc(CommandExecutioner);
          this.Visualforce = new Visualforce(CommandExecutioner);
          this.Mdapi = new Mdapi(CommandExecutioner);
          this.Source = new Source(CommandExecutioner);
          this.Org = new Org(CommandExecutioner);
          this.Package = new Package(CommandExecutioner);
          this.User = new User(CommandExecutioner);
          this.Project = new Project(CommandExecutioner);
          this.Config = new Config(CommandExecutioner);
          this.Auth = new Auth(CommandExecutioner);
          this.Alias = new Alias(CommandExecutioner);
          this.Schema = new Schema(CommandExecutioner);
          this.Package1 = new Package1(CommandExecutioner);
        }
    }
}

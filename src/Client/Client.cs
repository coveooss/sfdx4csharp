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
    public class SFDXClient : GeneratedSFDXClient
    {
        public SFDXClient(string p_SFDXPath) : base(p_SFDXPath)
        {
        }
    }
}

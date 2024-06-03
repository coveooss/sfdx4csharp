namespace sfdx4csharpClient
{
    /// <summary>
    /// A client using the Salesforce CLI command-line interface.
    /// </summary>
    /// <remarks>
    /// In order to use this client, you need to install the Salesforce CLI on your machine.
    /// How to: https://developer.salesforce.com/docs/atlas.en-us.sfdx_setup.meta/sfdx_setup/sfdx_setup_intro.htm
    /// </remarks>
    public class SfClient : GeneratedSfClient
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public SfClient(string sfdxPath, string workingFolder = "")
            : base(sfdxPath, workingFolder)
        {
        }
    }
}
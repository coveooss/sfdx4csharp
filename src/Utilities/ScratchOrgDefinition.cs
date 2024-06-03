using Newtonsoft.Json;

namespace sfdx4csharpUtilities
{
    /// <summary>
    /// The scratch org definition is a blueprint for a scratch org. It mimics the shape of an org that you
    /// use in the development life cycle, such as sandbox, packaging, or production.
    /// </summary>
    /// <remarks>
    /// source: https://developer.salesforce.com/docs/atlas.en-us.sfdx_dev.meta/sfdx_dev/sfdx_dev_scratch_orgs_def_file.htm
    /// </remarks>
    public class ScratchOrgDefinition
    {
        /// <summary>
        /// The admin user email.
        /// </summary>
        [JsonProperty("adminEmail")]
        public string AdminEmail { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Edition (ex: Developer, Sandbox, Enterprise...).
        /// </summary>
        [JsonProperty("edition", Required = Required.Always)]
        public string Edition { get; set; }

        /// <summary>
        /// Features to enable (ex: Communities, Knowledge).
        /// </summary>
        [JsonProperty("features")]
        public string[] Features { get; set; }

        /// <summary>
        /// Whether to create the organization with sample data or empty.
        /// </summary>
        [JsonProperty("hasSampleData")]
        public bool HasSampleData { get; set; }

        /// <summary>
        /// The organization name.
        /// </summary>
        [JsonProperty("orgName")]
        public string OrgName { get; set; }

        /// <summary>
        /// Organization settings (ex: enableKnowledge, enableLightningKnowledge, enableSecureGuestAccess).
        /// </summary>
        [JsonProperty("orgPreferences")]
        public OrgPreferences OrgPreferences { get; set; }

        /// <summary>
        /// The username.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }
    }

    /// <summary>
    /// Org preferences are settings that a user can configure in the org.
    /// </summary>
    /// <remarks>
    /// source:
    /// https://developer.salesforce.com/docs/atlas.en-us.sfdx_dev.meta/sfdx_dev/sfdx_dev_scratch_orgs_def_file_config_values.htm
    /// </remarks>
    public class OrgPreferences
    {
        /// <summary>
        /// Disabled organization state.
        /// </summary>
        [JsonProperty("disabled")]
        public string[] Disabled { get; set; }

        /// <summary>
        /// Enabled organization state.
        /// </summary>
        [JsonProperty("enabled")]
        public string[] Enabled { get; set; }
    }
}
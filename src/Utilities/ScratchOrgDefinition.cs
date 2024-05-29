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
        [JsonProperty("adminEmail")]
        public string AdminEmail { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("edition", Required = Required.Always)]
        public string Edition { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }

        [JsonProperty("hasSampleData")]
        public bool HasSampleData { get; set; }

        [JsonProperty("orgName")]
        public string OrgName { get; set; }

        [JsonProperty("orgPreferences")]
        public OrgPreferences OrgPreferences { get; set; }

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
        [JsonProperty("disabled")]
        public string[] Disabled { get; set; }

        [JsonProperty("enabled")]
        public string[] Enabled { get; set; }
    }
}
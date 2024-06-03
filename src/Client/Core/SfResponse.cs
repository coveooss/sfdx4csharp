using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI Response's wrapper
    /// </summary>
    public class SfResponse
    {
        /// <summary>
        /// Deserialized from cli output. Represents the parsed output of the executed command.
        /// </summary>
        public JToken Result { get; set; }

        /// <summary>
        /// Deserialized from cli output. Represents the status code from the executed command.
        /// </summary>
        public SfCommandOutput CommandOutput { get; set; }

        /// <summary>
        /// The error message, if any.
        /// </summary>
        [JsonProperty("message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The error code, if any.
        /// </summary>
        [JsonProperty("name")]
        public string ErrorCode { get; set; }
    }
}
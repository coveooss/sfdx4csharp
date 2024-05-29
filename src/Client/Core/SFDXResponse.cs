using Newtonsoft.Json.Linq;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI Response's wrapper
    /// </summary>
    public class SfdxResponse
    {
        /// <summary>
        /// Deserialized from cli output. Represents the parsed output of the executed command.
        /// </summary>
        public JToken Result { get; set; }

        /// <summary>
        /// Deserialized from cli output. Represents the status code from the executed command.
        /// </summary>
        public SfdxOutput AdditionalInfo { get; set; }
    }
}
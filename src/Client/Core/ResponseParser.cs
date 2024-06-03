using System.Diagnostics;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// General deserializer for sfdx cli response.
    /// </summary>
    public class ResponseParser
    {
        /// <summary>
        /// Deserialize the response's JSON string into a T object.
        /// </summary>
        /// <param name="json">JSON string</param>
        /// <returns>SFDXResponse result</returns>
        public static SfResponse Parse(string json)
        {
            Debug.Assert(json != null);

            return JsonConvert.DeserializeObject<SfResponse>(SanitizeResponse(json));
        }

        private static string SanitizeResponse(string response)
        {
            // Remove non json message when installing plugin.
            response = response.Replace("Installing required plugins for force... done", "");

            // Remove leading blank spaces, space character and new lines.
            var rgx = new Regex("/^([\\s\\r\\n]+)/");
            return rgx.Replace(response, "");
        }
    }
}
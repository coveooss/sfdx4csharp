// Copyright (c) 2005-2018, Coveo Solutions Inc.

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
        /// <typeparam name="T">Response result type</typeparam>
        /// <param name="p_Json">JSON string</param>
        /// <returns>Response result</returns>
        public static T Parse<T>(string p_Json)
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Json));

            // Extracts the Result only.
            return JsonConvert.DeserializeObject<SFDXResponse<T>>(SanitizeResponse(p_Json)).Result;
        }

        private static string SanitizeResponse(string p_Response)
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Response));

            // Remove non json message when installing plugin.
            p_Response = p_Response.Replace("Installing required plugins for force... done", "");

            // Remove leading blank spaces, space character and new lines.
            var rgx = new Regex("/^([\\s\\r\\n]+)/");
            return rgx.Replace(p_Response, "");
        }
    }
}

// Copyright (c) 2005-2018, Coveo Solutions Inc.

using System.Diagnostics;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        /// <param name="p_Json">JSON string</param>
        /// <returns>SFDXResponse result</returns>
        public static JToken Parse(string p_Json)
        {
            Debug.Assert(p_Json != null);

            return JsonConvert.DeserializeObject<SFDXJsonResponse>(SanitizeResponse(p_Json))?.Result;
        }

        private static string SanitizeResponse(string p_Response)
        {
            // Remove non json message when installing plugin.
            p_Response = p_Response.Replace("Installing required plugins for force... done", "");

            // Remove leading blank spaces, space character and new lines.
            var rgx = new Regex("/^([\\s\\r\\n]+)/");
            return rgx.Replace(p_Response, "");
        }
    }
}
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// Command Builder.
    /// </summary>
    /// <typeparam name="T">Command's options type</typeparam>
    public static class CommandBuilder<T> where T : SfdxOptions
    {
        /// <summary>
        /// Constructs the full SFDX CLI command to be executed.
        /// </summary>
        /// <param name="command">Current api command's method.</param>
        /// <param name="requestOptions">Current command's method options.</param>
        /// <returns>SFDX cli command to be executed.</returns>
        public static string Build(string command, T requestOptions)
        {
            Debug.Assert(command != null);

            var options = BuildOptions(requestOptions);
            return string.IsNullOrEmpty(options) ? command : command + " " + options;
        }

        private static string BuildOptions(T requestOptions)
        {
            if (requestOptions == null)
            {
                return "";
            }

            var parameters = requestOptions.GetType()
                .GetProperties()
                .Where(prop => prop.GetValue(requestOptions) != null)
                .Select(prop => OptionToString(prop, requestOptions));
            return String.Join(" ", parameters);
        }

        private static string OptionToString(PropertyInfo prop, T requestOptions)
        {
            Debug.Assert(prop != null);
            Debug.Assert(requestOptions != null);

            var apiSwitchName = SwitchNameAttribute.GetSwitchNameValue(prop);
            var propValue = prop.GetValue(requestOptions);
            var boolValue = propValue as bool?;
            if (boolValue != null)
            {
                return boolValue.Value ? apiSwitchName : null;
            }
            return apiSwitchName + " " + propValue;
        }
    }
}
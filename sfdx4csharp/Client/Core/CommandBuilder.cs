// Copyright (c) 2005-2018, Coveo Solutions Inc.

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
    public static class CommandBuilder<T> where T : SFDXOptions
    {
        /// <summary>
        /// Constructs the full SFDX CLI command to be executed.
        /// </summary>
        /// <param name="p_Command">Current api command's method.</param>
        /// <param name="p_RequestOptions">Current command's method options.</param>
        /// <returns>SFDX cli command to be executed.</returns>
        public static string Build(string p_Command,
            T p_RequestOptions)
        {
            Debug.Assert(p_Command != null);
                        
            string options = BuildOptions(p_RequestOptions);
            return string.IsNullOrEmpty(options) ? p_Command : p_Command + " " + options;
        }

        private static string BuildOptions(T p_RequestOptions)
        {            
            if(p_RequestOptions == null) {
                return "";
            }

            var parameters = p_RequestOptions.GetType()
                .GetProperties()
                .Where(prop => prop.GetValue(p_RequestOptions) != null)
                .Select(prop => OptionToString(prop, p_RequestOptions));
            return String.Join(" ", parameters);
        }

        private static string OptionToString(PropertyInfo p_Prop, T p_RequestOptions)
        {
            Debug.Assert(p_Prop != null);
            Debug.Assert(p_RequestOptions != null);

            var apiSwitchName = SwitchNameAttribute.GetSwitchNameValue(p_Prop);
            var propValue = p_Prop.GetValue(p_RequestOptions);
            var boolValue = propValue as bool?;
            if (boolValue != null) {
                return boolValue.Value ? apiSwitchName : null;
            }
            return apiSwitchName + " " + propValue;
        }
    }
}

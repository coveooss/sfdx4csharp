using System;
using System.Diagnostics;
using System.Reflection;

namespace sfdx4csharpClient.Core.Attributes
{
    /// <summary>
    /// Represents an arguments name used with a Salesforce CLI command.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class SwitchNameAttribute : Attribute
    {
        private readonly string _value;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="value">SFDX Switch parameter.</param>
        /// <example>For the JSON option, the switch parameter should be "--json".</example>
        public SwitchNameAttribute(string value)
        {
            // Switch name can be empty (ex: OrgCreateOptions.Expression), but not null.
            Debug.Assert(value != null);

            _value = value;
        }

        /// <summary>
        /// Gets the attribute value for the given property.
        /// </summary>
        /// <param name="propertyInfo">Property with a SwitchNameAttribute to get.</param>
        /// <returns>The attribute value.</returns>
        public static string GetSwitchNameValue(PropertyInfo propertyInfo)
        {
            Debug.Assert(propertyInfo != null);

            return propertyInfo.GetCustomAttribute<SwitchNameAttribute>()?._value;
        }
    }
}
// Copyright (c) 2005-2018, Coveo Solutions Inc.

using System;
using System.Diagnostics;
using System.Reflection;

namespace sfdx4csharpClient.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SwitchNameAttribute : Attribute
    {
        private readonly string m_Value;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="p_Value">SFDX Switch parameter.</param>
        /// <example>For the JSON option, the switch parameter should be "--json".</example>
        public SwitchNameAttribute(string p_Value)
        {
            // Switch name can be empty (ex: OrgCreateOptions.Expression), but not null.
            Debug.Assert(p_Value != null);

            m_Value = p_Value;
        }

        /// <summary>
        /// Gets the attribute value for the given property.
        /// </summary>
        /// <param name="p_PropertyInfo">Property with a SwitchNameAttribute to get.</param>
        /// <returns>The attribute value.</returns>
        public static string GetSwitchNameValue(PropertyInfo p_PropertyInfo)
        {
            Debug.Assert(p_PropertyInfo != null);

            return p_PropertyInfo.GetCustomAttribute<SwitchNameAttribute>()?.m_Value;
        }
    }
}
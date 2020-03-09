// Copyright (c) 2005-2020, Coveo Solutions Inc.

using System;
using System.Diagnostics;
using System.Reflection;

namespace sfdx4csharpClient.Core.Attributes
{
    /// <summary>
    /// Attribute used to store the cli command associated with a command's function.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class CommandAttribute : Attribute
    {
        private readonly string m_Value;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="p_Value">SFDX CLI command.</param>
        /// <example>For the SOQL query command in the Data namespace, the command should be "soql:query".</example>
        public CommandAttribute(string p_Value)
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Value));

            m_Value = p_Value;
        }

        /// <summary>
        /// Gets the attribute value on the given method.
        /// </summary>
        /// <param name="p_Method">Method with a CommandAttribute to get.</param>
        /// <returns>The attribute value.</returns>
        public static string GetCommandValue(MethodBase p_Method)
        {
            Debug.Assert(p_Method != null);

            var attribute = (CommandAttribute)GetCustomAttribute(p_Method, typeof(CommandAttribute));
            return attribute?.m_Value;
        }
    }
}
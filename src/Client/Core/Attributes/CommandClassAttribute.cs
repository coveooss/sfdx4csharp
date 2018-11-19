// Copyright (c) 2005-2018, Coveo Solutions Inc.

using System;
using System.Diagnostics;

namespace sfdx4csharpClient.Core.Attributes
{
    /// <summary>
    /// Attribute used to store the cli command associated with a command's class.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandClassAttribute : Attribute
    {
        private readonly string m_Value;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="p_Value">SFDX CLI command's namespace.</param>
        /// <example>For the Auth commands, the namespace should be "force:auth".</example>
        public CommandClassAttribute(string p_Value)
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Value));

            m_Value = p_Value;
        }

        /// <summary>
        /// Gets the attribute value on the given type.
        /// </summary>
        /// <param name="p_Type">Type with a CommandClassAttribute to get.</param>
        /// <returns>The attribute value.</returns>
        public static string GetCommandClassValue(Type p_Type)
        {
            Debug.Assert(p_Type != null);

            var attribute = (CommandClassAttribute)GetCustomAttribute(p_Type, typeof(CommandClassAttribute));
            return attribute?.m_Value;
        }
    }
}
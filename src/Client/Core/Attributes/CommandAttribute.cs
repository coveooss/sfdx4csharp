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
        private readonly string _value;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="value">SFDX CLI command.</param>
        /// <example>For the SOQL query command in the Data namespace, the command should be "soql:query".</example>
        public CommandAttribute(string value)
        {
            Debug.Assert(!string.IsNullOrEmpty(value));

            _value = value;
        }

        /// <summary>
        /// Gets the attribute value on the given method.
        /// </summary>
        /// <param name="method">Method with a CommandAttribute to get.</param>
        /// <returns>The attribute value.</returns>
        public static string GetCommandValue(MethodBase method)
        {
            Debug.Assert(method != null);

            var attribute = (CommandAttribute)GetCustomAttribute(method, typeof(CommandAttribute));
            return attribute?._value;
        }
    }
}
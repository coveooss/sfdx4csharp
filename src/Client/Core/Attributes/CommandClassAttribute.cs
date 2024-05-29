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
        private readonly string _value;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">SFDX CLI command's namespace.</param>
        /// <example>For the Auth commands, the namespace should be "force:auth".</example>
        public CommandClassAttribute(string value)
        {
            Debug.Assert(!string.IsNullOrEmpty(value));

            _value = value;
        }

        /// <summary>
        /// Gets the attribute value on the given type.
        /// </summary>
        /// <param name="type">Type with a CommandClassAttribute to get.</param>
        /// <returns>The attribute value.</returns>
        public static string GetCommandClassValue(Type type)
        {
            Debug.Assert(type != null);

            var attribute = (CommandClassAttribute)GetCustomAttribute(type, typeof(CommandClassAttribute));
            return attribute?._value;
        }
    }
}
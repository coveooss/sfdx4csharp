using System;

namespace sfdx4csharpUtilities
{
    /// <summary>
    /// Exception thrown by ScratchOrgUtilities's functions when there is a missing environment variable.
    /// </summary>
    [Serializable]
    public class MissingEnvironmentVariableException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key">Missing environment variable's key.</param>
        public MissingEnvironmentVariableException(string key)
            : base(string.Format($"The '{key}' environment variable is missing."))
        {
        }
    }
}
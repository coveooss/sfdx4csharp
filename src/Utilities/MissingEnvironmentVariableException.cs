// Copyright (c) 2005-2018, Coveo Solutions Inc.

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
        /// <param name="p_Key">Missing environment variable's key.</param>
        public MissingEnvironmentVariableException(string p_Key)
            : base(string.Format($"The '{p_Key}' environment variable is missing."))
        {
        }
    }
}

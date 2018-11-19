// Copyright (c) 2005-2018, Coveo Solutions Inc.

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI Output's wrapper
    /// </summary>
    public class SFDXOutput
    {
        /// <summary>
        /// SFDX cli command used with parameters and flags.
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// StandardOutput from the console, if any.
        /// </summary>
        public string RawOutput { get; set; }

        /// <summary>
        /// StandardError from the console, if any.
        /// </summary>
        public string RawError { get; set; }
    }
}
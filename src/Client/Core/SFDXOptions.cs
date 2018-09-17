// Copyright (c) 2005-2018, Coveo Solutions Inc.

using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI command options's wrapper.
    /// </summary>
    public abstract class SFDXOptions
    {
        /// <summary>
        /// Format output as JSON.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json => true;
    }
}

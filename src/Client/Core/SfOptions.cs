﻿using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI command options's wrapper.
    /// </summary>
    public abstract class SfOptions
    {
        /// <summary>
        /// Format output as JSON.
        /// </summary>
        /// <value>
        /// The json property gets/sets the --json flag. The default value is true.
        /// </value>
        [SwitchName("--json")]
        public bool json { get; set; } = true;
    }
}
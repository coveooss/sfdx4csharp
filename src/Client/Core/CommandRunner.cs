// Copyright (c) 2005-2018, Coveo Solutions Inc.

using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI command runner.
    /// </summary>
    public class CommandRunner
    {
        private readonly string m_SFDXPath;

        /// <summary>
        /// The working folder where all the commands will be executed.
        /// </summary>
        public string WorkingFolder { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="p_Path">SFDX CLI path.</param>
        public CommandRunner(string p_Path,
            string p_WorkingFolder = "")
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Path));

            m_SFDXPath = p_Path;
            WorkingFolder = p_WorkingFolder;
        }

        /// <summary>
        /// Executes a command in a separate process and return the output.
        /// </summary>
        /// <param name="p_Command">Command to execute.</param>
        /// <returns>Output of the command.</returns>
        public string RunCommand(string p_Command)
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Command));

            string outText;
            string errText;
            using (var process = Process.Start(GetProcessValues(p_Command))) {
                if (process == null) {
                    throw new NullReferenceException(nameof(process));
                }

                var outTask = Task.Run(() => process.StandardOutput.ReadToEndAsync());
                var errTask = Task.Run(() => process.StandardError.ReadToEndAsync());
                process.WaitForExit();
                outText = outTask.Result;
                errText = errTask.Result;
            }

            if (!string.IsNullOrEmpty(outText)) {
                return outText;
            }

            throw new Exception(errText);
        }

        private ProcessStartInfo GetProcessValues(string p_Command)
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Command));

            var startInfo = new ProcessStartInfo(m_SFDXPath, p_Command);
            startInfo.EnvironmentVariables["SFDX_CONTENT_TYPE"] = "JSON";
            startInfo.EnvironmentVariables["SFDX_AUTOUPDATE_DISABLE"] = "true";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            if (!String.IsNullOrEmpty(WorkingFolder)) {
                startInfo.WorkingDirectory = WorkingFolder;
            }

            return startInfo;
        }
    }
}

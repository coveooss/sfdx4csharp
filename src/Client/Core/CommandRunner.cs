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
        /// <param name="p_WorkingFolder">The working folder where to run SFDX commands.</param>
        public CommandRunner(string p_Path,
            string p_WorkingFolder = "")
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Path));

            m_SFDXPath = FormatPath(p_Path);
            WorkingFolder = FormatPath(p_WorkingFolder);
        }

        /// <summary>
        /// Executes a command in a separate process and return the output.
        /// </summary>
        /// <param name="p_Command">Command to execute.</param>
        /// <returns>SFDX output informations.</returns>
        public SFDXOutput RunCommand(string p_Command)
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Command));

            SFDXOutput output = new SFDXOutput()
            {
                Command = p_Command
            };

            using (var process = Process.Start(GetProcessValues(p_Command)))
            {
                if (process == null)
                {
                    throw new NullReferenceException(nameof(process));
                }

                var outTask = Task.Run(() => process.StandardOutput.ReadToEndAsync());
                var errTask = Task.Run(() => process.StandardError.ReadToEndAsync());
                process.WaitForExit();
                output.RawOutput = outTask.Result;
                output.RawError = errTask.Result;
            }

            return output;
        }

        private string FormatPath(string p_Path)
        {
            Debug.Assert(p_Path != null);

            bool isEscaped = p_Path.StartsWith("\"") && p_Path.EndsWith("\"");
            return (p_Path.Contains(" ") && !isEscaped) ? string.Format("\"{0}\"", p_Path) : p_Path;
        }

        private ProcessStartInfo GetProcessValues(string p_Command)
        {
            Debug.Assert(!string.IsNullOrEmpty(p_Command));

            var startInfo = new ProcessStartInfo(m_SFDXPath, p_Command);
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
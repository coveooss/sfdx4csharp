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
        private readonly string _sfdxPath;

        /// <summary>
        /// The working folder where all the commands will be executed.
        /// </summary>
        public string WorkingFolder { get; set; }

        /// <summary>
        /// The home folder where sfdx will look for the '.sfdx' folder.
        /// </summary>
        public string HomeFolder { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="path">SFDX CLI path.</param>
        /// <param name="workingFolder">The working folder where to run SFDX commands.</param>
        public CommandRunner(string path, string workingFolder = "")
        {
            Debug.Assert(!string.IsNullOrEmpty(path));

            _sfdxPath = FormatPath(path);
            WorkingFolder = FormatPath(workingFolder);
            HomeFolder = "";
        }

        /// <summary>
        /// Executes a command in a separate process and return the output.
        /// </summary>
        /// <param name="command">Command to execute.</param>
        /// <returns>SFDX output informations.</returns>
        public SfdxOutput RunCommand(string command)
        {
            Debug.Assert(!string.IsNullOrEmpty(command));

            var output = new SfdxOutput()
            {
                Command = command
            };

            using (var process = Process.Start(GetProcessValues(command)))
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

        private string FormatPath(string path)
        {
            Debug.Assert(path != null);

            var isEscaped = path.StartsWith("\"") && path.EndsWith("\"");
            return (path.Contains(" ") && !isEscaped) ? string.Format("\"{0}\"", path) : path;
        }

        private ProcessStartInfo GetProcessValues(string command)
        {
            Debug.Assert(!string.IsNullOrEmpty(command));

            var startInfo = new ProcessStartInfo(_sfdxPath, command);
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            if (!String.IsNullOrEmpty(WorkingFolder)) {
                startInfo.WorkingDirectory = WorkingFolder;
            }

            if (!String.IsNullOrEmpty(HomeFolder)) {
                // This only works on Windows at the moment.
                startInfo.EnvironmentVariables["USERPROFILE"] = HomeFolder;
            }

            return startInfo;
        }
    }
}
using System.Diagnostics;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// Command Executioner.
    /// </summary>
    public class CommandExecutioner
    {
        private readonly CommandRunner _commandRunner;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="commandRunner">The command executor that will run the commands.</param>
        public CommandExecutioner(CommandRunner commandRunner)
        {
            Debug.Assert(commandRunner != null);

            _commandRunner = commandRunner;
        }

        /// <summary>
        /// Execute a command's method and return the serialized result.
        /// </summary>
        /// <typeparam name="T">Type of the command's method options.</typeparam>
        /// <param name="command">Current command's method.</param>
        /// <param name="requestOptions">Current command's method options.</param>
        /// <returns>SFDX output information.</returns>
        public SfdxOutput Execute<T>(string command, T requestOptions) where T : SfdxOptions
        {
            Debug.Assert(command != null);

            var completeCommand = CommandBuilder<T>.Build(command, requestOptions);
            return _commandRunner.RunCommand(completeCommand);
        }
    }
}
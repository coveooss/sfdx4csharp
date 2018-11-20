// Copyright (c) 2005-2018, Coveo Solutions Inc.

using System.Diagnostics;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// Command Executioner.
    /// </summary>
    public class CommandExecutioner
    {
        private readonly CommandRunner m_CommandRunner;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="p_CommandRunner">The command executor that will run the commands.</param>
        public CommandExecutioner(CommandRunner p_CommandRunner)
        {
            Debug.Assert(p_CommandRunner != null);

            m_CommandRunner = p_CommandRunner;
        }

        /// <summary>
        /// Execute a command's method and return the serialized result.
        /// </summary>
        /// <typeparam name="T">Type of the command's method options.</typeparam>
        /// <param name="p_Command">Current command's method.</param>
        /// <param name="p_RequestOptions">Current command's method options.</param>
        /// <returns>SFDX output informations.</returns>
        public SFDXOutput Execute<T>(string p_Command, T p_RequestOptions) where T : SFDXOptions
        {
            Debug.Assert(p_Command != null);

            string completeCommand = CommandBuilder<T>.Build(p_Command, p_RequestOptions);
            return m_CommandRunner.RunCommand(completeCommand);
        }
    }
}
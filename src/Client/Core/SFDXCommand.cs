// Copyright (c) 2005-2020, Coveo Solutions Inc.

using System.Diagnostics;
using System.Reflection;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient.Core
{
    /// <summary>
    /// SFDX CLI command's wrapper.
    /// </summary>
    public abstract class SFDXCommand
    {
        private readonly CommandExecutioner m_CommandExecutioner;

        protected SFDXCommand(CommandExecutioner p_CommandExecutioner)
        {
            Debug.Assert(p_CommandExecutioner != null);

            m_CommandExecutioner = p_CommandExecutioner;
        }

        protected SFDXResponse ExecuteCommand<TOptions>(string p_MethodName,
            TOptions p_Options) where TOptions : SFDXOptions, new()
        {
            Debug.Assert(p_MethodName != null);

            MethodInfo methodInfo = GetType().GetMethod(p_MethodName);
            Debug.Assert(methodInfo != null);

            string apiCommandClass = CommandClassAttribute.GetCommandClassValue(GetType());
            string apiCommand = CommandAttribute.GetCommandValue(methodInfo);
            string command = $"{apiCommandClass}:{apiCommand}";

            SFDXOptions options = p_Options ?? new TOptions();
            SFDXOutput output = m_CommandExecutioner.Execute(command, options);
            return new SFDXResponse {
                AdditionalInfo = output,
                Result = options.json ? ResponseParser.Parse(output.RawOutput) : null
            };
        }
    }
}
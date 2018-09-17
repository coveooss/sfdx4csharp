// Copyright (c) 2005-2018, Coveo Solutions Inc.

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

        protected TResult ExecuteCommand<TOptions, TResult>(string p_MethodName,
            TOptions p_Options) where TOptions : SFDXOptions
        {
            Debug.Assert(p_MethodName != null);

            MethodInfo methodInfo = GetType().GetMethod(p_MethodName);
            Debug.Assert(methodInfo != null);

            string apiCommandClass = CommandClassAttribute.GetCommandClassValue(GetType());
            string apiCommand = CommandAttribute.GetCommandValue(methodInfo);

            var json = m_CommandExecutioner.Execute($"{apiCommandClass}:{apiCommand}", p_Options);
            return ResponseParser.Parse<TResult>(json);
        }
    }
}

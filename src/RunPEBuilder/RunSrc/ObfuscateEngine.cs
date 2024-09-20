using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Linq;

namespace RunPEBuilder.Include
{
    public static class RandomUtils
    {
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

    public class RenameProtector
    {
        public static int count_xxx = 0;

        public static void Execute(ModuleDef module, string outPath)
        {
            try
            {
                module.Name = RandomUtils.RandomString(7);

                foreach (var type in module.Types)
                {
                    if (type.IsGlobalModuleType || type.IsRuntimeSpecialName || type.IsSpecialName || type.IsWindowsRuntime || type.IsInterface)
                        continue;

                    count_xxx++;
                    type.Name = RandomUtils.RandomString(40);
                    type.Namespace = "";

                    foreach (var property in type.Properties)
                    {
                        count_xxx++;
                        property.Name = RandomUtils.RandomString(40);
                    }

                    foreach (var field in type.Fields)
                    {
                        count_xxx++;
                        field.Name = RandomUtils.RandomString(40);
                    }

                    foreach (var eventDef in type.Events)
                    {
                        count_xxx++;
                        eventDef.Name = RandomUtils.RandomString(40);
                    }

                    foreach (var method in type.Methods)
                    {
                        if (method.IsConstructor) continue;
                        count_xxx++;
                        method.Name = RandomUtils.RandomString(40);
                    }
                }
                module.Write(outPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during renaming: {ex.Message}");
            }
        }
    }

    public class JunkMethods
    {
        public static void Execute(ModuleDef module, string OutPath)
        {
            try
            {
                foreach (var type in module.Types)
                {
                    for (int i = 0; i < 100; i++) // Create 100 junk methods for each type
                    {
                        var junkMethod = new MethodDefUser(RandomUtils.RandomString(10), MethodSig.CreateStatic(module.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static)
                        {
                            Body = new CilBody()
                        };
                        junkMethod.Body.Instructions.Add(OpCodes.Ret.ToInstruction());

                        type.Methods.Add(junkMethod);
                    }
                }

                for (int i = 0; i < 50; i++) // Create 50 junk classes
                {
                    var junkType = new TypeDefUser(RandomUtils.RandomString(10), module.CorLibTypes.Object.TypeDefOrRef);
                    module.Types.Add(junkType);

                    for (int j = 0; j < 10; j++) // For each junk class, create 10 junk methods
                    {
                        var junkMethod = new MethodDefUser(RandomUtils.RandomString(10), MethodSig.CreateStatic(module.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static)
                        {
                            Body = new CilBody()
                        };
                        junkMethod.Body.Instructions.Add(OpCodes.Ret.ToInstruction());

                        junkType.Methods.Add(junkMethod);
                    }
                }
                module.Write(OutPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during junk method insertion: {ex.Message}");
            }
        }
    }
}

using Day7_CognizantAtt;
using System.Reflection;

namespace Day7_MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = @"C:\Users\IET\Desktop\.Net_250845920048\Solution\Day7_EmpLib\bin\Debug\net8.0\Day7_EmpLib.dll";

            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] allTypes = asm.GetTypes();
            for (int i = 0; i < allTypes.Length; i++)
            {
                Type type = allTypes[i];
                //Console.WriteLine(type.Name);
                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];
                    if (attr is CognizantAttribute)
                    {
                        CognizantAttribute cogAttr = attr as CognizantAttribute;

                        Console.WriteLine($"Class {type.Name} is developed by {cogAttr.DeveloperName} of (c) {cogAttr.CompanyName}");
                    }

                    if (attr is SerializableAttribute)
                    {
                        Console.WriteLine($"Class {type.Name} is marked as Serializable");
                    }
                }
            }

        }
    }
}

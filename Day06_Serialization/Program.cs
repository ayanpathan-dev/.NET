using System;
using System.IO;
using System.Xml.Serialization;

namespace Day06_Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\IET\Desktop\.Net_250845920048\Solution\Day06_Serialization\file\data01.xml";

            Emp emp = new Emp
            {
                Id = 101,
                Name = "John Connor",
                Address = "Earth",
                Role = "Actor"
            };

            
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Emp));
                serializer.Serialize(fs, emp);
            }
            Console.WriteLine("Serialization Done!");

            
            if (File.Exists(filePath))
            {
                using (FileStream fs1 = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Emp));
                    Emp empData = serializer.Deserialize(fs1) as Emp;

                    if (empData != null)
                    {
                        Console.WriteLine($"Id = {empData.Id}, Name = {empData.Name}, Address = {empData.Address}, Role = {empData.Role}");
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
    }

    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    }
}

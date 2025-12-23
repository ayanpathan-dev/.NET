using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Day6_SerializationJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath1 = @"C:\Users\IET\Desktop\.Net_250845920048\Solution\Day6_SerializationJson\file.meoww.txt";
            Emp emp = new Emp();
            emp.Id = 101;
            emp.Name = "John Connor";
            emp.Address = "Earth";

            FileStream fs = null;

            if (File.Exists(filePath1))
            {
                fs = new FileStream(filePath1, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath1, FileMode.OpenOrCreate, FileAccess.Write);
            }

            JsonSerializer.Serialize<Emp>(fs, emp);
            fs.Close();
            Console.WriteLine("Done");



            FileStream fs1 = null;

            if (File.Exists(filePath1))
            {
                fs1 = new FileStream(filePath1, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }

            Emp empData = JsonSerializer.Deserialize<Emp>(fs1);
            fs1.Close();
            Console.WriteLine($"Id = {empData.Id}, Name = {empData.Name}, Address= {empData.Address}");

        }

        public class Emp
        {
            private int _Id;
            private string _Name;
            private string _Address;

            [XmlIgnore]
            [JsonIgnore]
            public string Address
            {
                get { return _Address; }
                set { _Address = value; }
            }
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public int Id
            {
                get { return _Id; }
                set { _Id = value; }
            }

        }
    }
}

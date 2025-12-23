using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;


namespace Day05_BinarySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\IET\Desktop\.Net_250845920048\Solution\Day05_BinarySerialization\file\abc.txt";

            Emp emp = new Emp();
            emp.EmpId = 101;
            emp.Ename = "Tony Stark";
            emp.Eaddress = "Shivaji Nagar";

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
           
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp);
            fs.Close();
            Console.WriteLine("Done");

            //fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //Emp empData = bf.Deserialize(fs) as Emp;
            //fs.Close();
        }

        [Serializable]
        public class Emp
        {
            private int _EmpId;

            public int EmpId
            {
                get { return _EmpId; }
                set { _EmpId = value; }
            }
            private string _Ename;

                public string Ename
            {
                get { return _Ename; }
                set { _Ename = value; }
            }

            private string _Eaddress;

            public string Eaddress
            {
                get { return _Eaddress; }
                set { _Eaddress = value; }
            }



        }
    }
}

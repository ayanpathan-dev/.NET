namespace Day6_FileIO
{

    internal class Program
    {
        static void Main(string[] args)
        {
            String filepath = @"C:\Users\IET\Desktop\.Net_250845920048\Solution\Day6_FileIO\file\OptimusPrime.txt";
            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("My name is Optimus Prime. We are autonomous robotic organisms from the planet Cybertron" +
                ", Freedom is the right of all sentient beings." +
                "At the end of this day, one shall stand… one shall fall!" +
                "In those memories, we live on.");
            writer.Flush();
            writer.Close();

            StreamReader reader = new StreamReader(filepath);
            String content = reader.ReadToEnd();
            Console.WriteLine(content);
            reader.Close();
            fs.Close();

            Emp emp = new Emp();
            emp.Id = 101;
            emp.Name = "Tony Stark";
            emp.Address = "Shivaji Nagar";


            String filepathh = @"C:\Users\IET\Desktop\.Net_250845920048\Solution\Day6_FileIO\file\emp.txt";
            FileStream fss = new FileStream(filepathh, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writerr = new StreamWriter(fss);
            String iteams = $"Emp Id={emp.Id} ,Emp Name={emp.Name} ,Emp Address = {emp.Address}";
            writerr.WriteLine(iteams);
            writerr.Flush();
            writerr.Close();



        }
        public class Emp
        {
            private int _Id;
            private string _Name;
            private string _Address;

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

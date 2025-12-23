namespace Day6_fileSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String filepath = @"C:\Users\IET\Desktop\.Net_250845920048\Solution\Day6_fileSerialization\OptimusPrime2.txt";
            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("My name is Optimus Prime. We are autonomous robotic organisms from the planet Cybertron" +
                ", Freedom is the right of all sentient beings." +
                "At the end of this day, one shall stand… one shall fall!" +
                "In those memories, we live on.");
            writer.Flush();
            writer.Close();
            fs.Close();
        }
    }
}

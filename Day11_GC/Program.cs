namespace Day11_GC
{
    internal class Program
    {
        static void Main(string[] args)
        { }
        public class Myclass : IDisposable
        {
            public void Dispose() {
                Console.WriteLine("called Dispose method");
                GC.SuppressFinalize(this);
            }

            public void sayHi()
            {
                Console.WriteLine("hi");
            }

        }
    }
}

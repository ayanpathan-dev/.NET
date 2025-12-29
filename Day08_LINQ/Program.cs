namespace Day08_C_Features
{
    public delegate bool MyDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = delegate (int num)
                                {
                                    return num > 10;
                                };
            int no = 10;
            var result = del(no);
            if (result)
                if (del(no))
            {
                Console.WriteLine($"No : {no} is greater than 10");
            }
            else
            {
                Console.WriteLine($"No : {no} is NOT greater than 10");
            }
        }
    }
}

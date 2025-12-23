namespace Day5_swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = 12;
            int b = 7;
            CMath cmath = new CMath();
            Console.WriteLine($"Before Swapping A={a}, B={b}");
            cmath.Swap(ref a, ref b);
            Console.WriteLine($"After Swapping A={a}, B={b}");

            string s1 = "Hello";
            string s2 = "Bye";
            Console.WriteLine($"Before Swapping S1={s1}, S2={s2}");
            cmath.Swap(ref s1, ref s2);
            Console.WriteLine($"After Swapping S1={s1}, S2={s2}");



            int a = 12;
            int b = 7;
            CMath cmath = new CMath();
            Console.WriteLine($"Before Swap A={a}, B={b}");
            cmath.Swap<int>(ref a, ref b);
            Console.WriteLine($"After Swap
            string s1 = "Hello";
            string s2 = "Bye";
            Console.WriteLine($"Before Swap S1={s1}, S2={s2}");
            cmath.Swap<string>(ref s1, ref s2);
            Console.WriteLine($"After Swap S1={s1}, S2={s2}");

        }
    }
}

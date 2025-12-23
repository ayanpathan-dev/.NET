namespace Day5_GenericPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 12;
            int b = 7;
            CMath cmath = new CMath();
            Console.WriteLine($"Before Swapping A={a}, B={b}");
            cmath.Swap<int>(ref a, ref b);
            Console.WriteLine($"After Swapping A={a}, B={b}");

            string s1 = "Hello";
            string s2 = "Bye";
            Console.WriteLine($"Before Swapping S1={s1}, S2={s2}");
            cmath.Swap<string>(ref s1, ref s2);
            Console.WriteLine($"After Swapping S1={s1}, S2={s2}");

            CMath cmath1 = new CMath();
            Console.WriteLine(cmath1.Add<int>(2, 4));
            Console.WriteLine(cmath1.Add<string>("2", "4"));
            Console.WriteLine(cmath1.Add<double>(22.22, 22.22));


            double area, circumference = 0;
            double radius = 5;
            CMath cmath2 = new CMath();
            cmath2.CalculateCircleArea(radius, out area, out circumference);
            Console.WriteLine($"Circle : Area = {area}, Circumference = {circumference}");
        }

        public class CMath
        {
           
            public void Swap<T>(ref T x, ref T y)
            {
                T temp = x;
                x = y;
                y = temp;

                Console.WriteLine($"After Swapping A={x}, B={y}");
            }
            
            


            public T Add<T>(T x, T y)
            {
                dynamic para1 = x;
                dynamic para2 = y;
                dynamic sum = para1 + para2; 
                return sum;
            }

            public void CalculateCircleArea(double radius, out double area, out double circumference)
            {
                area = 3.14 * radius * radius;
                circumference = 2 * 3.14 * radius;
            }
        }
    }
}

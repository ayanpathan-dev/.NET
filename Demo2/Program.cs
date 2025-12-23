namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num <= 1)
            {
                flag = false;
            }
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }

            }
            if (flag)
            {
                Console.WriteLine(num + " is prime number");
            }
            else
            {
                Console.WriteLine(num + "is not a prime number");
            }
        }
    }
}
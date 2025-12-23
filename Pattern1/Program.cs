namespace Pattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {


                for (int k = n; k > i + 1; k--)
                {
                    Console.Write("   ");
                }
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                }
                for (int k = 0; k < i; k++)
                {
                    if (k == i - 1)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }


                Console.WriteLine();
            }




            for (int i = 1; i < n + 1; i++)
            {

                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("   ");
                }
                for (int k = n; k > i; k--)
                {
                    if (k == n)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                }

                for (int k = n; k > i + 1; k--)
                {
                    if (k == i + 2)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                }


                Console.WriteLine();
            }
        }
    }
}

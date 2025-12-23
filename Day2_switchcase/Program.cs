namespace Day2_switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice =0;
            do
            {
                Console.Write("1. Addition 2.Substraction 3.Multiplication");
                Console.Write("Enter number :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("you slected addition");
                        break;
                    case 2:
                        Console.Write("yout selected substraction");
                        break;
                    case 3:
                        Console.Write("you selected Multi");
                        break;
                    default:
                        Console.Write("incorrect choice");
                        break;
                }

            } while (choice != 4);
            Console.WriteLine(" Exited program!");
            

        }
    }
}

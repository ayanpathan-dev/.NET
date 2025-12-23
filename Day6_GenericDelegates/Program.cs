namespace Day6_GenericDelegates
{
    public delegate void mydelegate();
    public delegate void mydelegate2(String msg);
    public delegate void MyDelegate2<T>(T para);
    public delegate void MyDelegate3<T1, T2>(T1 para1, T2 para2);
    public delegate bool PredicateDelegate<T>(T para);
    public delegate R FuncDelegate<T, R>(T para);
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            mydelegate del = demo.SayHi;
            del.Invoke();
            mydelegate2 del2 = demo.SayHello;
            del2.Invoke("meowwww");

            MyDelegate2<int> del3 = demo.Display;
            del3(42);

            MyDelegate3<string, string> del4 = demo.Greet;
            del4("Hugh Jackman", "The movie was really good!!");

            PredicateDelegate<int> pred1 = demo.CheckEven;
            bool isEven = pred1(11);
            Console.WriteLine($"isEven = {isEven} for number = 11");

            PredicateDelegate<int> pred2 = demo.CheckOdd;
            bool isOdd = pred2(7);
            Console.WriteLine($"isOdd = {isOdd} for number = 7");
        }
        public class Demo
        {
            public void SayHi()
            {
                Console.WriteLine("Hi there!");
            }
            public void SayHello(string name)
            {
                Console.WriteLine($"Hello, {name}");
            }
            public void Greet(string name, string msg)
            {
                Console.WriteLine($"Hey ! {name}, {msg}");
            }
            public void Display(int number)
            {
                Console.WriteLine($"Number is: {number}");
            }

            public bool CheckEven(int number)
            {
                return number % 2 == 0;
            }
            public bool CheckOdd(int number)
            {
                return number % 2 != 0;
            }

            public int Add(int[] numbers)
            {
                int sum = 0;
                foreach (var num in numbers)
                {
                    sum += num;
                }
                return sum;
            }
            public void Add(int n1, int n2, int n3, out int sum)
            {
                sum = n1 + n2 + n3;
            }
        }
    }
}

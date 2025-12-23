namespace day04_DemoDelegate
{
   
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string str);

        public delegate int MyAddDelegate(int p, int q);
        public delegate int MySquareDelegate(int x);
        internal class Program
        {
            static void Main(string[] args)
            {
                

                CMath cMath = new CMath();
                MyAddDelegate addDel = new MyAddDelegate(cMath.Add);

                Console.WriteLine("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int addResult = addDel(num1, num2);

                MySquareDelegate squareDel = new MySquareDelegate(cMath.Square);
                int squareResult = squareDel.Invoke(num1);
            
                Console.WriteLine($"Add = {addResult}, Square = {squareResult}");
            }
            static void SayHi()
            {
                Console.WriteLine("Hi");
            }
            static void SaySomething(string name)
            {
                Console.WriteLine($"Hi {name}");
            }
        }
        public class CMath
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Square(int x)
            {
                return x * x;
            }
        }
        public class MyClass
        {
            public void SayHello()
            {
                Console.WriteLine("Hello");
            }
            public void Greet(string name)
            {
                Console.WriteLine($"Hello {name}!!");
            }
        }
    }



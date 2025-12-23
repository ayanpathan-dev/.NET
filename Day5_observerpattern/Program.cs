namespace Day5_observerpattern
{
    public delegate void NotifyEventHadler(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            publisher pub = new publisher();
            subscriber sub = new subscriber();

            pub.Notify += sub.method1;
            pub.Notify += sub.method2;

            pub.Notifysubcriber("hey sale is live ");

            pub.Notify -= sub.method1;
            pub.Notifysubcriber("exclusive sell for desktop user ");
        }
        public class subscriber { 

        public void method1(string message)
        {
            Console.WriteLine($"{message}-msg form publisher to mobile user");
        }
        public void method2(string message)
        {
            Console.WriteLine($"{message}-msg form publisher to desktop user");
        }
        }

        public class publisher
        {
            public event NotifyEventHadler Notify;
            public void Notifysubcriber(string messege)
            {
                Notify.Invoke(messege);
            }
        }
    }
}

namespace Day5_Non_GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.EId = 103;
            emp.EName = "Tom Ellis";
            emp.EAddress = "L.A";

            Book book = new Book();
            book.BookName = "The Hobbit";
            book.Author = "J.R.R. Tolkien";

            Object[] objs = new Object[5];
            objs[0] = 100; 
            objs[1] = "Something";
            objs[2] = emp;
            objs[3] = book;
            objs[4] = 12.34; 

           

            for (int i = 0; i < objs.Length; i++)
            {
                object element = objs[i];
                if (element is int)
                {
                    int j = Convert.ToInt32(element); 
                    Console.WriteLine($"Value = {j}, Type ={element.GetType().ToString()}");
                }
                if (element is string)
                {
                    string str = element.ToString(); 
                    Console.WriteLine($"Value = {str}, Type ={element.GetType().ToString()}");
                }
                if (element is double)
                {
                    double d = Convert.ToDouble(element); 
                    Console.WriteLine($"Value = {d}, Type ={element.GetType().ToString()}");
                }
                if (element is Emp)
                {
                    Emp emp1 = element as Emp;
                    Console.WriteLine($"Value = {emp1.EId} {emp1.EName} {emp1.EAddress}, Type ={element.GetType().ToString()}");
                }
                if (element is Book)
                {
                    Book book2 = element as Book;
                    Console.WriteLine($"Value = {book2.BookName} {book2.Author}, Type ={element.GetType().ToString()}");
                }
            }
        }

        public class Book
        {
            private string _Author;
            private string _BookName;

            public string BookName
            {
                get { return _BookName; }
                set { _BookName = value; }
            }
            public string Author
            {
                get { return _Author; }
                set { _Author = value; }
            }

        }
        public class Emp
        {
            private int _EId;
            private string _EName;
            private string _EAddress;

            public string EAddress
            {
                get { return _EAddress; }
                set { _EAddress = value; }
            }

            public string EName
            {
                get { return _EName; }
                set { _EName = value; }
            }
            public int EId
            {
                get { return _EId; }
                set { _EId = value; }
            }
        }
    }
}

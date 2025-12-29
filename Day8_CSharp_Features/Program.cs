using System.Collections;

namespace Day8_CSharp_Features
{
    public delegate bool MyDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //MyDelegate del = delegate (int num)
            //{
            //    return num > 10;
            //};
            //int no = 10;

            //    if (del(no))
            //    {
            //        Console.WriteLine($"No : {no} is greater than 10");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"No : {no} is NOT greater than 10");
            //    }
            #endregion

            #region
            //int no = 12;
            //MyDelegate del = num => num > 10;
            //if (del(no))
            //{
            //    Console.WriteLine($"No : {no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"No : {no} is NOT greater than 10");
            //}
            #endregion

            #region 
            //int no = 9;
            //Predicate<int> del = num => num > 10;

            //if (del(no))
            //{
            //    Console.WriteLine($"No : {no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"No : {no} is NOT greater than 10");
            //} 
            #endregion

            #region
            //int[] arr = new int[] { 1, 5, 2, 3 };
            //var result = arr.Sum();
            //Console.WriteLine($"Sum1 = {result}");

            // //MyCustom fuction
            //string[] names = new string[] { "Hugh", "John", "Tom" };
            //var result2 = MySum(names);
            //Console.WriteLine($"Sum3 = {result2}");
            #endregion

            #region
            //Console.WriteLine("Enter your Email ID:");
            //string? email = Console.ReadLine();
            //if (email != null)
            //{
            //    if (MyClass.CheckForValidEmailID(email))
            //        Console.WriteLine("Valid EMail id");
            //    else
            //        Console.WriteLine("Invaild email Id");
            //}

            //Console.WriteLine("Enter your Email ID:");
            //string? email = Console.ReadLine();
            //if (email != null)
            //{
            //    if (email.CheckForValidEmailID())
            //        Console.WriteLine("Valid EMail id");
            //    else
            //        Console.WriteLine("Invaild email Id");
            //}
            #endregion



            #region
            //int[] arr = { 1, 2, 3, 4, 5 };

            //// Safe iteration
            //foreach (int ele in arr)
            //{
            //    Console.WriteLine(ele);
            //}

            //// List example
            //List<int> lstArr = new List<int>();
            //lstArr.Add(11);
            //lstArr.Add(22);

            //foreach (int ele in lstArr)
            //{
            //    Console.WriteLine(ele);
            //}
            #endregion



            MyCustomCollection customCollectionObject = new MyCustomCollection();
            customCollectionObject.AddElement(10);
            customCollectionObject.AddElement(20);
            customCollectionObject.AddElement(30);

            var result = customCollectionObject.GetElemets;
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            foreach (var item in customCollectionObject)
            {
                Console.WriteLine($"--{item}");
            }

            MyCollection collection = new MyCollection();
            foreach (string day in collection)
            {
                Console.WriteLine(day);
            }




        }
        public static T MySum<T>(IEnumerable<T> arr)
        {
            dynamic sum = 0;
            foreach (var ele in arr)
            {
                sum += ele;
            }
            return sum;
        }


    }
    public class MyCustomCollection : IEnumerable
    {
        private ArrayList arr = new ArrayList();
        public ArrayList GetElemets
        {
            //set
            //{
            //    arr.Add(value);
            //}
            get
            {
                return arr;
            }
        }
        public void AddElement(int element)
        {
            arr.Add(element);
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arr.Count; i++)
            {
                yield return arr[i];
                // yield keyword forces CLR to remeber last element index, which we have returned from this for loop and next time returns next element by increasing index as per the for loop syntax condition.
            }
        }
    }

    public class MyCollection : IEnumerable
    {
        private string[] days = new string[] { "Monday", "Tuesday", "Wedensday", "Thrusday", "Firday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                string day = days[i];
                yield return day; // yield keyword is used to return the value from the iterator method. And it maintains last index value.
            }
        }

      
    }

    public static class MyClass //: String : not allowed. sesled class
    {
        public static bool CheckForValidEmailID(this string email)
        {
            return email.Contains("@gmail.com");
        }

        public static List<T> ConvertToList<T>(this IEnumerable<T> source, int nonsenseParameter)
        {
            List<T> list = new List<T>();
            foreach (var item in source)
            {
                list.Add(item);
            }
            Console.WriteLine($"Nonsense Parameter value = {nonsenseParameter}");
            return list;
        }
    }
}

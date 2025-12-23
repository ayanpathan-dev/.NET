namespace _01_demo_property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EId = 10; 
            int id = emp.EId;
            Console.WriteLine($"ID  = {id} ");
            emp.EName = "Hugh Jackman";
            Console.WriteLine($"Output : {emp.EName}");
            emp.EAddress = "New York";
        }
    }

    public class Employee
    {
        private int _EId;
        private string _EName;
        private string _EAddress;

        public int EId
        {
            set
            {
                _EId = value;
            }
            get
            {
                return _EId;
            }
        }
        public string EName
        {
            set
            {
                if (value != null)
                {
                    _EName = "Mr/Mrs." + value;
                }
                else
                {
                    _EName = "Invalid format";
                }
            }
            get { return _EName; }
        }

        public string EAddress
        {
            set
            {
                _EAddress = value;
                Console.WriteLine($"Address : {_EAddress}");
            }
            //get { return _EAddress; }
        }


       
    }
}

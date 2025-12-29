using Day10_ADO_EMP.DAL;

namespace Day10_ADO_EMP
{
    internal class Program
    {
        static void Main(string[] args)
        {
          DBcontext db = new DBcontext();

            int NoOfRowAffected = 0;
            int choice =0;
            do
            {
                Console.WriteLine("Enter Db Operation Choice: 1. SELECT, 2. Select by ID, 3.INSERT, 4. UPDATE, 5. DELETE");
                 choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            var records = db.GetEmpRecord();
                            foreach(var emp in records)
                            {
                                Console.WriteLine($"Id: {emp.Eid}, Name: {emp.EName}, Address: {emp.EAddress}");
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("enter value to id");
                            int id = Convert.ToInt32(Console.ReadLine());
                            var emp = db.GetById(id);
                            if (emp == null)
                            {
                                Console.WriteLine("Id Not found");
                            }
                            else
                            {
                                foreach(var record in emp)
                                {
                                    Console.WriteLine($"Emp ID :{record.Eid}  Emp Name :{record.EName}  Emp Address :{record.EAddress}");
                                }
                            }
                                break;
                        }
                }

            } while (choice == 5);
        }
    }
}

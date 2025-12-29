using Day09_Demo_connected_ADO.ADL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_Demo_connected_ADO.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Class1 db = new Class1();
            int noOFRowsAffected = 0;

            while (true)
            {
                Console.WriteLine("Enter Db collection:1.select 2.select by id 3.insert 4.update 5.Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());

                switch (opChoice)
                {
                    case 1:
                        var records = db.GetEmpRecords();
                        foreach (var emp in records)
                        {
                            Console.WriteLine($"Id: {emp.EId}, Name: {emp.EName}, Address: {emp.EAddress}");
                        }
                        break;

                }
            }
        }
    }
}


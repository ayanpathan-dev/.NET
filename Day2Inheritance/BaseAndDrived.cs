using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day2Inheritance
{
    internal class BaseAndDrived
    {
        private int base_number;
        public BaseAndDrived()
        {
            Console.WriteLine("Inside Base class non para Constructor");
        }
        public BaseAndDrived(int num)
        {
            base_number = num;
            Console.WriteLine("num from derived class is {0}", base_number);
        }
        public void method()
        {
            Console.WriteLine("Inside base method");

        }
    }
    internal class Derived : BaseAndDrived
    {


        public Derived(int num) : base(num)
        {
        }

        public void method2()
        {
            Console.WriteLine("inside derived class methods");
        }





    }
}

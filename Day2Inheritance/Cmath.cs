using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day2Inheritance
{
    internal class Cmath
    {
        public int Add(int num1 ,int num2)
        {
            return num1 + num2;
        }
        public void Add(int num1, int num2,int num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }

        public virtual void Mult(int a, int b)
        {
            Console.WriteLine("CMath Mult: {0}", (a * b));
        }



    }
    internal class AdvancedMath : Cmath
    {
        public override void Mult(int a, int b)
        {
            Console.WriteLine("Adv Math Mult: {0}", (a * b) * 100);
        }

        public new void Sub(int a, int b)
        {
            Console.WriteLine("Adv Math Sub: {0}", (a - b) * 2);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine("Adv Math Add: {0}", (a + b) * 100);
        }

        public int Add(int a, int b, int p, int q)
        {
            return a + b + p + q;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMath_day04
{
    public class Cmath
    {
        public void add(int x,int y)
        {
            Console.WriteLine($"add={x + y}");

        }
        private void sub(int x, int y)
        {
            Console.WriteLine($"sub={x - y}");

        }
        protected void mul(int x, int y)
        {
            Console.WriteLine($"mul={x * y}");

        }
        internal void Div(int x, int y)
        {
            Console.WriteLine($"div={x / y}");

        }
    }
    public class AdMath : Cmath
    {
        public void Wrappermethod()
        {
            base.Div(6, 3);
            base.mul(5 , 5);
            base.add(5, 5);
        }
    }
}

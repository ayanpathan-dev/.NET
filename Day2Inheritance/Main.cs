namespace Day2Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Class !");
            BaseAndDrived baseo = new BaseAndDrived();
            baseo.method();
           
            Derived derivedobj = new Derived(10);
            derivedobj.method();
            //derivedobj.method();

            //BaseAndDrived bd = new Derived(20);
            //bd.method();

            Cmath math = new Cmath();
            Console.WriteLine(math.Add(10, 20));   
            math.Add(10, 20, 30);                  

            AdvancedMath adv = new AdvancedMath();
            adv.Add(10, 20);
            Console.WriteLine();     
            adv.Add(10, 20, 30);                 
            adv.Mult(2, 3);                       
            adv.Sub(10, 5);                       
            adv.Add(10, 20);                      
            Console.WriteLine(adv.Add(1, 2, 3, 4));





        }
    }
}

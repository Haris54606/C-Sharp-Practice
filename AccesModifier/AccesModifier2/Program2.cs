using System;
using AccesModifier;

namespace AccesModifier2
{
    class abc : class1
    {
       public void showAbc()
        {
            Console.WriteLine("AccesModifier2 chilled class ");
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            // ----- calling class1 from acces modifier 1 - -------> 
            //class1 c = new class1();
            //c.show1();


            // ----- calling class1 from acces modifier 2 (child class) - ------->
            abc q = new abc();
            q.show1();

            // ---- calling chiled class method ---------  ---->
            q.showAbc();
            Console.WriteLine("AccesModifier2");
        }
    }
}

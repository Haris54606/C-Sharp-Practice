using System;

namespace AccesModifier
{
   public class class1
    {
        public void show1()
        {
            Console.WriteLine("this is show1 method");
        }
        // ---- ---- show1 method calling in show2 method --- -->
        public void show2()
        {
            class1 c = new class1();
            c.show1();
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            //class1 c = new class1();
            //c.show1();
            class1 c = new class1();
            c.show2();
            Console.WriteLine("AccesModifier 1");
        }
    }
}

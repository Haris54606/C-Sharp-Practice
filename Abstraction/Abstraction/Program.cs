using System;

namespace Abstraction
{
    class employ
    {
        public int id;
        public string name;
        public double grosspay;
        double text_deduction = 0.1;
        double netsalary;


        //constructor
        public employ(int empid, string empName, double empGrosspay)
        {
            this.id = empid;
            this.name = empName;
            this.grosspay = empGrosspay;

        }
        // agr koi acces modifier nh lagao to by default private hoga 
        void calculate_Salary()
        {
            if (grosspay >= 30000)
            {
                netsalary = grosspay - (text_deduction * grosspay);
                Console.WriteLine("Your salary is : {0}",netsalary);
            }
            else
            {
                Console.WriteLine("your salary is : {0}",grosspay);
            }
        }

        public void show_employe_salary()
        {
            Console.WriteLine(this.id);
            Console.WriteLine("employe Name is : {0}",this.name);
            this.calculate_Salary();
        }



        class Program
        {
            static void Main(string[] args)
            {

                employ e = new employ(17, "haris", 10000);
                e.show_employe_salary();

                Console.WriteLine("Hello World!");
            }
        }
    }
}

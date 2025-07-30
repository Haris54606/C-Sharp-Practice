using System;

namespace Abstract_propertise
{
    public abstract class person
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
    }
    
    public class Student : person
    {
        int student_id;
        string Student_Name;
        public override int Id {
            set
            {
                this.student_id = value;
            }
            get
            {
                return this.student_id;
            }
             }
        public override string Name {
            set { 
                this.Student_Name = value;
            }
            get { 
                return this.Student_Name; }
             }

    }
    public class Teacher
    {

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 12;
            s.Name = "Haris";
            Console.WriteLine(s.Id);
            Console.WriteLine(s.Name);
            Console.WriteLine("Hello World!");
        }
    }
}

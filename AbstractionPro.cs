using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public long PhoneNumber;
        public abstract void PrintDetails();
    }
    class Student : Person
    {
        public int RollNo;
        public int Fees;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Student name is : {0}", name);
            Console.WriteLine("Student age is : {0}", this.Age);
            Console.WriteLine("Student Phone Number is : {0}", this.PhoneNumber);
            Console.WriteLine("Student Roll Number is : {0}", this.RollNo);
            Console.WriteLine("Student Fees is : {0}", this.Fees);
        }
    }
    class Teacher : Person
    {
        public string qualification;
        public int salary;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Teacher name is : {0}", name);
            Console.WriteLine("teacher age is : {0}", this.Age);
            Console.WriteLine("teacher Phone Number is : {0}", this.PhoneNumber);
            Console.WriteLine("Teacher qualification is : {0}", this.qualification);
            Console.WriteLine("teacher salary is : {0}", this.salary);
        }
    }
    class AbstractionPro
    {
        public static void Abstract(string[] args)
        {
            Student s = new Student();
            s.FirstName = "Maheen";
            s.LastName = "Akhtar";
            s.Age = 10;
            s.PhoneNumber = 123456789;
            s.RollNo = 12;
            s.Fees = 10000;
            s.PrintDetails();

            Console.WriteLine("\n _____________");

            Teacher t = new Teacher();
            t.FirstName = "Ayeza";
            t.LastName = "Akhtar";
            t.Age = 30;
            t.PhoneNumber = 123456789;
            t.qualification = "MCA";
            t.salary = 200000;
            t.PrintDetails();
            Console.ReadLine();
        }

    }
}
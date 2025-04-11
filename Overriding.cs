using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class person
    {

        public string Name = "Maheen Akhtar";
        public int Age = 24;
        public long Phoneno = 987654321;

        public virtual void Info()
        {
            Console.WriteLine($"My name is {Name} .", this.Name);
            Console.WriteLine($"I'm {Age} years Old.  ", this.Age);
            Console.WriteLine($"Contact me on : {Phoneno} number. ", this.Phoneno);
        }
    }
    public class student : person
    {
        public int Fees = 78000;
        public string School = "Seven Square Academy";
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"I'm am paying {Fees} .", this.Fees);
            Console.WriteLine($"I'm Studying in {School} .", this.School);
        }
    }
    public class Overriding 
    {
        public static void Over(string[] args)
        {
            person per = new student();
            per.Info();

            Console.ReadLine();
        }
    }
}
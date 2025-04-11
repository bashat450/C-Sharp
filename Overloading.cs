using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Overloading
    {
        public static void Overload(string[] args)
        {

            Console.Write("Enter your 1st no. : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter your 2nd no. : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter your 3rd no. : ");
            int c = int.Parse(Console.ReadLine());


            Overloading ov = new Overloading();
            Console.WriteLine($"{a} + {b} = " + ov.add(a,b));
            Console.WriteLine($"{a} + {b} + {c} = " + ov.add(a, b,c));

            Console.ReadLine();
        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b,int c)
        {
            return a + b +c;
        }

        

    }
}

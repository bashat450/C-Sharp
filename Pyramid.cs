using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Pyramid
    {
        public static void Pyra(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num-i; j++) //space
                {
                    Console.Write(" ");
                }
                for (int k=1; k <= (2 * i) - 1; k++) //star
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           
            Console.ReadLine();
        }
    }
}

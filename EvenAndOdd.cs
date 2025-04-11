using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class EvenAndOdd
    {
        public static void EvenOdd(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even.");
            }
            else
            {
                Console.WriteLine($"{number} is Odd.");
            }

            Console.ReadLine(); // Keeps the console window open
        }
    }
}

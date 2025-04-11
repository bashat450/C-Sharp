using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeNumber
    {
        /*public static void PrimeNo(string[] args)
         {
             Console.Write("Enter a number: ");
             int num = int.Parse(Console.ReadLine());

             bool isPrime = true;

             if (num <= 1)
             {
                 isPrime = false;
             }
             else
             {
                 for (int i = 2; i <= Math.Sqrt(num); i++)
                 {
                     if (num % i == 0)
                     {
                         isPrime = false;
                         break;
                     }
                 }
             }

             if (isPrime)
                 Console.WriteLine($"{num} is a prime number.");
             else
                 Console.WriteLine($"{num} is not a prime number.");
         }*/


        // print 1 to 100 prime number
        public static void PrimeNo(string[]args)
        {
            for(var i = 2; i <= 100; i++){
                bool isPrimeNumber = true;
                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.Write(i + " - ");
                }
            }
            Console.ReadLine();
            
        }

    }
}

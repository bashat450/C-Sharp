using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ArmstrongNumber
    {
        public static void ArmstrongNum(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            //make a obj
            ArmstrongNumber Ar = new ArmstrongNumber();
            Console.WriteLine(Ar.ArmNum(num));
        }
        public int ArmNum(int num)
        {
            int originalNumber = num;
            int sum = 0;
            int digits = num.ToString().Length;
            while (num > 0)
            {
                int d = num % 10;
                sum += (int)Math.Pow(d, digits);
                num /= 10;
            }
            if(sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is a armstrong number...");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not a armstrong number...");
            }
            return originalNumber;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PalindroneNumber
    {
        public static void PalindroneNo(string[] args)
        {
            /*PalindroneNumber PN = new PalindroneNumber();
            Console.WriteLine("Please Enter Your Number : ");
            int al = int.Parse(Console.ReadLine());
            Console.WriteLine("The given number is Palindrone : " );
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());*/
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            PalindroneNumber PN = new PalindroneNumber();
            Console.WriteLine(PN.Palin(num));
        }
        public String Palin(int number) 
        {
            int originalNumber = number;
            int reverse = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }

            if (originalNumber == reverse)
            {
                //Console.WriteLine($"{originalNumber} is a P                                                                                      alindrome number.");
                return " Is Palindrone";
            }
            else
            {
                //Console.WriteLine($"{originalNumber} is NOT a Palindrome number.");
                return "not Palindrone";
            }

            Console.ReadLine();
        }
            
    }
        
    
}

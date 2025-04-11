using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrintingNumber
    {
        public static void PrintNum(string[] args)
        {
            Console.WriteLine("Please Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            PrintingNumber Pr = new PrintingNumber();
            Console.WriteLine(Pr.Print(num));
        }
        public int Print(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
            return a;
        }




    }
}

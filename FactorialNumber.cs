using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class FactorialNumber
    {
        public static void FactorialNum(string[] args)
        {
            Console.Write("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            FactorialNumber FN = new FactorialNumber();
            Console.WriteLine(FN.factorialnumber(num));

            Console.ReadLine();
        }
        public int factorialnumber(int a)
        {
            int ans = 1;
            for (int i = 1; i <= a; i++)
            {
                ans = ans * i;
            }
            return ans;
        }
    }
}

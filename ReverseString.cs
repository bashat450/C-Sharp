using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseString
    {
        public static void ReverseSt(string[] args)
        {
            string original = "abc";
            string reversed = "";

            for (int i = original.Length - 1; i >= 0; i--)
            {
                reversed += original[i];
            }

            Console.WriteLine("Original: " + original);
            Console.WriteLine("Reversed: " + reversed);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class SwapProgram
    {
        public static void Swap(string[] args)
        {
            int a = 2, b = 5;

            Console.WriteLine($"Before Swap: a = {a}, b = {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After Swap: a = {a}, b = {b}");

            //Without Using a Temporary Variable

            int x = 5, y = 10;

            Console.WriteLine($"Before Swap: a = {x}, b = {y}");

            x = x + y; // a = 15
            y = x - y; // b = 5
            x = x -y; // a = 10

            Console.WriteLine($"After Swap: a = {x}, b = {y}");
            Console.ReadLine();
        }
    }
}

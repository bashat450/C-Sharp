using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Array
    {
        public static void ArrayList(string[] args)
        {
            /*
             //***********************************************************
            string[] fruits = new string[] { "Apple", "Banana", "Cherry", "Dragon fruit", "Evergreen huckleberry" };
            string[] names = new string[] { "Aman", "Bushra", "Chaman", "Danish", "Aman","Faiza","Gazala" };
            int[] numbers = new int[] {23, 45, 78, 89 };
            

            //Print array1 values by indexing
            Console.WriteLine($"\tFruits name : {fruits[0]} , {fruits[1]} , {fruits[2]} , {fruits[3]} , {fruits[4]}  \n");

            //Print array2 Values by indexing 
            Console.WriteLine($"\t Students name : {names[0]} , {names[1]} , {names[2]} , {names[3]} , {names[4]} , {names[5]} , {names[6]} \n");

            //Print array1 length
            Console.WriteLine($"\tTotal Fruits : {fruits.Length}\n");
            //Print array2  length
            Console.WriteLine($"\tTotal Students : {names.Length}");*/
            //***************************************
            //Print all Array values using for loop
            /*
            for(int i=1; i <= numbers.Length; i++){
                Console.WriteLine(numbers[i]);
            }*/
            //********************************
            //Print all Array fruits values using foreach loop
            /*
            Console.Write("\t *****Fruits name ***** \n ");
            foreach (string items in fruits)
            {
                Console.Write(" \t "+items);
            }
            Console.Write(" \n\n ");
            Console.WriteLine("\t *****Students name *****\n");
            

            //Print all Array names values using foreach loop
            foreach (string items in names)
            {
                
                Console.Write(" \t"+ items);
            }
            Console.Write("  \n\n ");
            Console.WriteLine("\t *****Numbers *****\n");
            
            //Print all Array number values using foreach loop
            foreach (int items in numbers)
            {
                
                Console.Write(" \t"+ items);
            }
            */
            //*************************************************
            /*
             // Print Values to take user input
            Console.Write("How many times U want to store values in a Array ; ");
            int num = Convert.ToInt32(Console.ReadLine());

            string[] fruits = new string[num]; 
            string[] names = new string[num]; 
            int[] numbers = new int[num];

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Data on Location ",i);
                Console.WriteLine("Enter Fruit ");
                string f = Console.ReadLine();
                Console.WriteLine("Enter Students name ");
                string n = Console.ReadLine();
                Console.WriteLine("Enter Your fees ");
                int no =Convert.ToInt32(Console.ReadLine());
                fruits[i] = f;
                names[i] = n;
                numbers[i] = no;
            }
            Console.WriteLine("******************  Your Data  *****************");
            foreach(string fr in fruits)
            {
                Console.WriteLine($"You want {fr} to eat...");
            }
            foreach (string nm in names)
            {
                Console.WriteLine($"Your name is {nm} ");
            }
            foreach (int numb in numbers)
            {
                Console.WriteLine($"You are paying {numb}");
            }*/
            //***************************************************
            // Sum of all values using foreach 
            // int[] numbers={45, 23, 67,89 };
            /*
            int sum = 0;
            foreach(int add in numbers)
            {
                sum += add;
            }
            Console.WriteLine("sum is : "+sum);
            */
            //*******************************************************
            // Print Maximum and minimum Values using foreach
            /*
            int[] numbers = { 45, 23, 67, 89 };
            int max = numbers[0];
            int min = numbers[0];

            foreach(int n in numbers)
            {
                if (n > max) max = n;
                if (n < min) min = n;
            }
            Console.WriteLine("Maximum number : "+max);
            Console.WriteLine("Minimum number : "+min);
            */
            //************************************Array Functions***********
            /*
            // Reverse the numbers
            int[] numbers = { 45, 23, 67, 89 };
            int[] rev = numbers.Reverse().ToArray();
            Console.WriteLine("Array Reversed : "+ string.Join(" , ",rev));
            // Sort Array Values
            int[] st = numbers.OrderBy(x => x).ToArray();
            Console.WriteLine("Array Reversed : " + string.Join(" , ", st));
            
            // Even and Odd
            int[] EvenOdd = { 12, 34, 23, 45, 89, 54, 98 };
            int even = 0, odd = 0;
            foreach(int num in EvenOdd)
            {
                if (num % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Even numbers : " + even);
            Console.WriteLine("Odd numbers : " + odd);
            */
            /*
            int[] arr = { 1, 2, 2, 3, 1, 4, 2 };
            var frequency = new Dictionary<int, int>();
            
            foreach (int num in arr)
            {
                if (frequency.ContainsKey(num))
                    frequency[num]++;
                else
                    frequency[num] = 1;
            }

            foreach (var item in frequency)
            {
                Console.WriteLine($"Element {item.Key} occurs {item.Value} time(s)");
            }
            */
            Console.ReadLine();

        }

      
    }
}

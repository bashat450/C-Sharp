using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     *****
                   ****
                   ***
                   **
                   *       */
            /*Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");

            Console.WriteLine("\n\n");

            for(int i=1; i<=num; i++)
            {
                for(int j=i; j<=num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/




            /*     12345
                   1234
                   123
                   12
                   1
             */
            /*Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("\n\n");

            for (int i = 1; i <= n; i++)
            {
                int a = 1;
                for (int j = i; j <= n; j++)
                {
                    Console.Write(a+" ");
                    a++;
                }
                Console.WriteLine();
            }*/





            /*
             * 54321
             * 4321
             * 321
             * 21
             * 1
             */
            /*Console.WriteLine("Enter a number : ");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("\n\n");
            int temp = no;

            for (int i = 1; i <= no; i++)
            {
            
                for (int j = temp; j >= 1; j--)
                {
                    Console.WriteLine(j + " ");
                   
                }
                temp--;
                Console.WriteLine();
            }*/





            /*
             *      *
             *      **
             *      ***
             *      ****
             *      *****
             */
            /* Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("\n\n");

            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("* ");
                    
                }
                Console.WriteLine();
            }*/


            /*
             *     *****
             *     ****
             *     ***
             *     **
             *     *
             */
            /* Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("\n\n");

            for (int i = 1; i <= n; i++)
            {

                for (int j = n; j >= i; j--)
                {
                    Console.WriteLine("* ");

                }
                Console.WriteLine();
            } */




            /* 
             *             ****
             *             ****
             *             ****
             *             ****
             */
            /* Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("\n\n");

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine("* ");

                }
                Console.WriteLine();
            } */




            Console.Write("Enter a number : ");     //3
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("\n\n"); 

            /*            *
             *           ***
             *          *****
             */
            /*
            for (int i = 1; i <= n; i++)
            {
                for (int s=1; s<=n-1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (2*i)-1; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            */

            /*              *****
             *               ***
             *                *
             */
            /*
            for (int i = n-1; i >=1; i--)
            {
                for (int s = 1; s <= n - 1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            } */



            /* int n = 5; // Number of rows

            for (int i = 1; i <= n; i++)
            {
                // Printing spaces
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                // Printing stars
                for (int k = 1; k <= (2 * (n - i)-1); k++)
                {
                    Console.Write("*");
                }

                // Moving to the next line
                Console.WriteLine();

            }*/

            /*for (int i = 1; i <= 4; i++) // Loop for rows
            {
                for (int j = 1; j <= 4; j++) // Loop for columns
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/


                Console.ReadLine();
            
        }
}   }

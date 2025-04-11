using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class DupNumber
    {
        public static void DupNo(string[] args)
        {
            DupNumber duplicateString = new DupNumber();
            Console.WriteLine(duplicateString.removeduplicate("tanveer"));
            Console.ReadLine();
         
        }
        public String removeduplicate(String message)
        {
            string result = " ";
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                bool isduplicate = true;
                for (int j = 0; j < result.Length; j++)
                {
                    if (result[j] == c)
                    {
                        isduplicate = false;
                        break;
                    }
                }
                if (isduplicate)
                {
                    result = result + c;
                }
            }
            return result; 
        }
    }
}

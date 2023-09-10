using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbers
{

    // Niko Huber
    // 9-12-23
    // Two Numbers
    // Gets two user inputted numbers and rejects them if both are not less than 10. 
    internal class Program
    {
        // Niko Huber
        // 9-12-23
        // Two Numbers
        // Gets two user inputted numbers and rejects them if both are not less than 10. 
        static void Main(string[] args)
        {
            // Variable declarations- two integers, a temp string, and a boolean for the while loop
            int var1 = 0;
            int var2 = 0;
            string temp = null;
            bool rejected = true;

            Console.WriteLine("Please Enter an Integer less than 10");
            while(rejected) // loops until two acceptable numbers are acquired
            {

                temp = Console.ReadLine(); // reads a line and trys to convert to an integer
                try
                {
                    var1 = Convert.ToInt32(temp);
                }
                catch // catch if not an int
                {
                    Console.WriteLine("Please Enter an Integer LESS than 10");
                }

                temp = Console.ReadLine();
                try // reads a line and trys to convert to an integer
                {
                    var2 = Convert.ToInt32(temp);
                }
                catch // catch if not an int
                {
                    Console.WriteLine("Please Enter an Integer");
                }

                if((var1 < 10) || (var2 < 10)) // compares current input numbers if one is less than 10
                {
                    rejected = false;
                }
                else // reminds the user to try again
                {
                    Console.WriteLine("Please try again.");
                }

            }
        }
    }
}

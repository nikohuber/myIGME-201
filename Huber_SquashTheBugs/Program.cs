using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // int i = 0 (syntax error -- missing semicolon)
            int i = 0;

            // loop through the numbers 1 through 10
            string allNumbers = null;
            for (i = 1; i < 10; ++i)
            {
                // declare string to hold all numbers
                //string allNumbers = null; (synax error -- all Numbers should be called before this for loop)

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = "); (syntax error -- parenthesis are required around "i-1")
                Console.WriteLine(i +  "/" + (i - 1) + "=");

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1)); (runtime -- will result in a logical error with 1 / 0 in the loop)

                try
                {
                    Console.WriteLine(i / (i - 1));
                }
                catch
                {
                    Console.WriteLine("ERROR: " + i + "/" + (i - 1) + " is not possible.");
                }

                // concatenate each number to allNumbers
                allNumbers += (i + " ");
               

                // increment the counter
                //i = i + 1; (syntax -- it is already incremented in the for loop on line 24 -- is entirely funcitonal but if we would like increments at each integer from 1-10 then it must be omitted)
            }
            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers); (syntax error -- missing addition)
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}

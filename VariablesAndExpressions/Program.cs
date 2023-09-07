using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Niko Huber
// IGME 201
// Generates product of four user inputs

namespace VariablesAndExpressions // Main namespace
{
    internal class Program
    {
        static void Main(string[] args) // main
        {

            // array to store user variables and product
            int[] numArray = new int[4];
            int product = 0;

            for (int i = 0; i < 4; i++)  // looping through one readNum function for each unit in array
            {
                numArray[i] = readNum();
            }

            product = numArray[0] * numArray[1] * numArray[2] * numArray[3]; // calculating product

            Console.WriteLine("The product of your numbers is: " + product); // final console message
        }
        
        static int readNum() // readNum function for reading user input
        {

            // temp variables
            String tempNum = null;
            int? inputNum = null;

            Console.WriteLine("Please enter an integer."); // intro message

            while(inputNum == null) // while loop continues until a proper number  is acquired
            {
                tempNum = Console.ReadLine();

                try // attempts a conversion
                {
                    inputNum = Convert.ToInt32(tempNum);
                }
                catch // catch statement
                {
                    Console.WriteLine("Please enter an INTEGER.");
                }
            }
           
            return inputNum.Value ; // returns the value of the nullified int
        }
    }
}

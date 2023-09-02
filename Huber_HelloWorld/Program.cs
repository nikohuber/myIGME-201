using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huber_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // name
            Console.WriteLine("Nikolaus Huber"); 

            // variables and calculations
            int x = 1;
            int y = 2;
            int z = x * y;

            // printing results
            Console.WriteLine(y  + "*"  + x + "=" + z);

            // for loop and printing results
            for(int i = 0; i < 10; i++)
            {
                z = z + z * i;
            }
            Console.WriteLine(z);

        }
    }
}

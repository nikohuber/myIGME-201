using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Niko Huber
// Exam 1
// Rounding Delegate
namespace question3
{
    internal class Program
    {
        // rounding
        delegate double roundingFunction(double d, int i);


        static void Main(string[] args)
        {
            // declate delegate
            roundingFunction mathFunc;

            // assign delegate
            mathFunc = new roundingFunction(Round);

            // print result
            Console.WriteLine(mathFunc(1.778, 2));
        }


        // round input double to set decimals
        static double Round(double d, int i)
        {
            return Math.Round(d, i);
        }
        
    }
}

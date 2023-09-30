using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Niko Huber
// Exam 1
// Raise Simulator
namespace question12
{
    // question 12 - raise sim
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            string sName;
            double dSalary = 30000;

            // input gathering
            Console.WriteLine("What's your name?");
            sName = Console.ReadLine();

            // calls GiveRaise and computes if you got a raise
            if(GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine("Congrats! You got a raise of $19999.99; your new salary is: $" + dSalary);
            }
            else
            {
                Console.WriteLine("no raise :(");
            }

            

        }

        // Gives raise if name is my name
        static bool GiveRaise(string name, ref double salary)
        {
            // default value
            bool raise = false;

            // if name == niko then raise
            if (name == "niko")
            {
                raise = true;
                salary += 19999.99;
            }

            return raise;
        }
    }
}

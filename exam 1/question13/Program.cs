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
        // employee struct
        struct Employee
        {
            public string sName;
            public double dSalary;
        }

        static void Main(string[] args)
        {
            // new employee
            Employee emp = new Employee();

            // default salary
            emp.dSalary = 30000;

            // input gathering
            Console.WriteLine("What's your name?");
            emp.sName = Console.ReadLine();

            // calls GiveRaise and computes if you got a raise
            if (GiveRaise(ref emp))
            {
                Console.WriteLine("Congrats! You got a raise of $19999.99; your new salary is: $" + emp.dSalary);
            }
            else
            {
                Console.WriteLine("no raise :(");
            }



        }

        // Gives raise if name is my name
        static bool GiveRaise(ref Employee emp)
        {
            // default value
            bool raise = false;

            // if name == niko then raise
            if (emp.sName == "niko")
            {
                raise = true;
                emp.dSalary += 19999.99;
            }

            return raise;
        }
    }
}
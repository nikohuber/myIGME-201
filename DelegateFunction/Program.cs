using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Niko Huber
// IGME 201
// 9-22-23
// Delegate Function
namespace DelegateFunction
{
    // DelegateFunction ReadLine(); test

    // Declares delegate 
    public delegate string Read();
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declares variable and target method 
            Read input = ReadLine;

            // calls input(); for reference and assigns the read line to temp
           string temp =  input();

            // prints result
            Console.WriteLine(temp);

        }

        // Reads an available console line
        public static string ReadLine()
        {

            // stores and returns the console line
            string temp = Console.ReadLine();
            return temp ;
        }
    }
}

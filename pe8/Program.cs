using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Niko Huber
// IGME 201
// 9-20-23
// pe8
namespace pe8
{
    internal class Program
    {

        // Niko Huber
        // IGME 201
        // 9-20-23
        // pe8

        static void Main(string[] args)
        {

            // choses between the four different programs in pe8
            Console.WriteLine("Enter 1,2, 3 or 4 to select projects");
            string input = Console.ReadLine();

            switch (input) // switches between the four programs
            {
                // 3d array
                case ("1"): 
                    
                    // declares the 3d array and x,y and z variables
                    double x, y, z;
                    double[,,] arr = new double[20, 30, 3]; // scope is 20 containers of 30 containers of 3 variable arrays (thats how my head seemed to work with 3d arrays)

                    // starting x and y vals
                    x = -1;
                    y = 1;
                    for(int i = 0; i < 20; i += 1) // 20 iterations of x
                    {
                        for(int j = 0; j < 30; j += 1) // 30 iterations of y
                        {
                            z = 3 * (y * y) + 2 * x - 1; // calc for z

                            // placing in 3d array
                            arr[i, j, 0] = x;
                            arr[i, j, 1] = y;
                            arr[i, j, 2] = z;

                            y += 0.1;
                        }
                        y = 1;
                        x += 0.1;
                    }
                    break;

                // string reverser
                case ("2"):

                    // takes input string and initializes array of chars
                    Console.WriteLine("Enter a string");
                    string temp = Console.ReadLine();
                    char[] charArr = new char [(temp.Length)];
                    int count = 0;

                    // reads the input string from back to front and adds to the char array
                    for(int i = temp.Length; i > 0; i--)
                    {
                        charArr[count] = temp[i-1];
                        count += 1;
                    }

                    // converts charArr to one string
                    temp = new string(charArr);

                    Console.WriteLine(temp);

                    break;

                // replaces "no" with "yes"
                case ("3"):

                    // reads the input string and splits it into an array of strings
                    Console.WriteLine("Enter a string");
                    temp = Console.ReadLine();
                    string[] stringArr = temp.Split(' ');
                    
                    // iterates through each word in the string array
                    for(int i = 0; i < stringArr.Length; i++)
                    {
                        // if no, replace it with yes
                        if(stringArr[i] == "no")
                        {
                            stringArr[i] = stringArr[i].Replace("no", "yes");
                        }
                        // if No, replace it with Yes
                        else if (stringArr[i] == "No")
                        {
                            stringArr[i] = stringArr[i].Replace("No", "Yes");
                        }
                    }

                    // joins the strings with a space in between
                    temp = string.Join(" ", stringArr);
                    Console.WriteLine(temp);

                    break;

                // adds quotation marks around words
                case ("4"):

                    // reads input and splits into a string array 
                    Console.WriteLine("Enter a string");
                    temp = Console.ReadLine();
                    stringArr = temp.Split(' ');

                    // iterates through each word and inserts a " at the beginning and end of each string
                    for(int i = 0; i < stringArr.Length; i++)
                    {
                        stringArr[i] = stringArr[i].Insert(0,"\"");
                        stringArr[i] = stringArr[i].Insert(stringArr[i].Length, "\"");
                    }

                    // adds all the strings together with a space in between
                    temp = string.Join(" ", stringArr);
                    Console.WriteLine(temp);

                    break;
            }
        }
    }
}

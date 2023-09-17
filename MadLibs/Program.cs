using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.SymbolStore;

// Niko Huber
// IGME 201
// 9-17-23
// MadLibs

namespace MadLibs
{
    internal class Program
    {

        // Niko Huber
        // IGME 201
        // 9-17-23
        // MadLibs

        static void Main(string[] args)
        {

            // begin input stream and initialize temp string and playing bool
            StreamReader input = null;
            bool? playing = null;
            string temp;

            while (playing == null) // check if playing
            {
                // welcome message and parsing
                Console.WriteLine("Would you like to play MadLibs?");
                temp = Console.ReadLine();

                if ((temp == "yes") || (temp == "Yes")) // if inputs are yes, play game. 
                {
                    while (input == null) // attempt to open input stream
                    {
                        try
                        {
                            input = new StreamReader("c://templates/MadLibsTemplate.txt");
                        }
                        catch
                        {
                            Console.WriteLine("Input File Invalid");
                        }
                    }

                    // counts the number of prompts in the initial text
                    int count = 0;
                    while (input.ReadLine() != null)
                    {
                        count += 1;
                    }

                    // creates array of count length and reinstates stream to re-read the text
                    string[] stringArr = new string[count];
                    input = new StreamReader("c://templates/MadLibsTemplate.txt");

                    // reads input text
                    for (int i = 0; i < count; i++)
                    {
                        stringArr[i] = input.ReadLine();
                    }

                    // variables for reading name and num inputs
                    int? num = null;
                    string name;

                    Console.WriteLine("Please enter your name:");
                    name = Console.ReadLine();

                    while ((num == null)) // input number parsing
                    {
                        Console.WriteLine("Please Enter a story number between 1 and " + count);
                        temp = Console.ReadLine();

                        try
                        {
                            num = Convert.ToInt32(temp);
                        }
                        catch
                        {
                            Console.WriteLine("Please enter an INTEGER");
                        }
                    }

                    // picks the text out of the array selected
                    string resultString = stringArr[num.Value - 1];

                    // splits the string into sub-strings
                    string[] subString;
                    subString = resultString.Split();

                    // sub-string manipulation
                    for (int i = 0; i < subString.Length; i++)
                    {
                        if (subString[i] == "\\n") // changing newlines
                        {
                            subString[i] = "\n";
                        }
                        subString[i] = subString[i].Replace('_', ' '); // replaces '_'

                        if (subString[i][0] == '{') // if the text is a user user inputted variable then process it
                        {
                            // replaces both { and }
                            subString[i] = subString[i].Replace('{', ' ');
                            subString[i] = subString[i].Replace('}', ':');

                            // prints a newline and a the given input substring
                            Console.WriteLine();
                            Console.WriteLine(subString[i]);

                            // reads user input
                            temp = Console.ReadLine();

                            // overwrites past input
                            subString[i] = temp; 
                        }
                        else
                        {
                            // if not a user inputted string, display string
                            Console.Write(subString[i] + " ");
                        }
                    }

                    // prints all the contents of the madlibs
                    for(int i = 0; i < subString.Length; i++)
                    {
                        Console.Write(subString[i] + " ");
                    }

                    Console.ReadLine(); // to pause the loop 
                }
                else if((temp == "no") || (temp == "No")) // breaks if user decides not to play madlibs
                {
                    Console.WriteLine("Goodbye.");
                    input.Close();
                    break;
                }
            }
        }
    }
}

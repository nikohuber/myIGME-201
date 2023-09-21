using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Niko Huber
// IGME 201
// 9-14-23
// Random Number Game

namespace ParsingAndFormatting
{

    // Niko Huber
    // IGME 201
    // 9-14-23
    // Random Number Game
    internal class Program 
    {
        static void Main(string[] args) 
        { 
            // random number assigning and printing
            Random rand = new Random();

            int randomNumber = rand.Next(0, 101);

            Console.WriteLine(randomNumber);

            // variables declaration
            string temp = null;
            int guess = -1; // out of scope of while loop but overwritten when num is parsed
            int i;

            for(i = 0; i < 8; i++) // allows for 8 tries
            {
                while (true) // while number is valid
                {

                    Console.WriteLine("Turn #" + (i + 1) + " : Enter your guess: ");
                    temp = Console.ReadLine();

                    try // parses to int
                    {
                        guess = Convert.ToInt32(temp);
                    }
                    catch // not convertable case
                    {
                        Console.WriteLine("Please enter an INTEGER");
                    }

                    if((guess >= 0) && (guess < 101)) // if number is valid
                    { 
                        break;
                    }

                    Console.WriteLine("Invalid Input: Try Again"); // if not valid error message
                }

                if(guess > randomNumber) // if too high
                {
                    Console.WriteLine("too high");
                }
                else if(guess < randomNumber) // if too low
                {
                    Console.WriteLine("too low");
                }
                else // breaks if correct
                {
                    break;
                }
            }
            if(i == 8) // if went through all 8 tries 
            {
                Console.WriteLine("You ran out of turns... The Number was: " + randomNumber);
            }
            else // message printed if won
            {
                Console.WriteLine("Correct! You won in " + (i + 1) + " turns.");
            }
        }
    }
}

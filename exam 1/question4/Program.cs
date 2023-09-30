using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


// Niko Huber
// Exam 1
// Timed Question Test
namespace question4
{
    // question4 - timed question test
    internal class Program
    {
        // global timer, outOfTime bool, and ans for printig in the timer elapsed event
        static Timer timer;
        static bool outOfTime = false;
        static string ans;

        // main 
        static void Main(string[] args)
        {
            // temp input
            string temp;

            // user ans and choice num
            string userAns;
            int choice;

            // bool for playing again
            bool again = true;
            while (again)
            {
                // start key for goto when getting user information
                Start:

                // reset loop exit status
                outOfTime = false;

                // ask for input num
                Console.WriteLine("Choose your question (1-3):");
                temp = Console.ReadLine();

                // parse input num
                try
                {
                    choice = Convert.ToInt32(temp);
                }
                catch
                {
                    Console.WriteLine("Please Enter an integer");
                    goto Start; // start over
                }

                if((choice > 3) || (choice < 1))
                {
                    Console.WriteLine("Please enter an integer BETWEEN 1 and 3");
                    goto Start; // start over
                }

                // display start message and the question given num input
                Console.WriteLine("You have 5 seconds to answer the following question:");
                switch (choice)
                {
                    case 1: // color
                        Console.WriteLine("What is your favorite color?");
                        ans = "black";
                        break;

                    case 2: // answer to life
                        Console.WriteLine("What is the answer to life, the universe and everything?");
                        ans = "42";
                        break;

                    case 3: // birds stats?
                        Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                        ans = "What do you mean? African or European swallow?";
                        break;

                }

                // while loop for waiting for user input or timer finish
                while (!outOfTime)
                {
                    // timer init
                    timer = new Timer(5000);
                    timer.Elapsed += new ElapsedEventHandler(NoTime);
                    timer.Start();

                    // wait for user input
                    userAns = Console.ReadLine();

                    // if user inputs stop timer
                    timer.Stop();

                    // if timer elapsed exit loop
                    if (outOfTime)
                    {
                        break;
                    }

                    // if not elapsed, compare input to answer
                    else if(userAns == ans)
                    {
                        Console.WriteLine("Well Done!");
                        break;
                    }

                    // if answer is wrong
                    else
                    {
                        Console.WriteLine("Wrong! " + " The answer is: " + ans);
                        break;
                    }
                }

                // play again?
                Console.WriteLine("Play again?");

                // if answer starts with n, stop program
                temp = Console.ReadLine();
                if (temp.ToLower().StartsWith("n"))
                {
                    again = false;
                }
            }
        }

        // Event when timer elapsed
        static void NoTime(object sender, ElapsedEventArgs e)
        {
            // print to console out
            Console.WriteLine();
            Console.WriteLine("Time's Up!");
            Console.WriteLine("The answer is: " + ans);
            Console.WriteLine("Please press Enter.");
            
            // set loop elapsed bool to exit loop
            outOfTime = true;

            // stop timer
            timer.Stop();
        }
    }
}

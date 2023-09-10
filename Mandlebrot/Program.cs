using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            // variable declatation- start and end values and temp string
            double? startX = null, endX = null;
            double? startY = null, endY = null;
            string temp;
            bool chosen = false;
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            while (!chosen) // iterates through inputs untill all elements are chosen
            {
                // reads the start x input
                Console.WriteLine("Please Enter an X start Value (default: 1.2)");
                temp = Console.ReadLine();
                try
                {
                    startX = Convert.ToDouble(temp);
                }
                catch
                {
                    Console.WriteLine("Please Enter a NUMBER");
                }

                // reads the end x input
                Console.WriteLine("Please Enter an X end Value less than the starting value(default: -1.2)");
                do
                {
                    temp = Console.ReadLine();
                    try
                    {
                        endX = Convert.ToDouble(temp);
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a NUMBER");

                    }
                }
                while (endX > startX); // compares if greater than start x

                // start y input
                Console.WriteLine("Please Enter an Y start Value (default: -0.6)");
                temp = Console.ReadLine();
                try
                {
                    startY = Convert.ToDouble(temp);
                }
                catch
                {
                    Console.WriteLine("Please Enter a NUMBER");
                }

                // end y input
                Console.WriteLine("Please Enter an Y end Value (default: 1.77)");
                do
                {
                    temp = Console.ReadLine();
                    try
                    {
                        endY = Convert.ToDouble(temp);
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a NUMBER");

                    }
                } while (endY < startY); // compares if end y is greater than start y

                // breaks if all values are inputted
                if((startX != null) && (endX != null) && (startY != null) && (endY != null))
                {
                    chosen = true; 
                }
            }

            // mandelbrot generation
            for (imagCoord = startX.Value; imagCoord >= startY.Value; imagCoord -= ((startX.Value + Math.Abs(endX.Value)) / 48)) // x value
            {
                for (realCoord = startY.Value; realCoord <= endY.Value; realCoord += ((Math.Abs(startY.Value) + endY.Value) / 80)) // y value
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;


// Niko Huber
// IGME 201
// Traffic
namespace Traffic
{

    // traffic
    internal class Program
    {
        // main (empty)
        static void Main(string[] args)
        {

        }

        // add passenger- of passengerCarrier interface 
        void AddPassenger(PassengerCarrier passenger)
        {

            // loads passenger
            passenger.LoadPassenger();

            // writes string of passenger
            Console.WriteLine(passenger.ToString());
        }
    }
}

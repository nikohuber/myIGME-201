using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Niko Huber
// IGME 201
// Vehicles
namespace Vehicles
{
    // Abstract Vehicle Class
    public abstract class Vehicle
    {

        // LoadPassenger
        public virtual void  LoadPassenger()
        {

        }
    }

    // PassengerCarrier interface
    public interface PassengerCarrier
    {
         void  LoadPassenger();

    }

    // HeavyLoadCarrier interface
    public interface HeavyLoadCarrier
    {

    }

    // Car
    public abstract class Car
    {

    }

    // Train
    public abstract class Train
    {

    }

    // Compact Car
    public class Compact : Car, PassengerCarrier
    {
        public virtual void LoadPassenger()
        {

        }

    }

    // SUV Car
    public class SUV: Car, PassengerCarrier
    {
        public virtual void LoadPassenger()
        {

        }

    }

    // Pickup Car
    public class Pickup : Car, HeavyLoadCarrier
    {

    }

    // Passenger Train
    public class PassengerTrain: Train, PassengerCarrier
    {
        public virtual void LoadPassenger()
        {

        }

    }

    // Freight Train
    public class FreightTrain: Train, HeavyLoadCarrier
    {

    }

    // DoubleBogey Train
    public class DoubleBogey: Train, HeavyLoadCarrier
    {

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public virtual void  LoadPassenger()
        {

        }
    }

    public interface PassengerCarrier
    {
         void  LoadPassenger();

    }

    public interface HeavyLoadCarrier
    {

    }

    public abstract class Car
    {

    }

    public abstract class Train
    {

    }

    public class Compact : Car, PassengerCarrier
    {
        public virtual void LoadPassenger()
        {

        }

    }

    public class SUV: Car, PassengerCarrier
    {
        public virtual void LoadPassenger()
        {

        }

    }

    public class Pickup : Car, HeavyLoadCarrier
    {

    }

    public class PassengerTrain: Train, PassengerCarrier
    {
        public virtual void LoadPassenger()
        {

        }

    }

    public class FreightTrain: Train, HeavyLoadCarrier
    {

    }

    public class DoubleBogey: Train, HeavyLoadCarrier
    {

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace question4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);
            

        }


        static void UsePhone(object obj)
        {

            PhoneInterface phoneInterface = (PhoneInterface)obj;
            phoneInterface.MakeCall();
            phoneInterface.HangUp();

            if(phoneInterface.GetType() == typeof(PhoneBooth))
            {
                PhoneBooth phoneBooth = (PhoneBooth)phoneInterface;
                phoneBooth.OpenDoor();
                phoneBooth.CloseDoor();
            }
        }

        public class Tardis : RotaryPhone
        {
            private bool sonicScrewdriver;
            private byte whichDrWho;
            private string femaleSideKick;
            public double exteriorSurfaceArea;
            public double interiorVolume;

            public static bool operator ==(Tardis tardis1, Tardis tardis2)
            {

                return (tardis1 == tardis2);
            }
            public static bool operator !=(Tardis tardis1, Tardis tardis2)
            {
                return (tardis1 != tardis2);
            }

            public static bool operator >=(Tardis tardis1, Tardis tardis2)
            {
                if(tardis1.whichDrWho == 10)
                {
                    return true;
                }
                else
                {
                    return (tardis1 >= tardis2);
                }
            }
            public static bool operator <=(Tardis tardis1, Tardis tardis2)
            {
                return (tardis1 <= tardis2);
            }

            public static bool operator >(Tardis tardis1, Tardis tardis2)
            {
                if (tardis1.whichDrWho == 10)
                {
                    return true;
                }
                else
                {
                    return (tardis1 > tardis2);
                }
            }
            public static bool operator <(Tardis tardis1, Tardis tardis2)
            {
                return (tardis1 > tardis2);
            }

            public byte WhichDrWho
            {
                get
                {
                    return WhichDrWho;
                }
                set
                {
                    whichDrWho = value;
                }
            }

            public string FemaleSideKick
            {
                get
                {
                    return FemaleSideKick;
                }
            }

            public void TimeTravel()
            {

            }
        }

        public class RotaryPhone : Phone, PhoneInterface
        {
            public void Answer()
            {

            }
            public void MakeCall()
            {

            }
            public void HangUp()
            {

            }

            public override void Connect()
            {

            }

            public override void Disconnect()
            {

            }

        }

        public abstract class Phone
        {
            private string phoneNumber;
            public string address;
            public string PhoneNumber;

            public abstract void Connect();
            public abstract void Disconnect();
        }

        public interface PhoneInterface
        {
            void Answer();
            void MakeCall();
            void HangUp();

        }

        public class PushButtonPhone : Phone, PhoneInterface
        {
            public void Answer()
            {

            }
            public void MakeCall()
            {

            }
            public void HangUp()
            {

            }
            public override void Connect()
            {

            }
            public override void Disconnect()
            {

            }
        }

        public class PhoneBooth : PushButtonPhone
        {
            private bool superMan;
            public double costPerCall;
            public bool phoneBook;

            public void OpenDoor()
            {

            }
            public void CloseDoor()
            {

            }
        }
    }
}

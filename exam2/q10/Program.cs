using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DJing djing = new DJing();
            VJing vjing = new VJing();

            Performance(djing);
            Performance(vjing);

        }

        static void Performance(object obj)
        {

            LiveMusicPerformance performer = (LiveMusicPerformance)obj;

            performer.Perform();
            performer.Leave();

            if(performer.GetType() == typeof(DJing))
            {
                IDJ iDJ = (IDJ)performer;
                iDJ.PlayLouder();

            }

            if (performer.GetType() == typeof(VJing))
            {
                IVJ iVJ = (IVJ)performer;
                iVJ.StrobeLights();

            }


        }

        public abstract class LiveMusicPerformance
        {
            public abstract void Perform();

            public virtual void Leave()
            {

            }

            public string date;
            public string venue;
        }

        public class DJing : LiveMusicPerformance, IDJ
        {
            public string controllerType;
            public string genre;
            public int skillAbility;

            public override void Perform()
            {

                Console.WriteLine("wub wub wub wub");

            }

            public void PlayLouder()
            {

                Console.WriteLine("WUB WUB WUB WUB");

            }

        }

        public class VJing : LiveMusicPerformance, IVJ
        {
            public string laptopType;
            public int outputResolution;
            public bool projectionMapping;

            public override void Perform()
            {

                Console.WriteLine("blend lights, adjust colors");
                
            }
            public void StrobeLights()
            {

                Console.WriteLine("FLASHING STROBESSSS");

            }
        }

        public interface IDJ
        {
            void PlayLouder();

        }

        public interface IVJ
        {
            void StrobeLights();
        }
    }
}

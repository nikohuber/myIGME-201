using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Niko Huber
// IGME 201
// 10-19-23
// Classy

namespace Classy
{
    // Program
    internal class Program
    {
        // main
        static void Main(string[] args)
        {
            // class init
            Classy class1 = new Class1();
            Classy class2 = new Class2();

            // call MyMethod
            MyMethod(class1);
            MyMethod(class2);



        }

        // takes a Classy object and calls the interface method
        public static void MyMethod(object Classy)
        {

            IClass iclass = (IClass)Classy;

            iclass.Method();

        }

        // Classy object
        public abstract class Classy
        {

            // private string
            private string temp;

            // public get/set string
            public string Temp
            {

                get
                {
                    return temp;
                }
                set
                {
                    temp = value;
                }

            }
        }

        // Class1
        public class Class1 : Classy, IClass
        {
            // method
            public void Method()
            {

                Console.WriteLine("eeeee");

            }

        }

        // Class2
        public class Class2 : Classy, IClass
        {
            // method
            public void Method()
            {
                Console.WriteLine("aaaa");
            }

        }

        // interface class
        public interface IClass
        {
            void Method();

        }
    }
}

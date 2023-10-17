using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyDerivedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDerivedClass myDerivedClass = new MyDerivedClass();

        }
    }
    public class MyClass{

        public virtual string GetString() {

            return MyString;

        }


        private string myString;

        public string MyString
        {
            get
            {
                return myString;
            }
            set
            {
                myString = value;
            }
        }
		
    }

    public  class MyDerivedClass : MyClass
    {
        public override string GetString()
        {


            return ($"(output from the derived class) {MyString}");

        }

    }
 }


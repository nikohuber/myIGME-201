using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;


// Niko Huber
// IGME 201
// 10-16-23
// MoreClasses 

namespace MoreClasses
{
    // pe 13
    internal class Program
    {
        // calling main items and populating list
        static void Main(string[] args)
        {
            // null variables
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            // create new pets list
            Pets pets = new Pets();

            // random setup
            Random rand = new Random();

            // temp variables 
            string name, temp, license;
            int age = 0;

            // iterates through 50 actions
            for(int i = 0; i < 50; i++)
            {
                // if random from 1-10
                if (rand.Next(1, 11) == 1)
                {
                    // 50% chance for cat
                    if (rand.Next(0, 2) == 0)
                    {
                        // add new Cat to the list and make that new cat the current thisPet
                        cat = new Cat();
                        pets.Add(cat);
                        thisPet = pets[pets.count - 1];

                        // naming and variable input fun stuff :)
                        Console.WriteLine("You got a new cat!");
                        Console.WriteLine("What will you name them?");
                        name = Console.ReadLine();

                        thisPet.Name = name;

                        Console.WriteLine("How old are they?");
                        temp = Console.ReadLine();

                        try
                        {
                            age = Convert.ToInt32(temp);
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a number");
                        }

                        thisPet.age = age;


                    }
                    // if not cat then dog
                    else
                    {
                        // naming and variable input fun stuff :)
                        Console.WriteLine("You got a new dog!");
                        Console.WriteLine("What will you name them?");
                        name = Console.ReadLine();

                        Console.WriteLine("How old are they?");
                        temp = Console.ReadLine();

                        try
                        {
                            age = Convert.ToInt32(temp);
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a number");
                        }

                        Console.WriteLine("What is their license number?");
                        license = Console.ReadLine();

                        // creates and adds new dog to the list, indexes thisPet
                        dog = new Dog(license, name, age);
                        pets.Add(dog);
                        thisPet = pets[pets.count - 1];
                    }
                }
                // skips if there is no pet in list
                if (thisPet == null)
                {
                    continue;
                }
                // if no new pet was created, picks a random action from a pet
                else
                {
                    thisPet = pets[rand.Next(0, pets.count)];
                }

                // if dog
                if (thisPet.GetType() == typeof(Dog))
                {
                    // set interface and call output function
                    iDog = (IDog)thisPet;
                    Console.Write(thisPet.Name + ": ");
                    switch (rand.Next(0, 5))
                    {
                        case (0):
                            iDog.Eat();
                            break;
                        case (1):
                            iDog.Play();
                            break;
                        case (2):
                            iDog.Bark();
                            break;
                        case (3):
                            iDog.GotoVet();
                            break;
                        case (4):
                            iDog.NeedWalk();
                            break;
                    }
                }
                // if cat
                else
                {
                    // set interface and call output function
                    iCat = (ICat)thisPet;
                    Console.Write(thisPet.Name + ": ");
                    switch (rand.Next(0, 5))
                    {
                        case (0):
                            iCat.Purr();
                            break;
                        case (1):
                            iCat.Eat();
                            break;
                        case (2):
                            iCat.Play();
                            break;
                        case (3):
                            iCat.GotoVet();
                            break;
                        case (4):
                            iCat.Scratch();
                            break;
                    }

                }
                
            }

        }
    }

    // cat interface
    public interface ICat
    {
        void Eat();


        void Play();

        void Scratch();

        void Purr();

        void GotoVet();

    }

    // pets container class
    public class Pets
    {

        // list
        List<Pet> petList = new List<Pet>();


        // indexer for list
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }


        public int count { 
            get { return petList.Count; }
        }

        public void Add(Pet pet)
        {

            petList.Add(pet);

        }

        public void Remove(Pet pet)
        {

            petList.Remove(pet);

        }

        public void RemoveAt(int petEl)
        {

            petList.RemoveAt(petEl);

        }

    }

    // individual pet class
    public abstract class Pet
    {

        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        private string name;

        public int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public abstract void Eat();

        public abstract void Play();

        public abstract void GotoVet();

    }

    // dog interface
    public interface IDog
    {

        void Eat();

        void Play();

        void Bark();

        void NeedWalk();

        void GotoVet();

    }

    // cat class
    public class Cat : Pet, ICat
    {

        public Cat()
        {

        }

        public override void Eat()
        {
            Console.WriteLine("om nom nom nom");
        }

        public override void Play()
        {
            Console.WriteLine("much catch laser must catch shiny light");
        }

        public void Purr()
        {
            Console.WriteLine("purrrrrrrrrrrrrrrrrrrrrrrrrrrrrr");
        }

        public void Scratch()
        {
            Console.WriteLine("scritch-scratch-scritch-scratch");
        }

        public override void GotoVet()
        {
            Console.WriteLine("NO NOT THE VET PLZ ANYTHING BUT THE VET");

        }

    }

    // dog class
    public class Dog : Pet, IDog
    {

        public Dog(string szLicense, string szName, int nAge)
        {
            this.license = szLicense;
            this.Name = szName;
            this.age = nAge;

        }

        public string license;

        public override void Eat()
        {

            Console.WriteLine("om nom nom nom");

        }

        public override void Play()
        {
            Console.WriteLine("fetch, bring back ball, fetch! bring back ball");
        }

        public void Bark()
        {
            Console.WriteLine("WOOF");
        }

        public void NeedWalk()
        {
            Console.WriteLine("plz plz plz can we go outside");
        }

        public override void GotoVet()
        {
            Console.WriteLine("NO NOT THE VET PLZ ANYTHING BUT THE VET");
        }


    }
}

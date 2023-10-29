using System;

// Niko Huber
// Exam 2
// IGME 201
namespace StructToClass
{
    // friend class
    public class Friend : ICloneable
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;

        // clone!
        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    // main
    class Program
    {

        // main cont
        static void Main(string[] args)
        {
            // create new class objects
            Friend friend = new Friend();
            Friend enemy = new Friend();

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            // clone friend
            enemy = (Friend)friend.Clone();

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}

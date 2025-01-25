/*
    polymorphism: Allows objects to be identified by more than one type. 
*/

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate array of Vehicle objects
            Vehicle[] vehicles = { new Car(), new Bicycle(), new Boat() };

            // Loop through Vehicle objects and call go method
            foreach (var vehicle in vehicles)
            {
                vehicle.go();
            }
        }
    }

    abstract class Vehicle
    {
        public abstract void go();
    }

    class Car : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The car drives");
        }
    }

    class Bicycle : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The bicycle cycles");
        }
    }

    class Boat : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The boat sails");
        }
    }
}
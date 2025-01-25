/*
    interface: A completely abstract class which can only contain abstract methods
               and properties. It is common practice to prefix iterface names with
               an 'I'.
*/

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate array of Vehicle objects
            IVehicle[] vehicles = { new Car(), new Bicycle(), new Boat() };

            // Loop through Vehicle objects and call go method
            foreach (var vehicle in vehicles)
            {
                vehicle.go();
            }
        }

        // Define interface
        interface IVehicle
        {
            public void go();
        }

        class Car : IVehicle
        {
            public void go()
            {
                Console.WriteLine("The car drives");
            }
        }

        class Bicycle : IVehicle
        {
            public void go()
            {
                Console.WriteLine("The bicycle cycles");
            }
        }

        class Boat : IVehicle
        {
            public void go()
            {
                Console.WriteLine("The boat sails");
            }
        }
    }
}

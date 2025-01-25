/*
    inheritance: Allows a class to inherit fields and methods from a parent class.
*/

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Car object
            Car car = new Car();

            // Print inherited field and call inherited method
            Console.WriteLine("Car speed: " + car.speed);
            car.go();

            // Print non-inherited field
            Console.WriteLine("Car number of wheels: " + car.wheels);   
        }
    }

    // Parent class
    class Vehicle
    {
        public int speed = 10;

        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    // Child class
    class Car : Vehicle
    {
        public int wheels = 4;
    }
}

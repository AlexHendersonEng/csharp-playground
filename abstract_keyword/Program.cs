/*
    abstract: A keyword used for classes and methods. An abstract class is a restricted
              class that cannot be used to create objects (to access it, it must be
              inherited from another class). An abstract method can only be used in an
              abstract class and does not have any body. The body is provided by the 
              derived class.
*/

namespace abstract_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Car object (cannot instantiate Vehicle object as
            // it is abstract)
            Car car = new Car();

            // Print inherited field and call inherited method
            Console.WriteLine("Car speed: " + car.speed);
            car.hello();

            // Call overriden go method on Car object
            car.go();
        }
    }

    // Define abstract class
    abstract class Vehicle
    {
        public int speed = 0;

        public void hello()
        {
            Console.WriteLine("Hello I am a vehicle");
        }

        // Declare abstract method
        public abstract void go();
    }

    // Inherit from abstract class
    class Car : Vehicle 
    {
        // Define body for abstract method
        public override void go()
        {
            Console.WriteLine("The car drives");
        }
    }
}
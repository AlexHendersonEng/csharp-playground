/*
    virtual: Used to modify a method and allow for it to be overridden in 
             a derived class.
*/

namespace virtual_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Animal and Dog objects
            Animal animal = new Animal();
            Dog dog = new Dog();

            // Call speak methods
            animal.speak();
            dog.speak();
        }
    }

    // Parent class
    class Animal
    {
        // Define virtual method that can be overriden in derived classes
        public virtual void speak()
        {
            Console.WriteLine("The animal goes grr");
        }
    }

    // Child class
    class Dog : Animal
    {
        // Override virtual method in parent class
        public override void speak() {
            Console.WriteLine("The dog goes bark");
        }
    }
}

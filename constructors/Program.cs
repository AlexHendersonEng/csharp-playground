/*
    constructor: A method named the same as the class name that is called on object instantiation.
*/

namespace constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Person object (uses constructor)
            Person person = new Person("Bob");

            // Print Person field
            Console.WriteLine($"Person name: {person.name}");

            // Call Person method
            person.sayHello();
        }

        // Person class
        class Person
        {
            // field
            public string name;

            // constructor
            public Person(string name)
            {
                this.name = name;
            }

            // method
            public void sayHello()
            {
                Console.WriteLine($"{name} says hello");
            }
        }
    }
}

namespace objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Person object
            Person person = new Person();
            person.name = "Bob";

            // Print Person field
            Console.WriteLine($"Person name: {person.name}");

            // Call Person method
            person.sayHello();

            // Instantiate Animal object
            Animal animal = new Animal();

            // Print Animal field
            Console.WriteLine($"Animal alive: {animal.alive}");

            // Call Animal method
            animal.run();
        }
    }

    // Person class
    class Person
    {
        // member
        public string name;

        // method
        public void sayHello()
        {
            Console.WriteLine($"{name} says hello");
        }
    }
}

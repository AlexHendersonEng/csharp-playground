/*
    static: Modifier which can be applied to classes, fields and methods. A static 
            class can only can only contain static fields and methods. Static fields
            and methods are owned by the class so do not require an object instance to
            be called.
*/

namespace static_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create people
            Person person1 = new Person("Bob");
            Person person2 = new Person("Fred");
            Person person3 = new Person("Wendy");

            // Print out static field
            Console.WriteLine("Number of people: " + Person.numberOfPeople);

            // Call static method
            Person.race();
        }
    }

    // Person class
    class Person
    {
        // fields
        public string name;
        public static int numberOfPeople = 0; // static field owned by class

        // constructor
        public Person(string name)
        {
            this.name = name;
            numberOfPeople++;
        }

        // methods
        public void sayHello()
        {
            Console.WriteLine($"{name} says hello");
        }

        public static void race() // static method owned by class
        {
            Console.WriteLine(numberOfPeople + " people race");
        }
    }
}

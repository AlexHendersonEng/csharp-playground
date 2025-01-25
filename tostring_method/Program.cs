/*
    ToString method: Converts an object to its string representation.
*/

namespace tostring_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate person method
            Person person = new Person("Bob", "Fred");

            // Print object (implicitly calls ToString method)
            Console.WriteLine(person);
        }
    }

    class Person
    {
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Override ToString method
        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}

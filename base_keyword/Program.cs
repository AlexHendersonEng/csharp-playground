/*
    base: Used to access members of the parent class from within a
          base class.
*/

namespace base_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee object
            Employee employee = new Employee("Bob", "Fred", 1e6);

            // Print out employee object (implicitly calls ToString method)
            Console.WriteLine(employee);
        }
    }

    // Define parent class
    class Person
    {
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }

    // Define child class
    class Employee : Person
    {
        public double salary;

        // Call base class contructor
        public Employee(string firstName, string lastName, double salary) : base(firstName, lastName)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            // Use base class ToString method
            return base.ToString() + " " + this.salary;
        }
    }
}

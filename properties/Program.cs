/*
    property: A field with 'get' and 'set' methods. If using property to access a
              private variable it is best practice to use the same name for both but
              with the property using an uppercase first letter.
*/

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Person object
            Person person = new Person();

            // Assign properties
            person.Name = "Bob";
            person.Age = 25;

            // Print properties
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }

        class Person
        {
            // Define field
            private string name; 

            // Define property
            public string Name
            {
                get 
                {
                    Console.WriteLine("Getting property");
                    return name;
                } // get method
                set 
                {
                    Console.WriteLine("Setting property");
                    name = value;
                } // set method
            }

            // Define automatic property
            public int Age { get; set; }
        }
    }
}

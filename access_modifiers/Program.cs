/*
    access_modifiers: Used to set the access level/visibilty for classes, fields,
                      methods and properties.

    public: The code is accessible for all classes.

    private: The code is only accessible within the same class.

    protected: The code is accessible within the same class or in a class that is 
               inherited form that class.

    internal: The code is only accessible within its own assembly but not from another
              assembly.
*/

namespace access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Subclass object
            Subclass subclass = new Subclass();

            // Print out accessible fields in Subclass object
            Console.WriteLine("Public property a: " + subclass.a);
            Console.WriteLine("Internal property d: " + subclass.d);
        }

        class Class
        {
            // Public field accessible by all classes
            public int a = 1;

            // Private field accessible only within this class
            private int b = 2;

            // Protected field accessible within this class and derived classes
            protected int c = 3;

            // Internal field accesible within its own assembly
            internal int d = 4; 

        }

        class Subclass : Class { }
    }
}

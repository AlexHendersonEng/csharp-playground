/*
    using: The using statment defines a scope at the end of which an object is
           disposed. The using directive creates an alias for a namespace or imports
           types defined in other namespaces.
*/

// Imports types defined in other namespaces
using System;
using System.IO;

namespace using_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write to a file
            using (StreamWriter writer = new StreamWriter("example.txt"))
            {
                writer.WriteLine("Hello, world!");
            }

            // Read from the file
            using (StreamReader reader = new StreamReader("example.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}

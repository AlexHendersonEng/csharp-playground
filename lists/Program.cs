/*
    lists: A data structure that represents a list of objects that can be accessed
           by an index. It is similar to an array but can dynamically increase/decrease
           in size.
*/

// Import List definition which sits in 'System.Collections.Generic'
using System.Collections.Generic;

namespace lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define list
            List<string> list = new List<string>();

            // Add strings to list
            list.Add("a");
            list.Add("b");
            list.Add("c");

            // Print out strings
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

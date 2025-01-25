/*
    generic: Allows for data types for a class or class member to be defined at
             compile time using the '<T>' syntax. In addition the 'where' keyword
             can be used to constrain the type.
*/

namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define array
            int[] ints = { 1, 2, 3 };
            double[] doubles = { 1.0, 2.0, 3.0 };
            string[] strings = { "1", "2", "3" };

            // Use generic method to print arrays
            Console.WriteLine("Integers:");
            displayElements<int>(ints);
            Console.WriteLine("Doubles:");
            displayElements<double>(doubles);
            Console.WriteLine("Strings:");
            displayElements<string>(strings);
        }

        // Define generic displayElements method with type constraint
        public static void displayElements<T>(T[] array) where T : notnull
        {
            foreach (T element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}

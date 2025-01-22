/*
    foreach loop: A simpler way to iterate over an array 
*/

namespace foreach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define array
            int[] integers = { 1, 2, 3, 4, 5 };

            // Iterate over and print array values with standard foor loop
            Console.WriteLine("Standard for loop:");
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine(integers[i]);
            }

            // Iterate over and print array values using foreach loop
            Console.WriteLine("foreach loop:");
            foreach (int i in integers)
            {
                Console.WriteLine(i);
            }
        }
    }
}

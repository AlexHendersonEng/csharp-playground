/*
    var: Used to declare an implicit type variable.
*/

namespace var_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define variables using var keyword
            var a = 1;
            var b = 2.0;
            var c = "Hello";

            // Print out values
            Console.WriteLine("Variable a: " + a + ", Type: " + a.GetType());
            Console.WriteLine("Variable b: " + b + ", Type: " + b.GetType());
            Console.WriteLine("Variable c: " + c + ", Type: " + c.GetType());
        }
    }
}

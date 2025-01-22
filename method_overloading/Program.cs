/*
    method overloading: Allows methods to have the same name but with different parameters and return types.
*/

namespace method_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call add method with integers
            int res1 = add(1, 2);
            Console.WriteLine("Overloaded add method for integers: " + res1);

            // Call add method with doubles
            double res2 = add(1.5, 2.6);
            Console.WriteLine("Overloaded add method for doubles: " + res2);
        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static double add(double a, double b)
        {
            return a + b;
        }
    }
}

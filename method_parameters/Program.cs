namespace method_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call add method with default arguments
            int res1 = add();
            Console.WriteLine("Default arguments: " + res1);

            // Call add method with positional arguments
            int res2 = add(4, 5, 6);
            Console.WriteLine("Positional arguments: " + res2);

            // Call add method with named arguments
            int res3 = add(z: 7, y: 8, x: 9);
            Console.WriteLine("Named arguments: " + res3);
        }

        static int add(int x = 1, int y = 2, int z = 3)
        {
            return x + y + z;
        }
    }
}

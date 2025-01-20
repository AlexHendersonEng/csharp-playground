namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and then assign variable
            int x;
            x = 10;
            System.Console.WriteLine("Variable declared then assigned: " + x);

            // Declare and assign variable
            int y = 20;
            System.Console.WriteLine("Variable declared and assigned: " + y);

            // Initialise multiple variables on one line
            int a = 1, b = 2, c = 3;
            System.Console.WriteLine("Multiple variable initialisation: a = " + a + ", b = " + b + ", c = " + c);
        }
    }
}

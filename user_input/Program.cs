namespace user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user for name
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            // Print message to user using user input
            Console.WriteLine("Hello " + name);
        }
    }
}

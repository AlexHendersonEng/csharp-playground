/*
    String interpolation: Allows for the substitution of variables into placeholders in a string.  
*/

namespace string_interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "First";
            string lastName = "Last";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
        }
    }
}

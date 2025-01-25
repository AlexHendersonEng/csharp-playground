/*
    lambda expressions: Allows for the creation of an anonymous function using the
                        lambda declaration operator '=>'.
*/

namespace lambda_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare lambda function
            Func<int, int> squaredNumbers = x => x * x;

            // Use and print out result of lambda function
            Console.WriteLine(squaredNumbers(4));
        }
    }
}
/*
    const: A keyword used in front of the variable type which declares a variable
           as constant meaning it is unchangeable and read only.
*/ 

namespace constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define constant variable
            const int constVar = 10;
            System.Console.WriteLine("Constant variable: " + constVar);
        }
    }
}

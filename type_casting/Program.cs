/*
    type casting: The process of assigning a value of one data type to another data type. 
*/

namespace type_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit casting
            int a = 9;
            double b = a;
            Console.WriteLine("int implicitly casted to a double: " + b);

            // Explicit casting
            double c = 3.45;
            int d = (int)c;
            Console.WriteLine("double explicitly casted to a int: " + d);

            // Type conversion method casting
            int e = 1;
            bool f = Convert.ToBoolean(e);
            Console.WriteLine("int casted to a bool using type conversion method: " + f);
        }
    }
}

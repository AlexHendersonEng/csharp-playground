namespace operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Number objects
            Number n1 = new Number(1);
            Number n2 = new Number(2);

            // Add numbers using overloaded operator
            int res = n1 + n2;

            // Print result
            Console.WriteLine(res);
        }

        class Number
        {
            public int value;

            public Number(int value)
            {
                this.value = value;
            }

            // Overload addition operator
            public static int operator +(Number n1, Number n2)
            {
                return n1.value + n2.value;
            }
        }
    }
}

namespace params_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call sum_elements method
            double res = sum_elements(1.1, 2.2, 3.3, 4.4, 5.5);
            Console.WriteLine(res);
        }

        static double sum_elements(params double[] a)
        {
            return a.Sum();
        }
    }
}

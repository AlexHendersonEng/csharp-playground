namespace exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try // Execute block of code that might throw an exception
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e) // Execute code if exception occurs
            { 
                Console.WriteLine("Exeception has occured");
                Console.WriteLine(e.ToString());
            }
            finally // Execute code whether exception occurs or not
            {
                Console.WriteLine("This is always executed!");
            }
        }
    }
}

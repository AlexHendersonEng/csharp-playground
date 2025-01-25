/*
    enums: A special class that contains a set of named integer constants.
*/

namespace enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print enumeration information
            Console.WriteLine(Weekdays.Monday + " is a weekday");
            Console.WriteLine(Weekdays.Tuesday + " has value " + (int)Weekdays.Tuesday);
        }
    }

    // Define enumeration (default numbering starts at 0 but can be explicitly defined)
    enum Weekdays
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5
    }
}

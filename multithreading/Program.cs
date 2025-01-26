/*
    thread: An execution path of a program.

    multithreading: Using multiple threads to perform different tasks within a program
                    concurrently.
*/

using System;
using System.Threading;

namespace multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define and start threads
            Thread thread1 = new Thread(() => countUp());
            thread1.Start();
            Thread thread2 = new Thread(() => countDown());
            thread2.Start();
        }

        static void countUp()
        {
            Console.WriteLine("Timer 1 started!");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer 1: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timeer 1 finished!");
        }

        static void countDown()
        {
            Console.WriteLine("Timer 2 started!");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer 2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timeer 2 finished!");
        }
    }
}
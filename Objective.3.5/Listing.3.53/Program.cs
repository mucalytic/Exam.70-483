using System;
using System.Diagnostics;

namespace Listing_3_53
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press Esc to stop");

            using (var performanceCounter = new PerformanceCounter("Memory", "Available Bytes"))
            {
                const string text = "Available Memory: ";

                Console.Write(text);

                do
                {
                    while (!Console.KeyAvailable)
                    {
                        Console.Write(performanceCounter.RawValue);
                        Console.SetCursorPosition(text.Length, Console.CursorTop);
                    }
                }
                while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
        }
    }
}

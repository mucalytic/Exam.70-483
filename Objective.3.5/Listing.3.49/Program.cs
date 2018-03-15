using System;
using System.Diagnostics;

namespace Listing_3_49
{
    public class Program
    {
        private static string TestSource => nameof(TestSource);

        private static string TestLog => nameof(TestLog);

        public static void Main(string[] args)
        {
            if (!EventLog.SourceExists(TestSource))
            {
                EventLog.CreateEventSource(TestSource, TestLog);
            }

            using (var log = new EventLog { Source = TestSource })
            {
                log.WriteEntry("Test log event!");
            }

            Console.ReadKey();
        }
    }
}

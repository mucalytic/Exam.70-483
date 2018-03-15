using System;
using System.Diagnostics;
using System.IO;

namespace Listing_3_47
{
    public class Program
    {
        // configuring TraceListener
        public static void Main(string[] args)
        {
            using (var stream = File.Create("trace.txt"))
            using (var listener = new TextWriterTraceListener(stream))
            {
                var source = new TraceSource("Test Trace", SourceLevels.All);

                source.Listeners.Clear();
                source.Listeners.Add(listener);
                source.TraceInformation("Blah");
                source.Flush();
                source.Close();
            }

            Console.ReadKey();
        }
    }
}

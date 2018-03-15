using System;
using System.Diagnostics;

namespace Listing_3_54
{
    public class Program
    {
        private static string OperationsPerSecond => "# operations / second";

        private static string OperationsExecuted => "# operations executed";

        private static string TestCategory => nameof(TestCategory);

        public static void Main(string[] args)
        {
            if (!PerformanceCounterCategory.Exists(TestCategory))
            {
                PerformanceCounterCategory.Create(TestCategory, "Test Category", PerformanceCounterCategoryType.SingleInstance, new CounterCreationDataCollection
                {
                    new CounterCreationData(OperationsPerSecond, "Number of operations executed per second", PerformanceCounterType.RateOfCountsPerSecond32),
                    new CounterCreationData(OperationsExecuted, "Total number of operations executed", PerformanceCounterType.NumberOfItems32)
                });
            }

            var operationsPerSecondCounter = new PerformanceCounter(TestCategory, OperationsPerSecond, string.Empty, false);
            var totalOperationsCounter = new PerformanceCounter(TestCategory, OperationsExecuted, string.Empty, false);

            Console.WriteLine("Press Esc to stop");

            do
            {
                while (!Console.KeyAvailable)
                {
                    totalOperationsCounter.Increment();
                    operationsPerSecondCounter.Increment();
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

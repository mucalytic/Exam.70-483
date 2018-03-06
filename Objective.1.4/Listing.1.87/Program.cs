using System;
using System.Collections.Generic;
using System.Linq;

namespace Listing_1_87
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pub = new Pub();

            pub.OnChange += (s, a) => Console.WriteLine("Subscriber 1 called");
            pub.OnChange += (s, a) => throw new Exception();
            pub.OnChange += (s, a) => Console.WriteLine("Subscriber 3 called");

            try
            {
                pub.Raise();
            }
            catch (AggregateException exception)
            {
                Console.WriteLine(exception.InnerExceptions.Count);
            }

            Console.ReadKey();
        }
    }

    public class Pub
    {
        public event EventHandler OnChange;

        public void Raise()
        {
            var exceptions = new List<Exception>();

            foreach (var handler in OnChange?.GetInvocationList() ?? new Delegate[] {})
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch (Exception exception)
                {
                    exceptions.Add(exception);
                }
            }

            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}

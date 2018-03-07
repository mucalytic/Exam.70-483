using System;

namespace Listing_2_24
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var money = new Money(12.5m);
            decimal whole = money;
            var rounded = (int)money;

            Console.WriteLine($"{whole} {rounded}");
            Console.ReadKey();
        }

        public class Money
        {
            public decimal Amount { get; set; }

            public static implicit operator decimal(Money money)
            {
                return money.Amount;
            }

            public static explicit operator int(Money money)
            {
                return (int)money.Amount;
            }

            public Money(decimal amount)
            {
                Amount = amount;
            }
        }
    }
}

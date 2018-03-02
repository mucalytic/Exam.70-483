using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Listing_1_22
{
    [TestClass]
    public class UnitTest
    {
        // using AsParallel
        [TestMethod]
        public void TestMethod1()
        {
            var result =
                Enumerable
                    .Range(0, 100_000_000)
                    .AsParallel()
                    .Where(i => i % 2 == 0)
                    .ToArray();

            Assert.AreEqual(result.Length, 50_000_000);
        }
    }
}

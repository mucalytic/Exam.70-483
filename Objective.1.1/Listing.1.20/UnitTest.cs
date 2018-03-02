using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Listing_1_20
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var id = Thread.CurrentThread.ManagedThreadId;

            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync("http://www.microsoft.com");
            }

            Assert.AreEqual(id, Thread.CurrentThread.ManagedThreadId);
        }

        [TestMethod]
        public async Task TestMethod2()
        {
            var id = Thread.CurrentThread.ManagedThreadId;

            using (var client = new HttpClient())
            {
                await client
                    .GetStringAsync("http://www.microsoft.com")
                    .ConfigureAwait(false);
            }

            Assert.AreNotEqual(id, Thread.CurrentThread.ManagedThreadId);
        }
    }
}

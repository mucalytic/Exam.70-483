using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Listing_1_21
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            string content;

            using (var client = new HttpClient())
            {
                content = await client.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);
            }

            using (var stream = new FileStream("temp.html", FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
            {
                var bytes = Encoding.Unicode.GetBytes(content);

                await stream.WriteAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
            }
        }
    }
}

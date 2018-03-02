using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_19
{
    public class Program
    {
        // scalability vs. responsiveness
        public static void Main(string[] args) { }

        private Task SleepAsyncA(TimeSpan timeout)
        {
            return Task.Run(() => Thread.Sleep(timeout));
        }

        private Task SleepAsyncB(TimeSpan timeout)
        {
            TaskCompletionSource<bool> source = null;
            var timer = new Timer(o => source.TrySetResult(true), null, -1, -1);
            source = new TaskCompletionSource<bool>(timer);
            timer.Change(Convert.ToInt32(timeout.TotalMilliseconds), -1);
            return source.Task;
        }
    }
}

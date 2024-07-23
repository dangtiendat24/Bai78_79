using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Bắt đầu chương trình.");

        // Phần 1: Sử dụng Thread
        var thread = new Thread(() =>
        {
            Console.WriteLine("Thread bắt đầu.");
            Thread.Sleep(1000); // Chặn thread trong 1 giây
            Console.WriteLine("Thread kết thúc.");
        });

        thread.Start();
        thread.Join(); // Đợi thread hoàn thành

        Console.WriteLine("Đã hoàn thành thread.");

        // Phần 2: Sử dụng Async/Await
        Task asyncTask = AsyncExample();

        asyncTask.Wait(); // Đợi async hoàn thành

        Console.WriteLine("Đã hoàn thành async.");

        Console.WriteLine("Kết thúc chương trình.");
    }

    public static async Task AsyncExample()
    {
        Console.WriteLine("Async bắt đầu.");
        await Task.Delay(1000); // Không chặn thread
        Console.WriteLine("Async kết thúc.");
    }
}

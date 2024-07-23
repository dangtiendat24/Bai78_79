using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Tạo một thread mới và gán phương thức DoWork để thực thi
        Thread thread = new Thread(new ThreadStart(DoWork));
        thread.Start();

        // Main thread tiếp tục chạy
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main thread: " + i);
            Thread.Sleep(100); // Tạm dừng main thread trong 100ms
        }

        // Chờ cho worker thread hoàn tất
        thread.Join();
    }

    static void DoWork()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Worker thread: " + i);
            Thread.Sleep(100); // Tạm dừng worker thread trong 100ms
        }
    }
}
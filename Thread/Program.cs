
#region IsBackground
//int i = 10;
//Thread thread = new Thread(() =>
//{
//    while (i >= 0)
//    {
//        i--;
//        Thread.Sleep(1000);
//    };
//    Console.WriteLine($"Worker Thread completed.");
//});

//thread.IsBackground = false; // if IsBackground is true,it works on background and main thread does not wait the finish of worker thread.
//                            // if it is false, main thread will wait finish of the worker thread.
//thread.Start();

//Console.WriteLine($"Main Thread completed.");
#endregion
#region ThreadState
//int i = 10;
//Thread thread = new Thread(() =>
//{
//    while (i >= 0)
//    {
//        i--;
//        Thread.Sleep(1000);
//    };
//    Console.WriteLine($"Worker Thread completed.");
//});
//thread.Start();
//ThreadState state = ThreadState.Running;
//while(true) 
//{
//    if (thread.ThreadState == ThreadState.Stopped) break;
//    if(state != thread.ThreadState) 
//    {
//        state = thread.ThreadState;
//        Console.WriteLine(thread.ThreadState);
//    }
//};

//Console.WriteLine($"Main Thread completed.");

#endregion
#region Locking
//object locking = new(); // obje referansı üzerinden bir kaynağa erişim lock yapılabilir.
//int i = 1;
//Thread thread1 = new(() =>
//{
//    lock (locking)
//    {
//        while (i < 10)
//        {
//            i++;
//            Console.WriteLine($"Thread 1 {i}");
//        }
//    }
//});

//Thread thread2 = new(() =>
//{
//    lock (locking)
//    {
//        while (i > 0)
//        {
//            Console.WriteLine($"Thread 2 {--i}");
//        }
//    }
//});
//thread1.Start();
//thread2.Start();
#endregion
#region Sleep 
//Thread thread = new(() =>
//{
//	for (int i = 0; i < 10; i++)
//	{
//		Console.WriteLine(i);
//		Thread.Sleep(1000);
//	}
//});
//thread.Start();
#endregion
#region Join
//Thread thread1 = new(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Thread 1 {i}");
//    }
//});
//Thread thread2 = new(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Thread 2 {i}");
//    }
//});
//thread1.Start();
//thread1.Join();
//thread2.Start();
#endregion
#region Graceful Shutdown

//bool stop = false;
//Thread thread = new(() =>
//{
//    while (true)
//    {
//        if(stop) break;
//        Console.WriteLine("Thread is running...");
//    }
//    Console.WriteLine("Thread finished.");
//}); 

//thread.Start();
//Thread.Sleep(3000);
//stop = true;
//Thread thread = new((cancellationToken) =>
//{
//    while (true)
//    {
//        var cancel = (CancellationTokenSource)cancellationToken;
//        if (cancel.IsCancellationRequested) break;
//        Console.WriteLine("Thread is running...");
//    }
//    Console.WriteLine("Thread finished.");
//});
//CancellationTokenSource cancellationToken = new();
//thread.Start(cancellationToken);
//Thread.Sleep(3000);
//cancellationToken.Cancel();
#endregion
#region Interrupt 
Thread thread = new(() => {
	try
	{
		Console.WriteLine("Thread is waiting");
		Thread.Sleep(3000);
	}
	catch (ThreadInterruptedException ex)
	{
		Console.WriteLine($"{ex.Message}");
	}
});
thread.Start();
thread.Interrupt();
#endregion
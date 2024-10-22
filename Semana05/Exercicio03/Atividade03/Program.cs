using System;
using System.Threading;
class  MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        for (int i = 0; i < Environment.ProcessorCount; i++)
        {
            var t = new Thread(MetodoDif);
            t.IsBackground = true;
            t.Start(i);
        }
        Console.WriteLine("Saindo da main");
    }
    static void MetodoDif(object threadID)
    {
        Console.WriteLine("Meu nome");
        while(true)
        {
            Console.WriteLine($"oi da thread do método {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}

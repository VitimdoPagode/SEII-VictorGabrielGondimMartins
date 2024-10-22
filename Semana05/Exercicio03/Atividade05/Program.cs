using System;
using System.Threading;
class  MainClass
{
    static int count = 0;
    static object baton = new object();

    static void Main(string[] args)
    {
        var t1 =  new Thread(Incremento);
        var t2 =  new Thread(Incremento);
        t1.Start();
        Thread.Sleep(500);
        t2.Start();

    }

    static void Incremento()
    {
        while(true)
        {
            lock(baton)
            {
                int temp = count;
                Thread.Sleep(1000);
                count = temp + 1;
                Console.WriteLine($"Thread ID {Thread.CurrentThread.ManagedThreadId} contagem de incremento {count}");
                Thread.Sleep(1000);
             }
            
        }
    }
}

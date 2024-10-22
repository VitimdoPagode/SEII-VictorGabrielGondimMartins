using System;
using System.Threading;
class  MainClass
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 12; i++)
        {
            var t = new Thread(MetodoDif);
            t.Start(i);
        }
        
    }

    static void MetodoDif(object threadID)
    {
        Console.WriteLine("Meu nome");
        while(true)
        {
            Console.WriteLine($"oi da thread do método {threadID}");
        }
    }
}

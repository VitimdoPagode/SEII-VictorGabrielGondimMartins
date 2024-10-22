using System;
using System.Threading;
class  MainClass
{
    static void Main(string[] args)
    {
        var t = new Thread(MetodoDif);
        t.Start();
        
    }

    static void MetodoDif()
    {
        Console.WriteLine("Meu nome");
    }
}

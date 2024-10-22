using System;
using System.Threading;

class MainClass
{
    static object baton = new object();
    static void Main(string[] args)
    {
        bool locktaken = false;
        Monitor.Enter(baton, ref locktaken);
        try
        {
            Console.WriteLine("está com o baton");
        }
        finally
        {
            if(locktaken)
                Monitor.Exit(baton);
        }
    }       
}
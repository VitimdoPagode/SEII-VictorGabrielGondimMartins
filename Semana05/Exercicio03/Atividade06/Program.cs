using System;
using System.Threading;

class MainClass
{
    static object baton = new object();
    static Random random = new Random();
    static void Main(string[] args)
    {
        for (int i = 0; i < 8; i++)
        {
            new Thread(ParadaDeEmergencia).Start();
        }
    } 
    static void ParadaDeEmergencia()
    {
        Console.WriteLine($"Thread de numero {Thread.CurrentThread.ManagedThreadId} quer fazer uma parada de emergencia...");
        lock(baton)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} esta fazendo uma parada de emergencia no momento...");
            Thread.Sleep(random.Next(2000));
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} saindo da parada de emergencia...");
        }

    }       
}
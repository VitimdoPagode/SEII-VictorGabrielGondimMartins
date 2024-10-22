using System;
using System.Diagnostics;
using System.Threading;

class MainClass
{
    static byte[] values = new byte[500000000];
    static void GenerateInts()
    {
        var random = new Random(987);
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = (byte)random.Next(10);
        }
    }
    static void Main(string[] args)
    {
        GenerateInts();
        Console.WriteLine("somando....");
        Stopwatch sw = new Stopwatch();

        sw.Start();
        long total = 0;
        for (int i = 0; i < values.Length; i++)
        {
            total += values[i];
        }   
        sw.Stop();
    
        Console.WriteLine($"a soma total é: {total}");
        Console.WriteLine($"o tempo de soma foi de {sw.ElapsedMilliseconds} ms");
    }       
}
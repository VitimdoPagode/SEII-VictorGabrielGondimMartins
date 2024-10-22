using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

class MainClass
{
    static byte[] values = new byte[500000000];
    static long[] resultadosParciais;
    static int tamanhoParciais;
    static void GenerateInts()
    {
        var random = new Random(987);
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = (byte)random.Next(10);
        }
    }

    static void SomasParciais(object numeroParciais)
    {
        long soma = 0;
        int parciaisNumeroInt = (int)numeroParciais;

        int baseIndice = parciaisNumeroInt*tamanhoParciais;
 
        for(int i = baseIndice; i < baseIndice + tamanhoParciais; i++)
        {
            soma += values[i];
        }

        resultadosParciais[parciaisNumeroInt] = soma;

    }

    static void Main(string[] args)
    {
        resultadosParciais = new long[Environment.ProcessorCount];
        tamanhoParciais = values.Length / Environment.ProcessorCount;
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

        sw.Reset();

        sw.Start();
        Thread[] threads = new Thread[Environment.ProcessorCount];
        for(int i = 0; i < Environment.ProcessorCount; i++)
        {
            threads[i] = new Thread(SomasParciais);
            threads[i].Start(i);
        }

        long total2 = 0;

        for(int i = 0; i < Environment.ProcessorCount; i++)
            threads[i].Join();
        for(int i = 0; i < Environment.ProcessorCount; i++)
            total2 += resultadosParciais[i];
        sw.Stop();

        Console.WriteLine($"a soma total2 é: {total2}");
        Console.WriteLine($"o tempo2 de soma foi de {sw.ElapsedMilliseconds} ms");

    }       
}
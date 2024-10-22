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

        for(int i = parciaisNumeroInt*tamanhoParciais; i < parciaisNumeroInt*tamanhoParciais + tamanhoParciais; i++)
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
    }       
}
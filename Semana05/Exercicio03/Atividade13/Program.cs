using System;
 class Mainclass
 {
    static Queue<int> numbers = new Queue<int>();

    const int numThreads = 3;
    static int[] somas = new int[numThreads];
    static Random random = new Random();
    static void ProduceNumbers()
    {
        for (int i = 0; i < 10; i++)
        {
            int numToQueue = random.Next(10);
            Console.WriteLine($"adicionando {numToQueue} na fila");
            numbers.Enqueue(numToQueue);
            Thread.Sleep(random.Next(1000));
        }
    }

    static void somaNumeros(object threadNumber)
    {
        DateTime startTime = DateTime.Now;
        int soma = 0;
        while((DateTime.Now - startTime).Seconds < 11)
        {   
            int numToSum = -1;
            lock(numbers)
            {
                if(numbers.Count != 0)
                {
                    numToSum = numbers.Dequeue();
                }  
            }
            if(numToSum != -1)
            {
                soma += numToSum; 
                Console.WriteLine($"problema na thread #{threadNumber}");
                Console.WriteLine($"Utilizando thread #{threadNumber} adicionando {numToSum} na soma total");
            } 
        }

        somas[(int)threadNumber] = soma;  
    }

    static void Main(string[] args)
    {


        var criandoThreads = new Thread(ProduceNumbers);
        criandoThreads.Start();
        
        Thread[] threads = new Thread[numThreads];

        for(int i = 0; i < numThreads; i++)
        {
            threads[i] = new Thread(somaNumeros);
            threads[i].Start(i);
        }
        for(int i = 0; i < numThreads; i++)
        {
            threads[i].Join();
        }
        int somaTotal = 0;
        for(int i = 0; i < numThreads; i++)
        {
            somaTotal += somas[i];
        }

        Console.WriteLine($"Soma finalizada: {somaTotal}");
    }
 }
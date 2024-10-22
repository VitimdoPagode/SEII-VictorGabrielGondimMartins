using System;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Claims;

class Cabine 
{
    [MethodImpl(MethodImplOptions.Synchronized)]
    public void SerUsada()
    {
        lock(this)
        {
            Console.WriteLine("Fazendo coisas.....");
            Thread.Sleep(5000);
        }
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void Descarga()
    {
        lock(this)
        {
            Console.WriteLine("Dando Descarga.....");
            Thread.Sleep(5000);
        }
    }
}

class BanheiroPublico
{
    Cabine cabine1 = new Cabine();
    Cabine cabine2 = new Cabine();
    public void UseStall1()
    {
        lock(cabine1)
        {
            cabine1.SerUsada();
            cabine1.Descarga();    
        }
    }
    public void UseStall2()
    {
        lock(cabine2)
        {
            cabine2.SerUsada();
            cabine2.Descarga();

        }
    }
    public void LimparPia()
    {
        lock(cabine1)
        Console.WriteLine("Limpando a pia...");
    }
}

class MainClass
{
    static void Main(string[] args)
    {

        var cabine1 = new Cabine();
        new Thread(cabine1.SerUsada).Start();
        new Thread(cabine1.Descarga).Start();

    }
}
using System;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Claims;

class BanheiroPublico
{
    object baton1 = new object();
    object baton2 = new object();
    public void UseStall1()
    {
        lock(baton1)
        Console.WriteLine("na cabine 1");
        Thread.Sleep(2000);
    }
    public void UseStall2()
    {
        lock(baton2)
        Console.WriteLine("na cabine 2");
        Thread.Sleep(2000);
    }
    public void UseSink1()
    {
        Console.WriteLine("na pia 1");
        Thread.Sleep(2000);
    }
    public void UseSink2()
    {
        Console.WriteLine("na pia 2");
        Thread.Sleep(2000);
    }
}

class MainClass
{
    static void Main(string[] args)
    {

        var banheiro = new BanheiroPublico();
        new Thread(banheiro.UseStall1).Start();
        new Thread(banheiro.UseStall2).Start();
        new Thread(banheiro.UseStall1).Start();
        new Thread(banheiro.UseStall2).Start();
    
    }
}
using System;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Claims;

class Cabine 
{
    object baton = new object();

    public void SerUsada()
    {
        lock(baton)
        Console.WriteLine("Fazendo coisas.....");

    }
    public void Descarga()
    {
        lock(baton)
        Console.WriteLine("Dando Descarga.....");
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

        var banheiro = new BanheiroPublico();
        new Thread(banheiro.UseStall1).Start();
        new Thread(banheiro.UseStall2).Start();
        new Thread(banheiro.UseStall1).Start();
        new Thread(banheiro.UseStall2).Start();
    
    }
}
using System;

class Banheiro
{
    public void Usar(int numUsuario)
    {
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Sendo usado por #{numUsuario}");
            Thread.Sleep(500);
        }
    }
}

class MainClass
{
    static Banheiro enrolar = new Banheiro();

    static void Main(string[] args)
    {
        for(int i = 0; i < 3; i++)
        {
            new Thread(UsuarioComum).Start();
        }
        new Thread(Estranho).Start();
    }

    static void UsuarioComum()
    {
        lock(enrolar)
            enrolar.Usar(Thread.CurrentThread.ManagedThreadId);
    }

    static void Estranho()
    {
        enrolar.Usar(99);
    }
}
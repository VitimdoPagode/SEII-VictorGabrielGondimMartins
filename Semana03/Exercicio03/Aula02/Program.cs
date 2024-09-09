using System;

namespace Aula02
{
    class Program
    {
        public static void Main(string[] args)
        {
            string arquivo = "arquivo.txt";

            string texto = File.ReadAllText(arquivo);

            Console.WriteLine("conteudo do arquivo: " + texto);
        }
    }
}
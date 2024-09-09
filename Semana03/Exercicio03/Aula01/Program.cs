using System;
using System.IO;

namespace Aula01
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquico = "arquivo.txt";

            string texto = "Este é um documento de texto";

            File.WriteAllText(nomeDoArquico, texto);
            Console.WriteLine("Arquivo criado com sucesso");
            
        }
    }
}

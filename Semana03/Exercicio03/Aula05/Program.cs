using System;
using System.IO;

namespace Aula05
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "documentos.txt";

            string conteudo = File.ReadAllText(nomeDoArquivo);

            Console.WriteLine("conteudo do arquivo: ");
            Console.WriteLine(conteudo + "\n");

            File.AppendAllText(nomeDoArquivo, "um outro arquivo.");

            conteudo = File.ReadAllText(nomeDoArquivo);
            Console.WriteLine(conteudo + "\n");

        }
    }
}
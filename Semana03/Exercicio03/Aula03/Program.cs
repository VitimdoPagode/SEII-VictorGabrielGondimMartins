using System;
using System.IO;

namespace Aula03
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] documentos = {"documento 1.", "documento 2."};

            string nomeDoArquivo = "documentos.txt";

            File.WriteAllLines(nomeDoArquivo, documentos);

            Console.WriteLine("O Arquivo foi criado!");
        }
    }
}
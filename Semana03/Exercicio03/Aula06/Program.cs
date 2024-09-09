using System;
using System.IO;

namespace Aula06
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "arquivo.txt";

            Console.WriteLine(File.Exists(nomeDoArquivo));

            File.WriteAllText(nomeDoArquivo, "existe agora hahahahahaa");

            Console.WriteLine(File.Exists(nomeDoArquivo));
        }
    }
}
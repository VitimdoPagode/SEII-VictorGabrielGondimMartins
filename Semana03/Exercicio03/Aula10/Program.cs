using System;
using System.IO;

namespace Aula09
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] arquivos = Directory.GetFiles(@"C:\");
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
        }
    }
}
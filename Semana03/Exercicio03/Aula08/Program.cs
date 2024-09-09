using System;
using System.IO;

namespace Aula08
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pasta = "Nova Pasta";

            Directory.CreateDirectory(pasta);

            if(Directory.Exists(pasta)) Console.WriteLine("A pasta existe");
        }
    }
}

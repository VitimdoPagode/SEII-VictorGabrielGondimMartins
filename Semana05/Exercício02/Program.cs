using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace ProgAssincrona
{
    class Program
    {
        static void RealizarOp(int op, string nome, string sobrenome)
        {
            Console.WriteLine($"Iniciando operação {op}...");
            for(int i = 0; i < 1000000000; i++)
            {
                var p = new Pessoa(nome, sobrenome, 35);
            }
            Console.WriteLine($"Finalizando processo {op}...");

        }
        static void Main(string[] args)
        {
            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ExecucaoComTask();
            sw.Stop();
            Console.WriteLine($"Essa operação gastou {sw.ElapsedMilliseconds}");
            
        }

        //Atividade realizada em série
        static void ExecucaoSerie()
        {

            RealizarOp(1, "Fulano", "da Silva");
            RealizarOp(2, "Jon", "da Silva");
            RealizarOp(3, "Paulo", "da Silva");

        }
        //Atividade realizada em paralelo
        static void ExecucaoComThread()
        {
            var t = new Thread(() =>
            {
                RealizarOp(1, "Fulano", "da Silva");
            });
            var t2 = new Thread(() =>
            {
                RealizarOp(2, "Fulano", "da Silva");
            });
            var t3 = new Thread(() =>
            {
                RealizarOp(3, "Fulano", "da Silva");
            });

            t.Start();
            t2.Start();
            t3.Start();

            t.Join();
            t2.Join();
            t3.Join();
        }

        static void ExecucaoComTask()
        {
             var t = Task<int>.Run(() =>
            {
                RealizarOp(1, "Fulano", "da Silva");
                return 1;
            });
            var t2 = Task<int>.Run(() =>
            {
                RealizarOp(2, "Fulano", "da Silva");
                return 2;
            });
            var t3 = Task<int>.Run(() =>
            {
                RealizarOp(3, "Fulano", "da Silva");
                return 3;
            });

            Console.WriteLine($"A tarefa {t.Result} foi finalizada");
            Console.WriteLine($"A tarefa {t2.Result} foi finalizada");
            Console.WriteLine($"A tarefa {t3.Result} foi finalizada");

        }
        
    }
    internal class Pessoa
    {
        private string nome;
        private string sobrenome;
        private int v;

        public Pessoa(string nome, string sobrenome, int v)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.v = v;
        }
    }
}
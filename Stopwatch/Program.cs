using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundo => 1s = 1 segundo");
            Console.WriteLine("M - Minuto => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Informe o tempo para contagem:");
            System.Console.WriteLine("---------------------------------------");

            string input = Console.ReadLine().ToLower();
            char type = char.Parse(input.Substring(input.Length - 1, 1));
            int time = int.Parse(input.Substring(0, input.Length - 1));
            int multiplier = 1;

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            switch (type)
            {
                case 's': break;
                case 'm': multiplier = 60; break;
                default: System.Environment.Exit(0); break;
            }

            PreStart(time * multiplier);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            System.Console.WriteLine("Preparar...");
            Thread.Sleep(2000);
            System.Console.WriteLine("Apontar...");
            Thread.Sleep(2000);
            System.Console.WriteLine("Vai!");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (time > currentTime)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2000);
            Menu();
        }
    }
}
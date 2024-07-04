using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace TextEditor
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
            System.Console.WriteLine("Selecione uma opção:");
            System.Console.WriteLine("1 - Abrir arquivo");
            System.Console.WriteLine("2 - Editar arquivo");
            System.Console.WriteLine("0 - Sair");
            System.Console.WriteLine("---------------------------------------");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }
        static void Open()
        {
            Console.Clear();
            System.Console.WriteLine("Digite o caminho do arquivo:");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine();
            Console.ReadLine();
            Menu();
        }
        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair):");
            Console.WriteLine("---------------------------------------");
            string text = string.Empty;

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho para salvar o arquivo:");
            Console.WriteLine("---------------------------------------");
            string path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso.");
            Console.ReadLine();
            Menu();
        }
    }
}

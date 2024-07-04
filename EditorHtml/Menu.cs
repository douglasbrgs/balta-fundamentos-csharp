using System;

namespace EditorHtml
{
    class Menu
    {
        public static void Show()
        {
            var lines = 10;
            var columns = 30;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen(lines, columns);
            WriteOptions();

            short option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen(int lines, int columns)
        {
            DrawColumns(columns);
            DrawLines(lines, columns);
            DrawColumns(columns);
        }

        public static void DrawColumns(int columns)
        {
            Console.Write("+");
            for (int i = 0; i < columns; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public static void DrawLines(int lines, int columns)
        {
            for (int i = 0; i < lines; i++)
            {
                Console.Write("|");
                Console.Write(string.Empty.PadRight(columns));
                Console.WriteLine("|");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("===========================");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    System.Console.WriteLine("View");
                    break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    break;
                default: Show(); break;
            }
        }
    }
}
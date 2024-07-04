using System;

namespace Lists
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            // Aula1();
            // Aula2();
        }

        public static void Aula1()
        {
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            Console.WriteLine(meuArray[0]);

            var arrayTeste = new Teste[1] { new Teste() };
            Console.WriteLine(arrayTeste[0].Id);
        }

        public static void Aula2()
        {
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < meuArray.Length; i++)
            {
                Console.WriteLine(meuArray[i]);
            }
        }

        public static void Aula3()
        {
            // var meuArray = new int[5] { 10, 29, 38, 47, 56 };

            // foreach (var item in meuArray)
            // {
            //     Console.WriteLine(item);
            // }

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 1937, Nome = "Douglas" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }
        }

        public static void Aula4()
        {
            var primeiro = new int[4];
            var segundo = new int[4];

            segundo[0] = primeiro[0];

            primeiro[0] = 23;
            Console.WriteLine(segundo[0]);
        }
    }

    struct Teste
    {
        public int Id { get; set; }
    }

    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
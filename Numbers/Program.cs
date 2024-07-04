using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Aula1();
            Aula2();
        }

        public static void Aula1()
        {
            decimal valor = 10.25m;
            Console.WriteLine(valor);

            //G, C, E04, F, N, P
            System.Console.WriteLine(
                valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("es-ES")
                )
            );
        }

        public static void Aula2()
        {
            decimal valor = 10536.25m;
            Console.WriteLine(valor);

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
        }
    }
}

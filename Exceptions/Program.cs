namespace Exceptions
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();

            try
            {
                Cadastrar("Teste teste teste");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar o texto");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Exceção customizada.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }

        private static void Cadastrar(string? texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                // throw new ArgumentNullException("O texto não pode ser nulo ou vazio.");
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }

        public static void Aula1()
        {
            var arr = new int[3];

            for (int i = 0; i <= 3; i++)
            {
                // System.IndexOutOfRangeException
                Console.WriteLine(arr[i]);
            }
        }

        public static void Aula2()
        {
            var arr = new int[3] { 1, 2, 3 };

            try
            {
                for (int index = 0; index <= 3; index++)
                {
                    // IndexOutOfRangeException
                    Console.WriteLine(arr[index]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }

        public static void Aula3()
        {
            var arr = new int[3] { 1, 2, 3 };

            try
            {
                for (int index = 0; index <= 3; index++)
                {
                    // IndexOutOfRangeException
                    Console.WriteLine(arr[index]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                System.Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }

        public static void Aula4()
        {
            try
            {
                Cadastrar(null);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar o texto.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }

        public static void Aula5()
        {
            try
            {
                Cadastrar(null);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar o texto");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Exceção customizada.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }

    }
}
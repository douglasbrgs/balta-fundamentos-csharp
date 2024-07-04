using System;

namespace StructApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse Gamer", 299.99, EProductType.Product);
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            System.Console.WriteLine(mouse.Type);
            Console.WriteLine(mouse.PriceInDolar(5.1));
        }
    }

    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
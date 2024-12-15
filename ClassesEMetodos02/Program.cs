using System;
using System.Globalization;

namespace ClassesEMetodos02
{
    public class Program
    {
        static void Main(string[] args)
        {

            Product p = new Product("TV", 900, 10);

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }

    }
}
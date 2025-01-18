using HerancaAndPoliformismo.Entities;
using System.Globalization;
using System;

namespace HerancaAndPoliformismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numProducts = int.Parse(Console.ReadLine());

            for (int i=0; i<numProducts; i++)
            {
                Console.WriteLine($"Porduct #{i+1} data: ");

                Console.Write("Common, used or imported (c/u/i): ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op== 'i')
                {

                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customs));
                    
                } else if (op == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                } else
                {
                    list.Add(new Product(name, price));
                }

            }
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}

using System;
using System.Globalization;
namespace ClassesEMetodos02
{
    public class Product
    {
        public String Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Product() { }

        public Product(String nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Product(String nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            double valorTotal;
            valorTotal = Quantidade * Preco;
            return valorTotal;
        }
        public void AdicionarProdutos(int quantidades)
        {
            Quantidade += quantidades; 
        }
        public void RemoverProdutos(int quantidades)
        {
            Quantidade -= quantidades;
        }


        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
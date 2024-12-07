using System;
using System.Globalization;
namespace ClassesEMetodos02
{
    public class Product
    {
        public String Nome;
        public double Preco;
        public int Quantidade;

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
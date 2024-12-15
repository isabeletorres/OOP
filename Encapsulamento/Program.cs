using System;

using System.Globalization;

namespace Encapsulamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            
            Console.Write("Entre o Titular da conta: ");
            String titular = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            char res = char.Parse(Console.ReadLine());

            if (res == 'n')
            {
                conta = new ContaBancaria(numero, titular);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
            } else
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, valor);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);

            }

            Console.Write("Entre um valor para depósito: ");
            double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(val);

            Console.WriteLine(conta);

            Console.Write("Entre um valor para Saque: ");
           double vali = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(vali);
            Console.WriteLine(conta);
            Console.ReadKey();
        }

    }
}
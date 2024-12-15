using System;
using System.Globalization;
namespace Encapsulamento
{
    public class ContaBancaria
    {
        public int Numero { get; private set; }
        public String Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() { }

        public ContaBancaria(int numero, String titular)
        {
            Numero = numero;
            Titular = titular;
        } 

        public ContaBancaria(int numero, String titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            double valorTotal = quantia + 5.0; 
            Saldo -= valorTotal;
        }

        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
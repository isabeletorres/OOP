using System;

using Heranca.Entities;

namespace Heranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brouw", 100, 500);
            Console.WriteLine(account.Balance);
            Console.ReadKey();
        }
    }
}
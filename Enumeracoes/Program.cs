using System;
using Enumeracoes.Entites.Enums;
using Enumeracoes.Entites;

namespace Enumeracoes 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
            Console.ReadKey();
        }
    }
}

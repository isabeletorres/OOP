using System;
using System.Globalization;
using ExSemInterface.Entities;

namespace ExSemInterface
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/mm/yyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/mm/yyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            Console.Write("Enter price per hour: ");
            Console.Write("Enter price per day: ");
            Console.WriteLine("INVOICE: ");
            Console.Write("Basic payment: ");
            Console.Write("Tax: ");
            Console.Write("Total payment: ");

        }
    }
}
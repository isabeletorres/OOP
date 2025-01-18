using System;
using System.Collections.Generic;
using ExerciciesEmployee.Entities;
using System.Globalization;
namespace ExerciciesEmployee
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsource(y/n): ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double vpHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharges = double.Parse(Console.ReadLine());
                    list.Add(new OutsourceEmployee(name, hours, vpHours, additionalCharges));
                }
                else
                {
                    list.Add(new Employee(name, hours, vpHours));
                }
                Console.WriteLine();
            }
                Console.WriteLine("PAYMANTS");
                foreach (Employee emp in list)
                {
                    Console.WriteLine($"{emp.Name} - $ {emp.Paymant().ToString("F2", CultureInfo.InvariantCulture)}");
                }
           
        }
    }
}


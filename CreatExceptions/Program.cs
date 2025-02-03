using System;
using CreatExceptions.Entities;

namespace CreatExceptions
{
    public class ProcessFile
    {
        public static void Main()
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/mm/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/mm/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation resevartion = new Reservation(number, checkIn, checkOut);


            
        }
    }
}
using System;
using System.Globalization;
namespace ParteUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            x.A = (10);
            x.B = (11);
            x.C = (12);

            double areaX = x.Area();

            y.A = (12);
            y.B = (13);
            y.C = (14);

            double areaY= y.Area();

            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
        }   
    }
}
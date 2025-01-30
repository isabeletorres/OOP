﻿using System;
using System.Collections.Generic;
using System.Globalization;
using MetodoAbstrato.Entities.Enums;
using MetodoAbstrato.Entities;

namespace MetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i<=n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or circle (r/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Color: (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (type == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                } 
                else {
                    Console.Write("Radios: ");
                    double radios = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radios, color));
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
} 
using System;
using MetodoAbstrato.Entities.Enums;

namespace MetodoAbstrato.Entities
{
    class Circle : Shape
    {
        public double Radios { get; set; }

        public Circle(double radios, Color color) : base(color)
        {
            Radios = radios;
        }
        public override double Area()
        {
            return Math.PI * (Radios * Radios);
        }
    }
}

﻿using System;
using MetodoAbstrato.Entities.Enums;

namespace MetodoAbstrato.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        abstract public double Area();
       
    }
}

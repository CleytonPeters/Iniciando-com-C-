﻿using System;
using Aula_134_MétodosAbstratos.Entities.Enum;
namespace Aula_134_MétodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}

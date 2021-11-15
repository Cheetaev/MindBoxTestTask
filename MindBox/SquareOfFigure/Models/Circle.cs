using System;
using System.Collections.Generic;
using System.Text;

namespace SquareOfFigure
{
    public class Circle : IFigure
    {

        private readonly double _radius;

        public Circle (double radius)
        {
            _radius = radius;
        }

        public double Square => Math.Round(Math.PI * Math.Pow(_radius, 2), 5);

    }
}

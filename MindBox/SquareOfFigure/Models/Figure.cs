using System;
using System.Collections.Generic;
using System.Text;

namespace SquareOfFigure
{
    public class Figure : IFigure
    {
        private readonly IFigure figure;

        public Figure(double radius)
        {
            figure = new Circle(radius);
        }

        public Figure(double sideA, double sideB, double sideC)
        {
            figure = new Triangle(sideA, sideB, sideC);
        }

        public double Square => figure.Square;
    }
}

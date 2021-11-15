using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareOfFigure
{
    public class Triangle : IFigure
    {

        private readonly double _sideA, _sideB, _sideC;
        private readonly List<double> _sides;

        public Triangle(params double[] values)
        {
            _sideA = values[0];
            _sideB = values[1];
            _sideC = values[2];
            _sides = values.ToList();
        }

        public double Square
        {
            get
            {

                if (isExist())
                {
                    double p = (_sides.Sum()) / 2;
                    return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
                }

                return 0;

            }
        }

        public bool isExist()
        {

            if (_sideA <= 0 || _sideB <= 0 || _sideC <= 0)
            {
                //throw new Exception("Triangle does not exist, side cannot be 0");
                return false;
            }
                
            if (!((_sideA + _sideB > _sideC)
                && (_sideA + _sideC > _sideB)
                && (_sideB + _sideC > _sideA)))
            {
                //throw new Exception("Triangle does not exist");
                return false;
            }

            return true;

        }

        public bool isRectangular()
        {

            _sides.Sort();
            _sides.Reverse();
            return _sides[0] == _sides[1] + _sides[2];

        }

    }
}

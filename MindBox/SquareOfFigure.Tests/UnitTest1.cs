using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquareOfFigure.Tests
{
    [TestClass]
    public class SquareOfFigureTest
    {
        [TestMethod]
        public void Square_3and4and5_6Return()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);
            double correctSquare = 6;

            //act
            double square = triangle.Square;

            //assert
            Assert.AreEqual(correctSquare, square);
        }
    }
}

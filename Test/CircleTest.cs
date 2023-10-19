using Xunit;
using ShapeLib.Shapes;
using ShapeLib.Calculators;
using System;

namespace ShapeLib.Test
{
    public class CircleTest
    {
        [Fact]
        public void CalculateCircleArea()
        {
            Circle circle = new Circle(10);
            IGeometryCalculator calculator = new GeometryCalculator();

            double expectedArea = Math.PI * 10 * 10;
            double actualArea = calculator.CalculateArea(circle);

            Assert.Equal(expectedArea, actualArea, 2);
        }
    }
}
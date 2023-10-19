using Xunit;
using ShapeLib.Shapes;
using ShapeLib.Calculators;

namespace ShapeLib.Test
{
    public class TriangleTest
    {
        [Fact]
        private void CalculateTriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            IGeometryCalculator calculator = new GeometryCalculator();

            double expectedArea = 6;
            double actualArea = calculator.CalculateArea(triangle);

            Assert.Equal(expectedArea, actualArea, 2);
        }
        
        [Fact]
        public void IsRightTriangle()
        {
            var triangle = new Triangle(3.0, 4.0, 5.0);

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.True(isRightTriangle);
        }
    }
}
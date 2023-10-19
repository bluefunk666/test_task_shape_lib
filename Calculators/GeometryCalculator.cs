using ShapeLib.Shapes;

namespace ShapeLib.Calculators
{
    public class GeometryCalculator : IGeometryCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
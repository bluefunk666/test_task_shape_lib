using ShapeLib.Shapes;

namespace ShapeLib.Calculators
{
    public interface IGeometryCalculator
    {
        double CalculateArea(IShape shape);
    }
}
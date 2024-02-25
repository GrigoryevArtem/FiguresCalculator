using FiguresCalculator.Exceptions.Circle;
using FiguresCalculator.Helpers;
using FiguresCalculator.Interfaces;

namespace FiguresCalculator.Entities;

public class Circle : IFigure
{
    public double Radius { get;}

    public Circle(double radius)
    {
        if (!IsPositiveRadius(radius))
        {
            throw new NotExistsCircleWithThisRadiusException();
        }

        Radius = radius;
    }

    private static bool IsPositiveRadius(double radius)
    {
        return radius >= MathHelper.Eps;
    }

    public double GetSquare()
    {
        return Math.PI * Radius * Radius;
    }
}
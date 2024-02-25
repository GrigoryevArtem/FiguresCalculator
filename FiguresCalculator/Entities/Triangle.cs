using FiguresCalculator.Exceptions.Triangle;
using FiguresCalculator.Helpers;
using FiguresCalculator.Interfaces;

namespace FiguresCalculator.Entities;

public class Triangle : IFigure
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (!IsPositiveSides(firstSide, secondSide, thirdSide))
        {
            throw new NotExistsTriangleWithNegativeSideException();
        }

        if (!IsCorrectTriangleSides(firstSide, secondSide, thirdSide))
        {
            throw new NotExistsTriangleWithTheseSidesException();
        }

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    private static bool IsPositiveSides(double firstSide, double secondSide, double thirdSide)
    {
        return firstSide > MathHelper.Eps && secondSide > MathHelper.Eps && thirdSide > MathHelper.Eps;
    }

    private static bool IsCorrectTriangleSides(double firstSide, double secondSide, double thirdSide)
    {
        return firstSide + secondSide > thirdSide
               && firstSide + thirdSide > secondSide
               && secondSide + thirdSide > firstSide;
    }

    private double GetPerimeter() => (FirstSide + SecondSide + ThirdSide);

    public bool IsRightAngleTriangle() =>
        (Math.Abs(FirstSide * FirstSide - SecondSide * SecondSide - ThirdSide * ThirdSide) < MathHelper.Eps)
        || (Math.Abs(SecondSide * SecondSide - FirstSide * FirstSide - ThirdSide * ThirdSide) < MathHelper.Eps)
        || (Math.Abs(SecondSide * SecondSide + FirstSide * FirstSide - ThirdSide * ThirdSide) < MathHelper.Eps);


    public double GetSquare()
    {
        var semiPerimeter = GetPerimeter() / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) *
                         (semiPerimeter - ThirdSide));
    }
}
using FiguresCalculator.Entities;
using FiguresCalculator.Exceptions.Triangle;
using NUnit.Framework;

namespace FiguresCalculator.Tests.UnitTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        [TestCase(2, 2, 3, 1.9843)]
        [TestCase(3, 4, 5, 6)]
        public void GetSquare_TriangleWithValidSides_CorrectSquare(
            double firstSide, double secondSize, double thirdSize, double square)
        {
            var triangle = new Triangle(firstSide, secondSize, thirdSize);
            var calculateSquare = triangle.GetSquare();

            Assert.That(calculateSquare, Is.EqualTo(square).Within(0.0001));
        }

        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        public void IsRightTriangle_RightTriangleWithValidSides_True(double firstSide, double secondSize,
            double thirdSize)
        {
            var triangle = new Triangle(firstSide, secondSize, thirdSize);
            var isRightTriangle = triangle.IsRightAngleTriangle();

            Assert.That(isRightTriangle, Is.EqualTo(true));
        }

        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(3.5, 5.6, 5.2)]
        public void CreateTriangle_PositiveSides_CreateTriangleWithCorrectSides(
            double firstSide, double secondSide, double thirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.Multiple(() =>
            {
                Assert.That(triangle.FirstSide, Is.EqualTo(firstSide).Within(0.0001));
                Assert.That(triangle.SecondSide, Is.EqualTo(secondSide).Within(0.0001));
                Assert.That(triangle.ThirdSide, Is.EqualTo(thirdSide).Within(0.0001));
            });
        }

        [Test]
        [TestCase(3, 4, -1)]
        [TestCase(-1, 2, 3)]
        [TestCase(1, -2, 3)]
        [TestCase(-1, -2, -3)]
        [TestCase(1, 2, 0)]
        public void CreateTriangle_NegativeSides_ThrowNoExistsTriangleWithNegativeSideException(
            double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<NotExistsTriangleWithNegativeSideException>(() =>
            {
                var triangle = new Triangle(firstSide, secondSide, thirdSide);
            });
        }

        [Test]
        [TestCase(3, 4, 10)]
        [TestCase(3, 2, 0.5)]
        [TestCase(2, 5, 1.5)]
        public void CreateTriangle_InvalidSides_ThrowNoExistsTriangleWithTheseSidesException(
            double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<NotExistsTriangleWithTheseSidesException>(() =>
            {
                var triangle = new Triangle(firstSide, secondSide, thirdSide);
            });
        }
    }
}
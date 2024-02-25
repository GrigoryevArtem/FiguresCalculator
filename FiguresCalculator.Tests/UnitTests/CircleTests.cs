using FiguresCalculator.Entities;
using FiguresCalculator.Exceptions.Circle;
using NUnit.Framework;

namespace FiguresCalculator.Tests.UnitTests
{
    public class CircleTests
    {
        [Test]
        [TestCase(5.0, Math.PI * 5.0 * 5.0)]
        [TestCase(2.75, Math.PI * 2.75 * 2.75)]
        public void GetSquare_CircleWithPositiveRadius_CorrectSquare(double radius, double square)
        {
            var circle = new Circle(radius);
            var calculateSquare = circle.GetSquare();

            Assert.That(calculateSquare, Is.EqualTo(square).Within(0.0001));
        }

        [Test]
        [TestCase(3)]
        [TestCase(3.5)]
        public void CreateCircle_ValidRadius_CreateCircleWithValidRadius(double radius)
        {
            var circle = new Circle(radius);
            Assert.That(circle.Radius, Is.EqualTo(radius).Within(0.0001));
        }

        [Test]
        [TestCase(-3.6)]
        [TestCase(0)]
        public void CreateCircle_InvalidRadius_ThrowNotExistCircleException(double radius)
        {
            Assert.Throws<NotExistsCircleWithThisRadiusException>(() =>
            {
                var circle = new Circle(radius);
            });
        }
    }
}
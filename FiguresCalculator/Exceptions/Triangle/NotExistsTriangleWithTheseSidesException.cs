using System.Runtime.Serialization;

namespace FiguresCalculator.Exceptions.Triangle;

public class NotExistsTriangleWithTheseSidesException : Exception
{
    public NotExistsTriangleWithTheseSidesException() : base(
        "The sum of any two sides of a triangle must be greater than the third")
    {
    }

    protected NotExistsTriangleWithTheseSidesException(SerializationInfo info, StreamingContext context) : base(info,
        context)
    {
    }

    public NotExistsTriangleWithTheseSidesException(string? message) : base(message)
    {
    }

    public NotExistsTriangleWithTheseSidesException(string? message, Exception? innerException) : base(message,
        innerException)
    {
    }
}
using System.Runtime.Serialization;

namespace FiguresCalculator.Exceptions.Triangle;

public class NotExistsTriangleWithNegativeSideException : Exception
{
    public NotExistsTriangleWithNegativeSideException() : base("There is no triangle with negative sides")
    {
    }

    protected NotExistsTriangleWithNegativeSideException(SerializationInfo info, StreamingContext context) : base(info,
        context)
    {
    }

    public NotExistsTriangleWithNegativeSideException(string? message) : base(message)
    {
    }

    public NotExistsTriangleWithNegativeSideException(string? message, Exception? innerException) : base(message,
        innerException)
    {
    }
}
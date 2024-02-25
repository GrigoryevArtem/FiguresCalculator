using System.Runtime.Serialization;

namespace FiguresCalculator.Exceptions.Circle;

public class NotExistsCircleWithThisRadiusException : Exception
{
    public NotExistsCircleWithThisRadiusException() : base("There is no circle with this radius")
    {
    }

    protected NotExistsCircleWithThisRadiusException(SerializationInfo info, StreamingContext context) : base(info,
        context)
    {
    }

    public NotExistsCircleWithThisRadiusException(string? message) : base(message)
    {
    }

    public NotExistsCircleWithThisRadiusException(string? message, Exception? innerException) : base(message,
        innerException)
    {
    }
}
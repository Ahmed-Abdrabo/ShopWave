namespace BuildingBlocks.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string massage):base(massage)
    {
        
    }
    public BadRequestException(string message, string details) : base(message)
    {
        Details = details;
    }

    public string? Details { get; }
}

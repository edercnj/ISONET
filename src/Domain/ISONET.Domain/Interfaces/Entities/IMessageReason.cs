namespace ISONET.Domain.Interfaces.Entities
{
    public interface IMessageReason
    {
        int Code { get; }
        string Description { get; }
    }
}
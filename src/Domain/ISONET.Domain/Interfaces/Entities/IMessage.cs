namespace ISONET.Domain.Interfaces.Entities
{
    public interface IMessage
    {
        IBitMap BitMap { get; }
        IMessageTypeIndicator Mti { get; }
        IInstitution Institution { get; }
        string MessageName { get; }
    }
}
namespace ISONET.Domain.Interfaces.Entities
{
    public interface IAction
    {
        int Code { get; }
        IMessage[] MessagesUsed { get; }
        string Description { get; }
    }
}
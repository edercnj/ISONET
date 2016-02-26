using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class Action : IAction
    {
        public Action(int code, IMessage[] messagesUsed, string description)
        {
            Code = code;
            MessagesUsed = messagesUsed;
            Description = description;
        }

        public int Code { get; }
        public IMessage[] MessagesUsed { get; }
        public string Description { get; }
    }
}
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class MessageReason : IMessageReason
    {
        public int Code { get; }
        public string Description { get; }

        public MessageReason(int code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
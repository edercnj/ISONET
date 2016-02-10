using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Application
{
    public class CreateMessage
    {
        public Message Create(string stringMessage, ITemplate template, Message message)
        {
            return message.Map(stringMessage, template);
        }
    }
}
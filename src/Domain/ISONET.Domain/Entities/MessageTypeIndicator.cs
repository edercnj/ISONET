using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class MessageTypeIndicator : IMessageTypeIndicator
    {
        public int Mit { get; }

        public MessageVersion MessageVersion { get; }

        public MessageClass MessageClass { get; }

        public MessageFunction MessageFunction { get; }

        public MessageOrigin OriginMessage { get; }

        public MessageTypeIndicator(MessageVersion messageVersion, MessageClass messageClass, MessageFunction messageFunction, MessageOrigin originMessage)
        {
            MessageVersion = messageVersion;
            MessageClass = messageClass;
            MessageFunction = messageFunction;
            OriginMessage = originMessage;
            Mit = (int)messageVersion + (int)messageClass + (int)messageFunction + (int)originMessage;
        }
    }
}
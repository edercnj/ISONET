using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class Message : IMessage
    {
        public Message(IMessageTypeIndicator mti, string messageName, IInstitution institution, IBitMap bitMap)
        {
            Institution = institution;
            MessageName = messageName;
            Mti = mti;
            BitMap = bitMap;
        }

        public Message(IMessageTypeIndicator mti, string messageName, IBitMap bitMap)
        {
            Mti = mti;
            MessageName = messageName;
            BitMap = bitMap;
        }

        public IMessageTypeIndicator Mti { get; }
        public IInstitution Institution { get; }
        public string MessageName { get; }
        public IBitMap BitMap { get; }

        public override string ToString()
        {
            return Mti.Mit + BitMap.ToString();
        }
    }
}
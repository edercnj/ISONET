using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using System.Linq;

namespace ISONET.Domain.Entities
{
    public class Message : IMessage
    {
        public Message(int mti, string messageName, IInstitution institution, bool[] bitMap, IDataElement[] dataElements)
        {
            Institution = institution;
            MessageName = messageName;
            Mti = mti;
            BitMap = bitMap;
            DataElements = dataElements;
        }

        public Message(int mti, string messageName, bool[] bitMap, IDataElement[] dataElements)
        {
            Mti = mti;
            MessageName = messageName;
            BitMap = bitMap;
            DataElements = dataElements;
        }

        public Message(int mti, IInstitution institution, string messageName, bool[] bitMap, IDataElement[] dataElements, object[] header)
        {
            Mti = mti;
            Institution = institution;
            MessageName = messageName;
            BitMap = bitMap;
            DataElements = dataElements;
            Header = header;
        }

        public Message(int mti, string messageName, bool[] bitMap, IDataElement[] dataElements, object[] header)
        {
            Mti = mti;
            MessageName = messageName;
            BitMap = bitMap;
            DataElements = dataElements;
            Header = header;
        }

        public int Mti { get; set; }
        public IInstitution Institution { get; set; }
        public string MessageName { get; set; }
        public bool[] BitMap { get; set; }
        public IDataElement[] DataElements { get; set; }
        public object[] Header { get; set; }

        public override string ToString()
        {
            //TODO: Efetuar a implementação correta para retornar o bitMap no formato que o mesmo foi recebido
            return Mti + DataElements.Aggregate(BitMapConvert.BitMapToString(BitMap), (current, element) => current + element.ToString());
        }
    }
}
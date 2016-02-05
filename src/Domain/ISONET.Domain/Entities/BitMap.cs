using System.Linq;
using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;

namespace ISONET.Domain.Entities
{
    public class BitMap : IBitMap
    {
        public bool[] FirstBitMap { get; }
        public bool[] SecondBitMap { get; }
        public IDataElement[] DataElements { get; }

        public BitMap(bool[] firstBitMap, bool[] secondBitMap, IDataElement[] dataElements)
        {
            FirstBitMap = firstBitMap;
            SecondBitMap = secondBitMap;
            DataElements = dataElements;
        }

        public override string ToString()
        {
            return DataElements.Aggregate(BitMapConvert.BitMapToString(FirstBitMap), (current, element) => current + element.ToString());
        }
    }
}
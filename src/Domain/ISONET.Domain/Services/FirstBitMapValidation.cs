using System.Linq;
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class FirstBitMapValidation
    {
        public static bool IsValid(IBitMap bitMap)
        {
            bool isValid = BitMapLengthValidation.IsValid(bitMap.FirstBitMap) && bitMap.DataElements.All(t => bitMap.FirstBitMap[t.Bit - 1]);

            return isValid;
        }
    }
}
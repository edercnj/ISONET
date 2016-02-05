using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class SecondBitMapPresentValidation
    {
        public static bool IsPresent(IBitMap bitMap)
        {
            bool isPresent = FirstBitMapValidation.IsValid(bitMap) && bitMap.FirstBitMap[0];

            return isPresent;
        }
    }
}
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class BitMapValidation
    {
        public static bool IsValid(IBitMap bitMap)
        {
            bool isValid = !FirstBitMapValidation.IsValid(bitMap) || !SecondBitMapValidation.IsValid(bitMap);

            return isValid;
        }
    }
}
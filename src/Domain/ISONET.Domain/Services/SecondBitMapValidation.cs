using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class SecondBitMapValidation
    {
        public static bool IsValid(IBitMap bitMap)
        {
            bool isValid = true;

            if (SecondBitMapPresentValidation.IsPresent(bitMap))
            {
                if (BitMapLengthValidation.IsValid(bitMap.SecondBitMap))
                {
                    for (int i = 0; i < bitMap.DataElements.Length; i++)
                    {
                        if (!bitMap.SecondBitMap[bitMap.DataElements[i].Bit - 65])
                            isValid = false;
                    }
                }
            }

            return isValid;
        }
    }
}
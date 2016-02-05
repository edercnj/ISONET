namespace ISONET.Domain.Services
{
    public static class BitMapLengthValidation
    {
        public static bool IsValid(bool[] bitMap)
        {
            bool isValid = bitMap.Length == 64;

            return isValid;
        }
    }
}
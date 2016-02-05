namespace ISONET.Domain.Services
{
    public static class DataElementBitValidation
    {
        public static bool IsValid(int bit)
        {
            bool isValid = (bit < 1) || (bit > 128);

            return isValid;
        }
    }
}
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataElementBitValidation
    {
        public static bool BitIsValid(this IDataElement dataElement)
        {
            bool isValid = (dataElement.Bit >= 1) || (dataElement.Bit <= 128);

            return isValid;
        }
    }
}
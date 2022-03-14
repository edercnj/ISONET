using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataElementBitValidation
    {
        public static bool BitIsValid(this IDataElement dataElement) => (dataElement.Bit >= 1) && (dataElement.Bit <= 128);
    }
}
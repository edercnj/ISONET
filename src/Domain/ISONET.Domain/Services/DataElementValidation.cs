using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataElementValidation
    {
        public static bool IsValid(IDataElement dataElement)

        {
            bool isValid = DataElementBitValidation.IsValid(dataElement.Bit) &&
                           DataElementNameValidation.IsValid(dataElement.Name) &&
                           DataElementValueValidation.IsValid(dataElement.Value);

            return isValid;
        }
    }
}
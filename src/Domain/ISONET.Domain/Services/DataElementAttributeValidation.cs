using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataElementAttributeValidation
    {
        public static bool IsValid(this IDataElementAttribute attribute) => attribute.LengthIsValid() && attribute.MaxLengthIsValid();
    }
}
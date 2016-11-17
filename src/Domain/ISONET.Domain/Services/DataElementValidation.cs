using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataElementValidation
    {
        public static bool IsValid(this IDataElement dataElement) => dataElement.BitIsValid() && dataElement.NameIsValid() && dataElement.ValueIsValid();
    }
}
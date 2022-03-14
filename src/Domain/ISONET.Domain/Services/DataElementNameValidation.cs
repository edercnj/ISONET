using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataElementNameValidation
    {
        public static bool NameIsValid(this IDataElement dataElement) => !string.IsNullOrEmpty(dataElement.Name);
    }
}
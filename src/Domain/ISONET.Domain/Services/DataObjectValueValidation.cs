using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataObjectValueValidation
    {
        public static bool ValueIsValid(this IDataObject dataObject) => ValueFormatValidation.FormatIsValid(dataObject);
    }
}
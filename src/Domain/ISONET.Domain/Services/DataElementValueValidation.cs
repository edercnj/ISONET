using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataElementValueValidation
    {
        public static bool ValueIsValid(this IDataElement dataElement) => ValueFormatValidation.FormatIsValid(dataElement) && ValueMaskValidation.MaskIsValid(dataElement) && ValueLengthValidation.ValueLengthIsValid(dataElement);
    }
}
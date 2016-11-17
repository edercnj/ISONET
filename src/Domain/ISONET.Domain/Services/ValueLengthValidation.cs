using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class ValueLengthValidation
    {
        public static bool ValueLengthIsValid(IDataElement dataElement) => dataElement.Value.Length <= dataElement.DataElementAttribute.Length;
    }
}
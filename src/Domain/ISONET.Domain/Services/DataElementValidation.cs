using ISONET.Domain.Interfaces.Entities;
using System.Collections.Generic;

namespace ISONET.Domain.Services
{
    public static class DataElementValidation
    {
        public static bool IsValid(this IDataElement dataElement)
        {
            return dataElement.BitIsValid() && dataElement.NameIsValid() && dataElement.DataObjectsIsValid();
        }
    }
}
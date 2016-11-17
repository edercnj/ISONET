using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using System;
using System.Collections.Generic;

namespace ISONET.Application
{
    public static class DataElementApplication
    {
        public static IDataElement CreateDataElement(IDataElementAttribute dataElementAttribute, short bit, string description, string name, ConditionUse conditionUse, string value)
        {
            IDataElement dataElement = new DataElement(dataElementAttribute, bit, description, name, conditionUse, value);

            if (dataElement.IsValid())
                return dataElement;
            throw new ApplicationException();
        }

        public static IDataElement CreateDataElement(IDataElementAttribute dataElementAttribute, short bit, string description, string name, ConditionUse conditionUse, IEnumerable<IDataObject> dataObjects)
        {
            IDataElement dataElement = new DataElement(dataElementAttribute, bit, description, name, conditionUse, dataObjects);

            if (dataElement.IsValid())
                return dataElement;
            throw new ApplicationException();
        }
    }
}
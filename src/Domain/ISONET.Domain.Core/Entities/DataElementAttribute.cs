using ISONET.Domain.Interfaces.Entities;
using System;

namespace ISONET.Domain.Core.Entities
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class DataElementAttribute : Attribute
    {
        public IDataElement DataElement { get; }

        public DataElementAttribute(IDataElement dataElement)
        {
            DataElement = dataElement;
        }
    }
}
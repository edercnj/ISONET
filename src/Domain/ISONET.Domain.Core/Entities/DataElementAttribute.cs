using System;

namespace ISONET.Domain.Core.Entities
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class DataElementAttribute : Attribute
    {
        public short Bit { get; }

        public DataElementAttribute(short bit)
        {
            Bit = bit;
        }
    }
}
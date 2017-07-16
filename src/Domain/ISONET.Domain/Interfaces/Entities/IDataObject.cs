using System.Collections.Generic;
using ISONET.Domain.Entities;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IDataObject
    {
        string Type { get; }
        short Length { get; }
        string Value { get; set; }
        IEnumerable<AttributeFormat> AttributeFormat { get; }
    }
}
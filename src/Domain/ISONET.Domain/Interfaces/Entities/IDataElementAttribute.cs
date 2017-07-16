using ISONET.Domain.Entities;
using System.Collections.Generic;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IDataElementAttribute
    {
        IEnumerable<AttributeFormat> AttributeFormat { get; }
        LengthType LengthType { get; }
        IEnumerable<AttributeMask> AttributeMask { get; }
        short MaxLength { get; }
        short Length { get; }
    }
}
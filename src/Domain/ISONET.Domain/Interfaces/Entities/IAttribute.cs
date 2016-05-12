using ISONET.Domain.Entities;
using System.Collections.Generic;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IAttribute
    {
        IList<AttributeFormat> AttributeFormat { get; }

        LengthType LengthType { get; }

        IList<AttributeMask> AttributeMask { get; }

        short MaxLength { get; }

        short Length { get; }

        int AttributeFormatToInt(IList<AttributeFormat> att);
    }
}
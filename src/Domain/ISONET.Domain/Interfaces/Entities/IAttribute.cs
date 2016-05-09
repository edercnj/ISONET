using ISONET.Domain.Entities;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IAttribute
    {
        AttributeFormat[] AttributeFormat { get; }

        LengthType LengthType { get; }

        AttributeMask[] AttributeMask { get; }

        short MaxLength { get; }

        short Length { get; }
    }
}
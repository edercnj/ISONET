using ISONET.Domain.Entities;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IAtrribute
    {
        AttributeFormat[] AttributeFormat { get; }

        LengthType LengthType { get; }

        AttributeMask[] AttributeMask { get; }

        short MaxLength { get; }

        short Length { get; }
    }
}
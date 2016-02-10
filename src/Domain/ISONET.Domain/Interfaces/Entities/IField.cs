using ISONET.Domain.Entities;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IField
    {
        int Position { get; set; }
        int Length { get; set; }
        LengthType LengthType { get; set; }
        FieldType FieldType { get; set; }
        string PropertyName { get; set; }
    }
}
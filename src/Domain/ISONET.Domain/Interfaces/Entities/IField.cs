namespace ISONET.Domain.Interfaces.Entities
{
    public interface IField
    {
        int Position { get; set; }
        int Length { get; set; }
        object Value { get; set; }
    }
}
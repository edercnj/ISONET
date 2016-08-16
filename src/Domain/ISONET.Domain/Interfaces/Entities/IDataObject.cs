namespace ISONET.Domain.Interfaces.Entities
{
    public interface IDataObject
    {
        string Type { get; set; }

        int Length { get; set; }

        string Value { get; set; }

        string toTypeLengthValue();
    }
}
namespace ISONET.Domain.Interfaces.Entities
{
    public interface IDataObject
    {
        string Type { get; }

        short Length { get; }

        string Value { get; set; }
    }
}
namespace ISONET.Domain.Interfaces.Entities
{
    /// <summary>
    ///     Interface para abstração de tags TLV.
    /// </summary>
    public interface IDataObject
    {
        string Type { get; set; }

        int Length { get; set; }

        object Value { get; set; }

        string toTypeLengthValue();
    }
}
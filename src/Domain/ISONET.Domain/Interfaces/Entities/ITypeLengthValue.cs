namespace ISONET.Domain.Interfaces.Entities
{
    /// <summary>
    /// Interface para abstração de tags TLV.
    /// </summary>
    public interface ITypeLengthValue
    {
        string Type { get; set; }

        int Length { get; set; }

        object Value { get; set; }
    }
}
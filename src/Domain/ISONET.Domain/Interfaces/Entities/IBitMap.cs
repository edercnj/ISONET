namespace ISONET.Domain.Interfaces.Entities
{
    public interface IBitMap
    {
        bool[] FirstBitMap { get; }
        bool[] SecondBitMap { get; }
        IDataElement[] DataElements { get; }
    }
}
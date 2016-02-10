namespace ISONET.Domain.Interfaces.Entities
{
    public interface IMessage
    {
        int Mti { get; set; }
        IInstitution Institution { get; set; }
        string MessageName { get; set; }
        bool[] BitMap { get; set; }
        IDataElement[] DataElements { get; set; }
        object[] Header { get; set; }
    }
}
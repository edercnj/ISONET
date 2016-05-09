namespace ISONET.Domain.Interfaces.Entities
{
    public interface IDataElement
    {
        IAttribute Attribute { get; }
        short Bit { get; }
        IRule ConditionUse { get; }
        string Description { get; set; }
        string Name { get; }
        object Value { get; set; }
    }
}
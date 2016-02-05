namespace ISONET.Domain.Interfaces.Entities
{
    public interface IDataElement
    {
        IAtrribute Attribute { get; }
        short Bit { get; }
        IConditionUse ConditionUse { get; }
        string Description { get; set; }
        string Name { get; }
        object Value { get; set; }
    }
}
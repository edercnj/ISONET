namespace ISONET.Domain.Interfaces.Entities
{
    public interface ITemplate
    {
        IField[] Field { get; set; }
        string Name { get; set; }
    }
}
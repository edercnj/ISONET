using System.Reflection;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IFilter
    {
        int LeLength { get; set; }
        PropertyInfo Property { get; set; }
    }
}
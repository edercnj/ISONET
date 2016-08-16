using ISONET.Domain.Interfaces.Entities;
using System.Reflection;

namespace ISONET.Domain.Entities
{
    public class Filter : IFilter
    {
        public int LeLength { get; set; }
        public PropertyInfo Property { get; set; }
    }
}
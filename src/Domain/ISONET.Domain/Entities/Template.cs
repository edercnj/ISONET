using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class Template : ITemplate
    {
        public Template(IField[] field, string name)
        {
            Field = field;
            Name = name;
        }

        public IField[] Field { get; set; }
        public string Name { get; set; }
    }
}
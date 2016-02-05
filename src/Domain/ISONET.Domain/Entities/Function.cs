using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class Function : IFunction
    {
        public int Code { get; }
        public string Description { get; }

        public Function(int code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
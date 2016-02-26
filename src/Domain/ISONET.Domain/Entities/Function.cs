using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class Function : IFunction
    {
        public Function(int code, string description)
        {
            Code = code;
            Description = description;
        }

        public int Code { get; }
        public string Description { get; }
    }
}
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    /// <summary>
    ///     Implementação do formato TLV atraves de classes.
    /// </summary>
    public class TypeLengthValue : ITypeLengthValue
    {
        public TypeLengthValue(int length, string type, object value)
        {
            Length = length;
            Type = type;
            Value = value;
        }

        /// <summary>
        ///     Identificador da TAG, este valor necessita ser único para cada TAG em uma lista.
        /// </summary>
        public string Type { get; set; }

        public int Length { get; set; }

        public object Value { get; set; }

        public override string ToString()
        {
            return Type + Length + Value;
        }
    }
}
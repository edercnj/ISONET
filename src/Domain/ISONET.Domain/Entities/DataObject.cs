using ISONET.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;

namespace ISONET.Domain.Entities
{
    public class DataObject : IDataObject
    {
        private short _length;
        private string _type;
        private string _value;

        public DataObject(string type, short length, string value, IEnumerable<AttributeFormat> attributeFormat) : this(type, length, attributeFormat)
        {
            if (length != value.Length)
                throw new ApplicationException($"Construtor inválido. Comprimento '{value.Length}' de value.Length é diferente da propriedade Length.");

            Value = value;
        }

        public DataObject(string type, short length, IEnumerable<AttributeFormat> attributeFormat)
        {
            Length = length;
            AttributeFormat = attributeFormat;
            Type = type;
        }

        public IEnumerable<AttributeFormat> AttributeFormat { get; }

        public short Length
        {
            get => _length;
            private set
            {
                if (value <= 0 || value > 992)
                    throw new ApplicationException($"Length '{value}' inválido. Valor deve estar entre 1 e 992.");

                _length = value;
            }
        }

        public string Type
        {
            get => _type;
            private set
            {
                if (value.Length != 4)
                    throw new ApplicationException($"Type com tamanho '{value.Length}' inválido. Propriedade Type deve possuir comprimento 4.");
                _type = value;
            }
        }

        public string Value
        {
            get => _value;
            set => _value = value;
        }

        public sealed override string ToString()
        {
            return Type + Convert.ToString(Length.ToString(@"D3")) + Value;
        }
    }
}
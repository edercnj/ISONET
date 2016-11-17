using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using System;

namespace ISONET.Domain.Entities
{
    public class DataObject : IDataObject
    {
        private short _length;
        private string _type;
        private string _value;

        public DataObject(string type, short length, string value) : this(type, length)
        {
            if (length != value.Length)
                throw new ApplicationException($"Construtor inválido. Comprimento '{value.Length}' de value.Length é diferente da propriedade Length.");

            Value = value;
        }

        public DataObject(string type, short length)
        {
            Length = length;
            Type = type;
        }

        public short Length
        {
            get { return _length; }
            private set
            {
                if (value <= 0 || value > 999)
                    throw new ApplicationException($"Tamanho '{value}' inválido. Valor deve estar entre 1 e 999");

                _length = value;
            }
        }

        public string Type
        {
            get { return _type; }
            private set
            {
                if (value.Length <= 0 || value.Length > 4)
                    throw new ApplicationException($"Tamanho '{value.Length}' inválido. Propriedade Type deve possuir comprimento máximo de 4.");
                if (value.ContainsSpaceAndPad())
                    throw new ApplicationException($"Valor '{value}' Inválido. Propriedade Type não deve possuir espaços.");

                _type = value;
            }
        }

        public string Value
        {
            get { return _value; }
            set
            {
                if (Length != value.Length)
                    throw new ApplicationException($"Tamanho inválido. Comprimento do value.Length={value} diferente do valor definido no campo Length={Length}.");

                _value = value;
            }
        }

        public sealed override string ToString()
        {
            return Type + Convert.ToString(Length.ToString(@"D3")) + Value;
        }
    }
}
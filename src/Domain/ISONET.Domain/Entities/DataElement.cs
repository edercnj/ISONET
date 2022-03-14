using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ISONET.Domain.Entities
{
    public class DataElement : IDataElement
    {
        private IDataElementAttribute _dataElementAttribute;
        private short _bit;
        private string _description;
        private string _name;
        private ConditionUse _conditionUse;
        private string _value;
        private IEnumerable<IDataObject> _dataObjects;

        public DataElement(IDataElementAttribute dataElementAttribute, short bit, string description, string name, ConditionUse conditionUse, string value) : this(dataElementAttribute, bit, description, name, conditionUse)
        {
            if (dataElementAttribute.Length != value.Length)
                throw new ApplicationException("Tamanho do dataElementAttribute.Length diferente do tamanho do parâmetro value.Length.");

            Value = value;
        }

        public DataElement(IDataElementAttribute dataElementAttribute, short bit, string description, string name, ConditionUse conditionUse, IEnumerable<IDataObject> dataObjects) : this(dataElementAttribute, bit, description, name, conditionUse)
        {
            if (dataElementAttribute.Length != dataObjects.Aggregate(string.Empty, (current, data) => current + data.ToString()).Length)
                throw new ApplicationException($"Tamanho de dataElementAttribute.Length diferente do tamanho retornado pelo método 'dataObjects.Aggregate(string.Empty, (current, data) => current + data.ToString()).Length'.");

            DataObjects = dataObjects;
        }

        public DataElement(IDataElementAttribute dataElementAttribute, short bit, string description, string name, ConditionUse conditionUse)
        {
            if (!dataElementAttribute.IsValid())
                throw new ApplicationException(@"DataElementAttribute inválido.");

            DataElementAttribute = dataElementAttribute;
            Bit = bit;
            Description = description;
            Name = name;
            ConditionUse = conditionUse;
        }

        public IDataElementAttribute DataElementAttribute
        {
            get => _dataElementAttribute;
            private set => _dataElementAttribute = value;
        }
        public short Bit
        {
            get => _bit;
            private set => _bit = value;
        }
        public string Description
        {
            get => _description;
            set => _description = value;
        }
        public string Name
        {
            get => _name;
            private set => _name = value;
        }
        public ConditionUse ConditionUse
        {
            get => _conditionUse;
            private set => _conditionUse = value;
        }

        public string Value
        {
            get => _value;
            set
            {
                if (DataObjects != null)
                    throw new ApplicationException("Não é possível inserir um valor em um DataElement que possua DataObjects.");

                if (value.Equals(null))
                    throw new NullReferenceException(@"Valor de 'DataElment.Value' não pode ser null.");

                _value = value;
            }
        }

        public IEnumerable<IDataObject> DataObjects
        {
            get => _dataObjects;
            set => _dataObjects = value;
        }

        public sealed override string ToString()
        {
            string value;

            switch (DataElementAttribute.LengthType)
            {
                case LengthType.LLLVAR:
                    value = DataObjects != null
                           ? Convert.ToString(Value.Length.ToString(@"D3")) + DataObjects.Aggregate(string.Empty, (current, data) => current + data.ToString())
                           : Convert.ToString(Value.Length.ToString(@"D3")) + Value;
                    break;

                case LengthType.LLVAR:
                    value = DataObjects != null
                           ? Convert.ToString(Value.Length.ToString(@"D2")) + DataObjects.Aggregate(string.Empty, (current, data) => current + data.ToString())
                           : Convert.ToString(Value.Length.ToString(@"D2")) + Value;
                    break;

                case LengthType.FIXED:
                    value = DataObjects != null
                           ? DataObjects.Aggregate(string.Empty, (current, data) => current + data.ToString())
                           : Value;
                    break;

                default:
                    value = DataObjects != null
                           ? DataObjects.Aggregate(string.Empty, (current, data) => current + data.ToString())
                           : Value;
                    break;
            }
            return value;
        }
    }
}
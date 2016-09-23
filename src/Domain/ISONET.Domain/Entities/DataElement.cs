using ISONET.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ISONET.Domain.Entities
{
    public class DataElement : IDataElement
    {
        private IAttribute _attribute;
        private short _bit;
        private string _description;
        private string _name;
        private ConditionUse _conditionUse;
        private string _value;
        private IEnumerable<IDataObject> _dataObjects;

        public DataElement(IAttribute attribute, short bit, string description, string name, ConditionUse conditionUse, string value)
        {
            Attribute = attribute;
            Bit = bit;
            Description = description;
            Name = name;
            Value = value;
            ConditionUse = conditionUse;
        }

        public DataElement(IAttribute attribute, short bit, string description, string name, ConditionUse conditionUse)
        {
            Attribute = attribute;
            Bit = bit;
            Description = description;
            Name = name;
            ConditionUse = conditionUse;
        }

        public IAttribute Attribute { get { return _attribute; } private set { _attribute = value; } }
        public short Bit { get { return _bit; } private set { _bit = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Name { get { return _name; } private set { _name = value; } }
        public ConditionUse ConditionUse { get { return _conditionUse; } private set { _conditionUse = value; } }
        public string Value { get { return _value; } set { _value = value; } }
        public IEnumerable<IDataObject> DataObjects { get { return _dataObjects; } set { _dataObjects = value; } }

        public string ToTypeLengthValue()
        {
            return DataObjects.Aggregate(string.Empty, (current, data) => current + data.toTypeLengthValue());
        }

        public override string ToString()
        {
            string value = string.Empty;

            switch (Attribute.LengthType)
            {
                case LengthType.LLLVAR:
                    value = Convert.ToString(Value.Length.ToString("D3")) + Value;
                    break;

                case LengthType.LLVAR:
                    value = Convert.ToString(Value.Length.ToString("D2")) + Value;
                    break;

                case LengthType.FIXED:
                    value = Value;
                    break;
            }

            return value;
        }

        //TODO: Implementar tratamento de exceção personalizado
        public IEnumerable<IDataObject> Split(string isoMessage)
        {
            try
            {
                IEnumerable<IDataObject> dataObjects = new List<IDataObject>();
                int index = 0;

                do
                {
                    string type = isoMessage.Substring(index, 4);
                    index += type.Length;
                    int length = int.Parse(isoMessage.Substring(index, 3));
                    index += isoMessage.Substring(index, 3).Length;
                    string value = isoMessage.Substring(index, length);
                    index += value.Length;
                    dataObjects.ToList().Add(new DataObject(type, length, value));
                } while (index < isoMessage.Length);

                return dataObjects;
            }
            catch (ApplicationException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
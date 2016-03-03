using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE104 : DataElement
    {
        //Custom Data Element
        public DE104(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 104;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE104(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 104;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE104(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 100);
            ConditionUse = conditionUse;
            Bit = 104;
            Name = "transaction description";
            Value = value;
        }

        public DE104(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 100);
            ConditionUse = conditionUse;
            Bit = 104;
            Name = "transaction description";
        }

        public DE104(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 100, length);
            ConditionUse = conditionUse;
            Bit = 104;
            Name = "transaction description";
            Value = value;
        }

        public DE104(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 100, length);
            ConditionUse = conditionUse;
            Bit = 104;
            Name = "transaction description";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
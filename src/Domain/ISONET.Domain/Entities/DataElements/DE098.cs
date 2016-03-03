using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE098 : DataElement
    {
        //Custom Data Element
        public DE098(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 098;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE098(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 098;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE098(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 25);
            ConditionUse = conditionUse;
            Bit = 098;
            Name = "payee";
            Value = value;
        }

        public DE098(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 25);
            ConditionUse = conditionUse;
            Bit = 098;
            Name = "payee";
        }

        public DE098(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 25, length);
            ConditionUse = conditionUse;
            Bit = 098;
            Name = "payee";
            Value = value;
        }

        public DE098(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 25, length);
            ConditionUse = conditionUse;
            Bit = 098;
            Name = "payee";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
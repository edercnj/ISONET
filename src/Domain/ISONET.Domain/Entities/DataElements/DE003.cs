using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE003 : DataElement
    {
        //Custom  Data Element
        public DE003(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 003;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        //Custom  Data Element
        public DE003(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 003;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        public DE003(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 6);
            ConditionUse = conditionUse;
            Bit = 003;
            Name = "processing code";
            Value = value;
        }

        public DE003(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 6);
            ConditionUse = conditionUse;
            Bit = 003;
            Name = "processing code";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
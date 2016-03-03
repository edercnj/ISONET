using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE033 : DataElement
    {
        //Custom Data Element
        public DE033(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 033;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE033(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 033;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE033(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 11);
            ConditionUse = conditionUse;
            Bit = 033;
            Name = "forwarding institution identification code";
            Value = value;
        }

        public DE033(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 11);
            ConditionUse = conditionUse;
            Bit = 033;
            Name = "forwarding institution identification code";
        }

        public DE033(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 11, length);
            ConditionUse = conditionUse;
            Bit = 033;
            Name = "forwarding institution identification code";
            Value = value;
        }

        public DE033(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 11, length);
            ConditionUse = conditionUse;
            Bit = 033;
            Name = "forwarding institution identification code";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
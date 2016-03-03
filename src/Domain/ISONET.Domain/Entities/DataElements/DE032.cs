using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE032 : DataElement
    {
        //Custom Data Element
        public DE032(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 032;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE032(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 032;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE032(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 11);
            ConditionUse = conditionUse;
            Bit = 032;
            Name = "acquirer institution identification code";
            Value = value;
        }

        public DE032(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 11);
            ConditionUse = conditionUse;
            Bit = 032;
            Name = "acquirer institution identification code";
        }

        public DE032(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 11, length);
            ConditionUse = conditionUse;
            Bit = 032;
            Name = "acquirer institution identification code";
            Value = value;
        }

        public DE032(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 11, length);
            ConditionUse = conditionUse;
            Bit = 032;
            Name = "acquirer institution identification code";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
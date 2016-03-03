using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE001 : DataElement
    {
        public DE001(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 8);
            ConditionUse = conditionUse;
            Bit = 001;
            Name = "first bit map";
            Value = value;
        }

        public DE001(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 8);
            ConditionUse = conditionUse;
            Bit = 001;
            Name = "first bit map";
        }

        public override IAtrribute Attribute { get; }

        //Custom  Data Element
        public DE001(IAtrribute attribute, short bit, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        //Custom  Data Element
        public DE001(IAtrribute attribute, short bit, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
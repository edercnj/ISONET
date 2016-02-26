using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE036 : DataElement
    {
        public DE036(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ISOTRACK }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 104);
            ConditionUse = conditionUse;
            Bit = 036;
            Name = "track 3 data";
            Value = value;
        }

        public DE036(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ISOTRACK }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 104);
            ConditionUse = conditionUse;
            Bit = 036;
            Name = "track 3 data";
        }

        public DE036(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ISOTRACK }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 104, length);
            ConditionUse = conditionUse;
            Bit = 036;
            Name = "track 3 data";
            Value = value;
        }

        public DE036(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ISOTRACK }, LengthType.LLLVAR, new[] { AttributeMask.NoMask },
                104, length);
            ConditionUse = conditionUse;
            Bit = 036;
            Name = "track 3 data";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
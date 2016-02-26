using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE031 : DataElement
    {
        public DE031(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 99);
            ConditionUse = conditionUse;
            Bit = 031;
            Name = "acquirer reference data";
            Value = value;
        }

        public DE031(IConditionUse conditionUse)
        {
            Attribute =
                new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL },
                    LengthType.LLVAR, new[] { AttributeMask.NoMask }, 99);
            ConditionUse = conditionUse;
            Bit = 031;
            Name = "acquirer reference data";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
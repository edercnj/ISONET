using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE037 : DataElement
    {
        public DE037(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPACE }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 12);
            ConditionUse = conditionUse;
            Bit = 037;
            Name = "retrieval reference number";
            Value = value;
        }

        public DE037(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPACE }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 12);
            ConditionUse = conditionUse;
            Bit = 037;
            Name = "retrieval reference number";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE022 : DataElement
    {
        public DE022(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC }, LengthType.FIXED,
                new[] { AttributeMask.NoMask }, 12);
            ConditionUse = conditionUse;
            Bit = 022;
            Name = "point of service data code";
            Value = value;
        }

        public DE022(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC }, LengthType.FIXED,
                new[] { AttributeMask.NoMask }, 12);
            ConditionUse = conditionUse;
            Bit = 022;
            Name = "point of service data code";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value
        {
            get { return Value; }
            set { Value = value; }
        }
    }
}
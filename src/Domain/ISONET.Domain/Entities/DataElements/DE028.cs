using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE028 : DataElement
    {
        public DE028(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED,
                new[] { AttributeMask.YY, AttributeMask.MM, AttributeMask.DD }, 6);
            ConditionUse = conditionUse;
            Bit = 028;
            Name = "date, reconciliation";
            Value = value;
        }

        public DE028(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED,
                new[] { AttributeMask.YY, AttributeMask.MM, AttributeMask.DD }, 6);
            ConditionUse = conditionUse;
            Bit = 028;
            Name = "date, reconciliation";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
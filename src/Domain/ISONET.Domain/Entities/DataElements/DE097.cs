using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE097 : DataElement
    {
        public DE097(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.X, AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 1 + 16);
            // Neste caso é necessário 1 + 16 pois o formato X é C ou D + o proximo formato.
            ConditionUse = conditionUse;
            Bit = 0097;
            Name = "amount, net reconciliation";
            Value = value;
        }

        public DE097(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.X, AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 1 + 16);
            // Neste caso é necessário 1 + 16 pois o formato X é C ou D + o proximo formato.
            ConditionUse = conditionUse;
            Bit = 0097;
            Name = "amount, net reconciliation";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
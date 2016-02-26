using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE056 : DataElement
    {
        public DE056(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 35);
            ConditionUse = conditionUse;
            Bit = 056;
            Name = "original data elements";
            Value = value;
        }

        public DE056(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 35);
            ConditionUse = conditionUse;
            Bit = 056;
            Name = "original data elements";
        }

        public DE056(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 35, length);
            ConditionUse = conditionUse;
            Bit = 056;
            Name = "original data elements";
            Value = value;
        }

        public DE056(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 35, length);
            ConditionUse = conditionUse;
            Bit = 056;
            Name = "original data elements";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
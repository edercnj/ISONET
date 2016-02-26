using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE012 : DataElement
    {
        public DE012(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.YY, AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 12);
            ConditionUse = conditionUse;
            Bit = 012;
            Name = "date and time, local transaction";
            Value = value;
        }

        public DE012(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.YY, AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 12);
            ConditionUse = conditionUse;
            Bit = 012;
            Name = "date and time, local transaction";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
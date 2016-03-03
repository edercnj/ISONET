using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE007 : DataElement
    {
        //Custom  Data Element
        public DE007(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 007;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom  Data Element
        public DE007(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 007;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE007(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 10);
            ConditionUse = conditionUse;
            Bit = 007;
            Name = "date and time, transmission";
            Value = value;
        }

        public DE007(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 10);
            ConditionUse = conditionUse;
            Bit = 007;
            Name = "date and time, transmission";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
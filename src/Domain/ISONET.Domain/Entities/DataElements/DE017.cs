using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE017 : DataElement
    {
        //Custom  Data Element
        public DE017(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 017;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom  Data Element
        public DE017(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 017;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE017(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.MM, AttributeMask.DD }, 4);
            ConditionUse = conditionUse;
            Bit = 017;
            Name = "date, capture";
            Value = value;
        }

        public DE017(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.MM, AttributeMask.DD }, 4);
            ConditionUse = conditionUse;
            Bit = 017;
            Name = "date, capture";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
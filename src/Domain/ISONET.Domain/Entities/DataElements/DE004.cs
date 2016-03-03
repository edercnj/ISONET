using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE004 : DataElement
    {
        //Custom  Data Element
        public DE004(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 004;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        //Custom  Data Element
        public DE004(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 004;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        public DE004(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 12);
            ConditionUse = conditionUse;
            Bit = 004;
            Name = "amount, transaction";
            Value = value;
        }

        public DE004(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 12);
            ConditionUse = conditionUse;
            Bit = 004;
            Name = "amount, transaction";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
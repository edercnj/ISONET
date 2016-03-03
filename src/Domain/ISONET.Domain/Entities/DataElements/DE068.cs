using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE068 : DataElement
    {
        //Custom Data Element
        public DE068(IAtrribute attribute, short bit, IConditionUse conditionUse, string description, string name, Country country)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = (int)country;
        }

        //Custom Data Element
        public DE068(IAtrribute attribute, short bit, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE068(IConditionUse conditionUse, Country country)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 3);
            ConditionUse = conditionUse;
            Bit = 0068;
            Name = "country code, receiving institution";
            Value = (int)country;
        }

        public DE068(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 3);
            ConditionUse = conditionUse;
            Bit = 0068;
            Name = "country code, receiving institution";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value
        {
            get { return (int)Value; } //TODO: Resolver problemas de validação para tipo object
            set { Value = (int)value; }
        }
    }
}
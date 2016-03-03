using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE069 : DataElement
    {
        //Custom Data Element
        public DE069(IAtrribute attribute, short bit, IConditionUse conditionUse, string description, string name,
            Country country)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = (int)country;
        }

        //Custom Data Element
        public DE069(IAtrribute attribute, short bit, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE069(IConditionUse conditionUse, Country country)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 3);
            ConditionUse = conditionUse;
            Bit = 0069;
            Name = "country code, settlement institution";
            Value = (int)country;
        }

        public DE069(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 3);
            ConditionUse = conditionUse;
            Bit = 0069;
            Name = "country code, settlement institution";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
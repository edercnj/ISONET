using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE092 : DataElement
    {
        //Custom Data Element
        public DE092(IAtrribute attribute, IConditionUse conditionUse, string description, string name, Country country)
        {
            Attribute = attribute;
            Bit = 092;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = (int)country;
        }

        //Custom Data Element
        public DE092(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 092;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE092(IConditionUse conditionUse, Country country)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 3);
            ConditionUse = conditionUse;
            Bit = 092;
            Name = "country code, transaction originator institution";
            Value = (int)country;
        }

        public DE092(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 3);
            ConditionUse = conditionUse;
            Bit = 092;
            Name = "country code, transaction originator institution";
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
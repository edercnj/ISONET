using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE050 : DataElement
    {
        //Custom Data Element
        public DE050(IAtrribute attribute, IConditionUse conditionUse, string description, string name, Currency currency)
        {
            Attribute = attribute;
            Bit = 050;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = (int)currency;
        }

        //Custom Data Element
        public DE050(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 050;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE050(IConditionUse conditionUse, Currency currency)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 3);
            ConditionUse = conditionUse;
            Bit = 050;
            Name = "currency code, reconciliation";
            Value = (int)currency;
        }

        public DE050(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 3);
            ConditionUse = conditionUse;
            Bit = 050;
            Name = "currency code, reconciliation";
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
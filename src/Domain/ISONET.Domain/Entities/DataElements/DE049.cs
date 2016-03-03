using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE049 : DataElement
    {
        //Custom Data Element
        public DE049(IAtrribute attribute, IConditionUse conditionUse, string description, string name, Currency currency)
        {
            Attribute = attribute;
            Bit = 049;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = (int)currency;
        }

        //Custom Data Element
        public DE049(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 049;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE049(IConditionUse conditionUse, Currency currency)
        {
            //TODO: Implementar tratamento de numérico ou Alfabético
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 3);
            ConditionUse = conditionUse;
            Bit = 049;
            Name = "currency code, transaction";
            Value = (int)currency;
        }

        public DE049(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 3);
            ConditionUse = conditionUse;
            Bit = 049;
            Name = "currency code, transaction";
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
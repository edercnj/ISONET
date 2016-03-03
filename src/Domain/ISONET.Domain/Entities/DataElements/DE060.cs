using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE060 : DataElement
    {
        //Custom Data Element
        public DE060(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 060;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE060(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 060;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE060(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 060;
            Name = "reserved for national use";
            Value = value;
        }

        public DE060(IConditionUse conditionUse, object value, string name)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 060;
            Name = name;
            Value = value;
        }

        public DE060(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 060;
            Name = "reserved for national use";
        }

        public DE060(IConditionUse conditionUse, string name)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 060;
            Name = name;
        }

        public DE060(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 060;
            Name = "reserved for national use";
            Value = value;
        }

        public DE060(IConditionUse conditionUse, object value, string name, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 060;
            Name = name;
            Value = value;
        }

        public DE060(IConditionUse conditionUse, short length)
        {
            Attribute =
                new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL },
                    LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 060;
            Name = "reserved for national use";
        }

        public DE060(IConditionUse conditionUse, string name, short length)
        {
            Attribute =
                new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL },
                    LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 060;
            Name = name;
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
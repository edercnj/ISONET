﻿using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE035 : DataElement
    {
        public DE035(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ISOTRACK }, LengthType.LLVAR, new[] { AttributeMask.NoMask },
                37);
            ConditionUse = conditionUse;
            Bit = 035;
            Name = "track 2 data";
            Value = value;
        }

        public DE035(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ISOTRACK }, LengthType.LLVAR, new[] { AttributeMask.NoMask },
                37);
            ConditionUse = conditionUse;
            Bit = 035;
            Name = "track 2 data";
        }

        public DE035(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ISOTRACK }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 37, length);
            ConditionUse = conditionUse;
            Bit = 035;
            Name = "track 2 data";
            Value = value;
        }

        public DE035(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ISOTRACK }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 37, length);
            ConditionUse = conditionUse;
            Bit = 035;
            Name = "track 2 data";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
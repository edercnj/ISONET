﻿using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE016 : DataElement
    {
        public DE016(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.MM, AttributeMask.DD }, 4);
            ConditionUse = conditionUse;
            Bit = 016;
            Name = "date, conversion";
            Value = value;
        }

        public DE016(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.MM, AttributeMask.DD }, 4);
            ConditionUse = conditionUse;
            Bit = 016;
            Name = "date, conversion";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}
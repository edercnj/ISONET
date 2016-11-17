using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataElementAttributeLengthValidation
    {
        private const int _FIXEDMAXLENGTH = 999;
        private const int _LLVARMAXLENGTH = 99;
        private const int _LLLVARMAXLENGTH = 999;

        public static bool MaxLengthIsValid(this IDataElementAttribute att)
        {
            bool isValid;

            switch (att.LengthType)
            {
                case LengthType.FIXED:
                    isValid = att.MaxLength <= _FIXEDMAXLENGTH;
                    break;

                case LengthType.LLVAR:
                    isValid = att.MaxLength <= _LLVARMAXLENGTH;
                    break;

                case LengthType.LLLVAR:
                    isValid = att.MaxLength <= _LLLVARMAXLENGTH;
                    break;

                default:
                    isValid = att.MaxLength <= _FIXEDMAXLENGTH;
                    break;
            }

            return isValid;
        }

        public static bool LengthIsValid(this IDataElementAttribute att)
        {
            return att.Length <= att.MaxLength;
        }
    }
}
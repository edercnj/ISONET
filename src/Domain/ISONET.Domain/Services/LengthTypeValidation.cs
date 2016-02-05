using ISONET.Domain.Entities;

namespace ISONET.Domain.Services
{
    public static class LengthTypeValidation
    {
        private const int _FIXEDMAXLENGTH = 999;
        private const int _LLVARMAXLENGTH = 99;
        private const int _LLLVARMAXLENGTH = 999;

        public static bool MaxLengthIsValid(LengthType lengthType, int maxlength)
        {
            bool isValid;

            switch (lengthType)
            {
                case LengthType.FIXED:
                    isValid = maxlength <= _FIXEDMAXLENGTH;
                    break;

                case LengthType.LLVAR:
                    isValid = maxlength <= _LLVARMAXLENGTH;
                    break;

                case LengthType.LLLVAR:
                    isValid = maxlength <= _LLLVARMAXLENGTH;
                    break;

                default:
                    isValid = maxlength <= _FIXEDMAXLENGTH;
                    break;
            }

            return isValid;
        }
    }
}
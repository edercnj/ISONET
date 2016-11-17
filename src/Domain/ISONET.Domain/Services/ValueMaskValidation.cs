using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;
using System.Linq;

namespace ISONET.Domain.Services
{
    public static class ValueMaskValidation
    {
        public static bool MaskIsValid(IDataElement dataElement)
        {
            return ValueMaskIsValid(dataElement);
        }

        private static bool ValidMask(string val, AttributeMask mask)
        {
            var isValid = true;

            switch (mask)
            {
                case AttributeMask.NoMask:
                    isValid = true;
                    break;

                case AttributeMask.MM:
                    isValid = val.IsMonth();
                    break;

                case AttributeMask.DD:
                    isValid = val.IsDay();
                    break;

                case AttributeMask.YY:
                    isValid = val.IsYear();
                    break;

                case AttributeMask.hh:
                    isValid = val.IsHour();
                    break;

                case AttributeMask.mm:
                    isValid = val.IsMinute();
                    break;

                case AttributeMask.ss:
                    isValid = val.IsSecond();
                    break;
            }

            return isValid;
        }

        private static bool ValueMaskIsValid(IDataElement dataElement)
        {
            var deMasks = dataElement.DataElementAttribute.AttributeMask.ToList();
            var value = dataElement.Value;
            var index = 0;
            foreach (AttributeMask mask in deMasks)
            {
                var val = value.Substring(index, 2);
                index += 2;
                var isValid = ValidMask(val, mask);
                if (!isValid)
                    return false;
            }

            return true;
        }
    }
}
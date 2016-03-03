using System;
using System.Linq;

namespace ISONET.Domain.Services
{
    public static class DataConvert
    {
        public static char[] ToCharArray(string binaryString)
        {
            return binaryString.ToCharArray();
        }

        public static string ToBinaryString(string hexValue)
        {
            return string.Join(string.Empty, hexValue.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        }

        public static bool[] ToBitMap(string HexValue)
        {
            string binaryString = ToBinaryString(HexValue);
            var binaryCharArray = ToCharArray(binaryString);

            return ToBoolArray(binaryCharArray);
        }

        public static bool[] ToBoolArray(char[] binaryCharArray)
        {
            var bitMap = new bool[binaryCharArray.Length];

            for (int i = 0; i < binaryCharArray.Length; i++)
            {
                switch (Convert.ToInt32(binaryCharArray[i].ToString()))
                {
                    case 1:
                        bitMap[i] = true;
                        break;

                    case 0:
                        bitMap[i] = false;
                        break;

                    default:
                        throw new FormatException("Somente são esperados valores binários de 0 e 1");
                }
            }

            return bitMap;
        }

        public static int ConvertToNumeric(object val, int decimalPlaces)
        {
            string decimalFormat = "D" + decimalPlaces;
            string value = Convert.ToInt32(val.ToString()).ToString(decimalFormat);

            return Convert.ToInt32(value);
        }
    }
}
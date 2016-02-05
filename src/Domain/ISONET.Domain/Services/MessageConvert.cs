using System;
using System.Linq;

namespace ISONET.Domain.Services
{
    public static class MessageConvert
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
            char[] binaryCharArray = ToCharArray(binaryString);

            return ToBoolArray(binaryCharArray);
        }

        public static bool[] ToBoolArray(char[] binaryCharArray)
        {
            bool[] bitMap = new bool[64];

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
    }
}
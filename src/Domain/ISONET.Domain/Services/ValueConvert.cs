using System;
using System.Linq;
using System.Text;

namespace ISONET.Domain.Services
{
    public static class ValueConvert
    {
        public static char[] BinaryStringToCharArray(this string binaryString) => binaryString.ToCharArray();

        public static string HexToBinaryString(this string hexValue) => string.Join(@"", hexValue.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));

        public static bool[] HexToBitMapBoolArray(this string HexValue) => BinaryStringToCharArray(HexValue.HexToBinaryString()).BinaryCharArrayToBoolArray();

        public static bool[] BinaryCharArrayToBoolArray(this char[] binaryCharArray)
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
                }
            }
            return bitMap;
        }

        public static int ToNumeric(object val, int decimalPlaces)
        {
            var decimalFormat = @"D" + decimalPlaces;
            var value = Convert.ToInt32(val.ToString()).ToString(decimalFormat);

            return Convert.ToInt32(value);
        }

        public static string BinaryStringToHexa(this string binary)
        {
            var result = new StringBuilder(binary.Length / 8 + 1);

            if ((binary.Length % 8) != 0)
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');

            for (int i = 0; i < binary.Length; i += 8)
            {
                var eightBits = binary.Substring(i, 8);
                result.Append($"{Convert.ToByte(eightBits, 2):X2}");
            }

            return result.ToString();
        }

        public static string BoolArrayToHexa(this bool[] bitMap)
        {
            try
            {
                var stringBitMap = new StringBuilder();

                foreach (var bit in bitMap)
                {
                    if (bit)
                        stringBitMap.Append(@"1");
                    else
                        stringBitMap.Append(@"0");
                }

                return stringBitMap.ToString().BinaryStringToHexa();
            }
            catch (Exception erro)
            {
                throw new Exception(@"Erro ao converter o map de Bits para string: " + erro.Message);
            }
        }
    }
}
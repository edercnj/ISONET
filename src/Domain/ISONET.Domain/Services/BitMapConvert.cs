using System;

namespace ISONET.Domain.Services
{
    public static class BitMapConvert
    {
        public static string BitMapToString(bool[] bitMap)
        {
            try
            {
                string stringBitMap = string.Empty;
                for (int index = 0; index < bitMap.Length; index++)
                {
                    bool bit = bitMap[index];
                    if (bit)
                        stringBitMap += "1";
                    else
                        stringBitMap += "0";
                }

                return stringBitMap;
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao converter o map de Bits para string: " + erro.Message);
            }
        }
    }
}
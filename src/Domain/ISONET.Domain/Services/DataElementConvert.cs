using ISONET.Domain.Interfaces.Entities;
using System.Linq;

namespace ISONET.Domain.Services
{
    public static class DataElementConvert
    {
        public static bool[] DataElementsToBitMap(this IMessage message)
        {
            var deBits = new bool[128];
            var list = message.DataElements.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                deBits[list[i].Bit - 1] = true;
            }

            return deBits;
        }
    }
}
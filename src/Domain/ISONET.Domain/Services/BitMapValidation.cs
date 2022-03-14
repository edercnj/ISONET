using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class BitMapValidation
    {
        public static bool BitMapIsValid(this IMessage message)
        {
            var de = message.DataElementsToBitMap();

            for (int i = 0; i < message.BitMap.Length; i++)
            {
                if (de[i] != message.BitMap[i])
                    return false;
            }

            return true;
        }
    }
}
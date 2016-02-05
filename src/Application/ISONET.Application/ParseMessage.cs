using ISONET.Domain.Entities;
using ISONET.Domain.Services;
using System.Reflection;

namespace ISONET.Application
{
    public class ParseMessage
    {
        public ParseMessage(string message, BitMap template)
        {
            PropertyInfo[] properties = typeof(BitMap).GetProperties();

            if (BitMapValidation.IsValid(template))
            {
                foreach (PropertyInfo property in properties)
                {
                    switch (property.Name)
                    {
                        case "FirstBitMap":
                            property.SetValue(template, MessageConvert.ToBitMap(message.Substring(3, 3 + (16 - 1))));
                            break;

                        case "secondBitMap":
                            property.SetValue(template, MessageConvert.ToBitMap(message.Substring(19, 19 + (16 - 1))));
                            break;

                        case "dataElements":
                            break;
                    }
                }
            }
        }
    }
}
using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;

namespace ISONET.Application
{
    internal static class MessageExtension
    {
        public static Message Map(this IMessage message, string stringMessage, ITemplate template)
        {
            int ignoreString = 0;
            Message msg = (Message)message;

            for (int i = 0; i < template.Field.Length; i++)
            {
                switch (template.Field[i].FieldType)
                {
                    case FieldType.Header:
                        msg.Header[template.Field[i].Position] = stringMessage.Substring(ignoreString, template.Field[i].Length);
                        ignoreString += template.Field[i].Length;
                        break;

                    case FieldType.BitMap:
                        msg.BitMap = DataConvert.ToBitMap(stringMessage.Substring(ignoreString, template.Field[i].Length));
                        break;

                    case FieldType.DataElement:
                        switch (template.Field[i].LengthType)
                        {
                            case LengthType.FIXED:
                                msg.DataElements[template.Field[i].Position].Value = stringMessage.Substring(ignoreString, template.Field[i].Length);
                                ignoreString += template.Field[i].Length;
                                break;

                            case LengthType.LLVAR:
                                msg.DataElements[template.Field[i].Position].Value = stringMessage.Substring(ignoreString + 2, template.Field[i].Length);
                                ignoreString += template.Field[i].Length;
                                break;

                            case LengthType.LLLVAR:
                                msg.DataElements[template.Field[i].Position].Value = stringMessage.Substring(ignoreString + 3, template.Field[i].Length);
                                ignoreString += template.Field[i].Length;
                                break;
                        }
                        break;

                    case FieldType.Mti:
                        msg.Mti = int.Parse(stringMessage.Substring(ignoreString, template.Field[i].Length));
                        ignoreString += template.Field[i].Length;
                        break;
                }
            }
            return msg;
        }
    }
}
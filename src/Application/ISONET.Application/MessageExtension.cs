using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Application
{
    internal static class MessageExtension
    {
        //TODO: Implementar mapeamentos através de Refletion
        public static Message Map(this IMessage message, string stringMessage, ITemplate template)
        {
            return null;
        }
    }
}
using ISONET.Domain.Interfaces.Entities;
using System;

namespace ISONET.Domain.Core.Entities
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class MessageAttribute : Attribute
    {
        public IMessage Message { get; }

        public MessageAttribute(IMessage message)
        {
            Message = message;
        }
    }
}
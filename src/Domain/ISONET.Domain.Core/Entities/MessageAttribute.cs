using System;

namespace ISONET.Domain.Core.Entities
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class MessageAttribute : Attribute
    {
        public short Mti { get; }
        public string Header { get; }

        public MessageAttribute(short mti, string header)
        {
            Mti = mti;
            Header = header;
        }
    }
}
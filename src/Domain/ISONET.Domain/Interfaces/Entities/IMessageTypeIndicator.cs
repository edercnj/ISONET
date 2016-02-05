using ISONET.Domain.Entities;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IMessageTypeIndicator
    {
        MessageClass MessageClass { get; }
        MessageFunction MessageFunction { get; }
        MessageVersion MessageVersion { get; }
        int Mit { get; }
        MessageOrigin OriginMessage { get; }
    }
}
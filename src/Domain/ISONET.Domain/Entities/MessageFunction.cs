namespace ISONET.Domain.Entities
{
    public enum MessageFunction
    {
        Request = 0000,
        RequestResponse = 0010,
        Advice = 0020,
        AdviceResponse = 0030,
        Notification = 0040,
        ResponseAcknowledgment = 0080,
        NegativeAcknowledgment = 0090
    }
}
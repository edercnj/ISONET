namespace ISONET.Domain.Interfaces.Entities
{
    public interface IPointOfService
    {
        string CardDataInputCapability { get; }
        string CardholderAuthenticationCapability { get; }
        string CardCaptureCapability { get; }
        string OperatingEnvironment { get; }
        string CardholderPresent { get; }
        string CardPresent { get; }
        string CardDataInputMode { get; }
        string CardholderAuthenticationMethod { get; }
        string CardholderAuthenticationEntity { get; }
        string CardDataOutputCapability { get; }
        string TerminalOutputCapability { get; }
        string PINCaptureCapability { get; }
    }
}
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class PointOfService : IPointOfService
    {
        public string CardDataInputCapability { get; }
        public string CardholderAuthenticationCapability { get; }
        public string CardCaptureCapability { get; }
        public string OperatingEnvironment { get; }
        public string CardholderPresent { get; }
        public string CardPresent { get; }
        public string CardDataInputMode { get; }
        public string CardholderAuthenticationMethod { get; }
        public string CardholderAuthenticationEntity { get; }
        public string CardDataOutputCapability { get; }
        public string TerminalOutputCapability { get; }
        public string PINCaptureCapability { get; }

        public PointOfService(string cardDataInputCapability, string cardholderAuthenticationCapability, string cardCaptureCapability,
                              string operatingEnvironment, string cardholderPresent, string cardPresent, string cardDataInputMode,
                              string cardholderAuthenticationMethod, string cardholderAuthenticationEntity, string cardDataOutputCapability,
                              string terminalOutputCapability, string pinCaptureCapability)
        {
            CardDataInputCapability = cardDataInputCapability;
            CardholderAuthenticationCapability = cardholderAuthenticationCapability;
            CardCaptureCapability = cardCaptureCapability;
            OperatingEnvironment = operatingEnvironment;
            CardholderPresent = cardholderPresent;
            CardPresent = cardPresent;
            CardDataInputMode = cardDataInputMode;
            CardholderAuthenticationMethod = cardholderAuthenticationMethod;
            CardholderAuthenticationEntity = cardholderAuthenticationEntity;
            CardDataOutputCapability = cardDataOutputCapability;
            TerminalOutputCapability = terminalOutputCapability;
            PINCaptureCapability = pinCaptureCapability;
        }

        public override string ToString()
        {
            return CardDataInputCapability + CardholderAuthenticationCapability + CardCaptureCapability + OperatingEnvironment +
                   CardholderPresent + CardPresent + CardDataInputMode + CardholderAuthenticationMethod +
                   CardholderAuthenticationEntity + CardDataOutputCapability + TerminalOutputCapability + PINCaptureCapability;
        }
    }
}
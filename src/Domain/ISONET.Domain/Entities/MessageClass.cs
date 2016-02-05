namespace ISONET.Domain.Entities
{
    public enum MessageClass
    {
        Authorization = 0100,
        Financial = 0200,
        FileActions = 0300,
        Reversal = 0400,
        Reconciliation = 0500,
        Administrative = 0600,
        FeeCollection = 0700,
        NetworkManagement = 0800
    }
}
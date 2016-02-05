using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class MerchantCategoryClassification : IMerchantCategoryClassification
    {
        public int MCC { get; }
        public string MerchantType { get; }

        public MerchantCategoryClassification(int mcc, string merchantType)
        {
            MCC = mcc;
            MerchantType = merchantType;
        }
    }
}
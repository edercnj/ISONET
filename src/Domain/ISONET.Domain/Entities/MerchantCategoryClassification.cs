using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class MerchantCategoryClassification : IMerchantCategoryClassification
    {
        public MerchantCategoryClassification(int mcc, string merchantType)
        {
            MCC = mcc;
            MerchantType = merchantType;
        }

        public int MCC { get; }
        public string MerchantType { get; }
    }
}
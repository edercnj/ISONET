using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class Institution : IInstitution
    {
        public Institution(int institutionIdentificationCode, string name, InstitutionType institutionType)
        {
            InstitutionIdentificationCode = institutionIdentificationCode;
            Name = name;
            InstitutionType = institutionType;
        }

        public int InstitutionIdentificationCode { get; }
        public string Name { get; }
        public InstitutionType InstitutionType { get; }
    }
}
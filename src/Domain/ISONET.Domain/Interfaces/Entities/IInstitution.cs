using ISONET.Domain.Entities;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IInstitution
    {
        int InstitutionIdentificationCode { get; }
        string Name { get; }
        InstitutionType InstitutionType { get; }
    }
}
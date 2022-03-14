using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataObjectValidation
    {
        //TODO: Implementar verificação se o DataObject é válido, com base no seu value, tamanho.
        public static bool IsValid(this IDataObject dataObject) => dataObject.ValueIsValid();
    }
}
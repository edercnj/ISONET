using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
	public static class AttributeValidation
	{
		//TODO: Implementar validação de AttributeMask
		public static bool IsValid(this IAttribute attribute)
		{
			return attribute.LengthIsValid() && attribute.MaxLengthIsValid();
		}
	}
}
namespace ISONET.Domain.Services
{
    public static class DataElementValueValidation
    {
        public static bool IsValid(object value)
        {
            bool isValid = !value.Equals(null) || !value.Equals("");

            return isValid;
        }
    }
}
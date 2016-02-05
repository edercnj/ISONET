namespace ISONET.Domain.Services
{
    public static class DataElementNameValidation
    {
        public static bool IsValid(string name)
        {
            bool isValid = !string.IsNullOrEmpty(name);

            return isValid;
        }
    }
}
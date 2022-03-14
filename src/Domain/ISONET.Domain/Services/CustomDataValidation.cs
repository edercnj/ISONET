using System.Text.RegularExpressions;

namespace ISONET.Domain.Services
{
    public static class CustomDataValidation
    {
        //TODO: Implementar validação do tamanho do service Code (3 posições)
        public static bool IsServiceCode(this string value) => Regex.IsMatch(value, @"^(1|2|5|6|7)(0|2)(0|1|2|3|5|6|7)$");
    }
}
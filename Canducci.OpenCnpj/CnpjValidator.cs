using System.Linq;
namespace Canducci.OpenCnpj
{
    internal static class CnpjValidator
    {
        public static bool IsValid(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj))
                return false;

            // Mantém apenas dígitos
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            if (cnpj.Length != 14)
                return false;

            // Rejeita sequências repetidas (ex: 00000000000000)
            if (cnpj.All(c => c == cnpj[0]))
                return false;

            int[] multiplicator1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicator2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpj.Substring(0, 12);
            int sum = 0;

            for (int i = 0; i < 12; i++)
                sum += int.Parse(tempCnpj[i].ToString()) * multiplicator1[i];

            int remainder = (sum % 11);
            int digit = remainder < 2 ? 0 : 11 - remainder;
            string checkDigits = digit.ToString();

            tempCnpj += checkDigits;
            sum = 0;

            for (int i = 0; i < 13; i++)
                sum += int.Parse(tempCnpj[i].ToString()) * multiplicator2[i];

            remainder = (sum % 11);
            digit = remainder < 2 ? 0 : 11 - remainder;
            checkDigits += digit.ToString();

            return cnpj.EndsWith(checkDigits);
        }
    }
}


namespace Canducci.OpenCnpj
{
    public sealed class CompanyInfoValue
    {
        internal CompanyInfoValue(string number)
        {
            Number = number;
        }
        public string Number { get; private set; }        
        public static bool TryParse(string value, out CompanyInfoValue companyInfoValue)
        {
            companyInfoValue = null;
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            companyInfoValue = new CompanyInfoValue(value);
            return true;
        }

        public static CompanyInfoValue Parse(string value)
        {
            if (TryParse(value, out CompanyInfoValue zipCodeValue))
            {
                return zipCodeValue;
            }
            throw new System.FormatException("Invalid Cnpj");
        }

        public static implicit operator string(CompanyInfoValue zipCodeValue)
        {
            return zipCodeValue.Number;
        }

        public static implicit operator CompanyInfoValue(string value)
        {
            return Parse(value);
        }
    }
}


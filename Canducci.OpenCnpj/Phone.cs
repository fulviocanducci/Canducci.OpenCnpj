using System.Text.Json.Serialization;
namespace Canducci.OpenCnpj
{
    public class Phone
    {
        [JsonConstructor]
        public Phone(string areaCode, string number, bool isFax)
        {
            AreaCode = areaCode;
            Number = number;
            IsFax = isFax;
        }

        [JsonPropertyName("ddd")]
        public string AreaCode { get; private set; }

        [JsonPropertyName("numero")]
        public string Number { get; private set; }

        [JsonPropertyName("is_fax")]
        public bool IsFax { get; private set; }
    }
}


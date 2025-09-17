using System.Text.Json.Serialization;
namespace Canducci.OpenCnpj
{
    public class Phone
    {
        [JsonPropertyName("ddd")]
        public string AreaCode { get; private set; }

        [JsonPropertyName("numero")]
        public string Number { get; private set; }

        [JsonPropertyName("is_fax")]
        public bool IsFax { get; private set; }
    }
}


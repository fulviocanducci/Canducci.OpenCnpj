using System.Text.Json.Serialization;

namespace Canducci.OpenCnpj
{
    public class Shareholder
    {
        [JsonPropertyName("nome_socio")]
        public string PartnerName { get; private set; }

        [JsonPropertyName("cnpj_cpf_socio")]
        public string PartnerDocument { get; private set; }

        [JsonPropertyName("qualificacao_socio")]
        public string PartnerQualification { get; private set; }

        [JsonPropertyName("data_entrada_sociedade")]
        public string EntryDate { get; private set; }

        [JsonPropertyName("identificador_socio")]
        public string PartnerType { get; private set; }

        [JsonPropertyName("faixa_etaria")]
        public string AgeRange { get; private set; }
    }
}


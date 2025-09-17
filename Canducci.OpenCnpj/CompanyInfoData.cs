using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Canducci.OpenCnpj
{
    public class CompanyInfoData
    {
        [JsonConstructor]
        public CompanyInfoData
        (
            string cnpj, 
            string corporateName, 
            string tradeName, 
            string registrationStatus, 
            string registrationStatusDate, 
            string headquartersOrBranch, 
            string activityStartDate, 
            string mainCnae, 
            List<string> secondaryCnaes, 
            string legalNature, 
            string street, 
            string number, 
            string addressComplement, 
            string neighborhood, 
            string zipCode, 
            string state, 
            string city, 
            string email, 
            List<Phone> phones, 
            string shareCapital, 
            string companySize, 
            string simpleOption, 
            string simpleOptionDate, 
            string meiOption, 
            string meiOptionDate, 
            List<Shareholder> shareholders
        )
        {
            Cnpj = cnpj;
            CorporateName = corporateName;
            TradeName = tradeName;
            RegistrationStatus = registrationStatus;
            RegistrationStatusDate = registrationStatusDate;
            HeadquartersOrBranch = headquartersOrBranch;
            ActivityStartDate = activityStartDate;
            MainCnae = mainCnae;
            SecondaryCnaes = secondaryCnaes;
            LegalNature = legalNature;
            Street = street;
            Number = number;
            AddressComplement = addressComplement;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            State = state;
            City = city;
            Email = email;
            Phones = phones;
            ShareCapital = shareCapital;
            CompanySize = companySize;
            SimpleOption = simpleOption;
            SimpleOptionDate = simpleOptionDate;
            MeiOption = meiOption;
            MeiOptionDate = meiOptionDate;
            Shareholders = shareholders;
        }

        [JsonPropertyName("cnpj")]
        public string Cnpj { get; private set; }

        [JsonPropertyName("razao_social")]
        public string CorporateName { get; private set; }

        [JsonPropertyName("nome_fantasia")]
        public string TradeName { get; private set; }

        [JsonPropertyName("situacao_cadastral")]
        public string RegistrationStatus { get; private set; }

        [JsonPropertyName("data_situacao_cadastral")]
        public string RegistrationStatusDate { get; private set; }

        [JsonPropertyName("matriz_filial")]
        public string HeadquartersOrBranch { get; private set; }

        [JsonPropertyName("data_inicio_atividade")]
        public string ActivityStartDate { get; private set; }

        [JsonPropertyName("cnae_principal")]
        public string MainCnae { get; private set; }

        [JsonPropertyName("cnaes_secundarios")]
        public List<string> SecondaryCnaes { get; private set; }

        [JsonPropertyName("natureza_juridica")]
        public string LegalNature { get; private set; }

        [JsonPropertyName("logradouro")]
        public string Street { get; private set; }

        [JsonPropertyName("numero")]
        public string Number { get; private set; }

        [JsonPropertyName("complemento")]
        public string AddressComplement { get; private set; }

        [JsonPropertyName("bairro")]
        public string Neighborhood { get; private set; }

        [JsonPropertyName("cep")]
        public string ZipCode { get; private set; }

        [JsonPropertyName("uf")]
        public string State { get; private set; }

        [JsonPropertyName("municipio")]
        public string City { get; private set; }

        [JsonPropertyName("email")]
        public string Email { get; private set; }

        [JsonPropertyName("telefones")]
        public List<Phone> Phones { get; private set; }

        [JsonPropertyName("capital_social")]
        public string ShareCapital { get; private set; }

        [JsonPropertyName("porte_empresa")]
        public string CompanySize { get; private set; }

        [JsonPropertyName("opcao_simples")]
        public string SimpleOption { get; private set; }

        [JsonPropertyName("data_opcao_simples")]
        public string SimpleOptionDate { get; private set; }

        [JsonPropertyName("opcao_mei")]
        public string MeiOption { get; private set; }

        [JsonPropertyName("data_opcao_mei")]
        public string MeiOptionDate { get; private set; }

        [JsonPropertyName("QSA")]
        public List<Shareholder> Shareholders { get; private set; }
    }
}
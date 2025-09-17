using System.Threading.Tasks;
namespace Canducci.OpenCnpj
{
    public class CompanyInfoRequest : ICompanyInfoRequest
    {
        private readonly IWebRequestClient _webRequestClient;
        public CompanyInfoRequest(IWebRequestClient webRequestClient)
        {
            _webRequestClient = webRequestClient;
        }

        public Task<CompanyInfoResult> GetCnpjAsync(string cnpj)
        {
            string value = cnpj.ToNumber();
            if (!value.IsCnpj())
            {
                return Task.FromResult(CompanyInfoResult.Fail(500, "CNPJ invalid"));
            }
            return _webRequestClient.GetCnpjAsync(value);
        }

        public Task<CompanyInfoResult> GetCnpjAsync(CompanyInfoData companyInfoData)
        {
            return GetCnpjAsync(companyInfoData.Cnpj);
        }
    }
}
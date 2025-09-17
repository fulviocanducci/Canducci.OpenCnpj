using System.Threading.Tasks;
namespace Canducci.OpenCnpj
{
    public interface ICompanyInfoRequest
    {
        Task<CompanyInfoResult> GetCnpjAsync(string cnpj);
        Task<CompanyInfoResult> GetCnpjAsync(CompanyInfoData companyInfoData);
    }

}


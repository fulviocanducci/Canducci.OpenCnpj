using System.Threading.Tasks;
namespace Canducci.OpenCnpj
{
    public interface IWebRequestClient
    {
        Task<CompanyInfoResult> GetCnpjAsync(string zipCode);
    }
}


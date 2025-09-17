using Canducci.OpenCnpj;
using Microsoft.AspNetCore.Mvc;
namespace WebAppOpenCnpjTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    public class CnpjController(ICompanyInfoRequest companyInfoRequest) : ControllerBase
    {
        private readonly ICompanyInfoRequest _companyInfoRequest = companyInfoRequest;

        [HttpGet("{cnpj}")]
        public async Task<IActionResult> Get(string cnpj)
        {
            CompanyInfoResult? result = await _companyInfoRequest.GetCnpjAsync(cnpj);
            if (result is not null && result.IsValid)
            {
                return Ok(result.Data);
            }
            return NotFound();
        }
    }
}
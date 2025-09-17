using Canducci.OpenCnpj;
namespace Canducci.OpenCnpjTest
{
    public class Tests
    {
        internal IWebRequestClient WebRequestClient;
        internal ICompanyInfoRequest CompanyInfoRequest;

        [SetUp]
        public void Setup()
        {
            WebRequestClient = new WebRequestClient(new HttpClient()
            {
                BaseAddress = new Uri("https://api.opencnpj.org/")
            });
            CompanyInfoRequest = new CompanyInfoRequest(WebRequestClient);
        }

        [Test]
        public async Task TestCnpjOkAsync()
        {
            CompanyInfoResult? result = await CompanyInfoRequest.GetCnpjAsync("13990624000145");
            Assert.IsTrue(result.IsValid);
        }

        [Test]
        public async Task TestCnpjErrorAsync()
        {
            CompanyInfoResult? result = await CompanyInfoRequest.GetCnpjAsync("00.000.000/0000-00");
            Assert.IsFalse(result.IsValid);
        }
    }
}
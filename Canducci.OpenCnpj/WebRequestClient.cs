using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
namespace Canducci.OpenCnpj
{
    public class WebRequestClient : IWebRequestClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public WebRequestClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<CompanyInfoResult> GetCnpjAsync(string cnpj)
        {
            try
            {
                HttpResponseMessage message = await _httpClient.GetAsync(cnpj);
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CompanyInfoData data = JsonSerializer.Deserialize<CompanyInfoData>(json, Options);
                    return CompanyInfoResult.Success((int)message.StatusCode, data, message.ReasonPhrase);
                }
                return CompanyInfoResult.Fail((int)message.StatusCode, message.ReasonPhrase);
            }
            catch (HttpRequestException ex)
            {
                return CompanyInfoResult.Fail(503, ex.Message);
            }
            catch (TaskCanceledException ex)
            {
                return CompanyInfoResult.Fail(408, ex.Message);
            }
            catch (Exception ex)
            {
                return CompanyInfoResult.Fail(500, ex.Message);
            }
        }
    }
}


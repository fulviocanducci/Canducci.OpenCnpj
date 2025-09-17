namespace Canducci.OpenCnpj
{
    public class CompanyInfoResult
    {
        public bool IsValid => StatusCode >= 200 && StatusCode < 300 && Data != null;
        public int StatusCode { get; }
        public string ReasonPhrase { get; }
        public CompanyInfoData Data { get; }
        
        internal CompanyInfoResult(int statusCode, CompanyInfoData data, string reasonPhrase)
        {
            StatusCode = statusCode;
            Data = data;
            ReasonPhrase = reasonPhrase;
        }

        internal CompanyInfoResult(int statusCode, string reasonPhrase)
        {
            StatusCode = statusCode;
            Data = null;
            ReasonPhrase = reasonPhrase;
        }

        public static CompanyInfoResult Success(int statusCode, CompanyInfoData data, string reasonPhrase) => new CompanyInfoResult(statusCode, data, reasonPhrase);     
        public static CompanyInfoResult Fail(int statusCode, string reasonPhrase) => new CompanyInfoResult(statusCode, reasonPhrase);
    }
}


using Microsoft.Extensions.DependencyInjection;
using System;
namespace Canducci.OpenCnpj
{
    public static class Extensions
    {
        public static IServiceCollection AddOpenCnpj(this IServiceCollection services)
        {
            services.AddHttpClient<IWebRequestClient, WebRequestClient>(client =>
            {
                client.BaseAddress = new Uri("https://api.opencnpj.org/");
            });
            services.AddTransient<ICompanyInfoRequest, CompanyInfoRequest>();
            return services;
        }

        internal static string ToNumber(this string zipCode)
        {
            return System.Text.RegularExpressions.Regex.Replace(zipCode, "[^0-9]", "");
        }

        internal static bool IsCnpj(this string value)
        {
            return value.Length == 14 && CnpjValidator.IsValid(value);
        }
    }
}


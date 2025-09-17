# Canducci.OpenCnpj

[![Version](https://img.shields.io/nuget/v/Canducci.OpenCnpj.svg?style=plastic&label=version)](https://www.nuget.org/packages/Canducci.OpenCnpj/) [![NuGet](https://img.shields.io/nuget/dt/Canducci.OpenCnpj.svg)](https://www.nuget.org/packages/Canducci.OpenCnpj/)
[![Canducci.OpenZip](https://github.com/fulviocanducci/Canducci.OpenCnpj/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/fulviocanducci/Canducci.OpenCnpj/actions/workflows/dotnet-desktop.yml)

## Code In-line

### namespace 
```csharp
Canducci.OpenCnpj
```

```csharp
IWebRequestClient WebRequestClient = new WebRequestClient(new HttpClient()
{
      BaseAddress = new Uri("https://api.opencnpj.org/")
});
ICompanyInfoRequest CompanyInfoRequest = new CompanyInfoRequest(WebRequestClient);
CompanyInfoResult? result = await CompanyInfoRequest.GetCnpjAsync("00.000.000/0001-00");
if (result.IsValid)
{
      var data = result.Data;
      data.Cnpj, 
      data.CorporateName, 
      data.TradeName, 
      data.RegistrationStatus, 
      data.RegistrationStatusDate, 
      data.HeadquartersOrBranch, 
      data.ActivityStartDate, 
      data.MainCnae, 
      data.SecondaryCnaes, 
      data.LegalNature, 
      data.Street, 
      data.Number, 
      data.AddressComplement, 
      data.Neighborhood, 
      data.ZipCode, 
      data.State, 
      dataCity, 
      data.Email, 
      data.Phones, 
      data.ShareCapital, 
      data.CcompanySize, 
      data.SimpleOption, 
      data.SimpleOptionDate, 
      data.MeiOption, 
      data.MeiOptionDate, 
      data.Shareholders
}
```

## Code Web 

#### [_Project Example MVC_](https://github.com/fulviocanducci/Canducci.OpenCnpj/tree/master/WebAppOpenCnpjTest)

### namespace 
```csharp
Canducci.OpenCnpj
```

### Configuration 

```csharp
services.AddOpenZip();
```

### Controller

```csharp
public async Task<ActionResult> GetCnpj
(
   [FromService]ICompanyInfoRequest companyInfoRequest, 
   string cnpj
)
{
   CompanyInfoResult? result = await companyInfoRequest.GetCnpjAsync(cnpj);
   if (result.IsValid)
   {
   }
}
```

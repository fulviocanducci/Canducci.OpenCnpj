# Canducci.OpenCnpj

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
public async Task<ActionResult> GetCnpj([FromService]ICompanyInfoRequest companyInfoRequest, string cnpj)
{
   CompanyInfoResult? result = await companyInfoRequest.GetCnpjAsync(cnpj);
   if (result.IsValid)
   {
   }
}
```

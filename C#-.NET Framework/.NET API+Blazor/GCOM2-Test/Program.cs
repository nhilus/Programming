using GCOM2_Test;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using GCOM2_Test.Data;
using GCOM2_Test.Services;
using System.Data.Entity.Core.Objects.DataClasses;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhjVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF9iS3xUdkNhXHpccn1TQw==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3xSdEdkWXlcdXFXRWFeVA==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRd0dhXn9YcnFQRGNeWUE=;ODIzNjMyQDMyMzAyZTM0MmUzMEhVT2RjcnpyS3BtemdaRXljbG9HMk5JNVhiVVlsYitZS2xlL3Y3aGp3OE09;ODIzNjMzQDMyMzAyZTM0MmUzMFZLU0g2dWE3aThsQnR2UldnQmRIZjU4d3BpL01abDNzRi84aWdKSGtGamc9;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdERhW3hednZQQ2JYUEdz;ODIzNjM1QDMyMzAyZTM0MmUzME5VVlg2YjkxSGxNNW1qMUVPdXYzcjhQeHRDeTd1RGp4R1JGUllKTURUczg9;ODIzNjM2QDMyMzAyZTM0MmUzMGJTdTNHYTV1cnlUN213R3lmSUVmdlpCejE1U3JwdGZ3dXM5Vno2UUxFZmc9;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRd0dhXn9YcnFQRGVcVkE=;ODIzNjM4QDMyMzAyZTM0MmUzMEEyb0dDOGhhNE44eDdFbzlYVlZtV1BuQUZxcnlQZnIzRGZZOTdYK3Nsa2M9;ODIzNjM5QDMyMzAyZTM0MmUzMFZpV2xJNFFSUzlEbk1ZbWhTaHFNdTQvY2YzdTJRR0o5ZkNUcFk4VzZ1QVk9;ODIzNjQwQDMyMzAyZTM0MmUzME5VVlg2YjkxSGxNNW1qMUVPdXYzcjhQeHRDeTd1RGp4R1JGUllKTURUczg9");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp=> new HttpClient { BaseAddress = new Uri("https://randomuser.me/api/")});
builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
});
builder.Services.AddScoped<Clientservices>();
builder.Services.AddScoped<RandomUserService>();

builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();

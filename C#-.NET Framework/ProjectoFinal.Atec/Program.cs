using IdentityModel.AspNetCore.AccessTokenManagement;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using ProjetoFinal.Migrations;
using ProjetoFinal.Web.Blazor.Data;
using ProjetoFinal.Web.Blazor.Identity;
using ProjetoFinal.Web.Blazor.Shared.Utilities;
using Syncfusion.Blazor;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Migrations;
using ProjetoFinal.Web.Blazor.Hubs;
using ProjetoFinal.Web.Blazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices(); // Mudblazor

// DB Context
builder.Services.AddDbContextFactory<PfaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Http
builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient();
builder.Services.AddHttpClient("api_client", configureClient =>
{
    configureClient.BaseAddress = new Uri(builder.Configuration.GetValue<string>("BaseAddress"));
    configureClient.DefaultRequestHeaders.Authorization = new("Bearer", "token");
});
builder.Services.AddHttpClient("Main", configureClient =>
{
    configureClient.BaseAddress = new Uri(builder.Configuration.GetSection("MainApi")["BaseAddress"]);
});

builder.Services.AddSyncfusionBlazor();

// Dependency injection
builder.Services.AddScoped<IUserAccessTokenStore, CustomTokenStore>();
builder.Services.AddScoped<ITokenProvider, TokenProvider>();
builder.Services.AddScoped<HttpUtilities>();
builder.Services.AddScoped<SyncfusionDatabaseUtilities>();
builder.Services.AddTransient<NotificationService>();

#region Auth
List<string> policies = new()
{
    "category.manage",
    "county.manage",
    "district.manage",
    "notification.read.all",
    "proposal.read.all",
    "proposal.create",
    "provider.profile.manage",
    "publication.create",
    "publication.reviewer",
    "role.manage",
    "socialNetwork.manage",
    "user.role.manage",
    "account.provider.approved"
};

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "cookie";
    options.DefaultChallengeScheme = "oidc";
    options.DefaultSignOutScheme = "oidc";
})
.AddCookie("cookie", options =>
{
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.SlidingExpiration = false;
    options.Cookie.Name = "__Host-bff";
    options.Cookie.SameSite = SameSiteMode.Strict;
})
.AddOpenIdConnect("oidc", options =>
{
    options.Authority = builder.Configuration.GetSection("OIDC")["Authority"];

    options.ClientId = builder.Configuration.GetSection("OIDC")["ClientId"];
    options.ClientSecret = builder.Configuration.GetSection("OIDC")["ClientSecret"];
    options.ResponseType = "code";
    options.ResponseMode = "query";

    options.GetClaimsFromUserInfoEndpoint = true;
    options.MapInboundClaims = false;
    options.SaveTokens = true;

    options.Scope.Clear();
    options.Scope.Add("openid");
    options.Scope.Add("profile");
    options.Scope.Add("offline_access");
    options.Scope.Add("Permissions");
    options.Scope.Add("PfaGeneralApi");

    options.TokenValidationParameters = new()
    {
        NameClaimType = "name",
        RoleClaimType = "role"
    };

    // Map claims that are inbound from the user info endpoint
    foreach (string claim in policies)
        options.ClaimActions.MapUniqueJsonKey(claim, claim);
    options.ClaimActions.MapUniqueJsonKey("account.type", "account.type");

    options.Events.OnTokenValidated = async n =>
    {
        var svc = n.HttpContext.RequestServices.GetRequiredService<IUserAccessTokenStore>();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        var exp = DateTimeOffset.UtcNow.AddSeconds(Double.Parse(n.TokenEndpointResponse.ExpiresIn));
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument.
        await svc.StoreTokenAsync(n.Principal, n.TokenEndpointResponse.AccessToken, exp, n.TokenEndpointResponse.RefreshToken);
#pragma warning restore CS8604 // Possible null reference argument.
    };
});

builder.Services.AddBff();
#endregion

builder.Services.AddAuthorization(options =>
{
    foreach (string policyName in policies)
        options.AddPolicy(policyName, policy => policy.RequireClaim(policyName, "true"));

    options.AddPolicy("isProvider", policy => policy.RequireClaim("account.type", "provider"));
    options.AddPolicy("isClient", policy => policy.RequireClaim("account.type", "client"));
    options.AddPolicy("isAdmin", policy => policy.RequireClaim("account.type", "administrator"));
    options.AddPolicy("isProviderApproved", policy => policy.RequireClaim("account.provider.approved", "true"));
});

var app = builder.Build();

// Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(builder.Configuration.GetSection("Keys")["Syncfusion"]);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseBff();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapBffManagementEndpoints();

    endpoints.MapBlazorHub();
    endpoints.MapFallbackToPage("/_Host");
    endpoints.MapHub<ChatHub>(ChatHub.HubUrl);
    endpoints.MapHub<NotificationHub>(NotificationHub.HubUrl);
});

app.Run();

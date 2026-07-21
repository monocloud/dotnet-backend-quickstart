using System.Security.Claims;
using MonoCloud.Authentication.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddAuthentication(MonoCloudAuthenticationDefaults.AuthenticationScheme)
    .AddMonoCloudAuthentication(options =>
    {
        options.TenantDomain = builder.Configuration["MonoCloud:TenantDomain"];
        options.Audience = builder.Configuration["MonoCloud:Audience"];
    });

builder.Services.AddAuthorization();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/api/protected", (ClaimsPrincipal user) => new
{
    message = "Protected endpoint",
    claims = user.Claims.Select(claim => new { claim.Type, claim.Value }),
})
.RequireAuthorization();

app.Run();

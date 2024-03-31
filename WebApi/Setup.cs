using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace WebApi;

public static class Setup
{
    public static IServiceCollection AddSecuritySchema(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddCors(opt =>
        {
            opt.AddPolicy("AllowLocalhost", x =>
            {
                x.WithOrigins("localhost", "127.0.0.1");
                x.AllowAnyMethod();
                x.AllowAnyHeader();
            });
        });

        return services;
    }
}
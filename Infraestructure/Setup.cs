using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Infraestructure.DbContexts;
using Application.Configurations;
using Application.Services;
using Infraestructure.Services;
using Application.Repositories;
using Infraestructure.Repositories;

namespace Infraestructure;

public static class Setup
{
    public static IServiceCollection AddInfraestructure(this IServiceCollection builder, ConfigurationManager configuration)
    {
        builder.AddDbContext<DefaultDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("Postgres"),
                              mig => mig.MigrationsAssembly("Infraestructure"));
        });


        builder.Configure<ExternalApiConfiguration>(configuration.GetRequiredSection("WeatherApi"))
               .AddScoped<IDateTimeService, DateTimeService>()
               .AddScoped<IApiRequestService, ApiRequestService>()
               .AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

        return builder;
    }
}
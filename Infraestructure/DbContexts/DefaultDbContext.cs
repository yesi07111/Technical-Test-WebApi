using Domain.Entities;
using Domain.Entities.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.DbContexts;

public class DefaultDbContext : IdentityDbContext<AppUser>
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options) { }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    public DbSet<WeatherCondition> WeatherConditions { get; set; }

}
using System.Linq.Expressions;
using Application.Dtos.WeatherForecast;
using Application.Repositories;
using Application.Services;
using Domain.Entities;
using Infraestructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories;

public class WeatherForecastRepository : IWeatherForecastRepository
{
    private readonly DefaultDbContext dbContext;
    private readonly IDateTimeService dateTimeService;

    public WeatherForecastRepository(DefaultDbContext dbContext, IDateTimeService dateTimeService)
    {
        this.dbContext = dbContext;
        this.dateTimeService = dateTimeService;
    }

    public Task<IQueryable<WeatherForecast>> GetAllAsync(Expression<Func<WeatherForecast, bool>>[] filters)
    {
        var result = filters.Aggregate(dbContext.WeatherForecasts.AsQueryable(), (current, filt) => current.Where(filt))
                            .OrderByDescending(x => x.Date)
                            .Include(x => x.Condition)
                            .AsNoTracking();

        return Task.FromResult(result);
    }

    public async Task<WeatherForecast> SaveAsync(WeatherForecastResponse data)
    {
        var weathercondition = await dbContext.WeatherConditions.FindAsync(data.Current.Condition.Code);

        if (weathercondition is null)
        {
            weathercondition = new WeatherCondition()
            {
                Id = data.Current.Condition.Code,
                Text = data.Current.Condition.Text,
                Icon = data.Current.Condition.Icon
            };

            await dbContext.WeatherConditions.AddAsync(weathercondition);
            await dbContext.SaveChangesAsync();
        }

        var weatherforecast = new WeatherForecast()
        {
            RegionName = data.Location.Name,
            Country = data.Location.Country,
            TempC = data.Current.temp_c,
            FeelsLikeC = data.Current.feelslike_c,
            WindKph = data.Current.wind_kph,
            Humidity = data.Current.Humidity,
            Date = dateTimeService.UtcNow,
            ConditionId = weathercondition.Id
        };

        await dbContext.WeatherForecasts.AddAsync(weatherforecast);
        await dbContext.SaveChangesAsync();

        return weatherforecast;
    }
}
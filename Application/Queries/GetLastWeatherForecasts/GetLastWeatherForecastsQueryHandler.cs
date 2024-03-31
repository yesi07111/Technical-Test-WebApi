using System.Linq.Expressions;
using Application.Repositories;
using Domain.Entities;
using FastEndpoints;

namespace Application.Queries.GetLastWeatherForecasts;

public class GetLastWeatherForecastsQueryHandler(IWeatherForecastRepository repository) : CommandHandler<GetLastWeatherForecastsQuery, IQueryable<WeatherForecast>>
{
    public override async Task<IQueryable<WeatherForecast>> ExecuteAsync(GetLastWeatherForecastsQuery command, CancellationToken ct = default)
    {
        var filters = new List<Expression<Func<WeatherForecast, bool>>>();

        if (command.ConditionName != null)
            filters.Add(x => x.Condition.Text == command.ConditionName);
        if (command.MinDate != null)
            filters.Add(x => x.Date > command.MinDate.Value.ToUniversalTime());
        if (command.MaxDate != null)
            filters.Add(x => x.Date < command.MaxDate.Value.ToUniversalTime());
        if (command.MinTempC != null)
            filters.Add(x => x.TempC > command.MinTempC);
        if (command.MaxTempC != null)
            filters.Add(x => x.TempC < command.MaxTempC);
        if (command.MinHumidiy != null)
            filters.Add(x => x.Humidity > command.MinHumidiy);
        if (command.MaxHumidiy != null)
            filters.Add(x => x.Humidity < command.MaxHumidiy);
        if (command.RegionName != null)
            filters.Add(x => x.RegionName == command.RegionName);

        var data = (await repository.GetAllAsync(filters.ToArray())).Take(10);
        return data;
    }
}
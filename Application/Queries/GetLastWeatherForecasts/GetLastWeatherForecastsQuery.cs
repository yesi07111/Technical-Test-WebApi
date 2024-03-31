using Domain.Entities;
using FastEndpoints;

namespace Application.Queries.GetLastWeatherForecasts;

public class GetLastWeatherForecastsQuery : ICommand<IQueryable<WeatherForecast>>
{
    public DateTime? MinDate { get; set; }
    public DateTime? MaxDate { get; set; }
    public decimal? MinTempC { get; set; }
    public decimal? MaxTempC { get; set; }
    public int? MinHumidiy { get; set; }
    public int? MaxHumidiy { get; set; }
    public string? RegionName { get; set; }
    public string? ConditionName { get; set; }
}
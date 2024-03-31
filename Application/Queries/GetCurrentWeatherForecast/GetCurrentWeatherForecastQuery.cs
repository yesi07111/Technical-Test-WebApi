using Domain.Entities;
using FastEndpoints;

namespace Application.Queries.GetCurrentWeatherForecast;

public class GetCurrentWeatherForecastQuery : ICommand<WeatherForecast>
{
    public string Location { get; set; } = string.Empty;

}
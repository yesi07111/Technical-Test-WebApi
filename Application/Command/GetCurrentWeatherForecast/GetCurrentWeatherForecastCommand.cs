using Domain.Entities;
using FastEndpoints;

namespace Application.Command.GetCurrentWeatherForecast;

public class GetCurrentWeatherForecastCommand : ICommand<WeatherForecast>
{
    public string Location { get; set; } = string.Empty;

}
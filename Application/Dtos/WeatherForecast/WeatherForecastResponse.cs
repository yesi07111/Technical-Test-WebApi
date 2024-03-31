namespace Application.Dtos.WeatherForecast;

public class WeatherForecastResponse
{
    public Location Location { get; set; } = null!;
    public Current Current { get; set; } = null!;
}
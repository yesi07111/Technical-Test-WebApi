namespace Application.Dtos.WeatherForecast;

public class Condition
{
    public string Text { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public int Code { get; set; }
}

namespace Application.Dtos.WeatherForecast;

public class Location
{
    public string Name { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public double Lat { get; set; }
    public double Lon { get; set; }
    public string TzId { get; set; } = string.Empty;
    public int LocaltimeEpoch { get; set; }
    public string Localtime { get; set; } = string.Empty;
}


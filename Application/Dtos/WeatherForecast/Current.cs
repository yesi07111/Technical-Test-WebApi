namespace Application.Dtos.WeatherForecast;

public class Current
{
    public Condition Condition { get; set; } = null!;

    public int LastUpdatedEpoch { get; set; }
    public string LastUpdated { get; set; } = string.Empty;
    public decimal temp_c { get; set; }
    public decimal TempF { get; set; }
    public int IsDay { get; set; }
    public decimal WindMph { get; set; }
    public decimal wind_kph { get; set; }
    public int WindDegree { get; set; }
    public string WindDir { get; set; } = string.Empty;
    public decimal PressureMb { get; set; }
    public decimal PressureIn { get; set; }
    public decimal PrecipMm { get; set; }
    public decimal PrecipIn { get; set; }
    public int Humidity { get; set; }
    public int Cloud { get; set; }
    public decimal feelslike_c { get; set; }
    public decimal FeelslikeF { get; set; }
    public decimal VisKm { get; set; }
    public decimal VisMiles { get; set; }
    public decimal Uv { get; set; }
    public decimal GustMph { get; set; }
    public decimal GustKph { get; set; }
}

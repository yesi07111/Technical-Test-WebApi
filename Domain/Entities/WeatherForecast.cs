using Domain.Entities.Common;

namespace Domain.Entities;

public class WeatherForecast : IBaseEntity<int>
{
    public int Id { get; set; }
    public string RegionName { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public decimal TempC { get; set; }
    public decimal FeelsLikeC { get; set; }
    public decimal WindKph { get; set; }
    public int Humidity { get; set; }
    public DateTime Date { get; set; }

    public int ConditionId { get; set; }
    public WeatherCondition Condition { get; set; } = null!;

}
using Domain.Entities.Common;

namespace Domain.Entities;

public class WeatherCondition : IBaseEntity<int>
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
}

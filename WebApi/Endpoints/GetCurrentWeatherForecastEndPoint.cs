using Application.Queries.GetCurrentWeatherForecast;
using Domain.Entities;
using FastEndpoints;

namespace WebApi.Endpoints;

public class GetCurrentWeatherForecastEndPoint : Endpoint<GetCurrentWeatherForecastQuery, WeatherForecast>
{
    public override void Configure()
    {
        AllowAnonymous();
        Get("/get_forecast");
    }

    public override async Task<WeatherForecast> ExecuteAsync(GetCurrentWeatherForecastQuery req, CancellationToken ct)
    {
        return await req.ExecuteAsync(ct);
    }
}
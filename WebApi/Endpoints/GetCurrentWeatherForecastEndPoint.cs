using Application.Command.GetCurrentWeatherForecast;
using Domain.Entities;
using FastEndpoints;

namespace WebApi.Endpoints;

public class GetCurrentWeatherForecastEndPoint : Endpoint<GetCurrentWeatherForecastCommand, WeatherForecast>
{
    public override void Configure()
    {
        AllowAnonymous();
        Get("/get_forecast");
    }

    public override async Task<WeatherForecast> ExecuteAsync(GetCurrentWeatherForecastCommand req, CancellationToken ct)
    {
        return await req.ExecuteAsync(ct);
    }
}
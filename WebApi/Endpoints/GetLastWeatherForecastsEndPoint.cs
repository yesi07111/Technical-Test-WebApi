using Application.Queries.GetLastWeatherForecasts;
using Domain.Entities;
using FastEndpoints;

namespace WebApi.Endpoints;

public class GetLastWeatherForecastsEndPoint : Endpoint<GetLastWeatherForecastsQuery, IQueryable<WeatherForecast>>
{
    public override void Configure()
    {
        AllowAnonymous();
        Get("/get_requests");
    }

    public override async Task<IQueryable<WeatherForecast>> ExecuteAsync(GetLastWeatherForecastsQuery req, CancellationToken ct)
    {
        return await req.ExecuteAsync(ct);
    }
}
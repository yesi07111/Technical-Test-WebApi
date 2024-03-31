using Application.Configurations;
using Application.Dtos.WeatherForecast;
using Application.Repositories;
using Application.Services;
using Domain.Entities;
using FastEndpoints;
using Microsoft.Extensions.Options;

namespace Application.Command.GetCurrentWeatherForecast;

public class GetCurrentWeatherForecastCommandHandler(IWeatherForecastRepository repository,
                                                   IApiRequestService requestService,
                                                   IOptions<ExternalApiConfiguration> externalConfiguration)
: CommandHandler<GetCurrentWeatherForecastCommand, WeatherForecast>
{
    public override async Task<WeatherForecast> ExecuteAsync(GetCurrentWeatherForecastCommand command, CancellationToken ct = default)
    {
        var _params = new Dictionary<string, string>();
        _params.Add("q", command.Location);
        _params.Add("aqi", "no");

        var response = await requestService.Get<WeatherForecastResponse>(externalConfiguration.Value, _params);

        if (response == null)
            ThrowError("The request cannot be made at this time. Try again later.");

        var forecast = await repository.SaveAsync(response);

        return forecast;
    }
}
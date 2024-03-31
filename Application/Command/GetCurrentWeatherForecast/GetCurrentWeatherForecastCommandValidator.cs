using FastEndpoints;
using FluentValidation;

namespace Application.Command.GetCurrentWeatherForecast;

public class GetCurrentWeatherForecastCommandValidator : Validator<GetCurrentWeatherForecastCommand>
{
    public GetCurrentWeatherForecastCommandValidator()
    {
        RuleFor(x => x.Location)
        .NotNull()
        .NotEmpty()
        .WithMessage("Location cannot be null or empty.");
    }
}
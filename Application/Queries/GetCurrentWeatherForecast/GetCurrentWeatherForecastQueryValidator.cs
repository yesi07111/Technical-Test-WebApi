using FastEndpoints;
using FluentValidation;

namespace Application.Queries.GetCurrentWeatherForecast;

public class GetCurrentWeatherForecastQueryValidator : Validator<GetCurrentWeatherForecastQuery>
{
    public GetCurrentWeatherForecastQueryValidator()
    {
        RuleFor(x => x.Location)
        .NotNull()
        .NotEmpty()
        .WithMessage("Location cannot be null or empty.");
    }
}
using FastEndpoints;
using FluentValidation;

namespace Application.Queries.GetLastWeatherForecasts;

public class GetLastWeatherForecastsQueryValidator : Validator<GetLastWeatherForecastsQuery>
{
    public GetLastWeatherForecastsQueryValidator()
    {
        RuleFor(x => x.ConditionName)
                    .Must(x =>
                    {
                        if (x == null) return true;

                        return x != string.Empty;
                    }).WithMessage("The condition name is not valid.");

        RuleFor(x => x.RegionName)
            .Must(x =>
            {
                if (x == null) return true;

                return x != string.Empty;
            }).WithMessage("The region name is not valid.");
    }
}
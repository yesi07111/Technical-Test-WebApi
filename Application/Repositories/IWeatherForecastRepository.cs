using System.Linq.Expressions;
using Application.Dtos.WeatherForecast;
using Domain.Entities;

namespace Application.Repositories;

public interface IWeatherForecastRepository
{
    public Task<WeatherForecast> SaveAsync(WeatherForecastResponse data);
    public Task<IQueryable<WeatherForecast>> GetAllAsync(Expression<Func<WeatherForecast, bool>>[] filters);

}
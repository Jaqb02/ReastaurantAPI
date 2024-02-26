using System.Collections.Generic;

namespace ReastaurantAPI
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get(int count, int minTemperature, int maxTemperature);
    }
}
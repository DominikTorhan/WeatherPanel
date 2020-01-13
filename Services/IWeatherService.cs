using WeatherPanel.Models;

namespace WeatherPanel.Services
{
  public interface IWeatherService
  {
    WeatherModel GetWeather();
  }
}

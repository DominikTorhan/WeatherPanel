using WeatherPanel.Models;
using WeatherPanel.Services.ApiClients;

namespace WeatherPanel.Services
{

  public class WeatherService : IWeatherService
  {

    public WeatherModel GetWeather()
    {

      //var client = new MetaWeatherClient();
      var client = new OpenWeatherClient();
      return client.GetWeather();

    }

  }
}

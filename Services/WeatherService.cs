using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherPanel.Models;

namespace WeatherPanel.Services
{

  public class WeatherService : IWeatherService
  {

    public WeatherModel GetWeather()
    {
      return new WeatherModel
      {
        temp = 1.5f,
        humidity = 70,
        airPressure = 1020
      };
    }

  }
}

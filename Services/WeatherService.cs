using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherPanel.Models;
using WeatherPanel.Services.ApiClients;

namespace WeatherPanel.Services
{

  public class WeatherService : IWeatherService
  {

    public WeatherModel GetWeather()
    {

      MetaWeatherClient client;
      client = new MetaWeatherClient();
      return client.GetWeather();

    }

  }
}

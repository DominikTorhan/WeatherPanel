using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherPanel.Models;

namespace WeatherPanel.Services.ApiClients
{
  public class OpenWeatherClient
  {

    public class Coord
    {
      public double lon { get; set; }
      public double lat { get; set; }
    }

    public class Weather
    {
      public int id { get; set; }
      public string main { get; set; }
      public string description { get; set; }
      public string icon { get; set; }
    }

    public class Main
    {
      public double temp { get; set; }
      public double pressure { get; set; }
      public int humidity { get; set; }
      public double temp_min { get; set; }
      public double temp_max { get; set; }
      public double sea_level { get; set; }
      public double grnd_level { get; set; }
    }

    public class Wind
    {
      public double speed { get; set; }
      public int deg { get; set; }
    }

    public class Clouds
    {
      public int all { get; set; }
    }

    public class Sys
    {
      public double message { get; set; }
      public string country { get; set; }
      public int sunrise { get; set; }
      public int sunset { get; set; }
    }

    public class RootObject
    {
      public Coord coord { get; set; }
      public List<Weather> weather { get; set; }
      public string @base { get; set; }
      public Main main { get; set; }
      public Wind wind { get; set; }
      public Clouds clouds { get; set; }
      public int dt { get; set; }
      public Sys sys { get; set; }
      public int id { get; set; }
      public string name { get; set; }
      public int cod { get; set; }
    }

    HttpClient _client;

    public OpenWeatherClient()
    {
      _client = new HttpClient();
    }

    public WeatherModel GetWeather()
    {

      //api.openweathermap.org/data/2.5/weather?lat=35&lon=139

      var response = _client.GetAsync(@"http://api.openweathermap.org/data/2.5/weather?lat=54&lon=20.5&units=metric&appid=a6d796b8b01721e68cb9cb7c1e46fb7e").Result;

      if (response.StatusCode != System.Net.HttpStatusCode.OK) return new WeatherModel { };

      var json = response.Content.ReadAsStringAsync().Result;
      var root = JsonConvert.DeserializeObject<RootObject>(json);

      return CreateWeatherModel(root);

    }

    private WeatherModel CreateWeatherModel(RootObject root)
    {

      return new WeatherModel
      {
        name = root.name,
        date = DateTime.Now,
        dscr = root.weather.First().description,
        temp = Convert.ToSingle(root.main.temp),
        humidity = root.main.humidity,
        airPressure = Convert.ToInt32(root.main.pressure),
      };
    }


  }
}

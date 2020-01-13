using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherPanel.Models;

namespace WeatherPanel.Services.ApiClients
{
  public class MetaWeatherClient
  {


    public class ConsolidatedWeather
    {
      public object id { get; set; }
      public string weather_state_name { get; set; }
      public string weather_state_abbr { get; set; }
      public string wind_direction_compass { get; set; }
      //public DateTime created { get; set; }
      public string applicable_date { get; set; }
      public double min_temp { get; set; }
      public double max_temp { get; set; }
      public double the_temp { get; set; }
      public double wind_speed { get; set; }
      public double wind_direction { get; set; }
      public double air_pressure { get; set; }
      public int humidity { get; set; }
      public double visibility { get; set; }
      public int predictability { get; set; }
    }

    public class Parent
    {
      public string title { get; set; }
      public string location_type { get; set; }
      public int woeid { get; set; }
      public string latt_long { get; set; }
    }

    public class Source
    {
      public string title { get; set; }
      public string slug { get; set; }
      public string url { get; set; }
      public int crawl_rate { get; set; }
    }

    public class RootObject
    {
      public List<ConsolidatedWeather> consolidated_weather { get; set; }
      //public DateTime time { get; set; }
      //public DateTime sun_rise { get; set; }
      //public DateTime sun_set { get; set; }
      public string timezone_name { get; set; }
      public Parent parent { get; set; }
      public List<Source> sources { get; set; }
      public string title { get; set; }
      public string location_type { get; set; }
      public int woeid { get; set; }
      public string latt_long { get; set; }
      public string timezone { get; set; }
    }

    HttpClient _client;

    public MetaWeatherClient()
    {
      _client = new HttpClient();
    }

    public WeatherModel GetWeather()
    {

      //string test = @"{""consolidated_weather"":[{""id"":6144787713359872,""weather_state_name"":""Heavy Cloud"",""weather_state_abbr"":""hc"",""wind_direction_compass"":""WSW"",""created"":""2020 - 01 - 13T10: 21:59.618134Z"",""applicable_date"":""2020 - 01 - 13"",""min_temp"":3.19,""max_temp"":5.605,""the_temp"":5.265,""wind_speed"":8.149051576372651,""wind_direction"":250.16524697855687,""air_pressure"":1021.0,""humidity"":83,""visibility"":8.879394337071503,""predictability"":71},{""id"":5056156756082688,""weather_state_name"":""Light Cloud"",""weather_state_abbr"":""lc"",""wind_direction_compass"":""SSW"",""created"":""2020 - 01 - 13T10: 22:02.898845Z"",""applicable_date"":""2020 - 01 - 14"",""min_temp"":0.06000000000000001,""max_temp"":5.09,""the_temp"":3.7249999999999996,""wind_speed"":7.223097136785175,""wind_direction"":191.67967913138637,""air_pressure"":1019.5,""humidity"":78,""visibility"":11.477036606219677,""predictability"":70},{""id"":5189805493190656,""weather_state_name"":""Light Cloud"",""weather_state_abbr"":""lc"",""wind_direction_compass"":""SSW"",""created"":""2020 - 01 - 13T10: 22:05.648613Z"",""applicable_date"":""2020 - 01 - 15"",""min_temp"":1.5499999999999998,""max_temp"":8.254999999999999,""the_temp"":5.994999999999999,""wind_speed"":7.300163122028685,""wind_direction"":199.16827218523318,""air_pressure"":1020.5,""humidity"":68,""visibility"":13.212526346138551,""predictability"":70},{""id"":4625905789960192,""weather_state_name"":""Heavy Cloud"",""weather_state_abbr"":""hc"",""wind_direction_compass"":""W"",""created"":""2020 - 01 - 13T10: 22:08.781949Z"",""applicable_date"":""2020 - 01 - 16"",""min_temp"":2.04,""max_temp"":5.365,""the_temp"":5.055,""wind_speed"":5.072896557856784,""wind_direction"":261.69011088476043,""air_pressure"":1027.0,""humidity"":80,""visibility"":12.57624224528752,""predictability"":71},{""id"":6513200252059648,""weather_state_name"":""Heavy Cloud"",""weather_state_abbr"":""hc"",""wind_direction_compass"":""SE"",""created"":""2020 - 01 - 13T10: 22:11.766243Z"",""applicable_date"":""2020 - 01 - 17"",""min_temp"":0.9500000000000001,""max_temp"":4.58,""the_temp"":3.3249999999999997,""wind_speed"":7.569855035305814,""wind_direction"":126.6619448107073,""air_pressure"":1028.0,""humidity"":85,""visibility"":13.21035154696572,""predictability"":71},{""id"":6195203784310784,""weather_state_name"":""Heavy Cloud"",""weather_state_abbr"":""hc"",""wind_direction_compass"":""SE"",""created"":""2020 - 01 - 13T10: 22:14.703387Z"",""applicable_date"":""2020 - 01 - 18"",""min_temp"":-0.8200000000000001,""max_temp"":3.1550000000000002,""the_temp"":1.29,""wind_speed"":5.627655889604709,""wind_direction"":145.0,""air_pressure"":1024.0,""humidity"":79,""visibility"":9.999726596675416,""predictability"":71}],""time"":""2020 - 01 - 13T12: 24:53.136620 + 01:00"",""sun_rise"":""2020 - 01 - 13T07: 40:15.425927 + 01:00"",""sun_set"":""2020 - 01 - 13T15: 49:00.059357 + 01:00"",""timezone_name"":""LMT"",""parent"":{""title"":""Poland"",""location_type"":""Country"",""woeid"":23424923,""latt_long"":""51.918919,19.134300""},""sources"":[{""title"":""BBC"",""slug"":""bbc"",""url"":""http://www.bbc.co.uk/weather/"",""crawl_rate"":360},{""title"":""Forecast.io"",""slug"":""forecast-io"",""url"":""http://forecast.io/"",""crawl_rate"":480},{""title"":""HAMweather"",""slug"":""hamweather"",""url"":""http://www.hamweather.com/"",""crawl_rate"":360},{""title"":""Met Office"",""slug"":""met-office"",""url"":""http://www.metoffice.gov.uk/"",""crawl_rate"":180},{""title"":""OpenWeatherMap"",""slug"":""openweathermap"",""url"":""http://openweathermap.org/"",""crawl_rate"":360},{""title"":""World Weather Online"",""slug"":""world-weather-online"",""url"":""http://www.worldweatheronline.com/"",""crawl_rate"":360}],""title"":""Warsaw"",""location_type"":""City"",""woeid"":523920,""latt_long"":""52.235352,21.009390"",""timezone"":""Europe/Warsaw""}";
      
      var response = _client.GetAsync(@"https://www.metaweather.com/api/location/523920").Result;

      if (response.StatusCode != System.Net.HttpStatusCode.OK) return new WeatherModel { };

      var json = response.Content.ReadAsStringAsync().Result;
      var root = JsonConvert.DeserializeObject<RootObject>(json);

      return CreateWeatherModel(root);

    }

    private WeatherModel CreateWeatherModel(RootObject root)
    {

      var data = root.consolidated_weather[0];

      return new WeatherModel
      {
        date = DateTime.Now,
        dscr = data.weather_state_name,
        temp = Convert.ToSingle(data.the_temp),
        humidity = data.humidity,
        airPressure = Convert.ToInt32(data.air_pressure),
      };
    }

  }
}

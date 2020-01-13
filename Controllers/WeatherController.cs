using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherPanel.Services;

namespace WeatherPanel.Controllers
{
  public class WeatherController : Controller
  {

    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
      _weatherService = weatherService;
    }

    public IActionResult Index()
    {

      var model = _weatherService.GetWeather();

      return View(model);

    }
  }
}
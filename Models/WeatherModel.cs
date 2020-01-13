using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherPanel.Models
{
  public class WeatherModel
  {
    public float temp { get; set; }
    public int humidity { get; set; }
    public int airPressure { get; set; }
  }
}

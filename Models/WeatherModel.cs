using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherPanel.Models
{
  public class WeatherModel
  {
    public DateTime date { get; set; }
    public string dscr { get; set; }
    public float temp { get; set; }
    public int humidity { get; set; }
    public int airPressure { get; set; }
  }
}

using System;

namespace WeatherPanel.Models
{
  public class WeatherModel
  {
    public string name { get; set; }
    public DateTime date { get; set; }
    public string dscr { get; set; }
    public float temp { get; set; }
    public int humidity { get; set; }
    public int airPressure { get; set; }
  }
}

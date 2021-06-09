using System;

namespace Models.WeatherForecast
{
    public class Forecast
    {
        public DateTime Date { get; set; }

        public int TemperatureinCelsius { get; set; }

        public string Summary { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Responses.WeatherForecast
{
    /// <summary>
    /// API response for getting a weather forecast
    /// </summary>
    public class WeatherForecastApiResponse
    {
        /// <summary>
        /// Date of weather forecast
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Daily average temperature in Celsius.
        /// </summary>
        public int TemperatureinCelsius { get; set; }

        /// <summary>
        /// Daily average temperature in Fahrenheit
        /// </summary>
        public int TemperatureinFahrenheit => 32 + (int)(TemperatureinCelsius / 0.5556);

        /// <summary>
        /// Summary of weather type
        /// </summary>
        public string Summary { get; set; }
    }
}

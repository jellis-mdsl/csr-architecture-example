
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Requests.WeatherForecast
{
    /// <summary>
    /// Request for getting a weather forecast on a given date
    /// </summary>
    public class GetForecastApiRequest
    {
        /// <summary>
        /// Date of weather forecast
        /// </summary>
        [Required]
        public DateTime Date { get; set; }
    }

    /// <summary>
    /// Request for getting weather forecasts between two given dates
    /// </summary>
    public class GetForecastsApiRequest
    {
        /// <summary>
        /// Date of first weather forecast
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Date of last weather forecast
        /// </summary>
        [Required]
        public DateTime EndDate { get; set; }
    }
}

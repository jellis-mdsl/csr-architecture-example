using API.Mapping.WeatherForecast;
using API.Requests.WeatherForecast;
using API.Responses.WeatherForecast;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    /// <summary>
    /// Controller for weather forecasts
    /// </summary>
    [ApiController]
    [Route("weather")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService _weatherService;

        /// <summary>
        /// Constructor for WeatherForecastController
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="weatherService"></param>
        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        /// <summary>
        /// Gets the weather forecast for a given date.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("forecast")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WeatherForecastApiResponse))]
        public IActionResult GetForecast([FromQuery] GetForecastApiRequest request)
        {
            _logger.LogInformation($"weather/forecast API method called at {DateTime.UtcNow} (UTC).");

            var forecast = _weatherService.GetForecast(request.Date);
            
            return Ok(forecast.ToApiModel());
        }

        /// <summary>
        /// Gets weather forecasts for dates between a start date and an end date.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("forecasts")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<WeatherForecastApiResponse>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetForecasts([FromQuery] GetForecastsApiRequest request)
        {
            _logger.LogInformation($"weather/forecasts API method called at {DateTime.UtcNow} (UTC).");
             
            // Ideally should use custom validation attributes, but using try-catch here for simplicity
            try
            {
                var forecasts = _weatherService.GetForecasts(request.StartDate, request.EndDate);

                return Ok(forecasts.ToApiModels());
            }
            catch(ArgumentException)
            {
                return BadRequest("Start date should not be after the end date.");
            }
        }
    }
}

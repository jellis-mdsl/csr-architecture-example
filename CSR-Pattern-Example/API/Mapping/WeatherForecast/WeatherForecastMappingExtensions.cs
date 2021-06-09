using API.Responses.WeatherForecast;
using Models.WeatherForecast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mapping.WeatherForecast
{
    internal static class WeatherForecastMappingExtensions
    {
        /// <summary>
        /// Converts WeatherForecast model to WeatherForecastApiResponse model.
        /// </summary>
        /// <param name="weatherForecast"></param>
        /// <returns></returns>
        internal static WeatherForecastApiResponse ToApiModel(this Forecast weatherForecast)
        {
            return new WeatherForecastApiResponse()
            {
                Date = weatherForecast.Date,
                Summary = weatherForecast.Summary,
                TemperatureinCelsius = weatherForecast.TemperatureinCelsius
            };
        }

        /// <summary>
        /// Converts an IEnumerable of WeatherForecast models to an IEnumerable of WeatherForecastApiResponse models.
        /// </summary>
        /// <param name="weatherForecasts"></param>
        /// <returns></returns>
        internal static IEnumerable<WeatherForecastApiResponse> ToApiModels(this IEnumerable<Forecast> weatherForecasts)
        {
            return weatherForecasts.Select(weatherForecast => weatherForecast.ToApiModel());
        }
    }
}

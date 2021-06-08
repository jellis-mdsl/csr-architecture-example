using Contracts;
using Models.WeatherForecast;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// Implementation of the IWeatherRepository interface.
    /// This implementation pretends to get data from a data source but just generates it randomly, for simplicity.
    /// </summary>
    public class WeatherRandomRepository : IWeatherRepository
    {
        private string[] WeatherTypes = { "Sunny", "Cloudy", "Rainy", "Snowy" };

        private Random RandomGenerator { get; }

        public WeatherRandomRepository()
        {
            RandomGenerator = new Random();
        }

        public WeatherForecast GetForecast(DateTime date)
        {
            var forecast = new WeatherForecast()
            {
                Date = date,
                Summary = WeatherTypes[RandomGenerator.Next(0, WeatherTypes.Length - 1)],
                TemperatureinCelsius = RandomGenerator.Next(-10, 40)
            };

            return forecast;
        }

        public IEnumerable<WeatherForecast> GetForecasts(DateTime startDate, DateTime endDate)
        {
            var forecasts = new List<WeatherForecast>();

            if (!(startDate > endDate))
            {
                var dateDifference = (endDate - startDate).TotalDays + 1;

                for (int i = 0; i < dateDifference; i++)
                {
                    forecasts.Add(GetForecast(startDate.AddDays(i)));
                }
            }
            else
            {
                throw new ArgumentException("Start date cannot be after end date.");
            }

            return forecasts;
        }
    }
}

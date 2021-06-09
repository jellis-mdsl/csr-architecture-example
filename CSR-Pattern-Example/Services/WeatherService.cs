using Contracts;
using Models.WeatherForecast;
using System;
using System.Collections.Generic;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public Forecast GetForecast(DateTime date)
        {
            return _weatherRepository.GetForecast(date);
        }

        public IEnumerable<Forecast> GetForecasts(DateTime startDate, DateTime endDate)
        {
            return _weatherRepository.GetForecasts(startDate, endDate);
        }
    }
}

using Models;
using Models.WeatherForecast;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IWeatherService
    {
        WeatherForecast GetForecast(DateTime date);
        IEnumerable<WeatherForecast> GetForecasts(DateTime startDate, DateTime endDate);
    }
}

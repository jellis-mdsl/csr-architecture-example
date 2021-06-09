using Models;
using Models.WeatherForecast;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IWeatherService
    {
        Forecast GetForecast(DateTime date);
        IEnumerable<Forecast> GetForecasts(DateTime startDate, DateTime endDate);
    }
}

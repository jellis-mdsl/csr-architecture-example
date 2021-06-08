using Models.WeatherForecast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IWeatherRepository
    {
        WeatherForecast GetForecast(DateTime date);
        IEnumerable<WeatherForecast> GetForecasts(DateTime startDate, DateTime endDate);
    }
}

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
        Forecast GetForecast(DateTime date);
        IEnumerable<Forecast> GetForecasts(DateTime startDate, DateTime endDate);
    }
}

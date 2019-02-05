using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFWeatherService
{
    public class WeatherService : IWeatherService
    {
        public Double CelciusToFarenheit(double temp)
        {
            return ((temp * 9/5) + 32);
        }

        public Double FarenheitToCelcius(double temp)
        {
            return (temp - 32) * 5/9;
        }
    }
}
